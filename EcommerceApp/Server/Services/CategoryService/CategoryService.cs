namespace EcommerceApp.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var response = new ServiceResponse<List<Category>>() {
                Data = await _context.Categories.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Category>> GetCategory(int categoryId)
        {
            var response = new ServiceResponse<Category>();
            var category = await _context.Categories.FindAsync(categoryId);

            if (category == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this category does not exits.";
            }
            else
            {
                response.Success = true;
                response.Data = category;
            }

            return response;
        }
    }
}
