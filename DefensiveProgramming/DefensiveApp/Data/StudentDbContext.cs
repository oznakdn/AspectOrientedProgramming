using DefensiveApp.Entitites;
using Microsoft.EntityFrameworkCore;

namespace DefensiveApp.Data
{
    public class StudentDbContext:DbContext
    {

        private string connectionString = "Data Source= C:/Users/USER/Desktop/AspectOrientedProgramming/DefensiveProgramming/DefensiveApp/Data/StudentDB.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }
        public DbSet<Student> Students { get; set; }
    }
}
