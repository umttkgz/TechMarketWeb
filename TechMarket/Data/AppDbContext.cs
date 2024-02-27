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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Telefon", DisplayOrder = 1},
                new Category { Id = 2, Name = "Bilgisayar", DisplayOrder = 2},
                new Category { Id = 3, Name = "Televizyon", DisplayOrder = 3}
                );
        }
    }
}
