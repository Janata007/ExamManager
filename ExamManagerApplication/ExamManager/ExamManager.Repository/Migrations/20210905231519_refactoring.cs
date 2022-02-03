using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_Predmeti_PredmetId",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_StudiskiProgrami_StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_PredmetId",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Predmeti_PredmetId",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_PredmetId",
                table: "Termini");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudiskiProgrami",
                table: "StudiskiProgrami");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentiPolagaatPredmeti",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropIndex(
                name: "IX_StudentiPolagaatPredmeti_PredmetId",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PredmetiOdStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropIndex(
                name: "IX_PredmetiOdStudiskaPrograma_StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Predmeti",
                table: "Predmeti");

            migrationBuilder.AddColumn<string>(
                name: "KodNaPredmet",
                table: "PredmetiOdStudiskaPrograma",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImeNaStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma",
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropColumn(
                name: "PredmetId",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudiskiProgrami");

            migrationBuilder.DropColumn(
                name: "PredmetId",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropColumn(
                name: "PredmetId",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropColumn(
                name: "StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropColumn(
                name: "PredmetId",
                table: "Predmeti");

            migrationBuilder.AddColumn<string>(
                name: "KodNaPredmet",
                table: "Termini",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImeNaStudiskaPrograma",
                table: "StudiskiProgrami",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                nullable: false,
                defaultValue: "");

         
            migrationBuilder.AddColumn<string>(
                name: "KodNaPredmet",
                table: "Predmeti",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImeNaPredmet",
                table: "Predmeti",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudiskiProgrami",
                table: "StudiskiProgrami",
                column: "ImeNaStudiskaPrograma");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentiPolagaatPredmeti",
                table: "StudentiPolagaatPredmeti",
                columns: new[] { "BrojNaIndeks", "KodNaPredmet" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PredmetiOdStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma",
                columns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Predmeti",
                table: "Predmeti",
                column: "KodNaPredmet");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_KodNaPredmet",
                table: "Termini",
                column: "KodNaPredmet");

            migrationBuilder.CreateIndex(
                name: "IX_StudentiPolagaatPredmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                column: "KodNaPredmet");

            migrationBuilder.CreateIndex(
                name: "IX_PredmetiOdStudiskaPrograma_ImeNaStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma",
                column: "ImeNaStudiskaPrograma");

            migrationBuilder.AddForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_StudiskiProgrami_ImeNaStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma",
                column: "ImeNaStudiskaPrograma",
                principalTable: "StudiskiProgrami",
                principalColumn: "ImeNaStudiskaPrograma",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_Predmeti_KodNaPredmet",
                table: "PredmetiOdStudiskaPrograma",
                column: "KodNaPredmet",
                principalTable: "Predmeti",
                principalColumn: "KodNaPredmet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                column: "KodNaPredmet",
                principalTable: "Predmeti",
                principalColumn: "KodNaPredmet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Predmeti_KodNaPredmet",
                table: "Termini",
                column: "KodNaPredmet",
                principalTable: "Predmeti",
                principalColumn: "KodNaPredmet",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_StudiskiProgrami_ImeNaStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_Predmeti_KodNaPredmet",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Predmeti_KodNaPredmet",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_KodNaPredmet",
                table: "Termini");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudiskiProgrami",
                table: "StudiskiProgrami");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentiPolagaatPredmeti",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropIndex(
                name: "IX_StudentiPolagaatPredmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PredmetiOdStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropIndex(
                name: "IX_PredmetiOdStudiskaPrograma_ImeNaStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Predmeti",
                table: "Predmeti");

            migrationBuilder.DropColumn(
                name: "KodNaPredmet",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "KodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropColumn(
                name: "KodNaPredmet",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropColumn(
                name: "ImeNaStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma");

            migrationBuilder.DropColumn(
                name: "KodNaPredmet",
                table: "Predmeti");

            migrationBuilder.DropColumn(
                name: "ImeNaPredmet",
                table: "Predmeti");

            migrationBuilder.AddColumn<string>(
                name: "PredmetId",
                table: "Termini",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImeNaStudiskaPrograma",
                table: "StudiskiProgrami",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "StudiskiProgrami",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PredmetId",
                table: "StudentiPolagaatPredmeti",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PredmetId",
                table: "PredmetiOdStudiskaPrograma",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PredmetId",
                table: "Predmeti",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudiskiProgrami",
                table: "StudiskiProgrami",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentiPolagaatPredmeti",
                table: "StudentiPolagaatPredmeti",
                columns: new[] { "BrojNaIndeks", "PredmetId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PredmetiOdStudiskaPrograma",
                table: "PredmetiOdStudiskaPrograma",
                columns: new[] { "PredmetId", "StudiskaProgramaId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Predmeti",
                table: "Predmeti",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_PredmetId",
                table: "Termini",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentiPolagaatPredmeti_PredmetId",
                table: "StudentiPolagaatPredmeti",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_PredmetiOdStudiskaPrograma_StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma",
                column: "StudiskaProgramaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_Predmeti_PredmetId",
                table: "PredmetiOdStudiskaPrograma",
                column: "PredmetId",
                principalTable: "Predmeti",
                principalColumn: "PredmetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PredmetiOdStudiskaPrograma_StudiskiProgrami_StudiskaProgramaId",
                table: "PredmetiOdStudiskaPrograma",
                column: "StudiskaProgramaId",
                principalTable: "StudiskiProgrami",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_PredmetId",
                table: "StudentiPolagaatPredmeti",
                column: "PredmetId",
                principalTable: "Predmeti",
                principalColumn: "PredmetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Predmeti_PredmetId",
                table: "Termini",
                column: "PredmetId",
                principalTable: "Predmeti",
                principalColumn: "PredmetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
