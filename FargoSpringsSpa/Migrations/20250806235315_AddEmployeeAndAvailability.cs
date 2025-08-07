using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FargoSpringsSpa.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeAndAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeAvailability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    Sunday = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAvailability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeAvailability_AvailabilityId",
                        column: x => x.AvailabilityId,
                        principalTable: "EmployeeAvailability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_EmployeeId",
                table: "Booking",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AvailabilityId",
                table: "Employee",
                column: "AvailabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Employee_EmployeeId",
                table: "Booking",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Employee_EmployeeId",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeAvailability");

            migrationBuilder.DropIndex(
                name: "IX_Booking_EmployeeId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Booking");
        }
    }
}
