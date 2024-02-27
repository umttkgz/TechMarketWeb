using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TechMarket.Models;

namespace TechMarket.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
