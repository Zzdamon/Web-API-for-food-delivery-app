﻿// <auto-generated />
using FoodDeliveryAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodDeliveryAPI.Migrations
{
    [DbContext(typeof(FoodDeliveryDbContext))]
    [Migration("20201130175951_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodDeliveryAPI.Models.Categories", b =>
                {
                    b.Property<int>("categId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("restaurantId")
                        .HasColumnType("int");

                    b.HasKey("categId");

                    b.HasIndex("restaurantId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Restaurants", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("minOrder")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Categories", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Restaurants", "Restaurant")
                        .WithMany()
                        .HasForeignKey("restaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
