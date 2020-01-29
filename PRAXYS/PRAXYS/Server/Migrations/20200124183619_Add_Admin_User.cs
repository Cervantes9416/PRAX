using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class Add_Admin_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2", "8dac9f7d-8102-453d-96a9-edaf0e43bbef", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4", 0, "44e651c7-92e3-4243-865b-b6a26b330f75", "ccervantes@umbrella-seguros.com", true, false, null, "ccervantes@umbrella-seguros.com", "Admin1234", "AQAAAAEAACcQAAAAEHT5wAr9mOqzrU85S07bTBWSsNyGxZx1hPLZD+LXxD5DwTkUvDrVveseu/usS8KOXw==", null, false, "509545a4-02b2-43d3-a829-de80a8ee32e6", false, "Admin1234" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4", "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4", "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4");
        }
    }
}
