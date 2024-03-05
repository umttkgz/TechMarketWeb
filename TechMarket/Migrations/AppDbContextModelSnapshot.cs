﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechMarket.Data;

#nullable disable

namespace TechMarket.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechMarket.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Telefon"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Televizyon"
                        });
                });

            modelBuilder.Entity("TechMarket.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Notebook"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Masaüstü Bilgisayarlar"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 1,
                            Name = "Televizyonlar"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 2,
                            Name = "QLED TV"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 1,
                            Name = "Android Modelleri"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 2,
                            Name = "iPhone Modelleri"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
