using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KuzeyCodeFirst.Migrations
{
    public partial class TedarikciTablo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TedarikciId",
                table: "Urunler",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_TedarikciId",
                table: "Urunler",
                column: "TedarikciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Tedarikciler_TedarikciId",
                table: "Urunler",
                column: "TedarikciId",
                principalTable: "Tedarikciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Tedarikciler_TedarikciId",
                table: "Urunler");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_TedarikciId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "TedarikciId",
                table: "Urunler");
        }
    }
}
