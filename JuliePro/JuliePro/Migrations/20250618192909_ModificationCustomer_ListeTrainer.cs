using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    /// <inheritdoc />
    public partial class ModificationCustomer_ListeTrainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Trainers_TrainerId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_TrainerId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Customer");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTrainer");

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_TrainerId",
                table: "Customer",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Trainers_TrainerId",
                table: "Customer",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
