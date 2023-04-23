using Autofac;
using AutofacModule.Business;
using AutofacModule.Entity;
using AutofacModuleApp;



var builder = new ContainerBuilder();
builder.RegisterModule<IocContainer>();

var container = builder.Build();
var willBeInterceptor = container.Resolve<IEmployeeService>();
willBeInterceptor.Add(new Employee(7, "E", "F"));
willBeInterceptor.Update(new Employee(7, "G", "H"));

