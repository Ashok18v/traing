using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Data.Migrations
{
    public partial class migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmpEducation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassingYear = table.Column<int>(type: "int", nullable: false),
                    MarksPercentage = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpEducation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EmpEducation_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(50)", nullable: true),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Class_teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherID",
                table: "Class",
                column: "TeacherID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmpEducation_EmployeeID",
                table: "EmpEducation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_Name",
                table: "teachers",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "EmpEducation");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
