using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Nance.Migrations
{
    /// <inheritdoc />
    public partial class Initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Applications",
                newName: "Main_Category");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Main_Category",
                table: "Applications",
                newName: "Category");
        }
    }
}
