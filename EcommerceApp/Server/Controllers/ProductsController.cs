using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IProductService _productService;

        public ProductsController(DataContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            /*
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
               Data = products
            };
            */
            var result = await _productService.GetProductAsync();
            return Ok(result);
        }
    }
}
