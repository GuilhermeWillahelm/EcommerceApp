namespace EcommerceApp.Server.Data
{
    public class DataContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Clean Code 1",
                    Description = "How to write clean code 1.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Clean Code 2",
                    Description = "How to write clean code 2.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                    Price = 8.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Clean Code 3",
                    Description = "How to write clean code 3.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                    Price = 6.99m
                },
                new Product
                {
                    Id = 4,
                    Title = "Clean Code 4",
                    Description = "How to write clean code 4.",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41xShlnTZTL._SX376_BO1,204,203,200_.jpg",
                    Price = 5.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
