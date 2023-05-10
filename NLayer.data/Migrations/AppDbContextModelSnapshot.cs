﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayer.Data;

#nullable disable

namespace NLayer.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NLayer.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kitaplar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("NLayer.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5022),
                            Name = "Kalem 1",
                            Price = 100m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5041),
                            Name = "Kalem 2",
                            Price = 200m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5045),
                            Name = "Kalem 3",
                            Price = 50m,
                            Stock = 50
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5048),
                            Name = "Kitap 1",
                            Price = 900m,
                            Stock = 8
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5051),
                            Name = "Kitap 2",
                            Price = 1000m,
                            Stock = 6
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5128),
                            Name = "Defter 1",
                            Price = 600m,
                            Stock = 12
                        });
                });

            modelBuilder.Entity("NLayer.Core.Models.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("productFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Kırmızı",
                            Height = 100,
                            ProductId = 1,
                            Width = 200
                        },
                        new
                        {
                            Id = 2,
                            Color = "Mavi",
                            Height = 400,
                            ProductId = 2,
                            Width = 900
                        });
                });

            modelBuilder.Entity("NLayer.Core.Models.Product", b =>
                {
                    b.HasOne("NLayer.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayer.Core.Models.ProductFeature", b =>
                {
                    b.HasOne("NLayer.Core.Models.Product", "Product")
                        .WithOne("productFeature")
                        .HasForeignKey("NLayer.Core.Models.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLayer.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NLayer.Core.Models.Product", b =>
                {
                    b.Navigation("productFeature")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
