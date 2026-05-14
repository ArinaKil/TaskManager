using Microsoft.EntityFrameworkCore;
using TaskManager_Kilunina.Models;
using TaskManager_Kilunina.Classes.Database;


namespace TaskManager_Kilunina.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }

        public TasksContext()
        {
            Database.EnsureCreated();
            Tasks.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.connection, Config.version);
    }
}
