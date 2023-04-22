using Castle.DynamicProxy;

namespace CastleDynamicProxyApp.Aspects
{
    internal class InformationInterceptorAspect : IInterceptor
    {

        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Befor method running");
            invocation.Proceed();
            Console.WriteLine("After method running");
        }
    }
}
