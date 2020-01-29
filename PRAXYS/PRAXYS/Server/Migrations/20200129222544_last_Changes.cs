using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class last_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Insurance_AddressID",
                table: "Insurance",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Adress_AddressID",
                table: "Insurance",
                column: "AddressID",
                principalTable: "Adress",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Adress_AddressID",
                table: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Insurance_AddressID",
                table: "Insurance");
        }
    }
}
