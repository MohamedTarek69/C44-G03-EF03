using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations.SalesDb
{
    /// <inheritdoc />
    public partial class CreateSalesDBWithItsTablesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Off_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOffices",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOffices", x => x.Number);
                    table.ForeignKey(
                        name: "FK_SalesOffices_Employees_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Off_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_SalesOffices_Off_Number",
                        column: x => x.Off_Number,
                        principalTable: "SalesOffices",
                        principalColumn: "Number");
                });

            migrationBuilder.CreateTable(
                name: "PropOwners",
                columns: table => new
                {
                    Own_Id = table.Column<int>(type: "int", nullable: false),
                    Prop_Id = table.Column<int>(type: "int", nullable: false),
                    Precent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropOwners", x => new { x.Own_Id, x.Prop_Id });
                    table.ForeignKey(
                        name: "FK_PropOwners_Owners_Own_Id",
                        column: x => x.Own_Id,
                        principalTable: "Owners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PropOwners_Properties_Prop_Id",
                        column: x => x.Prop_Id,
                        principalTable: "Properties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Off_Number",
                table: "Employees",
                column: "Off_Number");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_Off_Number",
                table: "Properties",
                column: "Off_Number");

            migrationBuilder.CreateIndex(
                name: "IX_PropOwners_Prop_Id",
                table: "PropOwners",
                column: "Prop_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOffices_Emp_Id",
                table: "SalesOffices",
                column: "Emp_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SalesOffices_Off_Number",
                table: "Employees",
                column: "Off_Number",
                principalTable: "SalesOffices",
                principalColumn: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SalesOffices_Off_Number",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "PropOwners");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "SalesOffices");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
