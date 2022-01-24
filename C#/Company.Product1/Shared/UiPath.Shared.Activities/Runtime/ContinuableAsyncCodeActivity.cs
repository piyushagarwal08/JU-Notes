using System;
using System.Activities;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UiPath.Shared.Activities
{
    public abstract class ContinuableAsyncCodeActivity : AsyncTaskCodeActivity
    {
        public abstract InArgument<bool> ContinueOnError { get; set; }

        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state)
        {
            try
            {
                return base.BeginExecute(context, callback, state);
            }
            catch (Exception e)
            {
                if (ContinueOnError.Get(context))
                {
                    Trace.TraceError(e.ToString());

                    var taskCompletionSource = new TaskCompletionSource<AsyncCodeActivityContext>(state);
                    taskCompletionSource.TrySetResult(null);
                    callback?.Invoke(taskCompletionSource.Task);

                    return taskCompletionSource.Task;
                }

                throw;
            }
        }

        protected override void EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
            try
            {
                base.EndExecute(context, result);
            }
            catch (Exception e)
            {
                if (ContinueOnError.Get(context))
                {
                    Trace.TraceError(e.ToString());
                }
                else
                {
                    throw;
                }
            }
        }
    }

    public abstract class ContinuableAsyncCodeActivity<T> : AsyncTaskCodeActivity<T>
    {
        public abstract InArgument<bool> ContinueOnError { get; set; }

        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state)
        {
            try
            {
                return base.BeginExecute(context, callback, state);
            }
            catch
            {
                if (!ContinueOnError.Get(context)) throw;
            }

            var source = new TaskCompletionSource<AsyncCodeActivityContext>(state);
            source.TrySetResult(null);
            callback?.Invoke(source.Task);

            return source.Task;
        }

        protected override T EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
            try
            {
                return base.EndExecute(context, result);
            }
            catch
            {
                if (!ContinueOnError.Get(context)) throw;
            }

            return default(T);
        }
    }
}
