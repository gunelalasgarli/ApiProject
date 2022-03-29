using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApi.Migrations
{
    public partial class NewConfigChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 28, 15, 22, 31, 408, DateTimeKind.Utc).AddTicks(5142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 27, 0, 124, DateTimeKind.Utc).AddTicks(6371));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 27, 0, 124, DateTimeKind.Utc).AddTicks(6371),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 28, 15, 22, 31, 408, DateTimeKind.Utc).AddTicks(5142));
        }
    }
}
