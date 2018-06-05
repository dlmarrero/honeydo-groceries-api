using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GrocAPI.Migrations
{
    public partial class nomoreglist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_List_GroceryListId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_GroceryListId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "GroceryListId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "List");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroceryListId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "List",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Product_GroceryListId",
                table: "Product",
                column: "GroceryListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_List_GroceryListId",
                table: "Product",
                column: "GroceryListId",
                principalTable: "List",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
