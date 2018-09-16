using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inzynierka_Shop.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Produkt");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Produkt",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Produkt",
                newName: "Cena");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Produkt",
                newName: "Kategoria");

            migrationBuilder.AddColumn<string>(
                name: "Ilosc",
                table: "Produkt",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ilosc",
                table: "Produkt");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "Produkt",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Kategoria",
                table: "Produkt",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "Produkt",
                newName: "Price");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Produkt",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
