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
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Telefon", DisplayOrder = 1},
                new Category { Id = 2, Name = "Bilgisayar", DisplayOrder = 2},
                new Category { Id = 3, Name = "Televizyon", DisplayOrder = 3}
                );
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = 1, Name = "Notebook", DisplayOrder = 1 },
                new SubCategory { Id = 2, Name = "Masaüstü Bilgisayarlar", DisplayOrder = 2 },
                new SubCategory { Id = 3, Name = "Televizyonlar", DisplayOrder = 1 },
                new SubCategory { Id = 4, Name = "QLED TV", DisplayOrder = 2 },
                new SubCategory { Id = 5, Name = "Android Modelleri", DisplayOrder = 1 },
                new SubCategory { Id = 6, Name = "iPhone Modelleri", DisplayOrder = 2 }
                );
        }
    }
}
