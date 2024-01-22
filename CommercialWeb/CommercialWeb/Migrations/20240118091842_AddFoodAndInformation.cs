using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommercialWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodAndInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "InStock", "Price", "ProductName" },
                values: new object[,]
                {
                    { 11, true, 7.5, "Apple Pie" },
                    { 12, true, 3.5, "Garlic" },
                    { 13, true, 5.0, "Banana" },
                    { 14, false, 10.59, "Carrot Cake" },
                    { 15, false, 11.35, "Salmon" }
                });

            migrationBuilder.InsertData(
                table: "Information",
                columns: new[] { "ProductType", "BestBefore", "FoodId", "Storage", "Usage" },
                values: new object[,]
                {
                    { "Cake", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Under 7 degree", "Directly" },
                    { "Fish", new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Under 5 degree", "Reheat and Cook" },
                    { "Fruit", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "23 degree", "Directly" },
                    { "Herb", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "23 degree", "Directly" },
                    { "Pie", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Under 7 degree", "Reheat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Information",
                keyColumn: "ProductType",
                keyValue: "Cake");

            migrationBuilder.DeleteData(
                table: "Information",
                keyColumn: "ProductType",
                keyValue: "Fish");

            migrationBuilder.DeleteData(
                table: "Information",
                keyColumn: "ProductType",
                keyValue: "Fruit");

            migrationBuilder.DeleteData(
                table: "Information",
                keyColumn: "ProductType",
                keyValue: "Herb");

            migrationBuilder.DeleteData(
                table: "Information",
                keyColumn: "ProductType",
                keyValue: "Pie");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
