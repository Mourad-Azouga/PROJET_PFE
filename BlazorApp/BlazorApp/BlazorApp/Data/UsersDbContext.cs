using Microsoft.EntityFrameworkCore;
namespace BlazorApp.Data.Models
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options) 
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
