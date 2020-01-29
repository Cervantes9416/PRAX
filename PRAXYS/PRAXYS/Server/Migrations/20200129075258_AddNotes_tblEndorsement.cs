using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class AddNotes_tblEndorsement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Endorsement",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Endorsement");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2", "d123b58f-e7e7-4c80-8574-9bcd279affbb", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4", 0, "b4947f54-4b14-4513-8633-98e82b5feb0e", "ccervantes@umbrella-seguros.com", true, false, null, "ccervantes@umbrella-seguros.com", "Admin1234", "AQAAAAEAACcQAAAAEBXjp9a/gZVvSArkzYjv6hf3Az1CQsRubza2b0vLxIXOnO0cCQiAPZ4f4Tl98Z/0Vw==", null, false, "712ee466-98a2-4105-b333-8231f99b8e9a", false, "Admin1234" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4", "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2" });
        }
    }
}
