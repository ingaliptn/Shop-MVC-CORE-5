using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("93e2f7a3-4dae-4e51-8e2c-5a230426f4da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd8bc074-f3e4-4a69-beb5-dd31c7d35d30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df11b38f-4c03-4ccc-93e0-9ffe5e7584d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa18228f-a9f2-4306-865f-aa66e67b8eba"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("df11b38f-4c03-4ccc-93e0-9ffe5e7584d4"), "Пиво Разлив" },
                    { new Guid("bd8bc074-f3e4-4a69-beb5-dd31c7d35d30"), "Пиво Банки" },
                    { new Guid("93e2f7a3-4dae-4e51-8e2c-5a230426f4da"), "Пиво Стекло" },
                    { new Guid("fa18228f-a9f2-4306-865f-aa66e67b8eba"), "Пиво бочка" }
                });
        }
    }
}
