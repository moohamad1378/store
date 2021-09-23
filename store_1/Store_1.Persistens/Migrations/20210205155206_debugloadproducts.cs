using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_1.Persistence.Migrations
{
    public partial class debugloadproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 5, 19, 22, 5, 888, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 5, 19, 22, 5, 892, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 5, 19, 22, 5, 892, DateTimeKind.Local).AddTicks(4312));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 4, 19, 32, 14, 572, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 4, 19, 32, 14, 576, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 4, 19, 32, 14, 576, DateTimeKind.Local).AddTicks(8837));
        }
    }
}
