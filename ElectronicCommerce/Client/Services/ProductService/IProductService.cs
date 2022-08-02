﻿namespace ElectronicCommerce.Client.Services.ProductService;
public interface IProductService {
    event Action ProductsChange; 
    List<Product>? Products { get; set; }
    List<int>? Sales { get; set; }
    string Message { get; set; }
    int CurrentPage { get; set; }
    int PageCount { get; set; }
    string LastSearchText { get; set; }
    Task GetProducts(string? categoryUrl = null);
    Task<ServiceResponse<Product>> GetProduct(int productId);
    Task SearchProducts(string searchText, int page);
    Task<List<string>> GetProductSearchSuggestions(string searchText);
}

