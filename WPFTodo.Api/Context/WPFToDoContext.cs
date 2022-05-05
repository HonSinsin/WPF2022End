using Microsoft.EntityFrameworkCore;

namespace WPFTodo.Api.Context
{
    public class WPFToDoContext : DbContext
    {
        public WPFToDoContext(DbContextOptions<WPFToDoContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDo { get; set; }

        public DbSet<Memo> Memo { get; set; }

        public DbSet<User> User { get; set; }
    }
}
