using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Core_Project.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Std_Class = table.Column<int>(type: "int", nullable: false),
                    Std_Roll = table.Column<int>(type: "int", nullable: false),
                    Std_School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Std_Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
