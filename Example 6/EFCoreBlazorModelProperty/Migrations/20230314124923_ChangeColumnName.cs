using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBlazorMigrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostIndex",
                table: "Address",
                newName: "postal_index");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "postal_index",
                table: "Address",
                newName: "PostIndex");
        }
    }
}
