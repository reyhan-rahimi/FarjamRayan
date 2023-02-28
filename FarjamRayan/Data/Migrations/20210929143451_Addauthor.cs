using Microsoft.EntityFrameworkCore.Migrations;

namespace FarjamRayan.Data.Migrations
{
    public partial class Addauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "StateSites",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "StateSites");
        }
    }
}
