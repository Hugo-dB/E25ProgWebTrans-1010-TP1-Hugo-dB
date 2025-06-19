using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    /// <inheritdoc />
    public partial class ModifObjective : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 3,
                column: "LostWeightKg",
                value: 3.3999999999999999);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5,
                column: "DistanceKm",
                value: 15.699999999999999);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6,
                column: "DistanceKm",
                value: 12.5);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 9,
                column: "LostWeightKg",
                value: 10.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 3,
                column: "LostWeightKg",
                value: null);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5,
                column: "DistanceKm",
                value: null);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6,
                column: "DistanceKm",
                value: null);

            migrationBuilder.UpdateData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 9,
                column: "LostWeightKg",
                value: null);
        }
    }
}
