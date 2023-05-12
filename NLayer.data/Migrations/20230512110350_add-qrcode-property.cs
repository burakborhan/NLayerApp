using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Data.Migrations
{
    public partial class addqrcodeproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "qrcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 3, 50, 133, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 3, 50, 133, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 3, 50, 133, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 3, 50, 133, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 3, 50, 133, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 3, 50, 133, DateTimeKind.Local).AddTicks(9817));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "qrcode",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 14, 49, 41, 440, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 14, 49, 41, 440, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 14, 49, 41, 440, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 14, 49, 41, 440, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 14, 49, 41, 440, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 14, 49, 41, 440, DateTimeKind.Local).AddTicks(118));
        }
    }
}
