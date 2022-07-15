namespace ElectronicCommerce.Server.Services.ProductService;
public interface IProductService {
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
    Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string category);
    Task<ServiceResponse<Product>> GetProductAsync(int productId);
    Task<ServiceResponse<List<Product>>> SearchProductsAsync(string searchText);
    Task<ServiceResponse<List<string>>> GetProductsSearchSuggestionsAsync(string searchText);
}

