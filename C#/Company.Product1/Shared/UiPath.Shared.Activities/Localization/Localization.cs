using System;
using System.ComponentModel;
using UiPath.Shared.Localization;

namespace UiPath.Shared.Activities.Localization
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LocalizedCategoryAttribute : CategoryAttribute
    {
        public LocalizedCategoryAttribute(string category) : base(category)
        {
        }

        protected override string GetLocalizedString(string value) => SharedResources.ResourceManager.GetString(value) ?? base.GetLocalizedString(value);
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        public LocalizedDisplayNameAttribute(string displayName) : base(displayName)
        {
        }

        public override string DisplayName => SharedResources.ResourceManager.GetString(DisplayNameValue) ?? base.DisplayName;
    }

    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        public LocalizedDescriptionAttribute(string displayName) : base(displayName)
        {
        }

        public override string Description => SharedResources.ResourceManager.GetString(DescriptionValue) ?? base.Description;
    }
}
