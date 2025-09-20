using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations
{
    /// <inheritdoc />
    public partial class MakeRealtionshipManyToManyBetweenStudentAndCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_StdId",
                table: "Student_Course",
                column: "StdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_Courses_CrsId",
                table: "Student_Course",
                column: "CrsId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_Students_StdId",
                table: "Student_Course",
                column: "StdId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_Courses_CrsId",
                table: "Student_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_Students_StdId",
                table: "Student_Course");

            migrationBuilder.DropIndex(
                name: "IX_Student_Course_StdId",
                table: "Student_Course");
        }
    }
}
