using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicCommerce.Server.Migrations
{
    public partial class UpdateUserClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Email");
        }
    }
}
