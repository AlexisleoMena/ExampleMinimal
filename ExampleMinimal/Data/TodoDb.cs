using ExampleMinimal.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleMinimal.Data
{
    public class TodoDb : DbContext
    {
        public DbSet<Todo> Todos => Set<Todo>();
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }
    }
}
