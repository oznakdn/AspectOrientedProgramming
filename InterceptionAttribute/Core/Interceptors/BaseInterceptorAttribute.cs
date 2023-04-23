using Castle.DynamicProxy;

namespace Core.Interceptors
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,AllowMultiple =true,Inherited =true)]
    public abstract class BaseInterceptorAttribute : Attribute, IInterceptor
    {
        public int Primacy { get; set; } // Oncelik
        public virtual void Intercept(IInvocation invocation){}
    }
}
