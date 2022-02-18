namespace EcommerceApp.Client.Services.ProductTypeService
{
    public interface IProductTypeService
    {
        event Action OnChange;
        public List<ProductType> ProductTypes { get; set; };
        Task GetProductType();
        Task AddProductType(ProductType productType);
        Task UpdateProductType(ProductType productType);
        ProductType CreateNewProductType();
    }
}
