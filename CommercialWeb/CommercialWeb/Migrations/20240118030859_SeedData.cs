using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommercialWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories VALUES (4,'Gardening Tools')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES (5,'Utensils')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
