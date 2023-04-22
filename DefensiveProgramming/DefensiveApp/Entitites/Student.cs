namespace DefensiveApp.Entitites
{
    public class Student
    {

        public Student(){}
        public Student(string firstName, string lastName):this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentNumber = new Random().Next(1,1000);
        }

        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentNumber { get; set; }
    }
}
