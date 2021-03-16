using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class newPivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83d59c33-acd4-4a42-a92a-f438e74d6fe1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8779720-cacf-4bad-a811-140a8ff2e39f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f356adfb-1696-400d-ae02-c41eeb0f5a68"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("f356adfb-1696-400d-ae02-c41eeb0f5a68"), "Пиво Разлив" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("83d59c33-acd4-4a42-a92a-f438e74d6fe1"), "Пиво Банки" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c8779720-cacf-4bad-a811-140a8ff2e39f"), "Пиво Бокал" });
        }
    }
}
