using System;
using System.Activities;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace UiPath.Shared.Activities
{
    internal struct AsyncTaskCodeActivityImplementation : IDisposable
    {
        private CancellationTokenSource _cancellationTokenSource;
        private bool _tokenDisposed;

        public void Cancel()
        {
            if (!_tokenDisposed)
            {
                _cancellationTokenSource?.Cancel();
                _cancellationTokenSource?.Dispose();

                _tokenDisposed = true;
            }
        }

        public IAsyncResult BeginExecute(AsyncCodeActivityContext context, Func<AsyncCodeActivityContext, CancellationToken, Task<Action<AsyncCodeActivityContext>>> onExecute, AsyncCallback callback, object state)
        {
            if (!_tokenDisposed)
            {
                _cancellationTokenSource?.Dispose();
            }

            _cancellationTokenSource = new CancellationTokenSource();
            _tokenDisposed = false;

            TaskCompletionSource<Action<AsyncCodeActivityContext>> taskCompletionSource = new TaskCompletionSource<Action<AsyncCodeActivityContext>>(state);
            Task<Action<AsyncCodeActivityContext>> task = onExecute(context, _cancellationTokenSource.Token);

            var cancellationTokenSource = _cancellationTokenSource;
            task.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    taskCompletionSource.TrySetException(t.Exception.InnerException);
                }
                else if (t.IsCanceled || cancellationTokenSource.IsCancellationRequested)
                {
                    taskCompletionSource.TrySetCanceled();
                }
                else
                {
                    taskCompletionSource.TrySetResult(t.Result);
                }

                callback?.Invoke(taskCompletionSource.Task);
            });

            return taskCompletionSource.Task;
        }

        public void EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
            Task<Action<AsyncCodeActivityContext>> task = (Task<Action<AsyncCodeActivityContext>>)result;

            if (task.IsFaulted)
            {
                ExceptionDispatchInfo.Capture(task.Exception.InnerException).Throw();
            }
            if (task.IsCanceled || context.IsCancellationRequested)
            {
                context.MarkCanceled();
            }

            task.Result?.Invoke(context);

            if (!_tokenDisposed)
            {
                _cancellationTokenSource?.Dispose();

                _tokenDisposed = true;
            }
        }

        private bool _disposed; // To detect redundant calls
        public void Dispose()
        {
            if (!_disposed)
            {
                if (!_tokenDisposed)
                {
                    if (_cancellationTokenSource != null)
                        _cancellationTokenSource.Dispose();

                    _tokenDisposed = true;
                }
                _disposed = true;
            }
        }
    }

    public abstract class AsyncTaskCodeActivity : AsyncCodeActivity, IDisposable
    {
        private AsyncTaskCodeActivityImplementation _impl = new AsyncTaskCodeActivityImplementation();
        protected override void Cancel(AsyncCodeActivityContext context)
        {
            _impl.Cancel();
            base.Cancel(context);
        }

        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state)
        {
            return _impl.BeginExecute(context, ExecuteAsync, callback, state);
        }

        protected override void EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
            _impl.EndExecute(context, result);
        }

        protected abstract Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken);

        #region IDisposable Support
        private bool _disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                _impl.Dispose(); //structs are not garbage collected so they fit in the unmanaged bucket
                _disposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~AsyncTaskCodeActivity() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    public abstract class AsyncTaskCodeActivity<T> : AsyncCodeActivity<T>, IDisposable
    {
        private AsyncTaskCodeActivityImplementation _impl = new AsyncTaskCodeActivityImplementation();
        protected override void Cancel(AsyncCodeActivityContext context)
        {
            _impl.Cancel();
            base.Cancel(context);
        }

        protected override IAsyncResult BeginExecute(AsyncCodeActivityContext context, AsyncCallback callback, object state)
        {
            return _impl.BeginExecute(context, ExecuteAsync, callback, state);
        }

        protected override T EndExecute(AsyncCodeActivityContext context, IAsyncResult result)
        {
            _impl.EndExecute(context, result);
            return Result.Get(context);
        }

        protected abstract Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken);

        #region IDisposable Support
        private bool _disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                _impl.Dispose(); //structs are not garbage collected so they fit in the unmanaged bucket
                _disposed = true;
            }
        }

        // Override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~AsyncTaskCodeActivity() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // Uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
