using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class refactoredDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Predmeti_KodNaPredmet",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_KodNaPredmet",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "KodNaPredmet",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "BrojNaTermin",
                table: "Predmeti");

            migrationBuilder.DropColumn(
                name: "PolaganjeDo",
                table: "Predmeti");

            migrationBuilder.DropColumn(
                name: "PolaganjeOd",
                table: "Predmeti");

            migrationBuilder.DropColumn(
                name: "VremetraenjeNaTerminVoMinuti",
                table: "Predmeti");

            migrationBuilder.AddColumn<Guid>(
                name: "ispitId",
                table: "Termini",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Ispiti",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PolaganjeOd = table.Column<DateTime>(nullable: false),
                    PolaganjeDo = table.Column<DateTime>(nullable: false),
                    VremetraenjeNaTerminVoMinuti = table.Column<int>(nullable: false),
                    BrojNaTermin = table.Column<int>(nullable: false),
                    KodNaPredmet = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ispiti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ispiti_Predmeti_KodNaPredmet",
                        column: x => x.KodNaPredmet,
                        principalTable: "Predmeti",
                        principalColumn: "KodNaPredmet",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Termini_ispitId",
                table: "Termini",
                column: "ispitId");

            migrationBuilder.CreateIndex(
                name: "IX_Ispiti_KodNaPredmet",
                table: "Ispiti",
                column: "KodNaPredmet");

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Ispiti_ispitId",
                table: "Termini",
                column: "ispitId",
                principalTable: "Ispiti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Ispiti_ispitId",
                table: "Termini");

            migrationBuilder.DropTable(
                name: "Ispiti");

            migrationBuilder.DropIndex(
                name: "IX_Termini_ispitId",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "ispitId",
                table: "Termini");

            migrationBuilder.AddColumn<string>(
                name: "KodNaPredmet",
                table: "Termini",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BrojNaTermin",
                table: "Predmeti",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PolaganjeDo",
                table: "Predmeti",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PolaganjeOd",
                table: "Predmeti",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VremetraenjeNaTerminVoMinuti",
                table: "Predmeti",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Termini_KodNaPredmet",
                table: "Termini",
                column: "KodNaPredmet");

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Predmeti_KodNaPredmet",
                table: "Termini",
                column: "KodNaPredmet",
                principalTable: "Predmeti",
                principalColumn: "KodNaPredmet",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
