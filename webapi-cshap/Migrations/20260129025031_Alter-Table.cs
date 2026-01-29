using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi_cshap.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universe",
                table: "Universe");

            migrationBuilder.RenameTable(
                name: "Universe",
                newName: "Characters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "Universe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universe",
                table: "Universe",
                column: "Id");
        }
    }
}
