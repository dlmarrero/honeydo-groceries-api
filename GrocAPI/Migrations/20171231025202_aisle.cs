using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GrocAPI.Migrations
{
    public partial class aisle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Aisle",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Aisle",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
