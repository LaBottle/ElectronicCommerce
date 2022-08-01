namespace ElectronicCommerce.Client.Services.CategoryService;
public interface ICategoryService {
    public List<Category> Categories { get; set; }
    Task GetCategories();
    Task<ServiceResponse<Category>> GetCategory(int categoryId);
}

