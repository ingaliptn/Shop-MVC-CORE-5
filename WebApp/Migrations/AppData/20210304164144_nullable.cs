using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations.AppData
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "AssetId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "AssetId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Assets_AssetId",
                table: "Products",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
