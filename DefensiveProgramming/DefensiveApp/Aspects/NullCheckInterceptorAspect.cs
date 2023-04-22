using Castle.DynamicProxy;

namespace DefensiveApp.Aspects
{
    public class NullCheckInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            if(invocation.Arguments==null)
            {
                Console.WriteLine("Arguments can not be null!");
            }
            else
            {
                Console.WriteLine("Arguments okey.");
                invocation.Proceed();
            }
        }
    }
}
