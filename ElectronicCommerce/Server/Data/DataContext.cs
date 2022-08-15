namespace ElectronicCommerce.Server.Data;

public class DataContext : DbContext {
    public DataContext(DbContextOptions<DataContext> options) :
        base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<CartItem>()
           .HasKey(ci => new {ci.UserId, ci.ProductId, ci.ProductTypeId});

        modelBuilder.Entity<ProductVariant>()
           .HasKey(p => new {p.ProductId, p.ProductTypeId});

        modelBuilder.Entity<OrderItem>()
           .HasKey(oi => new {oi.OrderId, oi.ProductId, oi.ProductTypeId});

        modelBuilder.Entity<ProductType>().HasData(
            new ProductType {Id = 1, Name = "默认"},
            new ProductType {Id = 2, Name = "1件装"},
            new ProductType {Id = 3, Name = "2件装"},
            new ProductType {Id = 4, Name = "3件装"},
            new ProductType {Id = 5, Name = "6瓶"},
            new ProductType {Id = 6, Name = "12瓶"},
            new ProductType {Id = 7, Name = "24瓶"},
            new ProductType {Id = 8, Name = "蓝色"},
            new ProductType {Id = 9, Name = "粉色"},
            new ProductType {Id = 10, Name = "棕色"},
            new ProductType {Id = 11, Name = "白色"},
            new ProductType {Id = 12, Name = "原味"},
            new ProductType {Id = 13, Name = "牛奶味"},
            new ProductType {Id = 14, Name = "抹茶味"},
            new ProductType {Id = 15, Name = "椰子味"}
        );
        modelBuilder.Entity<Category>().HasData(
            new Category {
                Id = 1,
                Name = "饮品",
                Url = "drinks"
            },
            new Category {
                Id = 2,
                Name = "食物",
                Url = "food"
            },
            new Category {
                Id = 3,
                Name = "生活用品",
                Url = "daily-use"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product {
                Id = 1,
                CategoryId = 1,
                Title = "纯牛奶",
                Description =
                    "伊利 纯牛奶250ml 全脂牛奶 早餐伴侣\n纯牛奶也叫UHT超高温灭菌奶，将新鲜生牛乳经过超高温瞬时灭菌(135℃到150℃，4到15秒)的瞬间灭菌处理，完全破坏其中可生长的微生物和芽孢。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/215346/13/16450/81333/6247b583E969562c1/31fff20ec62fb164.jpg",
            },
            new Product {
                Id = 2,
                CategoryId = 1,
                Title = "可乐",
                Description =
                    "百事可乐 Pepsi 汽水330ML 碳酸饮料 (新老包装随机发货) 百事出品\n可乐(Cola)，是指有甜味、含咖啡因但不含酒精的碳酸饮料。味包括有香草、肉桂、柠檬香味等。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/214455/19/13675/260021/62206bfdE5e42b0c8/638fec85ed167e89.jpg",
            },
            new Product {
                Id = 3,
                CategoryId = 1,
                Title = "饮用水",
                Description =
                    "农夫山泉 饮用水 饮用天然水550ML 整箱装\n千岛湖，水域面积573 平方公里，库容量178.4 亿立方米。森林茂密，湖水清澈，水质清纯甘洌，水中存在钾、钙、钠、镁、偏硅酸等人体所需的天然矿物元素，呈天然弱碱性，适合长期饮用。在千岛湖生产基地，农夫山泉以千岛湖深层水为水源。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/192773/25/20204/39284/612743efE52581a57/13d53b488d3a3b56.jpg",
            },
            new Product {
                Id = 4,
                CategoryId = 2,
                Title = "蒸蛋糕",
                Description =
                    "港荣蒸蛋糕 奶香味900g整箱 饼干蛋糕 营养早餐食品 手撕面包口袋吐司 休闲零食夜宵充饥小吃\n蒸蛋糕是中国古代北方著名小吃，一款以鸡蛋、面粉、砂糖为原料的蛋糕，色泽淡黄，海绵状，富有弹性，无杂质，甜松绵软，潮润可口，具有蛋香风味的糕点。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/40458/9/12967/441009/5d413c37E1650336a/d4a9d8a9c3d97c78.jpg",
            },
            new Product {
                Id = 5,
                CategoryId = 2,
                Title = "巧克力",
                Description =
                    "徐福记糖果结婚喜糖散装批发代可可脂金币巧克力2斤七夕礼物（2斤大约84颗左右） 金币巧克力2斤\n巧克力（chocolate也译朱古力），原产中南美洲，其鼻祖是“xocolatl”，意为“苦水”。其主要原料可可豆产于赤道南北纬18度以内的狭长地带。作饮料时，常称为“热巧克力”或可可亚。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/203111/1/470/214466/6110903bEadfec97d/b7da2af0fa707e4c.jpg",
            },
            new Product {
                Id = 6,
                CategoryId = 2,
                Title = "早餐饼干",
                Description =
                    "嘉士利 零食饼干 营养早餐饼干 1000g/盒 送礼团购年货礼盒\n饼干，是以谷类粉（和/或豆类、薯类粉）等为主要原料，添加或不添加糖、油脂及其他原料,经调粉（或调浆）、成型、烘烤（或煎烤）等工艺制成的食品，以及熟制前或熟制后在产品之间(或表面、或内部)添加奶油、蛋白、可可、巧克力等的食品。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/50764/12/5064/233186/5d2c2b7bE1d7c01f9/e41cf6563c5c8d3e.jpg",
            },
            new Product {
                Id = 7,
                CategoryId = 3,
                Title = "衣架",
                Description =
                    " 富居(FOOJO)衣架 【天空蓝/20只装/38cm】防滑无痕衣架子 浸塑衣服挂架 干湿两用衣服撑子（含裤钩）\n衣架，用来搭披衣衫的架子。《鲁班经匠镜》讲到有素衣架和花衣架两种，外间较为少见。当时的衣架与现在的衣架不同。现代衣架大多采用挂钩式或枝叉式，衣物多以脖领处挂在衣钩上。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/119188/28/28940/89161/62c28d71E75bb01e0/22132c8900b708c9.jpg",
            },
            new Product {
                Id = 8,
                CategoryId = 3,
                Title = "脸盆",
                Description =
                    "千鸿 38CM脸盆 洗漱洗衣洗菜盆QH-01036\n环保PP材质，不含双酚A,厚实耐用，承重强，色彩清新典雅，浴室、厨房都可用。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t22456/44/982330814/207329/63e6e33e/5b4bddeaN6e4d9550.jpg",
            },
            new Product {
                Id = 9,
                CategoryId = 3,
                Title = "宿舍床垫",
                Description =
                    "南极人NanJiren 床垫家纺 学生宿舍单人床垫 上下铺榻榻米床褥子垫子可折叠防滑软垫 灰色 0.9米床\n床垫，是为了保证消费者获得健康和舒适睡眠而使用的一种介于人体和床之间的物品。床垫材质繁多，不同材料制作的床垫能给人带来不同的睡眠效果。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/175123/17/17446/337732/60dc1446E0d63da51/11fa5d7e7b31d8a9.jpg",
            },
            new Product {
                Id = 10,
                CategoryId = 3,
                Title = "牙刷",
                Description =
                    "高露洁（Colgate）宽柔小宽头超细软毛牙刷套装 经典48孔 宽头成人牙刷 轻适刷 深洁齿缝2支装\n牙刷是一种清洁用品，为手柄式刷子，用于在刷子上添加牙膏，然后反复刷洗牙齿各个部位，以保持口腔卫生。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/158825/2/26588/74194/61e943dbEb3661489/4edd6f32843f3505.jpg",
            },
            new Product {
                Id = 11,
                CategoryId = 3,
                Title = "毛巾",
                Description =
                    "洁丽雅（Grace）新疆棉毛巾 长绒棉A类毛巾2条装 纯棉加厚柔软强吸水洗脸巾 72×34cm 深灰色+深棕色\n毛巾是由三个系统纱线相互交织而成的具有毛圈结构的织物。这三个系统的纱线即是毛经、地经和纬纱。随着科技的发展，又出现了经编毛巾织物，这种毛巾毛圈固结牢，但形式相对单一，市场上的绝大部分为机织毛巾。",
                ImageUrl =
                    "https://img14.360buyimg.com/n0/jfs/t1/80567/26/14630/140709/5dc26d5dE55d05929/c8b87ef20c192e2e.jpg",
            }
        );

        modelBuilder.Entity<ProductVariant>().HasData(
            new ProductVariant {
                ProductId = 1,
                ProductTypeId = 5,
                Price = 18m,
            },
            new ProductVariant {
                ProductId = 1,
                ProductTypeId = 6,
                Price = 33m,
                OriginalPrice = 36m
            },
            new ProductVariant {
                ProductId = 1,
                ProductTypeId = 7,
                Price = 60m,
                OriginalPrice = 72m
            },
            new ProductVariant {
                ProductId = 2,
                ProductTypeId = 5,
                Price = 18m,
            },
            new ProductVariant {
                ProductId = 2,
                ProductTypeId = 6,
                Price = 33m,
                OriginalPrice = 36m
            },
            new ProductVariant {
                ProductId = 2,
                ProductTypeId = 7,
                Price = 60m,
                OriginalPrice = 72m
            },
            new ProductVariant {
                ProductId = 3,
                ProductTypeId = 5,
                Price = 12m,
            },
            new ProductVariant {
                ProductId = 3,
                ProductTypeId = 6,
                Price = 20m,
                OriginalPrice = 24m
            },
            new ProductVariant {
                ProductId = 3,
                ProductTypeId = 7,
                Price = 36m,
                OriginalPrice = 48m
            },
            new ProductVariant {
                ProductId = 4,
                ProductTypeId = 12,
                Price = 19.9m,
                OriginalPrice = 21.9m
            },
            new ProductVariant {
                ProductId = 4,
                ProductTypeId = 13,
                Price = 21.9m,
            },
            new ProductVariant {
                ProductId = 4,
                ProductTypeId = 15,
                Price = 21.9m,
            },
            new ProductVariant {
                ProductId = 5,
                ProductTypeId = 12,
                Price = 29.9m,
            },
            new ProductVariant {
                ProductId = 5,
                ProductTypeId = 14,
                Price = 29.9m,
                OriginalPrice = 39.9m
            },
            new ProductVariant {
                ProductId = 6,
                ProductTypeId = 1,
                Price = 14.9m,
            },
            new ProductVariant {
                ProductId = 7,
                ProductTypeId = 1,
                Price = 14.9m,
            },
            new ProductVariant {
                ProductId = 8,
                ProductTypeId = 1,
                Price = 14.9m,
                OriginalPrice = 19.9m
            },
            new ProductVariant {
                ProductId = 9,
                ProductTypeId = 1,
                Price = 69.9m,
            },
            new ProductVariant {
                ProductId = 10,
                ProductTypeId = 2,
                Price = 5m,
            },
            new ProductVariant {
                ProductId = 10,
                ProductTypeId = 3,
                Price = 9m,
                OriginalPrice = 10m
            },
            new ProductVariant {
                ProductId = 10,
                ProductTypeId = 4,
                Price = 12m,
                OriginalPrice = 15m
            },
             new ProductVariant {
                ProductId = 11,
                ProductTypeId = 8,
                Price = 9.9m,
            },
            new ProductVariant {
                ProductId = 11,
                ProductTypeId = 9,
                Price = 9.9m,
            },
            new ProductVariant {
                ProductId = 11,
                ProductTypeId = 10,
                Price = 9.9m,
            },
            new ProductVariant {
                ProductId = 11,
                ProductTypeId = 11,
                Price = 9.9m,
            }
        );
        
    }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<ProductType> ProductTypes { get; set; } = null!;
    public DbSet<ProductVariant> ProductVariants { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<CartItem> CartItems { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrdersItems { get; set; } = null!;
}