using Microsoft.EntityFrameworkCore;
using Practice.Entity.Entities;

namespace Practice.Data.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}

        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson>Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Lessons)
                .WithMany(x => x.Students);

            modelBuilder.Entity<Lesson>()
                .HasMany(x => x.Students)
                .WithMany(x => x.Lessons);

            modelBuilder.Entity<Student>().HasData(
                new Student("Abc", "Kartal") { Id = 1 },
                new Student("Def", "Koc") { Id = 2 },
                new Student("Ghi", "Aslan") { Id = 3 },
                new Student("Ijk", "Kaplan") { Id = 4 });

            modelBuilder.Entity<Lesson>().HasData(

                new Lesson("Matematik") { Id=1},
                new Lesson("Turkce") { Id=2},
                new Lesson("Fizik") { Id=3},
                new Lesson("Kimya") { Id=4}
                );
        }
    }
}
