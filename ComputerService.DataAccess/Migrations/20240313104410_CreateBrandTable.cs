using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerService.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateBrandTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "SpareParts");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "SpareParts");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "ServiceRecords");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "SpareParts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpareParts_BrandId",
                table: "SpareParts",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_BrandId",
                table: "ServiceRecords",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Brands_BrandId",
                table: "ServiceRecords",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpareParts_Brands_BrandId",
                table: "SpareParts",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Brands_BrandId",
                table: "ServiceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_SpareParts_Brands_BrandId",
                table: "SpareParts");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_SpareParts_BrandId",
                table: "SpareParts");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_BrandId",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "SpareParts");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "ServiceRecords");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "SpareParts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "SpareParts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "ServiceRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ServiceRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "ServiceRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
