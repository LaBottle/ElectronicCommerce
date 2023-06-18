using System.Diagnostics;

namespace ElectronicCommerce.Server.Services.ProductService;

public class ProductService : IProductService {
    private readonly DataContext _context;

    public ProductService(DataContext context) {
        _context = context;
    }

    public async Task<ServiceResponse<Product>> GetProduct(int productId) {
        var response = new ServiceResponse<Product>();
        var product = await _context.Products
           .Include(p => p.Varients)
           .ThenInclude(v => v.ProductType)
           .FirstOrDefaultAsync(p => p.Id == productId);
        if (product == null) {
            response.Success = false;
            response.Message = "抱歉，该商品不存在";
        } else {
            response.Data = product;
        }

        return response;
    }

    public async Task<ServiceResponse<List<Product>>> SearchProducts(string searchText) {
        var response = new ServiceResponse<List<Product>>();
        if (string.IsNullOrEmpty(searchText)) {
            response.Success = false;
            response.Message = "请输入搜索内容";
            return response;
        }

        if (searchText.Length > 36) {
            response.Message = "搜索内容过长";
            searchText = searchText[..36];
        }

        var products = await _context.Products
           .Where(p => p.Title.ToLower().Contains(searchText.ToLower())
             || p.Description.ToLower().Contains(searchText.ToLower()))
           .Include(p => p.Varients)
           .ToListAsync();

        response.Data = products;
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
        GetProductsSearchSuggestions(string searchText) {
        var response = new ServiceResponse<List<string>>();
        if (string.IsNullOrEmpty(searchText)) {
            response.Success = false;
            response.Message = "请输入搜索内容";
            return response;
        }
        
        var products = await FindProductsBySearchText(searchText);
        var result = new List<string>();
        foreach (var product in products) {
            if (product.Title.Contains(searchText,
                StringComparison.CurrentCultureIgnoreCase)) {
                result.Add(product.Title);
            }

            Debug.Assert(product != null);
            if (product.Description != null) {
                var punctuation = product.Description
                   .Where(char.IsPunctuation)
                   .Distinct()
                   .ToArray();
                var words = product.Description
                   .Split('（', '）', '(', ')', ' ', ',', '.', '，', '。', '、', '"', '“', '”')
                   .Select(s => s.Trim(punctuation));

                foreach (var word in words) {
                    if (word.Contains(searchText,
                            StringComparison.CurrentCultureIgnoreCase)
                     && !result.Contains(word)) {
                        result.Add(word);
                    }
                }
            }
        }

        response.Data = result;
        return response;
    }

    public async Task<ServiceResponse<int>> GetProductSales(int productId) {
        var response = new ServiceResponse<int>();
        var productResponse = await GetProduct(productId);
        if (productResponse.Success==false) {
            response.Success = false;
            response.Message = "抱歉，该商品不存在";
            return response;
        }
    
        var result = await _context.OrdersItems.Where(oi => oi.ProductId == productId).CountAsync();
        response.Data = result;
        return response;
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts() {
        var response = new ServiceResponse<List<Product>> {
            Data = await _context.Products.Include(p => p.Varients)
               .ToListAsync(),
        };

        return response;
    }

    public async Task<ServiceResponse<List<Product>>>
        GetProductsByCategory(string categoryUrl) {
        var response = new ServiceResponse<List<Product>>();
        if (string.IsNullOrEmpty(categoryUrl)) {
            response.Success = false;
            response.Message = "请输入类别URL";
            return response;
        }

        var result = await _context.Products
           .Where(p =>
                p.Category!.Url.ToLower().Equals(categoryUrl.ToLower()))
           .Include(p => p.Varients)
           .ToListAsync();

        if (!result.Any()) {
            response.Success = false;
            response.Message = "未找到该类别";
        } else {
            response.Data = result;
        }
        return response;
    }
}