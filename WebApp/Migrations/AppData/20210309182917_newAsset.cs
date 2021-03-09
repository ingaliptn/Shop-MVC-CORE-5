using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class newAsset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AssetId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69609eec-7182-46d8-8301-846cf78c0256"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78e4d5df-1a21-4d0a-8805-cb675171a04a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd16a953-b5dc-4522-81d9-9e02a748f9d9"));

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductAsset",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(name: "Product Id", type: "uniqueidentifier", nullable: false),
                    AssetId = table.Column<Guid>(name: "Asset Id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAsset", x => new { x.ProductId, x.AssetId });
                    table.ForeignKey(
                        name: "FK_ProductAsset_Assets_Asset Id",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAsset_Products_Asset Id",
                        column: x => x.AssetId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("715eadc4-b2fe-4a64-842b-07654e5af1ee"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("63191af2-96d7-4f82-9af7-abb53d09fbeb"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2a40ba37-e470-46e6-92d5-415b8aef2b99"), "Pivo Bokal" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAsset_Asset Id",
                table: "ProductAsset",
                column: "Asset Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAsset");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a40ba37-e470-46e6-92d5-415b8aef2b99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63191af2-96d7-4f82-9af7-abb53d09fbeb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("715eadc4-b2fe-4a64-842b-07654e5af1ee"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssetId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("78e4d5df-1a21-4d0a-8805-cb675171a04a"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bd16a953-b5dc-4522-81d9-9e02a748f9d9"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("69609eec-7182-46d8-8301-846cf78c0256"), "Pivo Bokal" });

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
