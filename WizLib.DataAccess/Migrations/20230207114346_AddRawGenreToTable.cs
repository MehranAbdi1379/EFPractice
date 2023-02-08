using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRawGenreToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into tbl_genres values ('Gen 1')");
            migrationBuilder.Sql("insert into tbl_genres values ('Gen 2')");
            migrationBuilder.Sql("insert into tbl_genres values ('Gen 3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
