namespace ElectronicCommerce.Server.Services.ProductService;
public interface IProductService {
    Task<ServiceResponse<List<Product>>> GetProducts();
    Task<ServiceResponse<List<Product>>> GetProductsByCategory(string category);
    Task<ServiceResponse<Product>> GetProduct(int productId);
    Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page);
    Task<ServiceResponse<List<string>>> GetProductsSearchSuggestions(string searchText);
    Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
}

