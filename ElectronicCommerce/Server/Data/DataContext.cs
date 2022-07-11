namespace ElectronicCommerce.Server.Data;
public class DataContext : DbContext {
    public DataContext(DbContextOptions<DataContext> options) : base(options) {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().HasData(
            new Product {
                Id = 1,
                Title = "美的(Midea)606升变频一级能效对开双门家用冰箱京东小家智能家电风冷无霜BCD-606WKPZM(E)大容量精细分储",
                Description = "很好",
                ImageUrl = "https://img14.360buyimg.com/n1/s546x546_jfs/t1/26576/18/18347/282563/62c55483Ed138ae22/b74923e09acaa7e9.jpg",
                Price = 3099m,
            },
        new Product {
            Id = 2,
            Title = "",
            Description = "",
            ImageUrl = "",
            Price = 9.99m,
        },
        new Product {
            Id = 3,
            Title = "",
            Description = "",
            ImageUrl = "",
            Price = 9.99m,
        },
        new Product {
            Id = 4,
            Title = "",
            Description = "",
            ImageUrl = "",
            Price = 9.99m,
        }
        );
    }

    public DbSet<Product> Products { get; set; }
}
