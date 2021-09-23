using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_1.Persistence.Migrations
{
    public partial class CartServ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 13, 10, 30, 23, 65, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 13, 10, 30, 23, 71, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 13, 10, 30, 23, 71, DateTimeKind.Local).AddTicks(6573));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 12, 22, 26, 51, 565, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 12, 22, 26, 51, 570, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 12, 22, 26, 51, 570, DateTimeKind.Local).AddTicks(2226));
        }
    }
}
