using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations
{
    /// <inheritdoc />
    public partial class MakeRealtionshipManyToManyBetweenInstructorAndCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Course_Instructor_Course_ID",
                table: "Course_Instructor",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_Courses_Course_ID",
                table: "Course_Instructor",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_Instructors_inst_ID",
                table: "Course_Instructor",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "Ins_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_Courses_Course_ID",
                table: "Course_Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_Instructors_inst_ID",
                table: "Course_Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Course_Instructor_Course_ID",
                table: "Course_Instructor");
        }
    }
}
