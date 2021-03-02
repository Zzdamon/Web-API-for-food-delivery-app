﻿// <auto-generated />
using FoodDeliveryAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodDeliveryAPI.Migrations
{
    [DbContext(typeof(FoodDeliveryDbContext))]
    partial class FoodDeliveryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodDeliveryAPI.Models.Category", b =>
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

            modelBuilder.Entity("FoodDeliveryAPI.Models.Item", b =>
                {
                    b.Property<int>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("itemId");

                    b.HasIndex("categId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("deliveryAddress")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("orderNotes")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("restaurantId")
                        .HasColumnType("int");

                    b.Property<string>("stage")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.HasIndex("restaurantId");

                    b.HasIndex("userId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.OrderItem", b =>
                {
                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.HasKey("itemId", "orderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Restaurant", b =>
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

            modelBuilder.Entity("FoodDeliveryAPI.Models.RestaurantTag", b =>
                {
                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RestaurantId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("RestaurantTag");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Tag", b =>
                {
                    b.Property<string>("tagId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("tagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("defaultAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("userId");

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Category", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("restaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Item", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.Order", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("restaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDeliveryAPI.Models.RestaurantTag", b =>
                {
                    b.HasOne("FoodDeliveryAPI.Models.Restaurant", "restaurant")
                        .WithMany("RestaurantTags")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDeliveryAPI.Models.Tag", "Tag")
                        .WithMany("RestaurantTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
