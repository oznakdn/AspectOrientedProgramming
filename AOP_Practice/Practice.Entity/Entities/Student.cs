namespace Practice.Entity.Entities
{
    public class Student:BaseEntity
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            SchoolNumber = new Random().Next(1,1000);
            Lessons = new HashSet<Lesson>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolNumber { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
    }
}
