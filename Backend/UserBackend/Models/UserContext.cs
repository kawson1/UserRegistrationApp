using Microsoft.EntityFrameworkCore;

namespace UserBackend.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        { 
        }

        DbSet<User> Users { get; set; }
    }
}
