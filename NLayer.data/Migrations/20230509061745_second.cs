using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 9, 9, 17, 44, 779, DateTimeKind.Local).AddTicks(5128));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 8, 14, 32, 29, 315, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 8, 14, 32, 29, 315, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 8, 14, 32, 29, 315, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 8, 14, 32, 29, 315, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 8, 14, 32, 29, 315, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 8, 14, 32, 29, 315, DateTimeKind.Local).AddTicks(7791));
        }
    }
}
