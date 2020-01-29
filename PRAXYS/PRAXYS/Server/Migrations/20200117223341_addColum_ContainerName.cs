using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class addColum_ContainerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bond_Agent_AgentID",
                table: "Bond");

            migrationBuilder.DropForeignKey(
                name: "FK_Bond_Clients_ClientsID",
                table: "Bond");

            migrationBuilder.DropIndex(
                name: "IX_Bond_ClientsID",
                table: "Bond");

            migrationBuilder.DropColumn(
                name: "ClientsID",
                table: "Bond");

            migrationBuilder.AddColumn<string>(
                name: "containerName",
                table: "InsuranceDocumentation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "containerName",
                table: "ClientDocumentation",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgentID",
                table: "Bond",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommissionPayments_BondPaymentID",
                table: "CommissionPayments",
                column: "BondPaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_BondPayments_BondID",
                table: "BondPayments",
                column: "BondID");

            migrationBuilder.CreateIndex(
                name: "IX_Bond_ClientID",
                table: "Bond",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bond_Agent_AgentID",
                table: "Bond",
                column: "AgentID",
                principalTable: "Agent",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bond_Clients_ClientID",
                table: "Bond",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BondPayments_Bond_BondID",
                table: "BondPayments",
                column: "BondID",
                principalTable: "Bond",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommissionPayments_BondPayments_BondPaymentID",
                table: "CommissionPayments",
                column: "BondPaymentID",
                principalTable: "BondPayments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bond_Agent_AgentID",
                table: "Bond");

            migrationBuilder.DropForeignKey(
                name: "FK_Bond_Clients_ClientID",
                table: "Bond");

            migrationBuilder.DropForeignKey(
                name: "FK_BondPayments_Bond_BondID",
                table: "BondPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_CommissionPayments_BondPayments_BondPaymentID",
                table: "CommissionPayments");

            migrationBuilder.DropIndex(
                name: "IX_CommissionPayments_BondPaymentID",
                table: "CommissionPayments");

            migrationBuilder.DropIndex(
                name: "IX_BondPayments_BondID",
                table: "BondPayments");

            migrationBuilder.DropIndex(
                name: "IX_Bond_ClientID",
                table: "Bond");

            migrationBuilder.DropColumn(
                name: "containerName",
                table: "InsuranceDocumentation");

            migrationBuilder.DropColumn(
                name: "containerName",
                table: "ClientDocumentation");

            migrationBuilder.AlterColumn<int>(
                name: "AgentID",
                table: "Bond",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ClientsID",
                table: "Bond",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bond_ClientsID",
                table: "Bond",
                column: "ClientsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bond_Agent_AgentID",
                table: "Bond",
                column: "AgentID",
                principalTable: "Agent",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bond_Clients_ClientsID",
                table: "Bond",
                column: "ClientsID",
                principalTable: "Clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
