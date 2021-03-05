using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class addeAss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d6bc102c-d797-4c80-9f7f-7287f5ed4764"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("5c1668b4-1346-4cc5-899b-a5c37056c958"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6702fd73-a9dc-41d0-829b-b5846c2adbda"), "Pivo Bokal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c1668b4-1346-4cc5-899b-a5c37056c958"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6702fd73-a9dc-41d0-829b-b5846c2adbda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6bc102c-d797-4c80-9f7f-7287f5ed4764"));

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
        }
    }
}
