using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations
{
    /// <inheritdoc />
    public partial class MakeRealtionshipOnetoManyBetweenStudentAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dep_Id",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dep_Id",
                table: "Students",
                column: "Dep_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students",
                column: "Dep_Id",
                principalTable: "Departments",
                principalColumn: "Dept_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dep_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dep_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Students");
        }
    }
}
