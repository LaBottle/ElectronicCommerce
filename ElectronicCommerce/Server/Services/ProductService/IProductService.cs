namespace ElectronicCommerce.Server.Services.ProductService;
public interface IProductService {
    Task<ServiceResponse<List<Product>>> GetProducts();
    Task<ServiceResponse<List<Product>>> GetProductsByCategory(string category);
    Task<ServiceResponse<Product>> GetProduct(int productId);
    Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);
    Task<ServiceResponse<List<string>>> GetProductsSearchSuggestions(string searchText);
    Task<ServiceResponse<int>> GetProductSales(int productId);
}

