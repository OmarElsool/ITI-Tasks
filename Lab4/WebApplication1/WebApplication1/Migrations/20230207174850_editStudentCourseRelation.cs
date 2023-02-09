using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class editStudentCourseRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_StdId",
                table: "StudentCourse");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StdId",
                table: "StudentCourse",
                column: "StdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_StdId",
                table: "StudentCourse");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StdId",
                table: "StudentCourse",
                column: "StdId",
                unique: true);
        }
    }
}
