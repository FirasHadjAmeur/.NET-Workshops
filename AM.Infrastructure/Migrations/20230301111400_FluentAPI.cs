using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class FluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyPlane",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneType = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaneCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlane", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FirstNamePassenger = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false, defaultValue: "FirstName"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelNumber = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassportNumber);
                });

            migrationBuilder.CreateTable(
                name: "MyFlights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineLogo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    EffectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFlights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_MyFlights_MyPlane_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "MyPlane",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassengerReservation",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    PassengersPassportNumber = table.Column<string>(type: "nvarchar(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerReservation", x => new { x.FlightsFlightId, x.PassengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_PassengerReservation_MyFlights_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "MyFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerReservation_Passengers_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlights_PlaneId",
                table: "MyFlights",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerReservation_PassengersPassportNumber",
                table: "PassengerReservation",
                column: "PassengersPassportNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PassengerReservation");

            migrationBuilder.DropTable(
                name: "MyFlights");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "MyPlane");
        }
    }
}
