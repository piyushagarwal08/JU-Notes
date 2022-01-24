using System.Activities;

namespace UiPath.Shared.Activities.Utilities
{
    /// <summary>Provides the standard functionality across activities.</summary>
    public static class ChildActivityExtensions
    {
        /// <summary>
        /// Get object from context.UserState object. 
        /// According to documentation, this is the place to store object for multithreaded access
        /// </summary>
        public static U GetFromUserState<U>(this AsyncCodeActivityContext context) where U : class
        {
            if (context.UserState is U obj)
                return obj;
            else return null;
        }

        /// <summary>
        /// Set context.UserState to desired value
        /// </summary>
        /// <typeparam name="U"></typeparam>
        /// <param name="context"></param>
        /// <param name="value"></param>
        public static void SetToUserState<U>(this AsyncCodeActivityContext context, U value) where U : class
        {
            context.UserState = value;
        }

        /// <summary>
        /// Get object from Context properties
        /// </summary>
        /// <param name="context"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static U GetFromContext<U>(this ActivityContext context, string propertyName) where U : class
        {
            var property = context.DataContext.GetProperties()[propertyName];
            var obj = property.GetValue(context.DataContext) as U;
            return obj;
        }
    }
}
