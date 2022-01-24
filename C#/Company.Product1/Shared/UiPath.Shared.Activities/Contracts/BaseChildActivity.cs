using System.Activities;

namespace UiPath.Shared.Activities.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBaseChildActivity
    {
        /// <summary>
        /// Gets the services container. This stores the authenticated clients
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="propertyName"></param>
        /// 
        /// <returns></returns>
        T GetFromContext<T>(ActivityContext context, string propertyName) where T : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <returns></returns>
        T GetFromUserState<T>(AsyncCodeActivityContext context) where T : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        void SetToUserState<T>(AsyncCodeActivityContext context, T value) where T : class;
    }

    public class BaseChildActivity : IBaseChildActivity
    {
        /// <summary>
        /// Get object from context.UserState object. 
        /// According to documentation, this is the place to store object for multithreaded access
        /// </summary>
        public U GetFromUserState<U>(AsyncCodeActivityContext context) where U : class
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
        public void SetToUserState<U>(AsyncCodeActivityContext context, U value) where U : class
        {
            context.UserState = value;
        }

        /// <summary>
        /// Get object from Context properties
        /// </summary>
        /// <param name="context"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public virtual U GetFromContext<U>(ActivityContext context, string propertyName) where U : class
        {
            var property = context.DataContext.GetProperties()[propertyName];
            var obj = property.GetValue(context.DataContext) as U;
            return obj;
        }
    }
}
