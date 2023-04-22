using DefensiveApp.Data;
using DefensiveApp.Entitites;

namespace DefensiveApp.Repositories
{
    public interface IStudentRepository
    {
        bool AddStudent(Student student);
     
        IEnumerable<Student> GetAllStudents();
    }
}
