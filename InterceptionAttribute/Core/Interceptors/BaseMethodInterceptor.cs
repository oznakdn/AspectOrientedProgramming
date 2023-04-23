using Castle.DynamicProxy;

namespace Core.Interceptors
{

    public class BaseMethodInterceptor:BaseInterceptorAttribute
    {
        public override void Intercept(IInvocation invocation){}
        public virtual void onBefore(IInvocation invocation){ }

        public virtual void onAfter(IInvocation invocation) {}
        public virtual void onSuccess(IInvocation invocation, string message){}

        public virtual void onError(IInvocation invocation,Exception ex){}
    }
}
