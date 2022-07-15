namespace ElectronicCommerce.Client.Services.ProductService;
public interface IProductService {
    event Action ProductsChange;
    public List<Product> Products { get; set; }
    Task GetProducts(string? categoryUrl = null);
    Task<ServiceResponse<Product>> GetProduct(int productId);
}

