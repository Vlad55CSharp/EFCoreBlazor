using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBlazorMigrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDisplayName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserData",
                newName: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "UserData",
                newName: "Name");
        }
    }
}
