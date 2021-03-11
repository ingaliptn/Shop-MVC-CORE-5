using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class newKeys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("ac34f89f-c54e-49f0-84fb-c52e90626152"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f5872e36-30f6-4fd1-a7c6-aabdfc2aba10"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4e873ae5-791f-46e8-b6a2-9df9c60c0e1e"), "Pivo Bokal" });
        }
    }
}
