using Autofac;
using Autofac.Core.Aspects;
using Autofac.Extras.DynamicProxy;
using AutofacModule.Business;
using Castle.DynamicProxy;

namespace AutofacModuleApp
{
    public class IocContainer:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeService>()
                .As<IEmployeeService>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                })
                .InstancePerDependency();
        }
    }
}
