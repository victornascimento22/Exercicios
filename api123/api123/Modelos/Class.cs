using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace api123.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItems> TodoItems { get; set; } = null!;
    }
}