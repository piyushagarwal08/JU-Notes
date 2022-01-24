using System.Activities;
using System.Activities.Expressions;

namespace UiPath.Shared.Activities
{
    public static class InArgumentExtensions
    {
        public static T? GetArgumentLiteralValue<T>(this InArgument<T> inArgument) where T : struct
        {
            return (inArgument?.Expression as Literal<T>)?.Value;
        }

        public static string GetArgumentLiteralValue(this InArgument<string> inArgument)
        {
            return (inArgument?.Expression as Literal<string>)?.Value;
        }

        public static bool SetIfNull<T>(this InArgument<T> inArgument, ActivityContext context, T valueToSet)
        {
            if (inArgument == null)
                return false;
            if (inArgument.Expression != null)
                return false;

            inArgument.Set(context, valueToSet);
            return true;
        }
    }
}
