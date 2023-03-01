using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class FluentAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlights_Planes_PlaneId",
                table: "MyFlights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "MyPlane");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlane",
                newName: "PlaneCapacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlights_MyPlane_PlaneId",
                table: "MyFlights",
                column: "PlaneId",
                principalTable: "MyPlane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlights_MyPlane_PlaneId",
                table: "MyFlights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlane",
                table: "MyPlane");

            migrationBuilder.RenameTable(
                name: "MyPlane",
                newName: "Planes");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Planes",
                newName: "Capacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlights_Planes_PlaneId",
                table: "MyFlights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
