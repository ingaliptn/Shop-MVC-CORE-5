﻿// <auto-generated />
using System;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebApp.Migrations.AppData
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20210325164742_cart2")]
    partial class cart2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("FileExtention")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("ext");

                    b.Property<string>("FileName")
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)")
                        .HasColumnName("fileName");

                    b.Property<string>("MimeType")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("mime");

                    b.Property<string>("OriginalFileName")
                        .HasMaxLength(260)
                        .HasColumnType("nvarchar(260)")
                        .HasColumnName("original");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52bef9a8-6edb-41a3-959d-5e9a0c1b0271"),
                            Name = "Пиво Разлив"
                        },
                        new
                        {
                            Id = new Guid("4987b264-d493-4fa6-9a28-08c2f35c9eb2"),
                            Name = "Пиво Банки"
                        },
                        new
                        {
                            Id = new Guid("9d9100fb-6c2f-4377-b446-5079a9dfc494"),
                            Name = "Пиво Стекло"
                        },
                        new
                        {
                            Id = new Guid("f69f5320-3ba1-4831-a488-eef23cc2fae8"),
                            Name = "Пиво бочка"
                        });
                });

            modelBuilder.Entity("Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ItemInCart");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("Name");

                    b.Property<decimal>("RetailPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("WholesalePrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.ProductAsset", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Product Id");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Asset Id");

                    b.HasKey("ProductId", "AssetId");

                    b.HasIndex("AssetId");

                    b.ToTable("ProductAsset");
                });

            modelBuilder.Entity("Entities.Item", b =>
                {
                    b.HasOne("Entities.Product", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.HasOne("Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.ProductAsset", b =>
                {
                    b.HasOne("Entities.Asset", "Asset")
                        .WithMany("ProductAssets")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Product", "Product")
                        .WithMany("ProductAssets")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Asset", b =>
                {
                    b.Navigation("ProductAssets");
                });

            modelBuilder.Entity("Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("ProductAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
