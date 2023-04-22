namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }

        public virtual void Add(int id, string name, string lastName)
        {
            new Employee { Id = id, Name = name, LastName = lastName };
            Console.WriteLine($"Id:{id} - Name: {name} Last Name: {lastName}");
        }
    }
}
