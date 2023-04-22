
using Castle.DynamicProxy;
using Core.Aspects;
using Entities;

var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<Employee>(new InterceptionAspect());
aspect.Add(1,"John","Doe");