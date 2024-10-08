using Microsoft.EntityFrameworkCore;
using UserDemo.Core.Entities;

namespace UserDemo.Infrastructure.Data
{
    public class UserDemoContext : DbContext
    {
        public UserDemoContext(DbContextOptions<UserDemoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
