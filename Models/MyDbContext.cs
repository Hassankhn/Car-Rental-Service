using Microsoft.EntityFrameworkCore;

namespace Spareparts.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        { 
        

        }

        public DbSet<User> Users { get; set; }

    }
}
