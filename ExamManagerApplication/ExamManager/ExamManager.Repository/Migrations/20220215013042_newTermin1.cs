using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class newTermin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sproveduvaci_Termini_SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci");

            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Termini_TerminId",
                table: "Studenti");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Ispiti_IspitId",
                table: "Termini");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Prostorii_ProstorijaId",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_IspitId",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_ProstorijaId",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Studenti_TerminId",
                table: "Studenti");

            migrationBuilder.DropIndex(
                name: "IX_Sproveduvaci_SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci");

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("01723f28-1e29-4693-8500-92775b54beee"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("05f7e3c9-9311-46f5-a5a3-67675d4cc9cf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1302556e-bd0f-4bfc-b7d0-a8931a67b6de"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("13de97f9-b55d-4aa2-b30e-418e6ddd849b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("154930d3-aab2-4b79-bb9d-8c7eafce53f0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("25b6c4b3-6091-4dfe-b957-e0ab91666f15"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2885c793-8d48-4d55-a230-d0ca7ea7ab6f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2946a338-7fe3-43cf-90e5-bc5f5fd9082b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("29c707f6-1e72-460b-a658-381d67467d94"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2e22ec80-f0fa-4f3c-bd57-1f089c5f4a89"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("314d6031-ca8c-44cb-ba72-e6b1df65b9ac"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("332dcf72-595a-402e-9e14-859737a31658"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3ad2be76-63db-4d8f-8c02-bd4e796edf49"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("40c744f0-5be1-4cb2-bca9-a6f9b674d2ad"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("42d28274-9ca9-4c6e-b339-3e47df1de4c2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("42e0faeb-a75a-40e5-a720-f134bd3ddab6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("43187aab-1532-4cd3-abb7-a0cf93ae4491"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("45a33f7c-5f08-4adf-819e-a7989c5d1fed"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("46c05682-c2ef-421b-b081-2be1fdfc0c05"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("471a3e5d-ac63-4578-8004-02ecb5a758a3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("47e4ca1a-384c-4d5b-82aa-c2a4d86222d3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4ad99267-0ad8-4de7-9bf9-66cc9c6cacb5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4bf1f0d8-ee7f-44a6-8a16-297c350f277c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4c54cab3-45f5-45dc-8244-81f4712ca684"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4d745716-7811-48a1-b49b-d35d7c055fd1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("50c9d6dd-1dfa-4f5d-944c-b01891376adf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("51a80d01-5b4d-496c-87b3-0fa5465a2bfa"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("532505e3-3306-4e08-bd6e-03f970093ed2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5380ca45-db84-48a4-b52e-5ac5d548f83c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5389bc34-f46d-4dbb-81bc-09e8e28d2175"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5673fd5d-ee63-4309-a032-000471d04542"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("57769926-8990-4cfa-a874-9eca69d33e69"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("596a7501-597f-4273-ad65-e49c0ebe2ebd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5c9070f8-7ade-4f79-96e8-14defa9ae5a7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5ec136c5-d898-453c-988a-07fbf5021df0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5ffce5b8-3628-424a-b62e-351de94e0fc9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("60156e21-ae9a-44c8-95bb-63bd589c41a9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("65e99b6d-9711-408d-b5fa-bbaae236318e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("689ed157-bf49-42be-96fb-30e95775b9c3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("777fe723-8a4d-4ffe-8277-3561460ce52a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7a028a3d-9d88-4e95-8315-1a3712d105a5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7bd8de61-389b-4e63-a0f5-0c81b8462596"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7e8303b9-8e78-4771-b055-a801edbfc4a1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8288ac29-fe9b-4f87-94c0-4a09ffd59c45"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("858e9aa4-aa2a-4fa4-9640-6f0bef809a5e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("860b3b2c-1795-44a9-bd6b-240e62868275"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("86e9da51-83bd-4c8a-939b-b0123aa00c80"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("878c8b74-ecea-4bbe-8d22-3740c4e6e7c2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8b7bb4ef-bd20-425d-9693-c110ac945fc9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8c5d9b1c-9b1c-48f2-a137-191060c346e6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8d1e5010-e44c-43d7-bd67-3b7b48a7b7c3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8ded0beb-18ac-4c6c-8c79-012e3a581ec1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9043f9d0-553b-433a-ac94-aed9da19ef5a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9c7265fd-6ba7-4ec1-8be1-43728151d683"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9de6306b-dc87-46e5-b5dd-bce59e375ec4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9e584656-6e19-4266-a83f-eac53b52539e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a5383c38-a4ab-4865-8d93-c018c51d0686"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a7963c07-7a10-4b03-bd72-48c065b14b90"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a79954f4-27ef-4dba-9ec3-f3ee0d76f603"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a8579b88-cdbc-44cc-b1bf-8ec6dac32658"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("aa1f17cb-3a26-467d-a901-a110a79fb589"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b9275f09-8474-436b-90f7-dde0e7a62524"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bd968d14-a8ed-4fb9-ad77-f52920eb2045"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bfd5f5d4-c996-4ee1-a62d-513a6b1c9d4e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c0f355f9-a7df-4047-857b-a2c383dce501"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c8521b61-7460-44f5-b075-33f30e002343"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cf779372-bbfd-4987-8912-362021c84bb5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d0534b4a-8e53-48fd-b15d-350421023c14"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d0d5e560-9dbe-4713-b2de-9482e6808c8f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d7642147-9537-4987-9339-cb90c48614cf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d8e4f2a9-bb14-4282-b793-ac4066a2e8d4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d9bbb4be-b9af-40dc-8dd4-dc2c22fe9aa4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d9f01754-1297-4a7c-bbba-31daff000fcb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("dbee470d-f154-4632-8045-b0be17073b37"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("dc959a21-63d6-475e-a255-90784f064bf5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("de7e0e05-0857-43e8-ab1e-463bcb3faba9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e1951596-7072-4187-9e40-9bb3d9efff48"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e33b1bd2-509f-4cb1-bc7d-41426468b110"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e67bb9cc-bd69-44ba-b2c2-60f5ebdf071b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ee232ba1-e2c1-4d94-a086-e8aabb39399b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f23f9f4a-ea8c-425c-8d10-7e8577904873"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f6123a5c-38f1-4713-a427-e10c8eabfbf3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f6bee830-db27-43f0-99cd-1a3f8fea74e0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f71394e5-b5c7-410a-9dc1-415e1aa365ab"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f74b5ce6-de65-490d-ada1-2e69b6d74d61"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f7ee5fe5-02bf-4c30-b9e8-21fdce229952"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f9a05883-d07f-4e15-8bc9-b5a133e95fc7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ffde570c-e352-46cf-8fba-e9317df69473"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("088c948a-7c4a-414d-a40d-632b4d064ba3"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("1974b77f-fc51-47fd-839d-a62dc37739ec"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("43efa188-6445-41bd-bac3-c4d1a34ed718"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("505e7704-208e-40cd-b17f-67450d1cc71d"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("7713b951-771b-4d4b-afdd-f57a8f28a0aa"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("8ee1a019-17a9-4a5f-8ec3-b3e33eda0f7c"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("9ecf6598-20e0-4f1a-b284-688d7fecfbaf"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("b53825da-9f40-44f6-869b-c866425b7afd"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("e9eb06a5-37e0-4086-82bb-04d54221cb22"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("edb44662-ef28-4249-aac6-9b2657e3b7d0"));

            migrationBuilder.DropColumn(
                name: "IspitId",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "ProstorijaId",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "CustomTerminId",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "TerminId",
                table: "Studenti");

            migrationBuilder.DropColumn(
                name: "SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci");

            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("e07056cf-4302-4ce5-8551-9b7125375e4c"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("298b68d9-93a6-4915-889c-c92b5ec13a37"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("cc6ff900-552d-4525-92a4-b209da7f178e"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("c061532b-9755-4009-9aaa-81ec34b7aabb"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("8dfe8b5a-1126-477e-bd78-7ed547cdfd72"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("300d35d2-47ee-429e-8802-5b793865f41b"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("ac2a83f3-e109-4f3e-8653-b11c07ab2838"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("932683b8-2bd8-419e-8f2a-5e43ee22dade"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("bcb8f67f-42c5-4f25-aec8-e9ba9c8e5237"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("193e879d-c45c-42c1-ad71-1649c1b83488"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("8f2d2beb-f7e2-4a4f-9c64-4d38aa8e72ae"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("071ed0ca-4cf9-407c-8d2b-9b599b582515"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("6a427723-a8dc-4f95-a450-b97248b801fa"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("24e407b9-f54a-44c3-badb-6162ed21628b"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("7b791d0c-4441-4425-999e-1ce9dc62cd85"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("ca4c4023-2e07-4503-9a8a-b5cf52c711d6"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("e79137a4-634f-44d8-87d6-dd514c52be2a"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("0205fda6-4b8b-4966-bf1f-64ea9a42273c"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("07c227f0-134b-47f5-8691-8763ea94c105"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("c18d1910-c7b4-495f-9243-27122a02526c"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("3d9f4505-e5c7-4a11-b8f0-fd8b1b36f9e2"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7df8356f-ef52-4bbd-a1ad-fceee456f641"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("b5583fa6-c0a4-4247-b25b-d2d3c2642f89"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("0ddae238-420a-421b-8a04-79d998ec4387"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("e39522cd-de64-41dd-80fb-038a5017c128"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("7d0dac88-2d65-4b55-bcab-a21e762b97d1"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("1874985d-9a96-4a7e-8311-35d97b7f4f85"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("f6eb8df7-8682-4dc5-8f74-cdba90a955f1"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f043cf70-6493-49d7-85d2-7f6c563375cc"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9cf59861-5cbe-48d5-804c-38d5bee9478c"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("60405940-d290-4e4d-a005-4b55af59b626"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("fc9a3eee-9dcf-4aa3-aa09-9e8ae579ba1e"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d66d4de4-e31d-4949-9169-75458bcb581d"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("21b4a84c-1884-4773-8dcf-3826e2055cd4"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("64bbc8f1-c422-4f22-b2e0-4b0f081e88c6"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9311a664-95b1-4bd3-a9c7-e33de3f062c1"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("afa1d3d1-1804-4625-bdd8-5244ad8bb20c"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("3c2359b4-de14-4c33-8b39-93af77679385"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("bdb69c1f-06f8-44b5-8bb2-000e4e8f664c"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("4ce86c0d-a48c-4a8d-a6dd-d3aa8eb1700f"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("2b18f123-ac2a-48d7-8287-961961fa8e80"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("12059427-ad06-411d-b74c-462a9a3f0d9a"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("461ca508-8232-460e-be1a-bf376768bee1"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("fdadb620-e53c-4afe-a5cf-69e6c0b50ffe"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("a14dad37-0fdb-4346-86df-706a28984eca"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("b269d6d3-2a41-48a8-91b9-aa7f6fa4fc47"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("0b048340-69b9-45c0-a62d-6375e2bdef4f"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("7be9ffb8-2a2a-40b2-8069-bea7a606e186"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("886b457c-a73a-4cd8-bf8c-7058db772408"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("d5adcab4-4d4a-4bc8-8b4e-2c29358ce617"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("acf0c9ae-6fba-4ff4-a0f8-5667cb5beae9"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9a99c0b8-4c60-4f00-8f09-1081074c5b68"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("140969a5-abfb-405f-82e8-c48f6fe0882f"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("dcf2e11f-da79-4e32-af9e-a740978c957e"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("6f369d91-4d3e-4544-90bb-59ee57312af3"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("6ffce072-c2af-4cc6-900d-bedc58b1503e"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("36bc27c3-e5e1-4843-a54c-ef298fb423e4"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("76db30a6-8b04-4ad6-bf93-70f7e495f6d4"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("5b4f5fd1-9b61-4735-8fc8-c925acc9385f"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("9711fcf1-6c5e-4a4f-902e-5239f69879ae"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("80b29a81-a457-4998-9b4a-d091dbf92ad2"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("f2aa2cd1-777c-4164-b370-8ccc7363db6f"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("3428ebe4-26fc-441f-ab99-b9066c0c26a3"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("e5e55343-ba2b-41b3-8d9c-c472d0bc8596"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("fdc48ef6-8d20-44ae-9a21-dfd7fbe35731"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("bdcbac8b-d91c-4147-92ef-a26a2773e9f3"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("40632548-7802-4d19-84be-463481394a7c"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("69fb59b6-c3e9-4bd6-8835-f4c4d84a522b"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e25a44cd-f392-4602-aeaf-44c22fba307e"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("9a8f4457-afef-4cd4-ae25-8fa6fb32e080"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("5df3a6a4-054a-4f90-9cba-bcf661166356"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("bc494d3e-6d82-4e94-a295-aac786720deb"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("bc6ee3ed-7147-4c99-b1b2-1507d453c28b"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("07ba0d9b-17fb-4917-8c1f-3297a926533b"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("eed571db-8c9d-4f4c-acad-404d8f3e4a4d"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("c38be8e1-c41e-43a8-bfc0-a5890d9d2f19"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("c87451a2-2fcd-400a-80c2-25262b36fb01"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("c042b6e5-3ddd-41d1-8ad9-24784b2e46e4"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("20aaa4f0-78ca-4e9b-8901-cf057bd698d2"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("9ad244a7-b43f-45b2-9bbe-664402aca4da"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("0d72d9fc-56ac-490c-b0b6-7b608baa2a63"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("d41c15fb-58ab-48ff-bda2-8aa2d12cded2"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("712e19ae-d965-4d03-aff6-01da622fd631"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("69598af2-ca10-4d90-85ed-d9cca543bcf3"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("dc7722a1-021f-46c0-86e8-bafa84064c05"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("35bf814c-7885-4113-b8f0-80b980b495c4"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("953f7589-5988-4393-a656-572fa10808a9"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9733ca1c-b110-4312-99c1-f8df7efbfac1"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("14c7b684-6214-4dac-b278-78429722f8d3"), "Lab8", 63 },
                    { new Guid("9e4a968d-8965-4b5b-af45-140c7b4853ab"), "Lab7", 69 },
                    { new Guid("9f5a38b8-3fbe-422b-898f-3c5faf0a1ea4"), "Lab6", 33 },
                    { new Guid("500a8b86-e45b-42b2-9124-0193be4f3d08"), "Lab5", 31 },
                    { new Guid("d2b64778-8536-4445-b9ca-8b6dd79eacbf"), "Lab1", 59 },
                    { new Guid("d23996b0-2f6e-4377-bdbc-797f90386793"), "Lab3", 28 },
                    { new Guid("b0a44b52-a67c-400a-ab68-6006a1d33040"), "Lab2", 30 },
                    { new Guid("73c5175c-6b48-496d-91b7-710a3f057bea"), "Lab9", 27 },
                    { new Guid("d61f3d52-074b-43eb-b5a5-0a6539314b6b"), "Lab4", 68 },
                    { new Guid("0bcf164f-5343-4052-8974-67c7c33bcd6a"), "Lab10", 58 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0205fda6-4b8b-4966-bf1f-64ea9a42273c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("071ed0ca-4cf9-407c-8d2b-9b599b582515"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("07ba0d9b-17fb-4917-8c1f-3297a926533b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("07c227f0-134b-47f5-8691-8763ea94c105"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0b048340-69b9-45c0-a62d-6375e2bdef4f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0d72d9fc-56ac-490c-b0b6-7b608baa2a63"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0ddae238-420a-421b-8a04-79d998ec4387"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("12059427-ad06-411d-b74c-462a9a3f0d9a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("140969a5-abfb-405f-82e8-c48f6fe0882f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1874985d-9a96-4a7e-8311-35d97b7f4f85"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("193e879d-c45c-42c1-ad71-1649c1b83488"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("20aaa4f0-78ca-4e9b-8901-cf057bd698d2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("21b4a84c-1884-4773-8dcf-3826e2055cd4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("24e407b9-f54a-44c3-badb-6162ed21628b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("298b68d9-93a6-4915-889c-c92b5ec13a37"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2b18f123-ac2a-48d7-8287-961961fa8e80"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("300d35d2-47ee-429e-8802-5b793865f41b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3428ebe4-26fc-441f-ab99-b9066c0c26a3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("35bf814c-7885-4113-b8f0-80b980b495c4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("36bc27c3-e5e1-4843-a54c-ef298fb423e4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3c2359b4-de14-4c33-8b39-93af77679385"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3d9f4505-e5c7-4a11-b8f0-fd8b1b36f9e2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("40632548-7802-4d19-84be-463481394a7c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("461ca508-8232-460e-be1a-bf376768bee1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4ce86c0d-a48c-4a8d-a6dd-d3aa8eb1700f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5b4f5fd1-9b61-4735-8fc8-c925acc9385f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5df3a6a4-054a-4f90-9cba-bcf661166356"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("60405940-d290-4e4d-a005-4b55af59b626"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("64bbc8f1-c422-4f22-b2e0-4b0f081e88c6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("69598af2-ca10-4d90-85ed-d9cca543bcf3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("69fb59b6-c3e9-4bd6-8835-f4c4d84a522b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6a427723-a8dc-4f95-a450-b97248b801fa"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6f369d91-4d3e-4544-90bb-59ee57312af3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6ffce072-c2af-4cc6-900d-bedc58b1503e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("712e19ae-d965-4d03-aff6-01da622fd631"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("76db30a6-8b04-4ad6-bf93-70f7e495f6d4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7b791d0c-4441-4425-999e-1ce9dc62cd85"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7be9ffb8-2a2a-40b2-8069-bea7a606e186"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7d0dac88-2d65-4b55-bcab-a21e762b97d1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7df8356f-ef52-4bbd-a1ad-fceee456f641"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("80b29a81-a457-4998-9b4a-d091dbf92ad2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("886b457c-a73a-4cd8-bf8c-7058db772408"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8dfe8b5a-1126-477e-bd78-7ed547cdfd72"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8f2d2beb-f7e2-4a4f-9c64-4d38aa8e72ae"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9311a664-95b1-4bd3-a9c7-e33de3f062c1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("932683b8-2bd8-419e-8f2a-5e43ee22dade"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("953f7589-5988-4393-a656-572fa10808a9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9711fcf1-6c5e-4a4f-902e-5239f69879ae"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9733ca1c-b110-4312-99c1-f8df7efbfac1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9a8f4457-afef-4cd4-ae25-8fa6fb32e080"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9a99c0b8-4c60-4f00-8f09-1081074c5b68"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9ad244a7-b43f-45b2-9bbe-664402aca4da"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9cf59861-5cbe-48d5-804c-38d5bee9478c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a14dad37-0fdb-4346-86df-706a28984eca"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ac2a83f3-e109-4f3e-8653-b11c07ab2838"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("acf0c9ae-6fba-4ff4-a0f8-5667cb5beae9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("afa1d3d1-1804-4625-bdd8-5244ad8bb20c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b269d6d3-2a41-48a8-91b9-aa7f6fa4fc47"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b5583fa6-c0a4-4247-b25b-d2d3c2642f89"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bc494d3e-6d82-4e94-a295-aac786720deb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bc6ee3ed-7147-4c99-b1b2-1507d453c28b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bcb8f67f-42c5-4f25-aec8-e9ba9c8e5237"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bdb69c1f-06f8-44b5-8bb2-000e4e8f664c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bdcbac8b-d91c-4147-92ef-a26a2773e9f3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c042b6e5-3ddd-41d1-8ad9-24784b2e46e4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c061532b-9755-4009-9aaa-81ec34b7aabb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c18d1910-c7b4-495f-9243-27122a02526c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c38be8e1-c41e-43a8-bfc0-a5890d9d2f19"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c87451a2-2fcd-400a-80c2-25262b36fb01"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ca4c4023-2e07-4503-9a8a-b5cf52c711d6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cc6ff900-552d-4525-92a4-b209da7f178e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d41c15fb-58ab-48ff-bda2-8aa2d12cded2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d5adcab4-4d4a-4bc8-8b4e-2c29358ce617"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d66d4de4-e31d-4949-9169-75458bcb581d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("dc7722a1-021f-46c0-86e8-bafa84064c05"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("dcf2e11f-da79-4e32-af9e-a740978c957e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e07056cf-4302-4ce5-8551-9b7125375e4c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e25a44cd-f392-4602-aeaf-44c22fba307e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e39522cd-de64-41dd-80fb-038a5017c128"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e5e55343-ba2b-41b3-8d9c-c472d0bc8596"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e79137a4-634f-44d8-87d6-dd514c52be2a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("eed571db-8c9d-4f4c-acad-404d8f3e4a4d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f043cf70-6493-49d7-85d2-7f6c563375cc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f2aa2cd1-777c-4164-b370-8ccc7363db6f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f6eb8df7-8682-4dc5-8f74-cdba90a955f1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fc9a3eee-9dcf-4aa3-aa09-9e8ae579ba1e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fdadb620-e53c-4afe-a5cf-69e6c0b50ffe"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fdc48ef6-8d20-44ae-9a21-dfd7fbe35731"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("0bcf164f-5343-4052-8974-67c7c33bcd6a"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("14c7b684-6214-4dac-b278-78429722f8d3"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("500a8b86-e45b-42b2-9124-0193be4f3d08"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("73c5175c-6b48-496d-91b7-710a3f057bea"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("9e4a968d-8965-4b5b-af45-140c7b4853ab"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("9f5a38b8-3fbe-422b-898f-3c5faf0a1ea4"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("b0a44b52-a67c-400a-ab68-6006a1d33040"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("d23996b0-2f6e-4377-bdbc-797f90386793"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("d2b64778-8536-4445-b9ca-8b6dd79eacbf"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("d61f3d52-074b-43eb-b5a5-0a6539314b6b"));

            migrationBuilder.AddColumn<Guid>(
                name: "IspitId",
                table: "Termini",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProstorijaId",
                table: "Termini",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomTerminId",
                table: "Studenti",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TerminId",
                table: "Studenti",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("cf779372-bbfd-4987-8912-362021c84bb5"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("b9275f09-8474-436b-90f7-dde0e7a62524"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("f6bee830-db27-43f0-99cd-1a3f8fea74e0"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("5ffce5b8-3628-424a-b62e-351de94e0fc9"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("c8521b61-7460-44f5-b075-33f30e002343"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("a5383c38-a4ab-4865-8d93-c018c51d0686"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("42d28274-9ca9-4c6e-b339-3e47df1de4c2"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("40c744f0-5be1-4cb2-bca9-a6f9b674d2ad"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("f7ee5fe5-02bf-4c30-b9e8-21fdce229952"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("f9a05883-d07f-4e15-8bc9-b5a133e95fc7"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("860b3b2c-1795-44a9-bd6b-240e62868275"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("8ded0beb-18ac-4c6c-8c79-012e3a581ec1"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("a8579b88-cdbc-44cc-b1bf-8ec6dac32658"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("9043f9d0-553b-433a-ac94-aed9da19ef5a"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("4ad99267-0ad8-4de7-9bf9-66cc9c6cacb5"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d9bbb4be-b9af-40dc-8dd4-dc2c22fe9aa4"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("9de6306b-dc87-46e5-b5dd-bce59e375ec4"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("65e99b6d-9711-408d-b5fa-bbaae236318e"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e1951596-7072-4187-9e40-9bb3d9efff48"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("de7e0e05-0857-43e8-ab1e-463bcb3faba9"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("60156e21-ae9a-44c8-95bb-63bd589c41a9"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("5380ca45-db84-48a4-b52e-5ac5d548f83c"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("29c707f6-1e72-460b-a658-381d67467d94"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("532505e3-3306-4e08-bd6e-03f970093ed2"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5ec136c5-d898-453c-988a-07fbf5021df0"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("8288ac29-fe9b-4f87-94c0-4a09ffd59c45"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("13de97f9-b55d-4aa2-b30e-418e6ddd849b"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("8b7bb4ef-bd20-425d-9693-c110ac945fc9"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("42e0faeb-a75a-40e5-a720-f134bd3ddab6"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("2885c793-8d48-4d55-a230-d0ca7ea7ab6f"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("50c9d6dd-1dfa-4f5d-944c-b01891376adf"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("596a7501-597f-4273-ad65-e49c0ebe2ebd"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("dbee470d-f154-4632-8045-b0be17073b37"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("7bd8de61-389b-4e63-a0f5-0c81b8462596"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("4bf1f0d8-ee7f-44a6-8a16-297c350f277c"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("aa1f17cb-3a26-467d-a901-a110a79fb589"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("ee232ba1-e2c1-4d94-a086-e8aabb39399b"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("a7963c07-7a10-4b03-bd72-48c065b14b90"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("2e22ec80-f0fa-4f3c-bd57-1f089c5f4a89"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("7e8303b9-8e78-4771-b055-a801edbfc4a1"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f6123a5c-38f1-4713-a427-e10c8eabfbf3"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7a028a3d-9d88-4e95-8315-1a3712d105a5"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("4d745716-7811-48a1-b49b-d35d7c055fd1"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f71394e5-b5c7-410a-9dc1-415e1aa365ab"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("c0f355f9-a7df-4047-857b-a2c383dce501"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("858e9aa4-aa2a-4fa4-9640-6f0bef809a5e"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("57769926-8990-4cfa-a874-9eca69d33e69"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("9e584656-6e19-4266-a83f-eac53b52539e"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("05f7e3c9-9311-46f5-a5a3-67675d4cc9cf"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("45a33f7c-5f08-4adf-819e-a7989c5d1fed"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e33b1bd2-509f-4cb1-bc7d-41426468b110"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("86e9da51-83bd-4c8a-939b-b0123aa00c80"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("8c5d9b1c-9b1c-48f2-a137-191060c346e6"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("5673fd5d-ee63-4309-a032-000471d04542"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("bd968d14-a8ed-4fb9-ad77-f52920eb2045"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("689ed157-bf49-42be-96fb-30e95775b9c3"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e67bb9cc-bd69-44ba-b2c2-60f5ebdf071b"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("f74b5ce6-de65-490d-ada1-2e69b6d74d61"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("8d1e5010-e44c-43d7-bd67-3b7b48a7b7c3"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f23f9f4a-ea8c-425c-8d10-7e8577904873"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("332dcf72-595a-402e-9e14-859737a31658"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("9c7265fd-6ba7-4ec1-8be1-43728151d683"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("d0d5e560-9dbe-4713-b2de-9482e6808c8f"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("154930d3-aab2-4b79-bb9d-8c7eafce53f0"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("25b6c4b3-6091-4dfe-b957-e0ab91666f15"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("bfd5f5d4-c996-4ee1-a62d-513a6b1c9d4e"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("01723f28-1e29-4693-8500-92775b54beee"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5c9070f8-7ade-4f79-96e8-14defa9ae5a7"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("314d6031-ca8c-44cb-ba72-e6b1df65b9ac"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("4c54cab3-45f5-45dc-8244-81f4712ca684"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("878c8b74-ecea-4bbe-8d22-3740c4e6e7c2"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("ffde570c-e352-46cf-8fba-e9317df69473"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("3ad2be76-63db-4d8f-8c02-bd4e796edf49"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("51a80d01-5b4d-496c-87b3-0fa5465a2bfa"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("777fe723-8a4d-4ffe-8277-3561460ce52a"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("43187aab-1532-4cd3-abb7-a0cf93ae4491"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("46c05682-c2ef-421b-b081-2be1fdfc0c05"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("d9f01754-1297-4a7c-bbba-31daff000fcb"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("d7642147-9537-4987-9339-cb90c48614cf"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("a79954f4-27ef-4dba-9ec3-f3ee0d76f603"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("1302556e-bd0f-4bfc-b7d0-a8931a67b6de"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("2946a338-7fe3-43cf-90e5-bc5f5fd9082b"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("d8e4f2a9-bb14-4282-b793-ac4066a2e8d4"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("47e4ca1a-384c-4d5b-82aa-c2a4d86222d3"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("471a3e5d-ac63-4578-8004-02ecb5a758a3"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("d0534b4a-8e53-48fd-b15d-350421023c14"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5389bc34-f46d-4dbb-81bc-09e8e28d2175"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("dc959a21-63d6-475e-a255-90784f064bf5"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("b53825da-9f40-44f6-869b-c866425b7afd"), "Lab8", 31 },
                    { new Guid("9ecf6598-20e0-4f1a-b284-688d7fecfbaf"), "Lab7", 62 },
                    { new Guid("7713b951-771b-4d4b-afdd-f57a8f28a0aa"), "Lab6", 69 },
                    { new Guid("e9eb06a5-37e0-4086-82bb-04d54221cb22"), "Lab5", 39 },
                    { new Guid("088c948a-7c4a-414d-a40d-632b4d064ba3"), "Lab1", 59 },
                    { new Guid("43efa188-6445-41bd-bac3-c4d1a34ed718"), "Lab3", 52 },
                    { new Guid("edb44662-ef28-4249-aac6-9b2657e3b7d0"), "Lab2", 51 },
                    { new Guid("8ee1a019-17a9-4a5f-8ec3-b3e33eda0f7c"), "Lab9", 48 },
                    { new Guid("1974b77f-fc51-47fd-839d-a62dc37739ec"), "Lab4", 25 },
                    { new Guid("505e7704-208e-40cd-b17f-67450d1cc71d"), "Lab10", 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Termini_IspitId",
                table: "Termini",
                column: "IspitId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_ProstorijaId",
                table: "Termini",
                column: "ProstorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_TerminId",
                table: "Studenti",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_Sproveduvaci_SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci",
                column: "SproveduvacDezuraVoTerminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sproveduvaci_Termini_SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci",
                column: "SproveduvacDezuraVoTerminId",
                principalTable: "Termini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Termini_TerminId",
                table: "Studenti",
                column: "TerminId",
                principalTable: "Termini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Ispiti_IspitId",
                table: "Termini",
                column: "IspitId",
                principalTable: "Ispiti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Prostorii_ProstorijaId",
                table: "Termini",
                column: "ProstorijaId",
                principalTable: "Prostorii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
