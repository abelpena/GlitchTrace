using Microsoft.EntityFrameworkCore.Migrations;

namespace GlitchTrace.Data.Migrations
{
    public partial class updateProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Project",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AdminId",
                column: "ConcurrencyStamp",
                value: "8be49eb0-8d02-48cd-a976-d84c3ea2e526");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Project",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AdminId",
                column: "ConcurrencyStamp",
                value: "43914383-dff4-4b21-86ac-2fbc2b63defe");
        }
    }
}
