using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMaar.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spaceships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerCount = table.Column<int>(type: "int", nullable: false),
                    CrewCount = table.Column<int>(type: "int", nullable: false),
                    CargoWeight = table.Column<int>(type: "int", nullable: false),
                    MaxSpeedInVacuum = table.Column<int>(type: "int", nullable: false),
                    BuiltAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaidenLaunch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSpaceShipPreviouslyOwned = table.Column<bool>(type: "bit", nullable: false),
                    FullTripsCount = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    FuelConsumptionPerDay = table.Column<int>(type: "int", nullable: false),
                    MaintenanceCount = table.Column<int>(type: "int", nullable: false),
                    LastMaintenance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaceships", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spaceships");
        }
    }
}
