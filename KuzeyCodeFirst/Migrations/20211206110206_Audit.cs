using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KuzeyCodeFirst.Migrations
{
    public partial class Audit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Urunler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Urunler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Urunler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Urunler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Siparisler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Siparisler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Siparisler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Siparisler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Kategoriler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Kategoriler",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Kategoriler");
        }
    }
}
