using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class Add_optionalAgent_colums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Agent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "Agent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clabe",
                table: "Agent",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "Clabe",
                table: "Agent");
        }
    }
}
