using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Data.Migrations
{
    public partial class addqrcodeproperty2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "qrcode",
                table: "Products",
                newName: "QRCode");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 35, 19, 631, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 35, 19, 631, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 35, 19, 631, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 35, 19, 631, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 35, 19, 631, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 12, 14, 35, 19, 631, DateTimeKind.Local).AddTicks(9184));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QRCode",
                table: "Products",
                newName: "qrcode");

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
    }
}
