using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class newKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAsset_Products_Asset Id",
                table: "ProductAsset");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("32242340-d396-4bc7-b6ad-698df62ea1c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c3a9028-965e-4543-b137-aff950282470"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e50dbdea-8669-4825-beeb-246a5ba70950"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ac34f89f-c54e-49f0-84fb-c52e90626152"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f5872e36-30f6-4fd1-a7c6-aabdfc2aba10"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4e873ae5-791f-46e8-b6a2-9df9c60c0e1e"), "Pivo Bokal" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAsset_Products_Product Id",
                table: "ProductAsset",
                column: "Product Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAsset_Products_Product Id",
                table: "ProductAsset");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e873ae5-791f-46e8-b6a2-9df9c60c0e1e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac34f89f-c54e-49f0-84fb-c52e90626152"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f5872e36-30f6-4fd1-a7c6-aabdfc2aba10"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e50dbdea-8669-4825-beeb-246a5ba70950"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9c3a9028-965e-4543-b137-aff950282470"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("32242340-d396-4bc7-b6ad-698df62ea1c7"), "Pivo Bokal" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAsset_Products_Asset Id",
                table: "ProductAsset",
                column: "Asset Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
