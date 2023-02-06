using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorAdnPublisherTableToDbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publisher_Id",
                table: "Authors",
                newName: "Author_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author_Id",
                table: "Authors",
                newName: "Publisher_Id");
        }
    }
}
