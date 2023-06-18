using System.Text;
using Xunit;

namespace ElectronicCommerce.Server.Services.ProductService;

public class ProductServiceTest {
    private readonly ProductService _service;


    public ProductServiceTest() {
        _service = new ProductService(ServicesTestBase.DataContext);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    private async Task GetProductValidly(int productId) {
        Assert.True((await _service.GetProduct(productId)).Success);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    private async Task GetProductInvalidly(int productId) {
        Assert.False((await _service.GetProduct(productId)).Success);
    }

    [Theory]
    [InlineData("牛奶")]
    [InlineData("面包")]
    [InlineData("西瓜")]
    private async Task SearchProductsValidly(string searchText) {
        Assert.True((await _service.SearchProducts(searchText)).Success);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    private async Task SearchProductsInValidly(string searchText) {
        Assert.False((await _service.SearchProducts(searchText)).Success);
    }

    [Fact]
    private async Task SearchProductsTooLong() {
        Assert.Equal("搜索内容过长", (await _service.SearchProducts(new string(' ', 40))).Message);
    }

    [Theory]
    [InlineData("牛奶,蒙牛")]
    [InlineData("牛")]
    [InlineData("奶，羊")]
    private async Task GetProductsSearchSuggestionsValidly(string searchText) {
        Assert.True((await _service.GetProductsSearchSuggestions(searchText)).Success);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    private async Task GetProductsSearchSuggestionsInValidly(string searchText) {
        Assert.False((await _service.GetProductsSearchSuggestions(searchText)).Success);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    private async Task GetProductSalesValidly(int productId) {
        Assert.True((await _service.GetProductSales(productId)).Success);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    private async Task GetProductSalesInvalidly(int productId) {
        Assert.False((await _service.GetProductSales(productId)).Success);
    }
    
    [Fact]
    private async Task GetProductsValidly() {
        Assert.True((await _service.GetProducts()).Success);
    }
    
    [Theory]
    [InlineData("drinks")]
    [InlineData("food")]
    private async Task GetProductsByCategoryValidly(string categoryUrl) {
        Assert.True((await _service.GetProductsByCategory(categoryUrl)).Success);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("宇宙飞船")]
    private async Task GetProductsByCategoryInValidly(string categoryUrl) {
        Assert.False((await _service.GetProductsByCategory(categoryUrl)).Success);
    }
}