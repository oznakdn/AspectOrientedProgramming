using Castle.DynamicProxy;

namespace DefensiveApp.Aspects
{
    public class SaveCheckInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            if(invocation.Method.IsFinal)
            {
                Console.WriteLine("Student can not be added!");
            }
            else
            {
                Console.WriteLine("Student added.");
            }

        }
    }
}
