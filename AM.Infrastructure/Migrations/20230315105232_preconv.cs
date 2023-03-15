using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class preconv : Migration
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
                    ManufactureDate = table.Column<DateTime>(type: "Date", nullable: false),
                    PlaneCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlane", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Passenger",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    FirstNamePassenger = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false, defaultValue: "FirstName"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "Date", nullable: false),
                    TelNumber = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.PassportNumber);
                });

            migrationBuilder.CreateTable(
                name: "MyFlights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    EffectiveArrival = table.Column<DateTime>(type: "Date", nullable: false),
                    Departure = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    Destination = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    PlaneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFlights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_MyFlights_MyPlane_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "MyPlane",
                        principalColumn: "PlaneId");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    Function = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    EmployementDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Staff_Passenger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber");
                });

            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    HealthInformation = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Traveller_Passenger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber");
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    FlightFk = table.Column<int>(type: "int", nullable: false),
                    PassengerFk = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    Siege = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    Vip = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.FlightFk, x.PassengerFk });
                    table.ForeignKey(
                        name: "FK_Ticket_MyFlights_FlightFk",
                        column: x => x.FlightFk,
                        principalTable: "MyFlights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passenger_PassengerFk",
                        column: x => x.PassengerFk,
                        principalTable: "Passenger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlights_PlaneId",
                table: "MyFlights",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerFk",
                table: "Ticket",
                column: "PassengerFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Traveller");

            migrationBuilder.DropTable(
                name: "MyFlights");

            migrationBuilder.DropTable(
                name: "Passenger");

            migrationBuilder.DropTable(
                name: "MyPlane");
        }
    }
}
