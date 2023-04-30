using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice.Data.Migrations
{
    public partial class Initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LessonName = table.Column<string>(type: "TEXT", nullable: false),
                    IsActice = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    SchoolNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActice = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonStudent",
                columns: table => new
                {
                    LessonsId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonStudent", x => new { x.LessonsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_LessonStudent_Lessons_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "IsActice", "LessonName" },
                values: new object[] { 1, true, "Matematik" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "IsActice", "LessonName" },
                values: new object[] { 2, true, "Turkce" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "IsActice", "LessonName" },
                values: new object[] { 3, true, "Fizik" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "IsActice", "LessonName" },
                values: new object[] { 4, true, "Kimya" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "IsActice", "LastName", "SchoolNumber" },
                values: new object[] { 1, "Abc", true, "Kartal", 297 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "IsActice", "LastName", "SchoolNumber" },
                values: new object[] { 2, "Def", true, "Koc", 704 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "IsActice", "LastName", "SchoolNumber" },
                values: new object[] { 3, "Ghi", true, "Aslan", 514 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "IsActice", "LastName", "SchoolNumber" },
                values: new object[] { 4, "Ijk", true, "Kaplan", 115 });

            migrationBuilder.CreateIndex(
                name: "IX_LessonStudent_StudentsId",
                table: "LessonStudent",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonStudent");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
