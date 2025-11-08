using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LisaKonveyer.Migrations
{
    /// <inheritdoc />
    public partial class new12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "StartDate",
                table: "LoanRequests",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "LoanRequests");
        }
    }
}
