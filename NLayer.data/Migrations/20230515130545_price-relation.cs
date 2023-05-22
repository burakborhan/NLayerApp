using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Data.Migrations
{
    public partial class pricerelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentPrice",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "OldPrice2",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "OldPrice3",
                table: "Prices");

            migrationBuilder.RenameColumn(
                name: "OldPrice4",
                table: "Prices",
                newName: "Prices");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 16, 5, 44, 783, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 16, 5, 44, 783, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 16, 5, 44, 783, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 16, 5, 44, 783, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 16, 5, 44, 783, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 16, 5, 44, 783, DateTimeKind.Local).AddTicks(5043));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prices",
                table: "Prices",
                newName: "OldPrice4");

            migrationBuilder.AddColumn<decimal>(
                name: "CurrentPrice",
                table: "Prices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice",
                table: "Prices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice2",
                table: "Prices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OldPrice3",
                table: "Prices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 15, 29, 19, 608, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 15, 29, 19, 608, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 15, 29, 19, 608, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 15, 29, 19, 608, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 15, 29, 19, 608, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 15, 29, 19, 608, DateTimeKind.Local).AddTicks(2131));
        }
    }
}
