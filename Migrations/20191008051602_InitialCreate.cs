using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Angular_GrahQL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Patronimic = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    AllowedSmoking = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoomId = table.Column<int>(nullable: false),
                    GuestId = table.Column<int>(nullable: false),
                    CheckinDate = table.Column<DateTime>(nullable: false),
                    CheckoutDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Name", "Patronimic", "RegisterDate", "Surname" },
                values: new object[,]
                {
                    { 1, "Владимир", null, new DateTime(2019, 9, 28, 8, 16, 2, 88, DateTimeKind.Local).AddTicks(5662), "Петров" },
                    { 2, "Александр", null, new DateTime(2019, 10, 3, 8, 16, 2, 91, DateTimeKind.Local).AddTicks(6972), "Кононов" },
                    { 3, "Дафт", null, new DateTime(2019, 10, 7, 8, 16, 2, 91, DateTimeKind.Local).AddTicks(7090), "Панков" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AllowedSmoking", "Name", "Number", "Status" },
                values: new object[,]
                {
                    { 1, false, "желтая-Комната", 101, 1 },
                    { 2, false, "синяя-Комната", 102, 1 },
                    { 3, false, "белая-Комната", 103, 0 },
                    { 4, false, "черная-Комната", 104, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckinDate", "CheckoutDate", "GuestId", "RoomId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 10, 6, 8, 16, 2, 92, DateTimeKind.Local).AddTicks(663), new DateTime(2019, 10, 11, 8, 16, 2, 92, DateTimeKind.Local).AddTicks(672), 1, 3 },
                    { 2, new DateTime(2019, 10, 7, 8, 16, 2, 92, DateTimeKind.Local).AddTicks(4082), new DateTime(2019, 10, 12, 8, 16, 2, 92, DateTimeKind.Local).AddTicks(4091), 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_GuestId",
                table: "Reservations",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId",
                table: "Reservations",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
