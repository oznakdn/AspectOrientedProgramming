using Castle.DynamicProxy;

namespace Autofac.Core.Aspects
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class,AllowMultiple =true,Inherited =true)]
    public class BaseInterceptorAspect : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"{invocation.Method} method running");
             invocation.Proceed();
        }

        public virtual void Before() => Console.WriteLine("Before Method");
        public virtual void After() => Console.WriteLine("After Method");
        public virtual void onSuccess(string? successMessage) { }
        public virtual void onFailure(string? failureMessage) { }
        public virtual void onException (Exception ex) { }


    }
}
