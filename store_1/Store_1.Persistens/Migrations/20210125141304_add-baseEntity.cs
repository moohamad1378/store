using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_1.Persistence.Migrations
{
    public partial class addbaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "RemoveTime",
                table: "users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "users",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "users");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RemoveTime",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "users");
        }
    }
}
