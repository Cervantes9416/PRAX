using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class TestMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2",
                column: "ConcurrencyStamp",
                value: "d123b58f-e7e7-4c80-8574-9bcd279affbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4947f54-4b14-4513-8633-98e82b5feb0e", "AQAAAAEAACcQAAAAEBXjp9a/gZVvSArkzYjv6hf3Az1CQsRubza2b0vLxIXOnO0cCQiAPZ4f4Tl98Z/0Vw==", "712ee466-98a2-4105-b333-8231f99b8e9a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b62204f-d8ee-41cb-8ef5-0d9bd46622b2",
                column: "ConcurrencyStamp",
                value: "8dac9f7d-8102-453d-96a9-edaf0e43bbef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47a5d10c-25ba-4f8a-80d1-2e4918a20ca4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44e651c7-92e3-4243-865b-b6a26b330f75", "AQAAAAEAACcQAAAAEHT5wAr9mOqzrU85S07bTBWSsNyGxZx1hPLZD+LXxD5DwTkUvDrVveseu/usS8KOXw==", "509545a4-02b2-43d3-a829-de80a8ee32e6" });
        }
    }
}
