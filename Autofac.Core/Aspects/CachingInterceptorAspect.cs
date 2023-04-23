using Castle.DynamicProxy;

namespace Autofac.Core.Aspects
{
    public class CachingInterceptorAspect:BaseInterceptorAspect
    {

        public override void Intercept(IInvocation invocation)
        {
            base.Intercept(invocation);
            After();
        }
        public override void After()
        {
            Console.WriteLine("Caching.....");
        }
    }
}
