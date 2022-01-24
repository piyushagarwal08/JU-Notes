using System;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Presentation;
using System.Activities.Presentation.Model;
using System.Activities.Presentation.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualBasic.Activities;

namespace UiPath.Shared.Activities.Design.Services
{
    public static class ModelItemExtensions
    {
        public static T GetInArgumentValue<T>(this ModelItem modelItem, string propertyName)
        {
            var argument = ((InArgument<T>)modelItem.Properties[propertyName]?.Value?.GetCurrentValue())?.Expression;
            if (argument is Literal<T> literal)
            {
                return literal.Value;
            }

            if (argument is VisualBasicValue<T> variable)
            {
                var argName = variable.ExpressionText;

                return GetDefaultVariableValue<T>(modelItem, argName);
            }

            return default(T);
        }

        public static bool ReplaceModelItem(this ModelItem toFind, object replaceWith) =>
            ReplaceModelItem(toFind.Parent, toFind, replaceWith);

        public static ModelItem GetParent<T>(this ModelItem modelItem) where T : Activity
        {
            if (modelItem == null)
                return null;

            var item = modelItem;
            var typeToFind = typeof(T);
            while (item.Parent != null && item.ItemType != typeToFind)
            {
                item = item.Parent;
            }

            return item?.ItemType == typeToFind ? item : null;
        }

        public static IEnumerable<ModelItem> GetChildren<T>(this ModelItem root) where T : Activity
        {
            var type = typeof(T);
            return FindBreadthFirst(root, m => type == m.ItemType).ToList();
        }

        public static ModelItem GetClosestBefore<T>(this ModelItem root, ModelItem refModelItem) =>
            GetClosestBefore(root, typeof(T), refModelItem);

        public static ModelItem GetClosestBefore(this ModelItem root, Type matchingType, ModelItem refModelItem) =>
            FindBefore(root, m => m.ItemType == matchingType, m => m == refModelItem).LastOrDefault();

        public static bool Is<T>(this ModelItem modelItem) where T : Activity
            => modelItem?.ItemType == typeof(T);

        public static void UpdatePropertyForAll<T>(EditingContext context, Type modelItemType,
                                            string propertyName, object value, Func<ModelItem, bool> excluded)
        {
            var modelService = context.Services.GetService<ModelService>();
            modelService.Root.UpdatePropertyForAll<T>(context, modelItemType, propertyName, value, excluded);
        }

        public static void UpdatePropertyForAll<T>(this ModelItem rootItem, EditingContext context, Type modelItemType,
                                            string propertyName, object value, Func<ModelItem, bool> excluded)
        {
            var modelService = context.Services.GetService<ModelService>();
            var items = modelService.Find(rootItem, modelItemType).ToList();
            if (excluded != null)
                items = items.Where(i => !excluded(i)).ToList();

            foreach (var item in items)
            {
                var property = item.Properties[propertyName];
                if (property == null)
                    continue;

                var crtValue = property.Value?.GetCurrentValue();
                if (PropertyEquals<T>(value, crtValue))
                    continue;

                var valueToSet = GetValueToSet<T>(value);
                property.SetValue(valueToSet);
            }
        }

        public static void CopyProperty<T>(this ModelItem source, ModelItem destination, string propertyName)
        {
            var srcProperty = source.Properties[propertyName];
            if (srcProperty == null)
                return;

            var value = srcProperty.Value?.GetCurrentValue();

            var property = destination.Properties[propertyName];
            if (property == null)
                return;

            var crtValue = property.Value?.GetCurrentValue();
            if (PropertyEquals<T>(value, crtValue))
                return;

            var valueToSet = GetValueToSet<T>(value);
            property.SetValue(valueToSet);
        }

        private static object GetValueToSet<T>(object value)
        {
            if (value is InArgument<T> inArgument)
                return new InArgument<T>((Activity<T>)GetValueToSet<T>(inArgument.Expression));

            if (value is Literal<T> literal)
                return new Literal<T>(literal.Value);
            if (value is VisualBasicValue<T> vbValue)
                return new VisualBasicValue<T>(vbValue.ExpressionText);
            if (value is ActivityDelegate)
                return Xaml.Clone((T)value);

            return value;
        }

        private static bool PropertyEquals<T>(object value1, object value2)
        {
            if (value1 is InArgument<T> inArgument1
                && value2 is InArgument<T> inArgument2)
                return PropertyEquals<T>(inArgument1.Expression, inArgument2.Expression);

            if (value1 is Literal<T> literal1 && value2 is Literal<T> literal2)
                return Equals(literal1.Value, literal2.Value);
            if (value1 is VisualBasicValue<T> vbValue1 && value2 is VisualBasicValue<T> vbValue2)
                return vbValue1.ExpressionText == vbValue2.ExpressionText;

            return false;
        }

        private static bool ReplaceModelItem(ModelItem parent, ModelItem toFind, object replaceWith)
        {
            if (parent == null)
                return false;

            // search in properties
            var prop = parent.Properties.FirstOrDefault(p => p.Value == toFind);
            if (prop != null)
            {
                parent.Properties[prop.Name].SetValue(replaceWith);
                return true;
            }

            // search in collection properties
            foreach (var collection in parent.Properties
                .Where(p => p.IsCollection && p.Collection != null)
                .Select(p => p.Collection))
            {
                var idx = collection.IndexOf(toFind);
                if (idx == -1)
                    continue;

                // ensure collection update is done as a single transaction
                // such that Undo in the designer will undo both changes at once
                using (var scope = collection.BeginEdit())
                {
                    collection.Insert(idx, replaceWith);
                    collection.Remove(toFind);

                    scope.Complete();
                }

                return true;
            }

            return ReplaceModelItem(parent.Parent, toFind, replaceWith);
        }

        private static T GetDefaultVariableValue<T>(ModelItem modelItem, string variableName)
        {
            foreach (var collection in modelItem.Properties
                                              .Where(p => p.IsCollection && p.PropertyType == typeof(Collection<Variable>))
                                              .Select(p => p.ComputedValue as Collection<Variable>)
                                              .Where(c => c != null))
            {
                if (collection.FirstOrDefault(v => v.Name == variableName) is Variable<T> variable
                    && variable.Default is Literal<T> variableDefault)
                    return variableDefault.Value;
            }

            var parent = modelItem.Parent;
            if (parent == null)
                return default(T);

            return GetDefaultVariableValue<T>(parent, variableName);
        }

        private static IEnumerable<ModelItem> FindBreadthFirst(ModelItem startingItem,
                                                               Func<ModelItem, bool> matcher,
                                                               Func<ModelItem, bool> exitCondition = null)
        {
            var foundItems = new List<ModelItem>();
            var modelItems = new Queue<ModelItem>();
            modelItems.Enqueue(startingItem);
            var alreadyVisited = new HashSet<ModelItem>();
            while (modelItems.Count > 0)
            {
                var currentModelItem = modelItems.Dequeue();
                if (currentModelItem == null)
                {
                    continue;
                }

                if (exitCondition?.Invoke(currentModelItem) == true)
                    break;

                if (matcher(currentModelItem))
                {
                    foundItems.Add(currentModelItem);
                }

                var children = GetChildren(currentModelItem);

                foreach (var child in children)
                {
                    if (!alreadyVisited.Contains(child))
                    {
                        alreadyVisited.Add(child);
                        modelItems.Enqueue(child);
                    }
                }
            }

            return foundItems;
        }

        private static List<ModelItem> GetChildren(ModelItem modelItem)
        {
            var neighbors = new List<ModelItem>();

            // do not search through Type and its derivatives
            if (typeof(Type).IsAssignableFrom(modelItem.ItemType))
            {
                return neighbors;
            }

            if (modelItem is ModelItemCollection collection)
            {
                neighbors.AddRange(collection.Where(m => m != null));
            }

            var dictionary = modelItem as ModelItemDictionary;
            if (dictionary != null)
            {
                foreach (var kvp in dictionary)
                {
                    var miKey = kvp.Key;
                    if (miKey != null)
                    {
                        neighbors.Add(miKey);
                    }

                    var miValue = kvp.Value;
                    if (miValue != null)
                    {
                        neighbors.Add(miValue);
                    }
                }
            }

            foreach (var property in modelItem.Properties)
            {
                if (dictionary != null && string.Equals(property.Name, "ItemsCollection"))
                {
                    // Don't search the item collection since we already search the items above.
                    continue;
                }

                // we don't want to even try to get the value for a value type property
                // because that will create a new ModelItem every time.

                // System.Type has properties that throw when we try to get value
                // we don't want to expand system.type further during a search.
                if (typeof(Type).IsAssignableFrom(property.PropertyType) || property.PropertyType.IsValueType)
                {
                    continue;
                }

                if (property.Value != null)
                {
                    neighbors.Add(property.Value);
                }
            }

            return neighbors;
        }

        private static IEnumerable<ModelItem> FindBefore(ModelItem startingItem,
                                                         Func<ModelItem, bool> matcher,
                                                         Func<ModelItem, bool> before)
        {
            var lst = new List<ModelItem>();
            FindBeforeInternal(startingItem, matcher, before, new HashSet<ModelItem>(), lst);
            return lst;
        }

        private static bool FindBeforeInternal(ModelItem startingItem,
                                                 Func<ModelItem, bool> matcher,
                                                 Func<ModelItem, bool> toFind,
                                                 ISet<ModelItem> visited,
                                                 List<ModelItem> matchingItems)
        {
            visited.Add(startingItem);

            foreach (var child in GetChildren(startingItem))
            {
                if (visited.Contains(child))
                    continue;

                if (toFind(child))
                    return true;

                if (matcher(child))
                    matchingItems.Add(child);

                var innerMatches = new List<ModelItem>();
                if (FindBeforeInternal(child, matcher, toFind, visited, innerMatches))
                {
                    matchingItems.AddRange(innerMatches);
                    return true;
                }
            }

            return false;
        }
    }
}
