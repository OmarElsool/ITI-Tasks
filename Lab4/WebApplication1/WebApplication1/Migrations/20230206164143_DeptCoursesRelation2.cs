using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class DeptCoursesRelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartment_Course_CoursesCrsId",
                table: "CourseDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseDepartment_Departments_DepartmentsDeptId",
                table: "CourseDepartment");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
