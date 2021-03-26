using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class cart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b710ae1-27e1-4c83-a53d-84d4d0b64604"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dfc960e-8582-4a7e-8b15-f22bc2f5b230"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68f004dd-a106-4b25-a67a-2557c0a93fb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc00e9f8-b4b2-432e-b8c7-5b30d294c5b4"));

            migrationBuilder.CreateTable(
                name: "ItemInCart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemInCart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("52bef9a8-6edb-41a3-959d-5e9a0c1b0271"), "Пиво Разлив" },
                    { new Guid("4987b264-d493-4fa6-9a28-08c2f35c9eb2"), "Пиво Банки" },
                    { new Guid("9d9100fb-6c2f-4377-b446-5079a9dfc494"), "Пиво Стекло" },
                    { new Guid("f69f5320-3ba1-4831-a488-eef23cc2fae8"), "Пиво бочка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemInCart_ProductId",
                table: "ItemInCart",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemInCart");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4987b264-d493-4fa6-9a28-08c2f35c9eb2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52bef9a8-6edb-41a3-959d-5e9a0c1b0271"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d9100fb-6c2f-4377-b446-5079a9dfc494"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f69f5320-3ba1-4831-a488-eef23cc2fae8"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("fc00e9f8-b4b2-432e-b8c7-5b30d294c5b4"), "Пиво Разлив" },
                    { new Guid("0b710ae1-27e1-4c83-a53d-84d4d0b64604"), "Пиво Банки" },
                    { new Guid("5dfc960e-8582-4a7e-8b15-f22bc2f5b230"), "Пиво Стекло" },
                    { new Guid("68f004dd-a106-4b25-a67a-2557c0a93fb1"), "Пиво бочка" }
                });
        }
    }
}
