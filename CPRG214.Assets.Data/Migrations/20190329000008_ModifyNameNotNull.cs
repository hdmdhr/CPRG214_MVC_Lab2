using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRG214.Assets.Data.Migrations
{
    public partial class ModifyNameNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AssetTypes",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
