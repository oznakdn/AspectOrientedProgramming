using Castle.DynamicProxy;
using CastleDynamicProxyApp.Aspects;
using CastleDynamicProxyApp.Business;

var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<ProductBusiness>(new InformationInterceptorAspect());
aspect.GetProducts();

