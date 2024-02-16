using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Nance.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Applications",
                newName: "Year_Released");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Applications",
                newName: "Primary_Director");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year_Released",
                table: "Applications",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Primary_Director",
                table: "Applications",
                newName: "Director");
        }
    }
}
