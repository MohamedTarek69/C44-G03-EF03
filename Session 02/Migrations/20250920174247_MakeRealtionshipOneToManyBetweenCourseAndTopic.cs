using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_02.Migrations
{
    /// <inheritdoc />
    public partial class MakeRealtionshipOneToManyBetweenCourseAndTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                table: "Courses");
        }
    }
}
