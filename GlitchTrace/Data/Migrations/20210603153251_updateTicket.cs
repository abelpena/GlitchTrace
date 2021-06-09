using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlitchTrace.Data.Migrations
{
    public partial class updateTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Tickets",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AdminId",
                column: "ConcurrencyStamp",
                value: "43914383-dff4-4b21-86ac-2fbc2b63defe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AdminId",
                column: "ConcurrencyStamp",
                value: "53b38762-8e81-48e0-8e95-beb4fccb31c8");
        }
    }
}
