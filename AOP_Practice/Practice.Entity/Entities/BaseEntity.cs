namespace Practice.Entity.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActice { get; set; } = true;
    }
}
