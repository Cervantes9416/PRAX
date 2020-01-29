using Microsoft.EntityFrameworkCore.Migrations;

namespace PRAXYS.Server.Migrations
{
    public partial class changeStringToInt_ColumEndorsementNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EndorsementNumber",
                table: "Insurance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EndorsementNumber",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
