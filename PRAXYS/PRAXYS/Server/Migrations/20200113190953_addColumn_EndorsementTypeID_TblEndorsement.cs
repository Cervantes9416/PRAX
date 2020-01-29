using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class addColumn_EndorsementTypeID_TblEndorsement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endorsement_EndorsementType_EndorsementTypeID",
                table: "Endorsement");

            migrationBuilder.DropColumn(
                name: "EndosementTypeID",
                table: "Endorsement");

            migrationBuilder.DropColumn(
                name: "Account",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Agent");

            migrationBuilder.DropColumn(
                name: "Clabe",
                table: "Agent");

            migrationBuilder.AlterColumn<int>(
                name: "EndorsementTypeID",
                table: "Endorsement",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endorsement_EndorsementType_EndorsementTypeID",
                table: "Endorsement",
                column: "EndorsementTypeID",
                principalTable: "EndorsementType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endorsement_EndorsementType_EndorsementTypeID",
                table: "Endorsement");

            migrationBuilder.AlterColumn<int>(
                name: "EndorsementTypeID",
                table: "Endorsement",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EndosementTypeID",
                table: "Endorsement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Agent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "Agent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clabe",
                table: "Agent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endorsement_EndorsementType_EndorsementTypeID",
                table: "Endorsement",
                column: "EndorsementTypeID",
                principalTable: "EndorsementType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
