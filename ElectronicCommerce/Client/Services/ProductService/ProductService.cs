﻿
namespace ElectronicCommerce.Client.Services.ProductService;
public class ProductService : IProductService {
    private readonly HttpClient _http;
    public event Action ProductsChange = null!;

    public ProductService(HttpClient http) {
        _http = http ?? throw new ArgumentNullException(nameof(http));
    }

    public List<Product> Products { get; set; } = new ();
    public async Task<ServiceResponse<Product>> GetProduct(int productId) {
        var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
        return result!;
    }
    public async Task GetProducts(string? categoryUrl = null) {
        var result = categoryUrl == null?
            await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product"):
            await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");

        if (result is {Data: { }}) {
            Products = result.Data;
        }

        ProductsChange.Invoke();
    }
}