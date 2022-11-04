using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DavArt.DAL.Migrations
{
    public partial class addSourceCategoryToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceCategory_Sources_SourceId",
                table: "SourceCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceCategory",
                table: "SourceCategory");

            migrationBuilder.RenameTable(
                name: "SourceCategory",
                newName: "SourceCategories");

            migrationBuilder.RenameIndex(
                name: "IX_SourceCategory_SourceId",
                table: "SourceCategories",
                newName: "IX_SourceCategories_SourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceCategories",
                table: "SourceCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceCategories_Sources_SourceId",
                table: "SourceCategories",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceCategories_Sources_SourceId",
                table: "SourceCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceCategories",
                table: "SourceCategories");

            migrationBuilder.RenameTable(
                name: "SourceCategories",
                newName: "SourceCategory");

            migrationBuilder.RenameIndex(
                name: "IX_SourceCategories_SourceId",
                table: "SourceCategory",
                newName: "IX_SourceCategory_SourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceCategory",
                table: "SourceCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceCategory_Sources_SourceId",
                table: "SourceCategory",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
