using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class cart3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("e82e8d74-baea-4a0b-86fc-95bf4dcb9be7"), "Пиво Разлив" },
                    { new Guid("fb8d487d-1f14-45ad-a6ff-7dd73a692eee"), "Пиво Банки" },
                    { new Guid("ef341e2f-0807-44e0-aa94-eda68d224772"), "Пиво Стекло" },
                    { new Guid("0bf635b2-b51e-4e87-a5e5-fea2fe4b565e"), "Пиво бочка" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bf635b2-b51e-4e87-a5e5-fea2fe4b565e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e82e8d74-baea-4a0b-86fc-95bf4dcb9be7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef341e2f-0807-44e0-aa94-eda68d224772"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb8d487d-1f14-45ad-a6ff-7dd73a692eee"));

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
        }
    }
}
