using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DatabaseConnectionContext : DbContext
    {
        public DatabaseConnectionContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
