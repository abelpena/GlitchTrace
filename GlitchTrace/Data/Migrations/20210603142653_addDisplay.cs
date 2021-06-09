using Microsoft.EntityFrameworkCore.Migrations;

namespace GlitchTrace.Data.Migrations
{
    public partial class addDisplay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "AdminId", "fdba4692-42f6-4c11-a2dc-b32944602f1a", "Administrator", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d3f1708f-93a9-4c1c-8b79-49febc0c152d", "AdminId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d3f1708f-93a9-4c1c-8b79-49febc0c152d", "AdminId" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AdminId");
        }
    }
}
