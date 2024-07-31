using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookQuotesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Text" },
                values: new object[,]
                {
                    { 1, "Franklin D. Roosevelt", "The only limit to our realization of tomorrow is our doubts of today." },
                    { 2, "Martin Luther King Jr.", "In the end, we will remember not the words of our enemies, but the silence of our friends." },
                    { 3, "Alan Kay", "The best way to predict the future is to invent it." },
                    { 4, "Charles R. Swindoll", "Life is 10% what happens to us and 90% how we react to it." },
                    { 5, "Steve Jobs", "The only way to do great work is to love what you do." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
