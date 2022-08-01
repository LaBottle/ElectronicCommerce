﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicCommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {
    private readonly IProductService _productService;

    public ProductController(IProductService productService) {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts() {
        var result = await _productService.GetProducts();
        return Ok(result);
    }

    [HttpGet("{productId:int}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId) {
        var result = await _productService.GetProduct(productId);
        return Ok(result);
    }
    
    [HttpGet("{productId:int}/sales")]
    public async Task<ActionResult<ServiceResponse<int>>> GetProductSales(int productId) {
        var result = await _productService.GetProductSales(productId);
        return Ok(result);
    }

    [HttpGet("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl) {
        var result = await _productService.GetProductsByCategory(categoryUrl);
        return Ok(result);
    }
    [HttpGet("search/{searchText}/{page:int}")]
    public async Task<ActionResult<ServiceResponse<ProductSearchResult>>> SearchProducts(string searchText, int page = 1) {
        var result = await _productService.SearchProducts(searchText, page);
        return Ok(result);
    }
    
    [HttpGet("searchSuggestions/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetProductsSearchSuggestions(string searchText) {
        var result = await _productService.GetProductsSearchSuggestions(searchText);
        return Ok(result);
    }
    
    [HttpGet("featured")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetFeaturedProducts() {
        var result = await _productService.GetFeaturedProducts();
        return Ok(result);
    }
}