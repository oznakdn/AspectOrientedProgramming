

using AutofacModule.Entity;

namespace AutofacModule.Business
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Update(Employee employee);
    }
}
