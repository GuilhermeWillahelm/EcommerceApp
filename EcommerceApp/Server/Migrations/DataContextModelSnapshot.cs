﻿// <auto-generated />
using System;
using EcommerceApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommerceApp.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EcommerceApp.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EcommerceApp.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Book",
                            Url = "book",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Movies",
                            Url = "movies",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "Video Games",
                            Url = "video-games",
                            Visible = true
                        });
                });

            modelBuilder.Entity("EcommerceApp.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EcommerceApp.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EcommerceApp.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "How to write clean code 1.",
                            Featured = true,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                            Price = 9.99m,
                            Title = "Clean Code 1",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "How to write clean code 2.",
                            Featured = true,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                            Price = 8.99m,
                            Title = "Clean Code 2",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "How to write clean code 3.",
                            Featured = true,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                            Price = 6.99m,
                            Title = "Clean Code 3",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "How to write clean code 4.",
                            Featured = true,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                            Price = 5.99m,
                            Title = "Clean Code 4",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Price = 4.59m,
                            Title = "Back to the Future",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Price = 5.59m,
                            Title = "Toy Story",
                            Visible = true
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Price = 7.39m,
                            Title = "Half-Life 2",
                            Visible = true
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Price = 9.49m,
                            Title = "Diablo II",
                            Visible = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Price = 12.39m,
                            Title = "Day of the Tentacle",
                            Visible = true
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Price = 6.39m,
                            Title = "Xbox",
                            Visible = true
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Price = 11.99m,
                            Title = "Super Nintendo Entertainment System",
                            Visible = true
                        });
                });

            modelBuilder.Entity("EcommerceApp.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Stream"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = 7,
                            Name = "VHS"
                        },
                        new
                        {
                            Id = 8,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 9,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("EcommerceApp.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 7.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            Deleted = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 14.99m,
                            Price = 7.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 6.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 5,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 3.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 6,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 7,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 3.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 5,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 2.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 8,
                            Deleted = false,
                            OriginalPrice = 29.99m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 9,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 69.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 10,
                            Deleted = false,
                            OriginalPrice = 59.99m,
                            Price = 49.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 8,
                            Deleted = false,
                            OriginalPrice = 24.99m,
                            Price = 9.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 8,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 14.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 299m,
                            Price = 159.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 399m,
                            Price = 79.99m,
                            Visible = true
                        });
                });

            modelBuilder.Entity("EcommerceApp.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCeated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EcommerceApp.Shared.Address", b =>
                {
                    b.HasOne("EcommerceApp.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("EcommerceApp.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcommerceApp.Shared.OrderItem", b =>
                {
                    b.HasOne("EcommerceApp.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceApp.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceApp.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("EcommerceApp.Shared.Product", b =>
                {
                    b.HasOne("EcommerceApp.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EcommerceApp.Shared.ProductVariant", b =>
                {
                    b.HasOne("EcommerceApp.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceApp.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("EcommerceApp.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EcommerceApp.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("EcommerceApp.Shared.User", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
