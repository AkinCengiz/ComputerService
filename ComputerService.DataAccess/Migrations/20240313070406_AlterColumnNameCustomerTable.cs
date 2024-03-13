using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerService.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumnNameCustomerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Customers",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Customers",
                newName: "Created");
        }
    }
}
