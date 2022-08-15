namespace ElectronicCommerce.Client.Services.ProductService;

public class ProductService : IProductService {
    private readonly HttpClient _http;
    private IProductService _productServiceImplementation;
    public event Action ProductsChange = null!;

    public ProductService(HttpClient http) {
        _http = http ?? throw new ArgumentNullException(nameof(http));
    }

    public List<Product>? Products { get; set; } = null;
    public List<int>? Sales { get; set; } = null;
    public string Message { get; set; } = "正在加载...";
    public int CurrentPage { get; set; } = 1;
    public int PageCount { get; set; } = 0;
    public string LastSearchText { get; set; } = string.Empty;

    public async Task<ServiceResponse<Product>> GetProduct(int productId) {
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<Product>>(
                $"api/product/{productId}");
        return result!;
    }

    public async Task SearchProducts(string searchText) {
        LastSearchText = searchText;
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>(
                $"api/product/search/{searchText}");
        if (result != null && result.Data != null) {
            Products = result.Data;
        }

        if (Products.Count == 0) {
            Message = $"抱歉，没有找到与“{searchText}”相关的商品";
        }

        Sales = new List<int>(Products.Count);
        foreach (var product in Products) {
            Sales.Add((await _http.GetFromJsonAsync<ServiceResponse<int>>(
                $"api/product/{product.Id}/sales"))!.Data);
        }

        ProductsChange.Invoke();
    }


    public async Task GetPopularProducts() {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product");
        if (result != null && result.Data != null) {
            Products = result.Data;
            Sales = new List<int>(Products.Count);
            foreach (var product in Products) {
                Sales.Add((await _http.GetFromJsonAsync<ServiceResponse<int>>(
                    $"api/product/{product.Id}/sales"))!.Data);
            }

            var popularProducts =
                Products.Zip(Sales).OrderByDescending(p => p.Second).Take(5).ToList();

            Products = new List<Product>(5);
            Sales = new List<int>(5);
            foreach (var p in popularProducts) {
                Products.Add(p.First);
                Sales.Add(p.Second);
            }
        }

        ProductsChange.Invoke();
    }

    public async Task<List<string>> GetProductSearchSuggestions(string searchText) {
        var result =
            await _http.GetFromJsonAsync<ServiceResponse<List<string>>>(
                $"api/product/searchSuggestions/{searchText}");
        return result!.Data!;
    }

    public async Task GetProductsByCategory(string categoryUrl) {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>(
            $"api/product/category/{categoryUrl}");

        if (result is {Data: { }}) {
            Products = result.Data;
        }

        CurrentPage = 1;
        PageCount = 0;

        if (Products.Count == 0) {
            Message = "抱歉，这里还没有商品";
        }

        Sales = new List<int>(Products.Count);
        foreach (var product in Products) {
            Sales.Add((await _http.GetFromJsonAsync<ServiceResponse<int>>(
                $"api/product/{product.Id}/sales"))!.Data);
        }

        ProductsChange.Invoke();
    }
}