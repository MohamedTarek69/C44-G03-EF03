using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations
{
    /// <inheritdoc />
    public partial class MakeRealtionshipOneToOneBetweenEmployeeAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "EmployeeSalary");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmployeeSalary",
                table: "Employees",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "DeptManagerId",
                schema: "Sales",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DeptManagerId",
                schema: "Sales",
                table: "Departments",
                column: "DeptManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_DeptManagerId",
                schema: "Sales",
                table: "Departments",
                column: "DeptManagerId",
                principalTable: "Employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_DeptManagerId",
                schema: "Sales",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DeptManagerId",
                schema: "Sales",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeptManagerId",
                schema: "Sales",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "EmployeeSalary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
