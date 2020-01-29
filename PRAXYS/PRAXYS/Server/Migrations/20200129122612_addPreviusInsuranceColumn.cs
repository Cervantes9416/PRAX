using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class addPreviusInsuranceColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreviousInsurance",
                table: "Insurance",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RenewedInsurance",
                table: "Insurance",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreviousInsurance",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "RenewedInsurance",
                table: "Insurance");
        }
    }
}
