using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicInstrumentsApp.WebMVC.Infrastructure.Migrations
{
    public partial class AddComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstrumentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "String" },
                    { 2, "Keyboard" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Japan", "Yamaha" },
                    { 2, "USA", "Fender" }
                });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Name", "Price", "ReleaseYear" },
                values: new object[] { 1, 1, 1, "Yamaha Acoustic Guitar", 299.99m, 2020 });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Name", "Price", "ReleaseYear" },
                values: new object[] { 2, 1, 2, "Fender Stratocaster", 699.99m, 2019 });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "Id", "CategoryId", "ManufacturerId", "Name", "Price", "ReleaseYear" },
                values: new object[] { 3, 2, 1, "Yamaha Digital Piano", 499.99m, 2021 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_InstrumentId",
                table: "Comments",
                column: "InstrumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instruments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
