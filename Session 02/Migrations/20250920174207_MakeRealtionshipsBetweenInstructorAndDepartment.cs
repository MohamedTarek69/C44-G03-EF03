using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations
{
    /// <inheritdoc />
    public partial class MakeRealtionshipsBetweenInstructorAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dept_ID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorDepartmentDept_Id",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ins_ID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_InstructorDepartmentDept_Id",
                table: "Instructors",
                column: "InstructorDepartmentDept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                unique: true,
                filter: "[Ins_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_InstructorDepartmentDept_Id",
                table: "Instructors",
                column: "InstructorDepartmentDept_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_InstructorDepartmentDept_Id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_InstructorDepartmentDept_Id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Dept_ID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "InstructorDepartmentDept_Id",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Ins_ID",
                table: "Departments");
        }
    }
}
