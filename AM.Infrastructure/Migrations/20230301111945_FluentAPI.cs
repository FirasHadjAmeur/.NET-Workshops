using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class FluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlights_MyPlane_PlaneId",
                table: "MyFlights");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "MyFlights",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlights_MyPlane_PlaneId",
                table: "MyFlights",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlights_MyPlane_PlaneId",
                table: "MyFlights");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "MyFlights",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlights_MyPlane_PlaneId",
                table: "MyFlights",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
