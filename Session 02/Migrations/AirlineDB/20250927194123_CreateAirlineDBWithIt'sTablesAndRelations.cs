using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations.AirlineDB
{
    /// <inheritdoc />
    public partial class CreateAirlineDBWithItsTablesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cont_person = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maj_pilot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assistant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AL_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aircrafts_Airlines_AL_Id",
                        column: x => x.AL_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AirlinePhones",
                columns: table => new
                {
                    Phone = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AL_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlinePhones", x => new { x.AL_Id, x.Phone });
                    table.ForeignKey(
                        name: "FK_AirlinePhones_Airlines_AL_Id",
                        column: x => x.AL_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BD_Year = table.Column<int>(type: "int", nullable: false),
                    BD_Month = table.Column<int>(type: "int", nullable: false),
                    BD_Day = table.Column<int>(type: "int", nullable: false),
                    AL_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Airlines_AL_Id",
                        column: x => x.AL_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amout = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AL_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Airlines_AL_Id",
                        column: x => x.AL_Id,
                        principalTable: "Airlines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AircraftRoutes",
                columns: table => new
                {
                    AC_Id = table.Column<int>(type: "int", nullable: false),
                    Route_Id = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Num_Of_Pass = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftRoutes", x => new { x.AC_Id, x.Route_Id });
                    table.ForeignKey(
                        name: "FK_AircraftRoutes_Aircrafts_AC_Id",
                        column: x => x.AC_Id,
                        principalTable: "Aircrafts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AircraftRoutes_Routes_Route_Id",
                        column: x => x.Route_Id,
                        principalTable: "Routes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmpQualifications",
                columns: table => new
                {
                    Qualification = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpQualifications", x => new { x.Emp_Id, x.Qualification });
                    table.ForeignKey(
                        name: "FK_EmpQualifications_Employees_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AircraftRoutes_Route_Id",
                table: "AircraftRoutes",
                column: "Route_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AL_Id",
                table: "Aircrafts",
                column: "AL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AL_Id",
                table: "Employees",
                column: "AL_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AL_Id",
                table: "Transactions",
                column: "AL_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftRoutes");

            migrationBuilder.DropTable(
                name: "AirlinePhones");

            migrationBuilder.DropTable(
                name: "EmpQualifications");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Airlines");
        }
    }
}
