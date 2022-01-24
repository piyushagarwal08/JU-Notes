using System.Activities;

namespace UiPath.Shared.Activities.Utilities
{
    static class ActivityExtensions
    {
        public static T GetValueOrDefault<T>(this AsyncCodeActivityContext context, InArgument<T> arg, T defaultValue = default(T))
        {
            return arg.Expression != null
                   ? arg.Get(context)       // User provided a value
                   : defaultValue;          // Field was left blank
        }
    }
}
