using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerService.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateInvoicesAndServiceRecordsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecord_Customers_CustomerId",
                table: "ServiceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecord_ServiceStatus_StatusId",
                table: "ServiceRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecord_Staffs_StaffId",
                table: "ServiceRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceRecord",
                table: "ServiceRecord");

            migrationBuilder.RenameTable(
                name: "ServiceRecord",
                newName: "ServiceRecords");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecord_StatusId",
                table: "ServiceRecords",
                newName: "IX_ServiceRecords_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecord_StaffId",
                table: "ServiceRecords",
                newName: "IX_ServiceRecords_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecord_CustomerId",
                table: "ServiceRecords",
                newName: "IX_ServiceRecords_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceRecords",
                table: "ServiceRecords",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceRecordId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_ServiceRecords_ServiceRecordId",
                        column: x => x.ServiceRecordId,
                        principalTable: "ServiceRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices",
                column: "ServiceRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Customers_CustomerId",
                table: "ServiceRecords",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceStatus_StatusId",
                table: "ServiceRecords",
                column: "StatusId",
                principalTable: "ServiceStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Staffs_StaffId",
                table: "ServiceRecords",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Customers_CustomerId",
                table: "ServiceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_ServiceStatus_StatusId",
                table: "ServiceRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Staffs_StaffId",
                table: "ServiceRecords");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceRecords",
                table: "ServiceRecords");

            migrationBuilder.RenameTable(
                name: "ServiceRecords",
                newName: "ServiceRecord");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecords_StatusId",
                table: "ServiceRecord",
                newName: "IX_ServiceRecord_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecords_StaffId",
                table: "ServiceRecord",
                newName: "IX_ServiceRecord_StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiceRecords_CustomerId",
                table: "ServiceRecord",
                newName: "IX_ServiceRecord_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceRecord",
                table: "ServiceRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecord_Customers_CustomerId",
                table: "ServiceRecord",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecord_ServiceStatus_StatusId",
                table: "ServiceRecord",
                column: "StatusId",
                principalTable: "ServiceStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecord_Staffs_StaffId",
                table: "ServiceRecord",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id");
        }
    }
}
