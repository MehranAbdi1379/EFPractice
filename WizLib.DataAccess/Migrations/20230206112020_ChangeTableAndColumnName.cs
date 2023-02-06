using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableAndColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");


            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "tbl_genres");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "tbl_genres",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_genres",
                table: "tbl_genres",
                column: "GenreId");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_genres",
                table: "tbl_genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Books",
                table: "Fluent_Books");

            migrationBuilder.RenameTable(
                name: "tbl_genres",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "Fluent_Books",
                newName: "Bookings");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Book_Id");
        }
    }
}
