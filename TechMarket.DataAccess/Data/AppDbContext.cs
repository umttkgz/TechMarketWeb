using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Drawing;
using TechMarket.Models;

namespace TechMarket.DataAccess.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Telefon", DisplayOrder = 1},
                new Category { Id = 2, Name = "Bilgisayar", DisplayOrder = 2},
                new Category { Id = 3, Name = "Televizyon", DisplayOrder = 3}
                );
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = 1, Name = "Notebook", DisplayOrder = 1, CategoryId = 2 },
                new SubCategory { Id = 2, Name = "Masaüstü Bilgisayarlar", DisplayOrder = 2, CategoryId = 2 },
                new SubCategory { Id = 3, Name = "Televizyonlar", DisplayOrder = 1, CategoryId = 3 },
                new SubCategory { Id = 4, Name = "QLED TV", DisplayOrder = 2 , CategoryId = 3 },
                new SubCategory { Id = 5, Name = "Android Modelleri", DisplayOrder = 1, CategoryId = 1 },
                new SubCategory { Id = 6, Name = "iPhone Modelleri", DisplayOrder = 2, CategoryId = 1 }
                );
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Victory Products" },
                new Brand { Id = 2, Name = "Glorious Company" },
                new Brand { Id = 3, Name = "Lion Company"},
                new Brand { Id = 4, Name = "Phoenix Electronics"}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "VPhone A12",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Aliquam consectetur diam tellus, vel dictum sapien aliquet vitae.Vestibulum ut libero.",
                    Price = 25000,
                    BrandId = 1,
                    SubCategoryId = 5,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 2, 
                    Title = "G-3 Notebook i5 512 GB Gtx-4060",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus hendrerit libero ut nunc porta venenatis. Mauris scelerisque ligula metus, et.",
                    Price = 45000,
                    BrandId = 2,
                    SubCategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 3, 
                    Title = "Phoenix PH-4 UHD Smart QLED TV",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus tincidunt laoreet justo pharetra blandit. Integer nec dolor ut dolor congue.",
                    Price = 50000,
                    BrandId = 4,
                    SubCategoryId = 4,
                    ImageUrl = ""
                }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Products & Solutions",
                    StreetAddress = "Tech Sk.",
                    City = "İstanbul",
                    PostalCode = "76523",
                    District = "Kadıköy",
                    PhoneNumber = "278346872"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Ad Agency",
                    StreetAddress = "Vid Sk.",
                    City = "Ankara",
                    PostalCode = "763452",
                    District = "Çankaya",
                    PhoneNumber = "678138764"
                },
                new Company
                {
                    Id = 3,
                    Name = "Nova Software Solutions",
                    StreetAddress = "Nova Sk.",
                    City = "İzmir",
                    PostalCode = "87162",
                    District = "Karşıyaka",
                    PhoneNumber = "18367876"
                }
                );
        }
    }
}
