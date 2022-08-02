using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicCommerce.Server.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "饮品", "drinks" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "食物", "food" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "生活用品", "daily-use" });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "默认");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "1件装");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2件装");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "3件装");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "6瓶");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "12瓶");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "24瓶");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "蓝色");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "粉色");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "棕色");

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "白色" },
                    { 12, "原味" },
                    { 13, "牛奶味" },
                    { 14, "抹茶味" },
                    { 15, "椰子味" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 5, 0m, 18m },
                    { 1, 6, 36m, 33m },
                    { 1, 7, 72m, 60m },
                    { 2, 5, 0m, 18m },
                    { 2, 6, 36m, 33m },
                    { 2, 7, 72m, 60m },
                    { 3, 5, 0m, 12m },
                    { 3, 6, 24m, 20m },
                    { 3, 7, 48m, 36m },
                    { 6, 1, 0m, 14.9m },
                    { 7, 1, 0m, 14.9m },
                    { 8, 1, 19.9m, 14.9m },
                    { 9, 1, 0m, 69.9m },
                    { 10, 2, 0m, 5m },
                    { 10, 3, 10m, 9m },
                    { 10, 4, 15m, 12m },
                    { 11, 8, 0m, 9.9m },
                    { 11, 9, 0m, 9.9m },
                    { 11, 10, 0m, 9.9m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "伊利 纯牛奶250ml 全脂牛奶 早餐伴侣\n纯牛奶也叫UHT超高温灭菌奶，将新鲜生牛乳经过超高温瞬时灭菌(135℃到150℃，4到15秒)的瞬间灭菌处理，完全破坏其中可生长的微生物和芽孢。", "https://img14.360buyimg.com/n0/jfs/t1/215346/13/16450/81333/6247b583E969562c1/31fff20ec62fb164.jpg", "纯牛奶" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "百事可乐 Pepsi 汽水330ML 碳酸饮料 (新老包装随机发货) 百事出品\n可乐(Cola)，是指有甜味、含咖啡因但不含酒精的碳酸饮料。味包括有香草、肉桂、柠檬香味等。", "https://img14.360buyimg.com/n0/jfs/t1/214455/19/13675/260021/62206bfdE5e42b0c8/638fec85ed167e89.jpg", "可乐" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "农夫山泉 饮用水 饮用天然水550ML 整箱装\n千岛湖，水域面积573 平方公里，库容量178.4 亿立方米。森林茂密，湖水清澈，水质清纯甘洌，水中存在钾、钙、钠、镁、偏硅酸等人体所需的天然矿物元素，呈天然弱碱性，适合长期饮用。在千岛湖生产基地，农夫山泉以千岛湖深层水为水源。", "https://img14.360buyimg.com/n0/jfs/t1/192773/25/20204/39284/612743efE52581a57/13d53b488d3a3b56.jpg", "饮用水" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "港荣蒸蛋糕 奶香味900g整箱 饼干蛋糕 营养早餐食品 手撕面包口袋吐司 休闲零食夜宵充饥小吃\n蒸蛋糕是中国古代北方著名小吃，一款以鸡蛋、面粉、砂糖为原料的蛋糕，色泽淡黄，海绵状，富有弹性，无杂质，甜松绵软，潮润可口，具有蛋香风味的糕点。", "https://img14.360buyimg.com/n0/jfs/t1/40458/9/12967/441009/5d413c37E1650336a/d4a9d8a9c3d97c78.jpg", "蒸蛋糕" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "徐福记糖果结婚喜糖散装批发代可可脂金币巧克力2斤七夕礼物（2斤大约84颗左右） 金币巧克力2斤\n巧克力（chocolate也译朱古力），原产中南美洲，其鼻祖是“xocolatl”，意为“苦水”。其主要原料可可豆产于赤道南北纬18度以内的狭长地带。作饮料时，常称为“热巧克力”或可可亚。", "https://img14.360buyimg.com/n0/jfs/t1/203111/1/470/214466/6110903bEadfec97d/b7da2af0fa707e4c.jpg", "巧克力" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "嘉士利 零食饼干 营养早餐饼干 1000g/盒 送礼团购年货礼盒\n饼干，是以谷类粉（和/或豆类、薯类粉）等为主要原料，添加或不添加糖、油脂及其他原料,经调粉（或调浆）、成型、烘烤（或煎烤）等工艺制成的食品，以及熟制前或熟制后在产品之间(或表面、或内部)添加奶油、蛋白、可可、巧克力等的食品。", "https://img14.360buyimg.com/n0/jfs/t1/50764/12/5064/233186/5d2c2b7bE1d7c01f9/e41cf6563c5c8d3e.jpg", "早餐饼干" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { " 富居(FOOJO)衣架 【天空蓝/20只装/38cm】防滑无痕衣架子 浸塑衣服挂架 干湿两用衣服撑子（含裤钩）\n衣架，用来搭披衣衫的架子。《鲁班经匠镜》讲到有素衣架和花衣架两种，外间较为少见。当时的衣架与现在的衣架不同。现代衣架大多采用挂钩式或枝叉式，衣物多以脖领处挂在衣钩上。", "https://img14.360buyimg.com/n0/jfs/t1/119188/28/28940/89161/62c28d71E75bb01e0/22132c8900b708c9.jpg", "衣架" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "千鸿 38CM脸盆 洗漱洗衣洗菜盆QH-01036\n环保PP材质，不含双酚A,厚实耐用，承重强，色彩清新典雅，浴室、厨房都可用。", "https://img14.360buyimg.com/n0/jfs/t22456/44/982330814/207329/63e6e33e/5b4bddeaN6e4d9550.jpg", "脸盆" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "南极人NanJiren 床垫家纺 学生宿舍单人床垫 上下铺榻榻米床褥子垫子可折叠防滑软垫 灰色 0.9米床\n床垫，是为了保证消费者获得健康和舒适睡眠而使用的一种介于人体和床之间的物品。床垫材质繁多，不同材料制作的床垫能给人带来不同的睡眠效果。", "https://img14.360buyimg.com/n0/jfs/t1/175123/17/17446/337732/60dc1446E0d63da51/11fa5d7e7b31d8a9.jpg", "宿舍床垫" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "高露洁（Colgate）宽柔小宽头超细软毛牙刷套装 经典48孔 宽头成人牙刷 轻适刷 深洁齿缝2支装\n牙刷是一种清洁用品，为手柄式刷子，用于在刷子上添加牙膏，然后反复刷洗牙齿各个部位，以保持口腔卫生。", "https://img14.360buyimg.com/n0/jfs/t1/158825/2/26588/74194/61e943dbEb3661489/4edd6f32843f3505.jpg", "牙刷" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "洁丽雅（Grace）新疆棉毛巾 长绒棉A类毛巾2条装 纯棉加厚柔软强吸水洗脸巾 72×34cm 深灰色+深棕色\n毛巾是由三个系统纱线相互交织而成的具有毛圈结构的织物。这三个系统的纱线即是毛经、地经和纬纱。随着科技的发展，又出现了经编毛巾织物，这种毛巾毛圈固结牢，但形式相对单一，市场上的绝大部分为机织毛巾。", "https://img14.360buyimg.com/n0/jfs/t1/80567/26/14630/140709/5dc26d5dE55d05929/c8b87ef20c192e2e.jpg", "毛巾" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 4, 12, 21.9m, 19.9m },
                    { 4, 13, 0m, 21.9m },
                    { 4, 15, 0m, 21.9m },
                    { 5, 12, 0m, 29.9m },
                    { 5, 14, 39.9m, 29.9m },
                    { 11, 11, 0m, 9.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Books", "books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Movies", "movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Video games", "video-games" });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Paperback");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "E-Book");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Audiobook");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Stream");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Blu-ray");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "VHS");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "PlayStation");

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Xbox");

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 2, 19.99m, 9.99m },
                    { 1, 3, 0m, 7.99m },
                    { 1, 4, 29.99m, 19.99m },
                    { 2, 2, 14.99m, 7.99m },
                    { 3, 2, 0m, 6.99m },
                    { 4, 5, 0m, 3.99m },
                    { 4, 6, 0m, 9.99m },
                    { 4, 7, 0m, 19.99m },
                    { 5, 5, 0m, 3.99m },
                    { 6, 5, 0m, 2.99m },
                    { 7, 8, 29.99m, 19.99m },
                    { 7, 9, 0m, 69.99m },
                    { 7, 10, 59.99m, 49.99m },
                    { 8, 8, 24.99m, 9.99m },
                    { 9, 8, 0m, 14.99m },
                    { 10, 1, 299m, 159.99m },
                    { 11, 1, 399m, 79.99m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 video game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" });
        }
    }
}
