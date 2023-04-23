using Autofac;
using Autofac.Extras.DynamicProxy;
using Business;
using Castle.DynamicProxy;
using Core.Aspects;
using Core.Interceptors;
using Entity.Entities;


var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<ProductManager>(new LogInterceptorAspect());
aspect.AddProduct(new Product(5, "E", 500));


/*IOC container*/
//var builder = new ContainerBuilder();
//builder.RegisterType<ProductService>().As<IProductService>()
//    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
//    {
//        Selector = new AspectInterceptorSelector()
//    }) 
//    .InstancePerDependency();

//var container = builder.Build();
//var willBeIntercepted = container.Resolve<ProductManager>();
//willBeIntercepted.AddProduct(new Product(5, "E", 500));




