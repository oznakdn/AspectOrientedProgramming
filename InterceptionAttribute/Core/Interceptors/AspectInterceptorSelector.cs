using Castle.DynamicProxy;
using System.Reflection;

namespace Core.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<BaseInterceptorAttribute>(true).ToList();
            var methodAttributes = type.GetMethod(method.Name)?.GetCustomAttributes<BaseInterceptorAttribute>(true);

            if (methodAttributes != null)
                classAttributes.AddRange(methodAttributes);

            return classAttributes.OrderBy(x => x.Primacy).ToArray();
        }
    }
}
