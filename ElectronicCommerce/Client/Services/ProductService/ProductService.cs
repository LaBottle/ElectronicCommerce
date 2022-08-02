namespace ElectronicCommerce.Client.Services.ProductService;

public class ProductService : IProductService {
    private readonly HttpClient _http;
    public event Action ProductsChange = null!;

    public ProductService(HttpClient http) {
        _http = http ?? throw new ArgumentNullException(nameof(http));
    }

    public List<Product>? Products { get; set; } = null;
    public List<int>? Sales { get; set; } = null;
    public string Message { get; set; } = "Loading products...";
    public int CurrentPage { get; set; } = 1;
    public int PageCount { get; set; } = 0;
    public string LastSearchText { get; set; } = string.Empty;

    public async Task<ServiceResponse<Product>> GetProduct(int productId) {
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<Product>>(
                $"api/product/{productId}");
        return result!;
    }

    public async Task SearchProducts(string searchText, int page) {
        LastSearchText = searchText;
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<ProductSearchResult>>(
                $"api/product/search/{searchText}/{page}");
        if (result is {Data: { }}) {
            Products = result.Data.Products;
            CurrentPage = result.Data.CurrentPage;
            PageCount = result.Data.Pages;
        }

        if (Products.Count == 0) {
            Message = "No products found...";
        }

        Sales = new List<int>(Products.Count);
        foreach (var product in Products) {
            Sales.Add((await _http.GetFromJsonAsync<ServiceResponse<int>>(
                $"api/product/{product.Id}/sales"))!.Data);
        }

        ProductsChange.Invoke();
    }

    public async Task<List<string>> GetProductSearchSuggestions(string searchText) {
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<List<string>>>(
                $"api/product/searchSuggestions/{searchText}");
        return result!.Data!;
    }

    public async Task GetProducts(string? categoryUrl = null) {
        var result = categoryUrl == null
            ? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>(
                "api/product/featured")
            : await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>(
                $"api/product/category/{categoryUrl}");

        if (result is {Data: { }}) {
            Products = result.Data;
        }

        CurrentPage = 1;
        PageCount = 0;

        if (Products.Count == 0) {
            Message = "No products found.";
        }

        Sales = new List<int>(Products.Count);
        foreach (var product in Products) {
            Sales.Add((await _http.GetFromJsonAsync<ServiceResponse<int>>(
                $"api/product/{product.Id}/sales"))!.Data);
        }

        ProductsChange.Invoke();
    }
}