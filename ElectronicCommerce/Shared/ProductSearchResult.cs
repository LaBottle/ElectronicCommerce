namespace ElectronicCommerce.Shared; 

public class ProductSearchResult {
    public List<Product> Products { get; set; } = null!;
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
}