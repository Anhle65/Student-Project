using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommercialWeb.Migrations
{
    /// <inheritdoc />
    public partial class BookData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("INSERT INTO Books ('Title', 'Price') VALUES ('Harry Porter', '10.5')");
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "Price" },
                values: new object[,]
                {
                    { 1, "Harry Porter", 19.5d },
                    { 2, "Scarlet", 8.65d },
                    { 3, "Snow White", 12d }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
