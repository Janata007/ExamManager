using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class consistency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nasoka",
                table: "Studenti");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nasoka",
                table: "Studenti",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
