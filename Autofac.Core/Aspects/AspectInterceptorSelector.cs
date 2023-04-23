using Castle.DynamicProxy;
using System.Reflection;

namespace Autofac.Core.Aspects
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<BaseInterceptorAspect>(true).ToList();
            var methodAttributes = type.GetMethod(method.Name)?.GetCustomAttributes<BaseInterceptorAspect>(true);

            if (methodAttributes != null)
                classAttributes.AddRange(methodAttributes);

            return classAttributes.ToArray();
        }
    }
}
