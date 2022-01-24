using System.Activities.Presentation;
using System.Activities.Presentation.Converters;
using System.Activities.Presentation.Model;
using System.Activities.Presentation.PropertyEditing;
using System.Windows;
using UiPath.Shared.Activities.Design.Editors;
using UiPath.Shared.Localization;

namespace UiPath.Shared.Activities.Design.Editors
{
    public partial class ArgumentCollectionEditor : DialogPropertyValueEditor
    {
        private static DataTemplate EditorTemplate = (DataTemplate)new EditorTemplates()["ArgumentDictionaryEditor"];

        public ArgumentCollectionEditor()
        {
            this.InlineEditorTemplate = EditorTemplate;
        }

        public override void ShowDialog(PropertyValue propertyValue, IInputElement commandSource)
        {
            string propertyDisplayName = propertyValue.ParentProperty.DisplayName;
            string propertyName = propertyValue.ParentProperty.PropertyName;

            var ownerActivity = (new ModelPropertyEntryToOwnerActivityConverter()).Convert(propertyValue.ParentProperty, typeof(ModelItem), false, null) as ModelItem;

            ShowDialog(propertyName, propertyDisplayName, ownerActivity);
        }

        public static void ShowDialog(string propertyName, string propertyDisplayName, ModelItem ownerActivity)
        {
            DynamicArgumentDesignerOptions options = new DynamicArgumentDesignerOptions()
            {
                Title = propertyDisplayName
            };

            ModelItem modelItem = ownerActivity.Properties[propertyName].Collection;

            using (ModelEditingScope change = modelItem.BeginEdit(propertyDisplayName + SharedResources.Editing))
            {
                if (DynamicArgumentDialog.ShowDialog(ownerActivity, modelItem, ownerActivity.GetEditingContext(), ownerActivity.View, options))
                {
                    change.Complete();
                }
                else
                {
                    change.Revert();
                }
            }
        }
    }
}
