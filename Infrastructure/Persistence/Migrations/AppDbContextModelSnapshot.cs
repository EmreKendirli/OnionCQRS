﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("categoriesId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "categoriesId");

                    b.HasIndex("categoriesId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(2619),
                            IsDeleted = false,
                            Name = "Sports, Kids & Automotive"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(2636),
                            IsDeleted = false,
                            Name = "Outdoors, Health & Music"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(2647),
                            IsDeleted = true,
                            Name = "Industrial & Books"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(4730),
                            IsDeleted = false,
                            Name = "Elektirik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(4732),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(4733),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 298, DateTimeKind.Local).AddTicks(4735),
                            IsDeleted = false,
                            Name = "Kadin",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripton")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 300, DateTimeKind.Local).AddTicks(5705),
                            Descripton = "Perferendis rem accusantium sed nihil.",
                            IsDeleted = false,
                            Title = "Sed."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 300, DateTimeKind.Local).AddTicks(5734),
                            Descripton = "Aliquam göze dağılımı inventore dicta.",
                            IsDeleted = true,
                            Title = "Dışarı."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 300, DateTimeKind.Local).AddTicks(5760),
                            Descripton = "Gazete uzattı uzattı eos vel.",
                            IsDeleted = false,
                            Title = "Esse."
                        });
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 302, DateTimeKind.Local).AddTicks(7621),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Discount = 5.63178914228060m,
                            IsDeleted = false,
                            Price = 420.36m,
                            Title = "Tasty Cotton Salad"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 6, 20, 16, 14, 50, 302, DateTimeKind.Local).AddTicks(7647),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Discount = 7.244705101530080m,
                            IsDeleted = false,
                            Price = 901.76m,
                            Title = "Small Metal Chips"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("categoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Detail", b =>
                {
                    b.HasOne("Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}