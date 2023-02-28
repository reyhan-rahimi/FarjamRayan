using Microsoft.EntityFrameworkCore.Migrations;

namespace FarjamRayan.Data.Migrations
{
    public partial class blogssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StateSites",
                table: "StateSites");

            migrationBuilder.RenameTable(
                name: "StateSites",
                newName: "Blogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "StateSites");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateSites",
                table: "StateSites",
                column: "Id");
        }
    }
}
