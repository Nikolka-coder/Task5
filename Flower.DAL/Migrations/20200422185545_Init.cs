using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flower.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plantations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantationId = table.Column<int>(nullable: false),
                    WarehouseId = table.Column<int>(nullable: false),
                    SheduledDate = table.Column<DateTime>(nullable: false),
                    ClosedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Id);
                    table.CheckConstraint("CK_Supplies_Status_Enum_Constraint", "[Status] IN(0, 1, 2, 3)");
                });

            migrationBuilder.CreateTable(
                name: "TheFlowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheFlowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantationFlowers",
                columns: table => new
                {
                    FlowerId = table.Column<int>(nullable: false),
                    PlantationId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 21, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantationFlowers", x => new { x.FlowerId, x.PlantationId });
                    table.ForeignKey(
                        name: "FK_PlantationFlowers_TheFlowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "TheFlowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantationFlowers_Plantations_PlantationId",
                        column: x => x.PlantationId,
                        principalTable: "Plantations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyFlowers",
                columns: table => new
                {
                    FlowerId = table.Column<int>(nullable: false),
                    SupplyId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 21, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyFlowers", x => new { x.FlowerId, x.SupplyId });
                    table.ForeignKey(
                        name: "FK_SupplyFlowers_TheFlowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "TheFlowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyFlowers_Supplies_SupplyId",
                        column: x => x.SupplyId,
                        principalTable: "Supplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseFlowers",
                columns: table => new
                {
                    FlowerId = table.Column<int>(nullable: false),
                    WarehouseId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 21, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseFlowers", x => new { x.FlowerId, x.WarehouseId });
                    table.ForeignKey(
                        name: "FK_WarehouseFlowers_TheFlowers_FlowerId",
                        column: x => x.FlowerId,
                        principalTable: "TheFlowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseFlowers_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantationFlowers_PlantationId",
                table: "PlantationFlowers",
                column: "PlantationId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyFlowers_SupplyId",
                table: "SupplyFlowers",
                column: "SupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseFlowers_WarehouseId",
                table: "WarehouseFlowers",
                column: "WarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantationFlowers");

            migrationBuilder.DropTable(
                name: "SupplyFlowers");

            migrationBuilder.DropTable(
                name: "WarehouseFlowers");

            migrationBuilder.DropTable(
                name: "Plantations");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "TheFlowers");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
