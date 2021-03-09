using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class newAsset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("715eadc4-b2fe-4a64-842b-07654e5af1ee"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("63191af2-96d7-4f82-9af7-abb53d09fbeb"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2a40ba37-e470-46e6-92d5-415b8aef2b99"), "Pivo Bokal" });
        }
    }
}
