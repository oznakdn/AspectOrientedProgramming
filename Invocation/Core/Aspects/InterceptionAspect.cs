using Castle.DynamicProxy;

namespace Core.Aspects
{
    public class InterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"Method Signature: {invocation.Method}");
            Console.WriteLine($"Target Type: {invocation.TargetType}");
            Console.WriteLine($"Invocation Target: {invocation.InvocationTarget}");
            Console.WriteLine("Arguments:");
            for (int i = 0; i < invocation.Arguments.Length; i++)
            {
                Console.WriteLine($"{i+1} - {invocation.Arguments[i]}");
            }
            invocation.Proceed();
            Console.WriteLine($"Method Name: {invocation.Method.Name}");
        }
    }
}
