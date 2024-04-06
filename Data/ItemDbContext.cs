

using Microsoft.EntityFrameworkCore;
using TeahausWebApp.Models;

namespace TeahausWebApp.Data {
    public class ItemDbContext : DbContext {
        public ItemDbContext (DbContextOptions<ItemDbContext> options) : base (options) { }
        public DbSet<Item> Items { get; set; }
    }
}