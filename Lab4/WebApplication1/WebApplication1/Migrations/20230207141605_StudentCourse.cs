using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class StudentCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeptCourse_Course_CoursesCrsId",
                table: "DeptCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_DeptCourse_Departments_DepartmentsDeptId",
                table: "DeptCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeptCourse",
                table: "DeptCourse");

            migrationBuilder.RenameTable(
                name: "DeptCourse",
                newName: "CourseDepartment");

            migrationBuilder.RenameIndex(
                name: "IX_DeptCourse_DepartmentsDeptId",
                table: "CourseDepartment",
                newName: "IX_CourseDepartment_DepartmentsDeptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDepartment",
                table: "CourseDepartment",
                columns: new[] { "CoursesCrsId", "DepartmentsDeptId" });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    CrsId = table.Column<int>(type: "int", nullable: false),
                    StdId = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.CrsId, x.StdId });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_CrsId",
                        column: x => x.CrsId,
                        principalTable: "Course",
                        principalColumn: "CrsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Students_StdId",
                        column: x => x.StdId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StdId",
                table: "StudentCourse",
                column: "StdId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDepartment_Course_CoursesCrsId",
                table: "CourseDepartment",
                column: "CoursesCrsId",
                principalTable: "Course",
                principalColumn: "CrsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDepartment_Departments_DepartmentsDeptId",
                table: "CourseDepartment",
                column: "DepartmentsDeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartment_Course_CoursesCrsId",
                table: "CourseDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartment_Departments_DepartmentsDeptId",
                table: "CourseDepartment");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDepartment",
                table: "CourseDepartment");

            migrationBuilder.RenameTable(
                name: "CourseDepartment",
                newName: "DeptCourse");

            migrationBuilder.RenameIndex(
                name: "IX_CourseDepartment_DepartmentsDeptId",
                table: "DeptCourse",
                newName: "IX_DeptCourse_DepartmentsDeptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeptCourse",
                table: "DeptCourse",
                columns: new[] { "CoursesCrsId", "DepartmentsDeptId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeptCourse_Course_CoursesCrsId",
                table: "DeptCourse",
                column: "CoursesCrsId",
                principalTable: "Course",
                principalColumn: "CrsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeptCourse_Departments_DepartmentsDeptId",
                table: "DeptCourse",
                column: "DepartmentsDeptId",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
