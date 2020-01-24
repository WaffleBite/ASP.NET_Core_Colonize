using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colonize.Website.Data.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage");

            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage");

            migrationBuilder.AlterColumn<int>(
                name: "ShipId",
                table: "Voyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Voyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "slrgk", "https://via.placeholder.com/480x360.png?text=Moon", "Moon" },
                    { 2, "qp3r", "https://via.placeholder.com/480x360.png?text=Mars", "Mars" }
                });

            migrationBuilder.InsertData(
                table: "Ship",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PassengerCapacity" },
                values: new object[,]
                {
                    { 1, "jsdf", "https://via.placeholder.com/480x360.png?text=Moonshot", "Moonshot", 200 },
                    { 2, "kjgns", "https://via.placeholder.com/480x360.png?text=Mars+Explorer", "Mars Explorer", 1800 }
                });

            migrationBuilder.InsertData(
                table: "Voyage",
                columns: new[] { "Id", "ArrivalAt", "DepartureAt", "DestinationId", "ShipId" },
                values: new object[] { 1, new DateTime(2022, 11, 10, 13, 36, 6, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Voyage",
                columns: new[] { "Id", "ArrivalAt", "DepartureAt", "DestinationId", "ShipId" },
                values: new object[] { 2, new DateTime(2026, 3, 30, 0, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 3, 20, 20, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage",
                column: "ShipId",
                principalTable: "Ship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage");

            migrationBuilder.DropForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage");

            migrationBuilder.DeleteData(
                table: "Voyage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voyage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ship",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "ShipId",
                table: "Voyage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "Voyage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Destination_DestinationId",
                table: "Voyage",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voyage_Ship_ShipId",
                table: "Voyage",
                column: "ShipId",
                principalTable: "Ship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
