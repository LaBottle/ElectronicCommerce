﻿namespace ElectronicCommerce.Server.Services.ProductService;

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
            response.Message = "Sorry, this product does not exist.";
        }
        else {
            response.Data = product;
        }

        return response;
    }

    public async Task<ServiceResponse<ProductSearchResult>> SearchProducts(
        string searchText, int page) {

        const int pageResults = 5;
        var pageCount =
            (int) Math.Ceiling((await FindProductsBySearchText(searchText)).Count / (float)pageResults);
        var products = await _context.Products
           .Where(p =>
                p.Title.ToLower().Contains(searchText.ToLower())
              ||
                p.Description.ToLower().Contains(searchText.ToLower()))
           .Include(p => p.Varients)
           .Skip((page - 1) * pageResults)
           .Take(pageResults)
           .ToListAsync();
        var response = new ServiceResponse<ProductSearchResult> {
            Data = new ProductSearchResult {
                Products = products,
                CurrentPage = page,
                Pages = pageCount
            }
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
        GetProductsSearchSuggestions(string searchText) {
        var products = await FindProductsBySearchText(searchText);
        var result = new List<string>();
        foreach (var product in products) {
            if (product.Title.Contains(searchText,
                StringComparison.CurrentCultureIgnoreCase)) {
                result.Add(product.Title);
            }

            if (product.Description != null) {
                var punctuation = product.Description
                   .Where(char.IsPunctuation)
                   .Distinct()
                   .ToArray();
                var words = product.Description
                   .Split()
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

        return new ServiceResponse<List<string>> {Data = result};
    }

    public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts() {
        var response = new ServiceResponse<List<Product>> {
            Data = await _context.Products
               .Where(p => p.Featured == true)
               .Include(p => p.Varients)
               .ToListAsync()
        };
        return response;
    }

    public async Task<ServiceResponse<int>> GetProductSales(int productId) {
        var result= await _context.OrdersItems.Where(oi => oi.ProductId == productId).CountAsync();
        return new ServiceResponse<int> {Data = result};
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
        var response = new ServiceResponse<List<Product>> {
            Data = await _context.Products
               .Where(p =>
                    p.Category!.Url.ToLower().Equals(categoryUrl.ToLower()))
               .Include(p => p.Varients)
               .ToListAsync()
        };

        return response;
    }
}