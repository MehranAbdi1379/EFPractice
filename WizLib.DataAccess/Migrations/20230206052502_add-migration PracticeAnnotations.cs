using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationPracticeAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categoria",
                newName: "NameOfTheColumn");

            migrationBuilder.AlterColumn<string>(
                name: "NameOfTheColumn",
                table: "Categoria",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "NameOfTheColumn",
                table: "Categories",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }
    }
}
