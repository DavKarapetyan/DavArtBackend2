using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DavArt.DAL.Migrations
{
    public partial class fixParseDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParseData",
                table: "ParsedProducts",
                newName: "ParseDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParseDate",
                table: "ParsedProducts",
                newName: "ParseData");
        }
    }
}
