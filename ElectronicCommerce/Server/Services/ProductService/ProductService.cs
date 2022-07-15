namespace ElectronicCommerce.Server.Services.ProductService;

public class ProductService : IProductService {
    private readonly DataContext _context;

    public ProductService(DataContext context) {
        _context = context;
    }

    public async Task<ServiceResponse<Product>> GetProductAsync(int productId) {
        var response = new ServiceResponse<Product>();
        var product = await _context.Products
           .Include(p => p.Varients)
           .ThenInclude(v => v.ProductType)
           .FirstOrDefaultAsync(p => p.Id == productId);
        if (product == null) {
            response.Success = false;
            response.Message = "Sorry, this product does not exist.";
        }
        else {
            response.Data = product;
        }

        return response;
    }

    public async Task<ServiceResponse<List<Product>>> SearchProductsAsync(
        string searchText) {
        var response = new ServiceResponse<List<Product>> {
            Data = await FindProductsBySearchText(searchText)
        };
        return response;
    }

    private async Task<List<Product>> FindProductsBySearchText(
        string searchText) {
        return await _context.Products
           .Where(p =>
                p.Title.ToLower().Contains(searchText.ToLower())
              ||
                p.Description.ToLower().Contains(searchText.ToLower()))
           .Include(p => p.Varients)
           .ToListAsync();
    }

    public async Task<ServiceResponse<List<string>>>
        GetProductsSearchSuggestionsAsync(string searchText) {
        var products = await FindProductsBySearchText(searchText);
        var result =
            (from product in products
             where product.Title.Contains(searchText,
                 StringComparison.CurrentCultureIgnoreCase)
             select product.Title).ToList();

        return new ServiceResponse<List<string>> {Data = result};
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsAsync() {
        var response = new ServiceResponse<List<Product>> {
            Data = await _context.Products.Include(p => p.Varients)
               .ToListAsync(),
        };

        return response;
    }

    public async Task<ServiceResponse<List<Product>>>
        GetProductsByCategoryAsync(string categoryUrl) {
        var response = new ServiceResponse<List<Product>> {
            Data = await _context.Products
               .Where(p => string.Equals(p.Category!.Url, categoryUrl,
                    StringComparison.CurrentCultureIgnoreCase))
               .Include(p => p.Varients)
               .ToListAsync()
        };

        return response;
    }
}