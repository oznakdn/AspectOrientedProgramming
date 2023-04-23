using Castle.DynamicProxy;
using Core.Interceptors;

namespace Core.Aspects
{
    public class LogInterceptorAspect: BaseMethodInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            onBefore(invocation);
            try
            {
                onSuccess(invocation, "");
            }
            catch (Exception ex)
            {
                onError(invocation, ex);
                throw;
            }
            finally
            {
                onAfter(invocation);
            }

            invocation.Proceed();
        }

        public override void onBefore(IInvocation invocation)
        {
            Console.WriteLine($"Before Method: {invocation.Method}");
        }

        public override void onAfter(IInvocation invocation)
        {
            Console.WriteLine($"After Method: {invocation.Method}");
        }

        public override void onSuccess(IInvocation invocation, string message)
        {
            Console.WriteLine($"Success Message: {message} - {invocation.Method}");
        }

        public override void onError(IInvocation invocation, Exception ex)
        {
            Console.WriteLine($"Error Message: {ex} - {invocation.Method}");
        }
    }
}
