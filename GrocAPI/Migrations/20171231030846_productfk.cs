using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GrocAPI.Migrations
{
    public partial class productfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_List_GroceryListId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "GroceryListId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_List_GroceryListId",
                table: "Product",
                column: "GroceryListId",
                principalTable: "List",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_List_GroceryListId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "GroceryListId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_List_GroceryListId",
                table: "Product",
                column: "GroceryListId",
                principalTable: "List",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
