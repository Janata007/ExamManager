using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class termini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Studenti_BrojNaIndeks",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropIndex(
                name: "IX_StudentiPolagaatPredmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("028d632c-c4d3-4902-ac07-27d68fc929fe"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0ba48411-4d3c-4921-b620-a61cc62d49b0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0fb40248-019d-4ffa-b1cc-ac4e9377f696"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("11f4966a-1ebf-4e0d-be46-fed1000552f6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1418ddae-b07c-4905-b17c-7c6718cc7b20"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("149c82ea-9dbd-4835-b11d-4573749d724c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("17b81370-7a94-4033-b9cd-1145864d6697"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("19ef361c-fb81-491e-81f7-0a50c4eb104b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1a00e3a7-d8d9-465a-afd2-35ea0346db25"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1b33d771-182c-4845-a920-a607c6f15dde"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1d3c3b4d-2535-4180-a3f4-8bc92f9217c8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("21f96d16-e571-4aa6-b0a5-c573c9380e9d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("25b07181-2652-41bc-b791-18c645d9946c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2e43a01c-fc0b-49e4-9e57-d5d0df475865"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("322f4cb3-e724-4fa6-9d40-8305b3f56762"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("323325a5-392e-4069-8e6f-0abd936ad5fd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("369e74e5-5317-4728-873f-2770ca4586f6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("389df58b-600f-4c33-894e-696f03f7fe29"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("40101837-02c8-4a60-abbc-9552c374c9c3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4420ef93-1683-4f95-a48d-af47197e064c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("46b968a1-cadc-4c3b-84f4-ea186ea55760"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("47ce4f80-d95b-4afa-8441-2e391794c05a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("47efe2e3-c179-4b78-ae1a-975b38179d52"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("48a47f88-ec1c-46a1-93e4-71518ab5e460"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4d896537-f6ed-4b68-aaf0-0889b77e57d1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("500381d8-239e-445d-8fd8-9cdbb6c218de"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("51bf5534-0bc6-4618-8c7b-d058eaee4b25"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("52f1581d-940a-40cb-96ed-f8f807f7e9c4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("56549d1b-3229-496f-8c2f-de4a0ac2f0eb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("598cadcb-87fd-44f6-98d4-64c3c2963012"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5b30389c-9bde-4065-8a00-226cf3a3b88f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5d6e95f2-970f-4a4d-9e3f-5d169e96cb12"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5df5ae37-b064-4c44-b926-c859e3fd04e1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5f026603-cf62-4e17-930d-10c38226bf3b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6bb979b1-f564-4289-902b-81359e2453a3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6c91cb3f-792a-4df2-b34e-486b5728ed38"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6ca12e41-a13c-4b00-a43d-4f63e2f6db5f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6f180362-974f-46de-afc4-1a2f6e8026af"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6feae9d7-8c30-4f82-971c-bdf6b8bad0cd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("71b71da8-6c4d-4778-97ef-619b8e528d1b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7296ac94-e2ca-4d6d-9682-adf1fcb5329c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("732e77f2-6ec0-4795-b13d-430a7ecd0a69"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7557e6e2-dd14-4ba8-8069-f25c6e651cb7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7dda060e-c1f0-4bd0-a983-213378639c48"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("834d176a-3d67-4c3b-9bef-837cf6700409"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("87f12e9e-b1c6-4f06-9f85-c993b89c2da7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8943fa80-318c-4ba2-8c29-cb446e6c1130"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("95d0d29b-5265-48f0-8315-30b1a01baa63"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("962b712a-768d-4b56-bf2a-de8d993ad561"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("98f11cb3-2b3c-4350-833b-c60ebd8730a1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("98f9a107-bdd0-4321-a7d2-48330ba81138"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9bfc7558-bbff-4bd2-957c-ac6674aacace"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9deba456-83a8-4312-b107-d7bf9940e9c4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9fb890e0-b89c-4225-a672-4eb068568708"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a12372d2-4727-4f03-89c3-f8b4732c6851"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a4767592-efa1-45c3-86dc-5a35989ca0ee"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a93497a2-b9c2-438c-8703-452e20972a91"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("aaa1fe29-cf30-4f5e-9cc6-eed596d1aadc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b448edb6-1b7b-4929-8b6a-60cceaf06ab0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b466fc47-e7cf-45c1-9244-2ac770a793ec"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131a-3239-4c46-8267-05c8fad70e95"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b969b8e2-b702-4b80-99c3-cfa2c1feff94"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bfd00edb-6dc0-4fb3-8462-f6c8d707b4ed"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c1c1a4b3-ed57-4cbd-917f-9fe41209f1ef"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c27a843a-b332-4f29-9a38-eeebd34184f0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c5309821-87b1-4a05-b93a-324a14747842"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cbad1935-82af-4c21-a4cd-5048330cd30b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cbf61184-1973-435e-bf0d-47f96cc1c5de"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cbf9d196-7bca-4b79-a1b4-58a419bce4b8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ccda599d-9869-4bf6-8c8c-a692a01c4f79"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cd92bb7d-ee28-42a1-8fde-8b8f9a631e04"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d12f45be-1ae2-406b-8c47-73e6f20afb81"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d49a0bf7-9581-43d0-a441-43d2d30ebeef"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("db0298bd-7e67-4daa-8b16-49ff5466f319"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ddf18499-8f39-45a4-bf81-0ffa68f5a112"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e2c9bd8c-b849-4429-aa6d-5ebcd40ccc64"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e526add0-30a2-4846-a139-e00843b8b529"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e6a738da-6e32-4db2-b82c-90f02518ca0e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e7e221d5-ade9-4c97-97d0-d5b3809850d0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e9f4f8a1-0ada-4e78-aa2f-b1c316fe759d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ea82bbbf-bf54-4394-a79e-2414fb1c5dd3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("eb217222-987e-4232-8b3e-dd781894abfb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f94c4aec-7c84-411e-9415-7438e8b62766"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f9b18fed-5627-4bf6-a95d-76909eb22b92"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fb0d1274-0851-46b5-87e1-1719d80e3387"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fd50cee5-158d-44cb-bab5-d59407974a73"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fe81c9ca-494f-4550-9bb1-1bc2f78c0a0e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ffa98946-03d4-44e5-a29d-974ace4c28d5"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("27de4f58-f127-475d-8655-a19cc705f906"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("5653e31f-1cb7-4de5-916c-b2d08b35f626"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("56f8626b-11a6-4f3b-8df1-851bad49dc7b"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("73bc8ce4-97ae-4d06-95bb-6fe8bcc6c8ba"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("7663d668-0a04-49d8-91d6-05ad6877e808"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("88f2f612-a680-4996-8afa-eb004c7e253e"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("bf6e53b9-95af-44c3-8c17-8c821ce61950"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("e45c2e6f-c1bb-4e0f-9462-a4de6cf47719"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("fef6769d-f0e5-4a93-a3bc-d016e7c0cc49"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("ff54fa23-f37a-418a-a779-e08815bc5ed3"));

            migrationBuilder.AddColumn<string>(
                name: "PredmetKodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentBrojNaIndeks",
                table: "StudentiPolagaatPredmeti",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("717b1539-c0d1-4c2d-a20c-643f197d3fc0"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("3532bfd7-11db-4236-a305-d58e8d781e67"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("4f70b822-30c2-43d0-890b-3f7ab5010d4a"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("2a2f9709-bf69-489d-a2da-d619dbf9c894"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("4783d290-9d97-45db-b3c0-256c8a918073"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("42ed7a39-7189-49c4-9c0a-a45eea3a55f6"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("2531fb8a-fcc7-452a-90c7-1245cf24d8f6"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("48b69293-deec-4a24-9197-eb9772f87faa"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("93c060c4-8fd9-4d51-aafb-25c48bceecfb"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("e93b496f-37ba-4972-83e6-61ddfd01f848"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5de9e3c6-3976-4c74-ad19-8627596bb406"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("a607c28f-bb7d-46a9-b177-28b67b185a11"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("03ae75c5-b9fc-43b9-b932-2b0a83ca32d7"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("f1e1c33c-dfaf-4161-9c23-eb4cb1e7421a"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("b7b481d9-4e22-4920-bb81-7fe981315a75"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("86211381-f425-4e50-a13c-cf48684825dc"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("5b2f0ca3-1192-4127-8446-9d1cc925ca67"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("4f06f9fa-d31f-4235-acf2-bdc691ae9689"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("4383bd8f-1d8d-4a7d-816c-5bf29709fd61"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("00f94e5f-ea93-45d7-a148-bcafa845b0df"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("2bb9f048-763d-4322-9fd5-669eb3864558"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("64c71e10-dff4-47fa-876e-2ba4a5f1651c"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("eb1d448e-9244-4e77-bab5-ad54d588972b"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("1fc37329-7c24-4d43-ba84-53ae04c811f4"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("8112ff26-6207-444c-9cd8-5dfccc473139"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("6a9b9247-4dc6-4fa2-9781-8358c07f19f3"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("17215865-27c1-42eb-a35e-06a037619074"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("16852ae8-9d5f-4d75-8826-480809351e81"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("92671dc2-3162-489c-9cad-42d9fdece49f"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("c965517b-4ae5-4bf8-a2d0-f62edd03dd9e"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("5d0b5536-98de-4f4b-9e1b-16760b98a2d4"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("af7b3fec-40f1-4033-852b-7ce53b572297"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9cde4a67-ae69-4075-bffe-72b42763e034"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("14ea5b06-4dfa-46da-87f6-b76610faadf1"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("edd892b2-b394-48df-a6e3-9bd4616bacbf"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("3f7f65dc-6576-4221-b04a-e5f4a126c5b3"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("d992df1b-1605-4d4a-91db-10c184d89000"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("6366021a-fd14-49fe-b4a6-d0c9cda6677e"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("e1ba0c12-297d-4486-9def-03d844894bd0"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("367f2665-8158-405b-ab04-860512bd99ff"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("a392ebd4-e364-406d-a757-3c0e7c01e111"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("143a5a9f-cbfe-4bcc-aa39-76a34343cd65"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7b50ce2e-e4e5-40ae-8e79-19f8b23a937f"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("3c0adc5d-8c23-46b9-a5dd-c09b6b97dddf"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("bbfe4b06-162d-4526-ac67-e4b136fb20e6"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("a37a1755-26a0-4f64-881f-9a98ab6591c3"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("a1abd3a8-7663-4b81-b9c7-7a373af43186"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("79bd1fdb-a0b8-4d2e-8629-ad6ee46cfae5"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1eefed7d-9c27-456a-866c-1d3cec840aff"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b7f13bd2-baf0-48a7-a8e3-598270c2322f"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("ec4c2065-ffde-476b-96de-9208922061b5"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("bf0076dc-7473-4fd3-ab2e-daf0ece095c6"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("ba7dc736-c465-4163-a182-e1dc6b10af01"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("63292927-9eef-4f0e-a04c-0b6445dcf88e"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("b92c9029-26c5-47ba-9c30-4cdbae9934ce"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("bed04af4-f2dd-419e-b75f-3414d628bce6"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("3f74a80c-e8f2-4fae-aa8c-bd8fee62eeaf"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("8eaccc06-a884-44a3-8f9d-b0f27eb72417"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("bb02ac8b-3fcb-4d2b-9133-946492e81cef"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("6f5706d7-7167-412f-9347-034297635593"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("26ec628f-2e48-4850-875b-3153f344fb0f"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("22cd11ef-93e4-4ab9-a8c5-ff2d5a9e8511"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("e864f02b-402c-4726-bc75-168daa1b36f2"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("0bc4376b-c85a-43d9-9e8e-f3da3d4ec926"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("0aad20cc-2399-4d08-a188-79f247ce4a36"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("075fc2ae-dc6a-4526-96d4-732fb0a22446"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("4d5fa553-98e5-4a0e-ae54-da6bfea472bf"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5d37d5b4-abd4-4dd9-b0aa-26b4bad3f555"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("374a5c57-ece7-4700-a462-ba0761685229"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("b4926970-207d-4977-8236-4d336489ff14"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("ae78a143-d858-4f4f-89ae-d9cfae84e343"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("3801b582-72ef-4487-8fbc-ef0611e1683c"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("169d2d90-eee6-4f99-8d6e-f512e3d7f3a8"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("eedb13c3-7651-4cbd-90b7-35e3882456d8"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("6dbb5619-53be-4582-b187-6550a8b62680"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("f0b9a4d6-9940-425a-a39c-fe05b524698c"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("1a134dd9-738b-49b4-8ab8-6c3f68593e41"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("0936e1fc-2ea8-4180-9b33-3b239f1765d4"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("fd0b4d64-1ee7-47b8-b4ca-f071c0fd5774"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("dac037e4-8bd3-446a-9a80-566c3454c9bf"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("9f6a0175-2ffe-4e50-baed-3d919424f0a7"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("66c0878f-9092-4911-ad6e-70abc2db8814"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("6e2c09d6-d6a6-499b-aa2b-1c5912d42180"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7e134277-508f-4cf8-893e-913a58b39559"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("18970d0f-0c31-4033-9504-507a82a967fc"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("31ffc8da-d160-42dc-b4b4-b7ae82b9354c"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9f52888e-060f-4845-a53b-73ad0f25a40b"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("da2c0a3c-c968-45dd-b289-646e487e1c22"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("29c32816-d7c2-4ef0-9573-3a8da14394d2"), "Lab8", 25 },
                    { new Guid("4e55cc2a-3436-4ba0-8a66-4e93d4695952"), "Lab7", 69 },
                    { new Guid("14bbbe5d-45b7-47c2-a322-52a23c70a908"), "Lab6", 31 },
                    { new Guid("f2f69407-49cc-4e9b-89e8-e3ed67def202"), "Lab5", 27 },
                    { new Guid("ec774e82-c5b7-4ed4-9ba3-4271ee7c31fa"), "Lab1", 59 },
                    { new Guid("604009ac-d5e8-4a16-9345-808697e28c26"), "Lab3", 39 },
                    { new Guid("96b56fb9-c219-407d-8aba-6ed3e6ede307"), "Lab2", 66 },
                    { new Guid("7a44e7d3-cd24-4568-8ca4-d22f3bc26e85"), "Lab9", 60 },
                    { new Guid("e40361f5-febf-4c79-baf1-5657e38e6467"), "Lab4", 41 },
                    { new Guid("feda3858-e799-4927-8205-6164c04aba16"), "Lab10", 39 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentiPolagaatPredmeti_PredmetKodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                column: "PredmetKodNaPredmet");

            migrationBuilder.CreateIndex(
                name: "IX_StudentiPolagaatPredmeti_StudentBrojNaIndeks",
                table: "StudentiPolagaatPredmeti",
                column: "StudentBrojNaIndeks");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_PredmetKodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                column: "PredmetKodNaPredmet",
                principalTable: "Predmeti",
                principalColumn: "KodNaPredmet",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Studenti_StudentBrojNaIndeks",
                table: "StudentiPolagaatPredmeti",
                column: "StudentBrojNaIndeks",
                principalTable: "Studenti",
                principalColumn: "BrojNaIndeks",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_PredmetKodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Studenti_StudentBrojNaIndeks",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropIndex(
                name: "IX_StudentiPolagaatPredmeti_PredmetKodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropIndex(
                name: "IX_StudentiPolagaatPredmeti_StudentBrojNaIndeks",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("00f94e5f-ea93-45d7-a148-bcafa845b0df"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("03ae75c5-b9fc-43b9-b932-2b0a83ca32d7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("075fc2ae-dc6a-4526-96d4-732fb0a22446"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0936e1fc-2ea8-4180-9b33-3b239f1765d4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0aad20cc-2399-4d08-a188-79f247ce4a36"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0bc4376b-c85a-43d9-9e8e-f3da3d4ec926"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("143a5a9f-cbfe-4bcc-aa39-76a34343cd65"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("14ea5b06-4dfa-46da-87f6-b76610faadf1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("16852ae8-9d5f-4d75-8826-480809351e81"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("169d2d90-eee6-4f99-8d6e-f512e3d7f3a8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("17215865-27c1-42eb-a35e-06a037619074"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("18970d0f-0c31-4033-9504-507a82a967fc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1a134dd9-738b-49b4-8ab8-6c3f68593e41"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1eefed7d-9c27-456a-866c-1d3cec840aff"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1fc37329-7c24-4d43-ba84-53ae04c811f4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("22cd11ef-93e4-4ab9-a8c5-ff2d5a9e8511"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2531fb8a-fcc7-452a-90c7-1245cf24d8f6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("26ec628f-2e48-4850-875b-3153f344fb0f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2a2f9709-bf69-489d-a2da-d619dbf9c894"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2bb9f048-763d-4322-9fd5-669eb3864558"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("31ffc8da-d160-42dc-b4b4-b7ae82b9354c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3532bfd7-11db-4236-a305-d58e8d781e67"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("367f2665-8158-405b-ab04-860512bd99ff"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("374a5c57-ece7-4700-a462-ba0761685229"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3801b582-72ef-4487-8fbc-ef0611e1683c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3c0adc5d-8c23-46b9-a5dd-c09b6b97dddf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3f74a80c-e8f2-4fae-aa8c-bd8fee62eeaf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3f7f65dc-6576-4221-b04a-e5f4a126c5b3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("42ed7a39-7189-49c4-9c0a-a45eea3a55f6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4383bd8f-1d8d-4a7d-816c-5bf29709fd61"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4783d290-9d97-45db-b3c0-256c8a918073"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("48b69293-deec-4a24-9197-eb9772f87faa"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4d5fa553-98e5-4a0e-ae54-da6bfea472bf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4f06f9fa-d31f-4235-acf2-bdc691ae9689"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4f70b822-30c2-43d0-890b-3f7ab5010d4a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5b2f0ca3-1192-4127-8446-9d1cc925ca67"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5d0b5536-98de-4f4b-9e1b-16760b98a2d4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5d37d5b4-abd4-4dd9-b0aa-26b4bad3f555"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5de9e3c6-3976-4c74-ad19-8627596bb406"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("63292927-9eef-4f0e-a04c-0b6445dcf88e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6366021a-fd14-49fe-b4a6-d0c9cda6677e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("64c71e10-dff4-47fa-876e-2ba4a5f1651c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("66c0878f-9092-4911-ad6e-70abc2db8814"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6a9b9247-4dc6-4fa2-9781-8358c07f19f3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6dbb5619-53be-4582-b187-6550a8b62680"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6e2c09d6-d6a6-499b-aa2b-1c5912d42180"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6f5706d7-7167-412f-9347-034297635593"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("717b1539-c0d1-4c2d-a20c-643f197d3fc0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("79bd1fdb-a0b8-4d2e-8629-ad6ee46cfae5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7b50ce2e-e4e5-40ae-8e79-19f8b23a937f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7e134277-508f-4cf8-893e-913a58b39559"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8112ff26-6207-444c-9cd8-5dfccc473139"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("86211381-f425-4e50-a13c-cf48684825dc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8eaccc06-a884-44a3-8f9d-b0f27eb72417"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("92671dc2-3162-489c-9cad-42d9fdece49f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("93c060c4-8fd9-4d51-aafb-25c48bceecfb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9cde4a67-ae69-4075-bffe-72b42763e034"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9f52888e-060f-4845-a53b-73ad0f25a40b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9f6a0175-2ffe-4e50-baed-3d919424f0a7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a1abd3a8-7663-4b81-b9c7-7a373af43186"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a37a1755-26a0-4f64-881f-9a98ab6591c3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a392ebd4-e364-406d-a757-3c0e7c01e111"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a607c28f-bb7d-46a9-b177-28b67b185a11"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ae78a143-d858-4f4f-89ae-d9cfae84e343"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("af7b3fec-40f1-4033-852b-7ce53b572297"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b4926970-207d-4977-8236-4d336489ff14"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b7b481d9-4e22-4920-bb81-7fe981315a75"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b7f13bd2-baf0-48a7-a8e3-598270c2322f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b92c9029-26c5-47ba-9c30-4cdbae9934ce"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ba7dc736-c465-4163-a182-e1dc6b10af01"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bb02ac8b-3fcb-4d2b-9133-946492e81cef"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bbfe4b06-162d-4526-ac67-e4b136fb20e6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bed04af4-f2dd-419e-b75f-3414d628bce6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bf0076dc-7473-4fd3-ab2e-daf0ece095c6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c965517b-4ae5-4bf8-a2d0-f62edd03dd9e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d992df1b-1605-4d4a-91db-10c184d89000"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("da2c0a3c-c968-45dd-b289-646e487e1c22"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("dac037e4-8bd3-446a-9a80-566c3454c9bf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e1ba0c12-297d-4486-9def-03d844894bd0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e864f02b-402c-4726-bc75-168daa1b36f2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e93b496f-37ba-4972-83e6-61ddfd01f848"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("eb1d448e-9244-4e77-bab5-ad54d588972b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ec4c2065-ffde-476b-96de-9208922061b5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("edd892b2-b394-48df-a6e3-9bd4616bacbf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("eedb13c3-7651-4cbd-90b7-35e3882456d8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f0b9a4d6-9940-425a-a39c-fe05b524698c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f1e1c33c-dfaf-4161-9c23-eb4cb1e7421a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fd0b4d64-1ee7-47b8-b4ca-f071c0fd5774"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("14bbbe5d-45b7-47c2-a322-52a23c70a908"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("29c32816-d7c2-4ef0-9573-3a8da14394d2"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("4e55cc2a-3436-4ba0-8a66-4e93d4695952"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("604009ac-d5e8-4a16-9345-808697e28c26"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("7a44e7d3-cd24-4568-8ca4-d22f3bc26e85"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("96b56fb9-c219-407d-8aba-6ed3e6ede307"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("e40361f5-febf-4c79-baf1-5657e38e6467"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("ec774e82-c5b7-4ed4-9ba3-4271ee7c31fa"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("f2f69407-49cc-4e9b-89e8-e3ed67def202"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("feda3858-e799-4927-8205-6164c04aba16"));

            migrationBuilder.DropColumn(
                name: "PredmetKodNaPredmet",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.DropColumn(
                name: "StudentBrojNaIndeks",
                table: "StudentiPolagaatPredmeti");

            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("028d632c-c4d3-4902-ac07-27d68fc929fe"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("598cadcb-87fd-44f6-98d4-64c3c2963012"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("cbad1935-82af-4c21-a4cd-5048330cd30b"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("47ce4f80-d95b-4afa-8441-2e391794c05a"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("46b968a1-cadc-4c3b-84f4-ea186ea55760"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("389df58b-600f-4c33-894e-696f03f7fe29"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9fb890e0-b89c-4225-a672-4eb068568708"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("a4767592-efa1-45c3-86dc-5a35989ca0ee"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("40101837-02c8-4a60-abbc-9552c374c9c3"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("6bb979b1-f564-4289-902b-81359e2453a3"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("4d896537-f6ed-4b68-aaf0-0889b77e57d1"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("c5309821-87b1-4a05-b93a-324a14747842"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("11f4966a-1ebf-4e0d-be46-fed1000552f6"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("0ba48411-4d3c-4921-b620-a61cc62d49b0"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("0fb40248-019d-4ffa-b1cc-ac4e9377f696"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("bfd00edb-6dc0-4fb3-8462-f6c8d707b4ed"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("95d0d29b-5265-48f0-8315-30b1a01baa63"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("e6a738da-6e32-4db2-b82c-90f02518ca0e"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("f94c4aec-7c84-411e-9415-7438e8b62766"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("369e74e5-5317-4728-873f-2770ca4586f6"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("98f9a107-bdd0-4321-a7d2-48330ba81138"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("aaa1fe29-cf30-4f5e-9cc6-eed596d1aadc"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("c27a843a-b332-4f29-9a38-eeebd34184f0"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("b8c1131a-3239-4c46-8267-05c8fad70e95"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("fe81c9ca-494f-4550-9bb1-1bc2f78c0a0e"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("e9f4f8a1-0ada-4e78-aa2f-b1c316fe759d"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("6f180362-974f-46de-afc4-1a2f6e8026af"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7dda060e-c1f0-4bd0-a983-213378639c48"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("1b33d771-182c-4845-a920-a607c6f15dde"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5df5ae37-b064-4c44-b926-c859e3fd04e1"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1418ddae-b07c-4905-b17c-7c6718cc7b20"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("ccda599d-9869-4bf6-8c8c-a692a01c4f79"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("322f4cb3-e724-4fa6-9d40-8305b3f56762"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("ea82bbbf-bf54-4394-a79e-2414fb1c5dd3"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("19ef361c-fb81-491e-81f7-0a50c4eb104b"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("323325a5-392e-4069-8e6f-0abd936ad5fd"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("fb0d1274-0851-46b5-87e1-1719d80e3387"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("7296ac94-e2ca-4d6d-9682-adf1fcb5329c"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("1d3c3b4d-2535-4180-a3f4-8bc92f9217c8"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f9b18fed-5627-4bf6-a95d-76909eb22b92"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("48a47f88-ec1c-46a1-93e4-71518ab5e460"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1a00e3a7-d8d9-465a-afd2-35ea0346db25"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("51bf5534-0bc6-4618-8c7b-d058eaee4b25"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("56549d1b-3229-496f-8c2f-de4a0ac2f0eb"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("b448edb6-1b7b-4929-8b6a-60cceaf06ab0"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("ddf18499-8f39-45a4-bf81-0ffa68f5a112"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("962b712a-768d-4b56-bf2a-de8d993ad561"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("6c91cb3f-792a-4df2-b34e-486b5728ed38"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("500381d8-239e-445d-8fd8-9cdbb6c218de"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e7e221d5-ade9-4c97-97d0-d5b3809850d0"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("17b81370-7a94-4033-b9cd-1145864d6697"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9bfc7558-bbff-4bd2-957c-ac6674aacace"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("87f12e9e-b1c6-4f06-9f85-c993b89c2da7"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("98f11cb3-2b3c-4350-833b-c60ebd8730a1"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("a12372d2-4727-4f03-89c3-f8b4732c6851"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("4420ef93-1683-4f95-a48d-af47197e064c"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("149c82ea-9dbd-4835-b11d-4573749d724c"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("cd92bb7d-ee28-42a1-8fde-8b8f9a631e04"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("7557e6e2-dd14-4ba8-8069-f25c6e651cb7"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("d12f45be-1ae2-406b-8c47-73e6f20afb81"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("6feae9d7-8c30-4f82-971c-bdf6b8bad0cd"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("834d176a-3d67-4c3b-9bef-837cf6700409"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("52f1581d-940a-40cb-96ed-f8f807f7e9c4"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("cbf61184-1973-435e-bf0d-47f96cc1c5de"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("6ca12e41-a13c-4b00-a43d-4f63e2f6db5f"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("eb217222-987e-4232-8b3e-dd781894abfb"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e2c9bd8c-b849-4429-aa6d-5ebcd40ccc64"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d49a0bf7-9581-43d0-a441-43d2d30ebeef"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("21f96d16-e571-4aa6-b0a5-c573c9380e9d"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("8943fa80-318c-4ba2-8c29-cb446e6c1130"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e526add0-30a2-4846-a139-e00843b8b529"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("a93497a2-b9c2-438c-8703-452e20972a91"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("c1c1a4b3-ed57-4cbd-917f-9fe41209f1ef"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("db0298bd-7e67-4daa-8b16-49ff5466f319"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("fd50cee5-158d-44cb-bab5-d59407974a73"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("cbf9d196-7bca-4b79-a1b4-58a419bce4b8"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("5b30389c-9bde-4065-8a00-226cf3a3b88f"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("9deba456-83a8-4312-b107-d7bf9940e9c4"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b969b8e2-b702-4b80-99c3-cfa2c1feff94"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("732e77f2-6ec0-4795-b13d-430a7ecd0a69"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("71b71da8-6c4d-4778-97ef-619b8e528d1b"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("5f026603-cf62-4e17-930d-10c38226bf3b"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("47efe2e3-c179-4b78-ae1a-975b38179d52"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("ffa98946-03d4-44e5-a29d-974ace4c28d5"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("2e43a01c-fc0b-49e4-9e57-d5d0df475865"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("25b07181-2652-41bc-b791-18c645d9946c"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("b466fc47-e7cf-45c1-9244-2ac770a793ec"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5d6e95f2-970f-4a4d-9e3f-5d169e96cb12"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("bf6e53b9-95af-44c3-8c17-8c821ce61950"), "Lab8", 31 },
                    { new Guid("ff54fa23-f37a-418a-a779-e08815bc5ed3"), "Lab7", 61 },
                    { new Guid("56f8626b-11a6-4f3b-8df1-851bad49dc7b"), "Lab6", 68 },
                    { new Guid("e45c2e6f-c1bb-4e0f-9462-a4de6cf47719"), "Lab5", 60 },
                    { new Guid("5653e31f-1cb7-4de5-916c-b2d08b35f626"), "Lab1", 67 },
                    { new Guid("27de4f58-f127-475d-8655-a19cc705f906"), "Lab3", 44 },
                    { new Guid("73bc8ce4-97ae-4d06-95bb-6fe8bcc6c8ba"), "Lab2", 33 },
                    { new Guid("88f2f612-a680-4996-8afa-eb004c7e253e"), "Lab9", 40 },
                    { new Guid("fef6769d-f0e5-4a93-a3bc-d016e7c0cc49"), "Lab4", 64 },
                    { new Guid("7663d668-0a04-49d8-91d6-05ad6877e808"), "Lab10", 62 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentiPolagaatPredmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                column: "KodNaPredmet");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Studenti_BrojNaIndeks",
                table: "StudentiPolagaatPredmeti",
                column: "BrojNaIndeks",
                principalTable: "Studenti",
                principalColumn: "BrojNaIndeks",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentiPolagaatPredmeti_Predmeti_KodNaPredmet",
                table: "StudentiPolagaatPredmeti",
                column: "KodNaPredmet",
                principalTable: "Predmeti",
                principalColumn: "KodNaPredmet",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
