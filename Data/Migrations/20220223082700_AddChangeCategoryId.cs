using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApi.Migrations
{
    public partial class AddChangeCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 27, 0, 124, DateTimeKind.Utc).AddTicks(6371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 21, 55, 354, DateTimeKind.Utc).AddTicks(8484));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 12, 21, 55, 354, DateTimeKind.Utc).AddTicks(8484),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 23, 12, 27, 0, 124, DateTimeKind.Utc).AddTicks(6371));
        }
    }
}
