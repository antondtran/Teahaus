using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeahausWebApp.Data {
    public class UserDbContext : IdentityDbContext<User> {
        public UserDbContext (DbContextOptions<UserDbContext> options) : base (options) { }
        public DbSet<User> Users { get; set; }
    }
}