
using Castle.DynamicProxy;
using DefensiveApp.Aspects;
using DefensiveApp.Manager;
using DefensiveApp.Repositories;

var proxy =new ProxyGenerator();
var aspect = proxy.CreateClassProxy<StudentManager>(
    new NullCheckInterceptorAspect(),
    new SaveCheckInterceptorAspect()
    );

aspect.AddStudent("John","Doe");

IStudentRepository repository = new StudentRepository();
repository.GetAllStudents();

