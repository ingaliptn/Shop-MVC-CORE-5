using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class AppTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategotyId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategotyId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Asset",
                table: "Products",
                newName: "AssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategotyId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AlterColumn<decimal>(
                name: "WholesalePrice",
                table: "Products",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RetailPrice",
                table: "Products",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    original = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    mime = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ext = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("14a777eb-085b-4b1e-a650-b19217c6bdfc"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4f7dce26-a9df-4dc3-a25a-e63f167ea475"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9bc0c5a4-b482-4ae5-9e5f-3f57e1653eeb"), "Pivo Bokal" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AssetId",
                table: "Products",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Products_AssetId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14a777eb-085b-4b1e-a650-b19217c6bdfc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f7dce26-a9df-4dc3-a25a-e63f167ea475"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9bc0c5a4-b482-4ae5-9e5f-3f57e1653eeb"));

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CategotyId");

            migrationBuilder.RenameColumn(
                name: "AssetId",
                table: "Products",
                newName: "Asset");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategotyId");

            migrationBuilder.AlterColumn<decimal>(
                name: "WholesalePrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "RetailPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategotyId",
                table: "Products",
                column: "CategotyId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
