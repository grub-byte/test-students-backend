using Microsoft.EntityFrameworkCore.Migrations;

namespace VelvetechUniversity.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(maxLength: 40, nullable: false),
                    FirstName = table.Column<string>(maxLength: 40, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 60, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Nickname = table.Column<string>(maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Nickname",
                table: "Student",
                column: "Nickname",
                unique: true,
                filter: "[Nickname] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
