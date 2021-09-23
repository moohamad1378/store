using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_1.Persistence.Migrations
{
    public partial class add_slider_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 11, 20, 12, 54, 77, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 11, 20, 12, 54, 83, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 11, 20, 12, 54, 83, DateTimeKind.Local).AddTicks(5014));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 11, 20, 8, 31, 939, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 11, 20, 8, 31, 944, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2021, 2, 11, 20, 8, 31, 944, DateTimeKind.Local).AddTicks(240));
        }
    }
}
