﻿// <auto-generated />
using ElectronicCommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronicCommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220713130823_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ElectronicCommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electrical appliances",
                            Url = "electrical-appliances"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobile phone",
                            Url = "mobile-phone"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Computer",
                            Url = "computer"
                        });
                });

            modelBuilder.Entity("ElectronicCommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "很好",
                            ImageUrl = "https://img14.360buyimg.com/n1/s546x546_jfs/t1/26576/18/18347/282563/62c55483Ed138ae22/b74923e09acaa7e9.jpg",
                            Price = 3099m,
                            Title = "美的(Midea)606升变频一级能效对开双门家用冰箱京东小家智能家电风冷无霜BCD-606WKPZM(E)大容量精细分储"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "",
                            ImageUrl = "",
                            Price = 9.99m,
                            Title = ""
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "",
                            ImageUrl = "",
                            Price = 9.99m,
                            Title = ""
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "",
                            ImageUrl = "",
                            Price = 9.99m,
                            Title = ""
                        });
                });

            modelBuilder.Entity("ElectronicCommerce.Shared.Product", b =>
                {
                    b.HasOne("ElectronicCommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}