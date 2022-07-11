using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicCommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "很好", "https://img14.360buyimg.com/n1/s546x546_jfs/t1/26576/18/18347/282563/62c55483Ed138ae22/b74923e09acaa7e9.jpg", 3099m, "美的(Midea)606升变频一级能效对开双门家用冰箱京东小家智能家电风冷无霜BCD-606WKPZM(E)大容量精细分储" },
                    { 2, "", "", 9.99m, "" },
                    { 3, "", "", 9.99m, "" },
                    { 4, "", "", 9.99m, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
