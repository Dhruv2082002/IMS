using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Plugins.EFCoreSqlServer.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_ProductName",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_InventoryName",
                table: "Inventories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductName",
                table: "Products",
                column: "ProductName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_InventoryName",
                table: "Inventories",
                column: "InventoryName",
                unique: true);
        }
    }
}
