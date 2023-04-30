namespace Practice.Entity.Entities
{
    public class Lesson:BaseEntity
    {
        public Lesson(string lessonName)
        {
            LessonName = lessonName;
            Students = new HashSet<Student>();
        }
        public string LessonName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
