using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JuliePro.Migrations
{
    /// <inheritdoc />
    public partial class AjoutSeedCustomerEtObjective : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Objective_Customer_CustomerId",
                table: "Objective");

            migrationBuilder.DropTable(
                name: "CustomerTrainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Objective",
                table: "Objective");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Objective",
                newName: "Objectives");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Objective_CustomerId",
                table: "Objectives",
                newName: "IX_Objectives_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "StartWeight", "TrainerId" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ThoBerger@gmail.com", "Thomas", "Bergeron", 205.0, 1 },
                    { 2, new DateTime(1978, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AlexCool@gmail.com", "Alexis", "Plante", 228.0, 1 },
                    { 3, new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "BouLe@gmail.com", "Léa", "Boucher", 192.0, 1 },
                    { 4, new DateTime(1980, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "LECourtier@gmail.com", "Mathis", "Courtier", 199.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "AchievedDate", "CustomerId", "DistanceKm", "LostWeightKg", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 42.200000000000003, null, "Marathon" },
                    { 2, new DateTime(2018, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 10.0, "AllerAuGym" },
                    { 3, null, 1, null, null, "ExerciceQuot" },
                    { 4, new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 21.100000000000001, null, "DemiMarathon" },
                    { 5, null, 2, null, null, "GlowUp" },
                    { 6, null, 2, null, null, "PrepCourse" },
                    { 7, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 45.0, null, "Triathlon" },
                    { 8, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 2.0, "BodyBuilding" },
                    { 9, null, 4, null, null, "SummerBody" },
                    { 10, new DateTime(2012, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2.0, null, "NatationRapide" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TrainerId",
                table: "Customers",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Trainers_TrainerId",
                table: "Customers",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Objectives_Customers_CustomerId",
                table: "Objectives",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Trainers_TrainerId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Objectives_Customers_CustomerId",
                table: "Objectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TrainerId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Objectives",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Objectives",
                newName: "Objective");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Objectives_CustomerId",
                table: "Objective",
                newName: "IX_Objective_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objective",
                table: "Objective",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CustomerTrainer",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    TrainersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTrainer", x => new { x.CustomersId, x.TrainersId });
                    table.ForeignKey(
                        name: "FK_CustomerTrainer_Customer_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerTrainer_Trainers_TrainersId",
                        column: x => x.TrainersId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTrainer_TrainersId",
                table: "CustomerTrainer",
                column: "TrainersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Objective_Customer_CustomerId",
                table: "Objective",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
