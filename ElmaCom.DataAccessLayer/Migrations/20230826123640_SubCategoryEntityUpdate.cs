using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElmaCom.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SubCategoryEntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "SubCategories",
                newName: "BaseCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseCategoryId",
                table: "SubCategories",
                newName: "SubCategoryId");
        }
    }
}
