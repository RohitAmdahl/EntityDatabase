using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDatabase.Migrations
{
    /// <inheritdoc />
    public partial class relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BandId",
                table: "Musicians",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstrumentId",
                table: "Musicians",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_BandId",
                table: "Musicians",
                column: "BandId");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_InstrumentId",
                table: "Musicians",
                column: "InstrumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicians_Bands_BandId",
                table: "Musicians",
                column: "BandId",
                principalTable: "Bands",
                principalColumn: "BandId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Musicians_Instruments_InstrumentId",
                table: "Musicians",
                column: "InstrumentId",
                principalTable: "Instruments",
                principalColumn: "InstrumentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicians_Bands_BandId",
                table: "Musicians");

            migrationBuilder.DropForeignKey(
                name: "FK_Musicians_Instruments_InstrumentId",
                table: "Musicians");

            migrationBuilder.DropIndex(
                name: "IX_Musicians_BandId",
                table: "Musicians");

            migrationBuilder.DropIndex(
                name: "IX_Musicians_InstrumentId",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "BandId",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "InstrumentId",
                table: "Musicians");
        }
    }
}
