using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
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
        },

    };

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(Products);
        }
    }
}
