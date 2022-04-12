using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApi.Migrations
{
    public partial class AppUserTABLEAdded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Tags",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 491, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 491, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 11, 13, 40, 873, DateTimeKind.Utc).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 485, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 11, 13, 40, 871, DateTimeKind.Utc).AddTicks(2714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 484, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 489, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 489, DateTimeKind.Utc).AddTicks(7960));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 491, DateTimeKind.Utc).AddTicks(5260),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 491, DateTimeKind.Utc).AddTicks(4978),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 485, DateTimeKind.Utc).AddTicks(9886),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 4, 11, 11, 13, 40, 873, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 484, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 4, 11, 11, 13, 40, 871, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 489, DateTimeKind.Utc).AddTicks(8323),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 11, 10, 38, 30, 489, DateTimeKind.Utc).AddTicks(7960),
                oldClrType: typeof(DateTime));
        }
    }
}
