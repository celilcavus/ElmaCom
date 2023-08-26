using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElmaCom.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SubCategoryVeBaseCategoryiIlıskilindirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_BaseCategoryId",
                table: "SubCategories",
                column: "BaseCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_BaseCategories_BaseCategoryId",
                table: "SubCategories",
                column: "BaseCategoryId",
                principalTable: "BaseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_BaseCategories_BaseCategoryId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_BaseCategoryId",
                table: "SubCategories");
        }
    }
}
