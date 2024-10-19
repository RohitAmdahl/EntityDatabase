using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityDatabase.Migrations
{
    /// <inheritdoc />
    public partial class seed_correct_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "BandId", "Country", "FirstName" },
                values: new object[,]
                {
                    { 1, "India", "Coke Studio 5" },
                    { 2, "Latin America", "Veps spiders" },
                    { 3, "Norway", "Ola Nordman band" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Description", "InstrumentName" },
                values: new object[,]
                {
                    { 1, "Black color piano", "Piano" },
                    { 2, "Indian traditional sitar", "Sitar" },
                    { 3, "Electric gitar", "Gitar" }
                });

            migrationBuilder.InsertData(
                table: "Musicians",
                columns: new[] { "MusicianId", "BandId", "FirstName", "InstrumentId", "LastName", "Origin" },
                values: new object[,]
                {
                    { 1, 1, "Raju", 2, "Kumar", "Indian musician" },
                    { 2, 2, "Vinod", 3, "Srivastav", "American indian musician" },
                    { 3, 2, "Ram", 1, "Gopal", "British Indian musician" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musicians",
                keyColumn: "MusicianId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "BandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "InstrumentId",
                keyValue: 3);
        }
    }
}
