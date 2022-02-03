using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class initStudiskiCiklusStudiskaPrograma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Termini_TerminId",
                table: "Studenti");

            migrationBuilder.AlterColumn<Guid>(
                name: "TerminId",
                table: "Studenti",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "StudickiCiklusi",
                column: "CiklusNaStudii",
                values: new object[]
                {
                    "Докторски",
                    "Додипломски",
                    "Магистерски"
                });

            migrationBuilder.InsertData(
                table: "StudiskiProgrami",
                column: "ImeNaStudiskaPrograma",
                values: new object[]
                {
                    "Компјутерски науки и инженерство",
                    "Примена на е-технологии",
                    "Мрежни технологии",
                    "Компјутерска едукација-стара",
                    "Информатика и компјутерско инженерство",
                    "Академски студии по информатика",
                    "Професионални студии по информатика",
                    "Software engineering and information systems",
                    "Софтверско инженерство и информациски системи",
                    "Примена на информациски технологии",
                    "Компјутерско инженерство",
                    "Компјутерски науки",
                    "Компјутерска едукација",
                    "Професионални студии по информатички технологии",
                    "Интернет мрежи и безбедност"
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Termini_TerminId",
                table: "Studenti",
                column: "TerminId",
                principalTable: "Termini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Termini_TerminId",
                table: "Studenti");

            migrationBuilder.DeleteData(
                table: "StudickiCiklusi",
                keyColumn: "CiklusNaStudii",
                keyValue: "Додипломски");

            migrationBuilder.DeleteData(
                table: "StudickiCiklusi",
                keyColumn: "CiklusNaStudii",
                keyValue: "Докторски");

            migrationBuilder.DeleteData(
                table: "StudickiCiklusi",
                keyColumn: "CiklusNaStudii",
                keyValue: "Магистерски");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Software engineering and information systems");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Академски студии по информатика");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Интернет мрежи и безбедност");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Информатика и компјутерско инженерство");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Компјутерска едукација");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Компјутерска едукација-стара");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Компјутерски науки");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Компјутерски науки и инженерство");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Компјутерско инженерство");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Мрежни технологии");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Примена на е-технологии");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Примена на информациски технологии");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Професионални студии по информатика");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Професионални студии по информатички технологии");

            migrationBuilder.DeleteData(
                table: "StudiskiProgrami",
                keyColumn: "ImeNaStudiskaPrograma",
                keyValue: "Софтверско инженерство и информациски системи");

            migrationBuilder.AlterColumn<Guid>(
                name: "TerminId",
                table: "Studenti",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Termini_TerminId",
                table: "Studenti",
                column: "TerminId",
                principalTable: "Termini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
