using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class nullabletest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77bc5ad8-1208-4147-bda2-ec8f9a6cdb54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e15973e7-4bfb-45d2-b5b7-f298602cae13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e61fd726-0ad1-4327-ab20-63e238ac53d8"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e61fd726-0ad1-4327-ab20-63e238ac53d8"), "Pivo Razliv" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e15973e7-4bfb-45d2-b5b7-f298602cae13"), "Pivo Banki" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("77bc5ad8-1208-4147-bda2-ec8f9a6cdb54"), "Pivo Bokal" });
        }
    }
}
