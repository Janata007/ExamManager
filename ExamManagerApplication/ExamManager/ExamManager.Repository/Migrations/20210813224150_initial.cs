using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Prostorii",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Kapacitet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prostorii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sproveduvaci",
                columns: table => new
                {
                    SproveduvacId = table.Column<string>(nullable: false),
                    ImePrezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sproveduvaci", x => x.SproveduvacId);
                });

            migrationBuilder.CreateTable(
                name: "StudickiCiklusi",
                columns: table => new
                {
                    CiklusNaStudii = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudickiCiklusi", x => x.CiklusNaStudii);
                });

            migrationBuilder.CreateTable(
                name: "StudiskiProgrami",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ImeNaStudiskaPrograma = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiskiProgrami", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Predmeti",
                columns: table => new
                {
                    PredmetId = table.Column<string>(nullable: false),
                    Semestar = table.Column<int>(nullable: false),
                    PolaganjeOd = table.Column<DateTime>(nullable: false),
                    PolaganjeDo = table.Column<DateTime>(nullable: false),
                    VremetraenjeNaTerminVoMinuti = table.Column<int>(nullable: false),
                    BrojNaTermin = table.Column<int>(nullable: false),
                    StudiskiCiklusId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmeti", x => x.PredmetId);
                    table.ForeignKey(
                        name: "FK_Predmeti_StudickiCiklusi_StudiskiCiklusId",
                        column: x => x.StudiskiCiklusId,
                        principalTable: "StudickiCiklusi",
                        principalColumn: "CiklusNaStudii",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PredmetiOdStudiskaPrograma",
                columns: table => new
                {
                    PredmetId = table.Column<string>(nullable: false),
                    StudiskaProgramaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredmetiOdStudiskaPrograma", x => new { x.PredmetId, x.StudiskaProgramaId });
                    table.ForeignKey(
                        name: "FK_PredmetiOdStudiskaPrograma_Predmeti_PredmetId",
                        column: x => x.PredmetId,
                        principalTable: "Predmeti",
                        principalColumn: "PredmetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PredmetiOdStudiskaPrograma_StudiskiProgrami_StudiskaProgramaId",
                        column: x => x.StudiskaProgramaId,
                        principalTable: "StudiskiProgrami",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Termini",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    VremeNaZapocnuvanje = table.Column<DateTime>(nullable: false),
                    VremeNaZavrshuvanje = table.Column<DateTime>(nullable: false),
                    PredmetId = table.Column<string>(nullable: true),
                    SproveduvacId = table.Column<string>(nullable: true),
                    ProstorijaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termini", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Termini_Predmeti_PredmetId",
                        column: x => x.PredmetId,
                        principalTable: "Predmeti",
                        principalColumn: "PredmetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Termini_Prostorii_ProstorijaId",
                        column: x => x.ProstorijaId,
                        principalTable: "Prostorii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Termini_Sproveduvaci_SproveduvacId",
                        column: x => x.SproveduvacId,
                        principalTable: "Sproveduvaci",
                        principalColumn: "SproveduvacId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    BrojNaIndeks = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(nullable: true),
                    Nasoka = table.Column<string>(nullable: true),
                    TerminId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.BrojNaIndeks);
                    table.ForeignKey(
                        name: "FK_Studenti_Termini_TerminId",
                        column: x => x.TerminId,
                        principalTable: "Termini",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentiPolagaatPredmeti",
                columns: table => new
                {
                    BrojNaIndeks = table.Column<int>(nullable: false),
                    PredmetId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentiPolagaatPredmeti", x => new { x.BrojNaIndeks, x.PredmetId });
                    table.ForeignKey(
                        name: "FK_StudentiPolagaatPredmeti_Studenti_BrojNaIndeks",
                        column: x => x.BrojNaIndeks,
                        principalTable: "Studenti",
                        principalColumn: "BrojNaIndeks",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentiPolagaatPredmeti_Predmeti_PredmetId",
                        column: x => x.PredmetId,
                        principalTable: "Predmeti",
                        principalColumn: "PredmetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Predmeti_StudiskiCiklusId",
                table: "Predmeti",
                column: "StudiskiCiklusId");

            migrationBuilder.CreateIndex(
                name: "IX_PredmetiOdStudiskaPrograma_StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma",
                column: "StudiskaProgramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_TerminId",
                table: "Studenti",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentiPolagaatPredmeti_PredmetId",
                table: "StudentiPolagaatPredmeti",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_PredmetId",
                table: "Termini",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_ProstorijaId",
                table: "Termini",
                column: "ProstorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_SproveduvacId",
                table: "Termini",
                column: "SproveduvacId",
                unique: true,
                filter: "[SproveduvacId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropTable(
                name: "StudentiPolagaatPredmeti");

            migrationBuilder.DropTable(
                name: "StudiskiProgrami");

            migrationBuilder.DropTable(
                name: "Studenti");

            migrationBuilder.DropTable(
                name: "Termini");

            migrationBuilder.DropTable(
                name: "Predmeti");

            migrationBuilder.DropTable(
                name: "Prostorii");

            migrationBuilder.DropTable(
                name: "Sproveduvaci");

            migrationBuilder.DropTable(
                name: "StudickiCiklusi");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
