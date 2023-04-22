using DefensiveApp.Entitites;
using DefensiveApp.Repositories;

namespace DefensiveApp.Manager
{
    public class StudentManager
    {
        private readonly IStudentRepository studentRepository;
        public StudentManager()
        {
            studentRepository = new StudentRepository();
        }

        public virtual void AddStudent(string firstName, string lastName)
        {
            Student student = new(firstName, lastName);
            studentRepository.AddStudent(student);
        }
    }
}
