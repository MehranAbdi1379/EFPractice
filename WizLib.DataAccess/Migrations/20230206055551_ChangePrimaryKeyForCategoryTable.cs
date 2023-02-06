using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangePrimaryKeyForCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categoria_CategoryId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categoria",
                newName: "Category_Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Books",
                newName: "Category_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                newName: "IX_Books_Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categoria_Category_Id",
                table: "Books",
                column: "Category_Id",
                principalTable: "Categoria",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categoria_Category_Id",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "Categoria",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Category_Id",
                table: "Books",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_Category_Id",
                table: "Books",
                newName: "IX_Books_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categoria_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
