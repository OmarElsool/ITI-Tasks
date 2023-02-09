using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class DeptCoursesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CrsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CrsId);
                });

            migrationBuilder.CreateTable(
                name: "CourseDepartment",
                columns: table => new
                {
                    CoursesCrsId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsDeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDepartment", x => new { x.CoursesCrsId, x.DepartmentsDeptId });
                    table.ForeignKey(
                        name: "FK_CourseDepartment_Course_CoursesCrsId",
                        column: x => x.CoursesCrsId,
                        principalTable: "Course",
                        principalColumn: "CrsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseDepartment_Departments_DepartmentsDeptId",
                        column: x => x.DepartmentsDeptId,
                        principalTable: "Departments",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseDepartment_DepartmentsDeptId",
                table: "CourseDepartment",
                column: "DepartmentsDeptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDepartment");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
