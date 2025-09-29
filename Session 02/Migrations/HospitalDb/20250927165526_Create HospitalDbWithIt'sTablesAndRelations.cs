using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations.HospitalDb
{
    /// <inheritdoc />
    public partial class CreateHospitalDbWithItsTablesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "DrugBrands",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugBrands", x => new { x.Code, x.Brand });
                    table.ForeignKey(
                        name: "FK_DrugBrands_Drugs_Code",
                        column: x => x.Code,
                        principalTable: "Drugs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NurseDrugPatients",
                columns: table => new
                {
                    Nur_Num = table.Column<int>(type: "int", nullable: false),
                    Drug_code = table.Column<int>(type: "int", nullable: false),
                    Pat_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseDrugPatients", x => new { x.Nur_Num, x.Drug_code, x.Pat_Id });
                    table.ForeignKey(
                        name: "FK_NurseDrugPatients_Drugs_Drug_code",
                        column: x => x.Drug_code,
                        principalTable: "Drugs",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nurse_Num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wards_Nurses_Nurse_Num",
                        column: x => x.Nurse_Num,
                        principalTable: "Nurses",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ward_Id = table.Column<int>(type: "int", nullable: false),
                    Con_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Consultants_Con_Id",
                        column: x => x.Con_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Wards_Ward_Id",
                        column: x => x.Ward_Id,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientCons",
                columns: table => new
                {
                    Con_Id = table.Column<int>(type: "int", nullable: false),
                    Pat_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCons", x => new { x.Con_Id, x.Pat_Id });
                    table.ForeignKey(
                        name: "FK_PatientCons_Consultants_Con_Id",
                        column: x => x.Con_Id,
                        principalTable: "Consultants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientCons_Patients_Pat_Id",
                        column: x => x.Pat_Id,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_NurseDrugPatients_Drug_code",
                table: "NurseDrugPatients",
                column: "Drug_code");

            migrationBuilder.CreateIndex(
                name: "IX_NurseDrugPatients_Pat_Id",
                table: "NurseDrugPatients",
                column: "Pat_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_Ward_Id",
                table: "Nurses",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PatientCons_Pat_Id",
                table: "PatientCons",
                column: "Pat_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Con_Id",
                table: "Patients",
                column: "Con_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_Ward_Id",
                table: "Patients",
                column: "Ward_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Wards_Nurse_Num",
                table: "Wards",
                column: "Nurse_Num");

            migrationBuilder.AddForeignKey(
                name: "FK_NurseDrugPatients_Nurses_Nur_Num",
                table: "NurseDrugPatients",
                column: "Nur_Num",
                principalTable: "Nurses",
                principalColumn: "Number");

            migrationBuilder.AddForeignKey(
                name: "FK_NurseDrugPatients_Patients_Pat_Id",
                table: "NurseDrugPatients",
                column: "Pat_Id",
                principalTable: "Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Wards_Ward_Id",
                table: "Nurses",
                column: "Ward_Id",
                principalTable: "Wards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Nurses_Nurse_Num",
                table: "Wards");

            migrationBuilder.DropTable(
                name: "DrugBrands");

            migrationBuilder.DropTable(
                name: "NurseDrugPatients");

            migrationBuilder.DropTable(
                name: "PatientCons");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Consultants");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "Wards");
        }
    }
}
