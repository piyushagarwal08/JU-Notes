using System;

namespace UiPath.Shared.Activities
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ArgumentSettingAttribute : Attribute
    {
        private static readonly string s_assemblyName = typeof(ArgumentSettingAttribute).Assembly.GetName().Name;

        public ArgumentSettingAttribute(string section, string property)
        {
            Section = section;
            Property = property;
            SettingsKey = GetSettingsKey(section, property);
        }

        public ArgumentSettingAttribute(string section, string property, object defaultValue) : this(section,
            property)
        {
            DefaultValue = defaultValue;
        }

        public ArgumentSettingAttribute(string section, string property, object defaultValue, bool required)
            : this(section, property, defaultValue)
        {
            Required = required;
        }

        public static string GetSettingsKey(string section, string property)
        {
            return $"{s_assemblyName}.{section}.{property}";
        }

        public string SettingsKey { get; set; }

        public string Section { get; set; }

        public string Property { get; set; }

        public object DefaultValue { get; set; }

        public bool Required { get; }
    }
}
