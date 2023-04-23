using Autofac.Core.Aspects;
using AutofacModule.Entity;

namespace AutofacModule.Business
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
             new Employee(1,"A","B"),
             new Employee(2,"C","D"),
             new Employee(3,"E","F"),
             new Employee(4,"G","H"),
             new Employee(5,"I","K"),
             new Employee(6,"L","M")
        };

        [LoggingInterceptorAspect]
        [CachingInterceptorAspect]
        public virtual void Add(Employee employee)
        {
            employees.Add(employee);
            foreach (var item in employees)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        [CachingInterceptorAspect]
        public virtual void Update(Employee employee)
        {
            var updateEmployee = employees.Where(e => e.Id == employee.Id).SingleOrDefault();
            if (updateEmployee != null)
            {
                employee.Id = updateEmployee.Id;
                employee.FirstName = updateEmployee.FirstName;
                employee.LastName = updateEmployee.LastName;
            }

            foreach (var item in employees)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
