using DefensiveApp.Data;
using DefensiveApp.Entitites;

namespace DefensiveApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public bool AddStudent(Student student)
        {
            using StudentDbContext context = new StudentDbContext();
            context.Students.Add(student);
            context.SaveChanges();
            return true;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            using StudentDbContext dbContext = new StudentDbContext();
            var students = dbContext.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} Number: {student.StudentNumber} First Name: {student.FirstName} Last Name: {student.LastName}");
            }

            return students;
        }
    }
}
