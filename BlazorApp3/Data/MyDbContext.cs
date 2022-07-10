using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Data> Models { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
