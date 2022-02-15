using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class newTermin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Prostorii_ProstorijaId",
                table: "Termini");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Sproveduvaci_SproveduvacId",
                table: "Termini");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Ispiti_ispitId",
                table: "Termini");

            migrationBuilder.DropIndex(
                name: "IX_Termini_SproveduvacId",
                table: "Termini");

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("007b7d16-db8f-4dcb-9968-3181af9a2ea0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("082ea15a-62ef-43bf-bed4-3c6216211a1f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("08ef73f5-8f6b-412d-8b9b-51ed0649bd89"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0dea44af-796d-42f5-9709-8e71dcb74194"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("161e6a33-a657-4fd7-a4a7-6ea2468c4ba4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1a0e9332-df96-4adf-bf67-e57b2f217f50"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1c807b7f-79fb-4762-85d5-434f7d891134"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1ef441d1-0944-4ba8-a5a2-43b86bb27294"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1f89701f-f149-4510-86f8-dce2ab5b0c99"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("20028133-714d-4e70-924d-2ae0a47e2716"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("24d9ba21-fd2d-47fe-abfd-c0f869fcfb18"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2af4d82c-c56a-4436-8482-800761baa68d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2e0b1b64-c8d3-495d-85ce-c72a5f3475f1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("30df14eb-4234-429c-8582-ee71aa6f31f0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("30fbfa9d-1348-4d42-a9b0-4db6d61872b3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("315dcae1-3d37-4601-b020-5d0eca9951e8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("34715873-aa57-4a61-96c3-48ab2b64553d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3c635f2c-9452-4140-9180-7bd317e88a20"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("46694e06-5eec-4302-8b71-ab70a79fbd0b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4d849f08-fb67-4735-81ca-221362f8eb34"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("528c0974-d2d8-483c-9b21-f2e013896111"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5511eff9-300f-4034-a4a3-576d39b7dd3f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5eb4243b-5272-43f0-8e29-3a2cac489714"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("60a2940a-49b8-40b9-8a97-dea4a97bc5ba"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("61109feb-1bd7-4d25-8180-125c24f7b718"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("62c78b25-166c-407b-af13-e384c09f3cdf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("644f96e3-4e39-435f-8bec-2859e9899cfc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("64995b9c-7d65-4c69-b3fc-84609e37a90e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6527352e-c4a0-4c2c-a977-44e760bda775"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("685b76aa-9eb4-4640-baa7-ed6849e504fb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("69c94d48-0b55-423a-8fa8-2428f725e57c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6a960216-955a-4f55-a191-6c282088cfe4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6be98900-2dd5-4e0f-bf69-3656cf3a9e7e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6c247230-685c-4bb1-8bc7-49413ef5a50d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6ef85bd6-4a9a-4ad1-80fb-42f6eae460ab"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6f489eaa-3256-4c75-9044-10ec5c3fd02e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("72039313-b6bd-4885-817a-b57d57fd7270"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7656c6ad-15cd-4918-889b-90a1bb2323cd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7f881092-209b-4211-8dd7-0eda21a6b2b2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("845c783f-22e0-472b-9f18-33b4a903b5b7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("86cb57a3-84ad-4bda-b1d8-f09cd9165806"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("87da6f72-f145-4d46-9e27-ec106d3e3cee"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("886c2eb5-30db-4c6c-a774-9c90bccd3e00"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("89ee444d-5492-4e13-bf5a-e394c890f213"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8b73299f-6c4b-4757-864c-d8a71867280c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8fe4b945-35f8-48c4-8d6e-542f514f8967"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("920c3bfc-8158-4aff-9967-89184124545d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9a3eca5d-3dc1-4e94-a67b-5597ddec05e2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a32e5998-974d-489c-9008-9bccfe30807b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a4a33ce3-5e2e-423e-b0d9-e8a6fcafcbb0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a562e654-920b-4529-81c4-5d15689d81e2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a5bfb4da-33ae-41a2-941a-aa4d41f951ff"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a7ec30a5-f4a9-443f-8a47-2c138ca43718"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a94175c9-78f5-465e-840e-10951b6e1630"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ad21b128-0723-4aed-82ee-093cd82a6604"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ae50c3ac-0413-48a4-b5b6-7c081fb8e15f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b093684b-79fd-4029-b162-ea66c45b1cb0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b32b3d5e-6b7b-4719-93ab-c52b7f1f39a8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b5fed29b-abda-4978-b1f7-ae4b31813a85"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b6d3e23c-900b-4082-9354-dbe2cb17193b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c27ac53b-7b2f-46ab-ab2c-62ae0628fa78"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c54749a4-c440-4aed-95b2-147207660690"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c66b78ca-6ff9-4e06-abff-67cf7ceb9d21"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cdc48787-c78b-4671-b983-ca843a9a63b9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ce53daf6-ca71-45f0-9554-e4ed62cf91ec"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d0bdff66-c125-44fe-af12-aaf3c23b55e3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d317a0a9-cd40-435c-9e41-e6797fb38163"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d31f090e-7141-4b5e-9f5e-c92d115c1c6d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d36c2391-01dd-477c-90a5-9505285e05ff"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d735abd6-2cb5-4621-8cda-f750c8479412"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("da5194cf-294c-4ae0-a24a-244f728c82ce"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("daa7f0e6-8ff5-46b9-9746-e7358b933461"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("db499fbb-c799-4941-9558-bc2359388f41"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("de84654e-49d6-4e2c-90c3-bba7bdf36ef4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("decdb5b9-4e8a-475d-8c48-b86a1eecd510"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("df0c446f-55d9-40ba-be50-11b6d0d103c0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e34fc304-3282-4c47-9536-b5f9844f639d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e39f2817-ad0e-4c82-80f3-7e9f6511c89d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e8c35391-f655-40e6-9e04-88e55f2247fc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e93109d2-b1e6-42ea-b4b3-ca0b44cb10e3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e99fcef2-42aa-466e-8051-486f0df483e5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ea7a6259-af58-4abf-91c7-78d491cfccde"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f0c56999-bd1f-42cb-a99c-b20fd0d02ff8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f2c09e25-8120-4ba5-8cd8-3573d889fa16"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f443b3a7-0b42-4c85-b6c3-29a0a476571f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f7a6b508-74a0-4460-a494-1cebaf121809"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f9b52ed8-ce50-4c6b-a634-63bd7f84323c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fbbfc827-5cdb-47c1-9417-d799da189c2b"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("18dd7d5b-547c-4422-800b-87c2cf12f72f"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("2678fa84-46b9-4471-ab51-ae4f2e971b98"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("4472e492-0eca-448f-84a4-7eb0cbddc0e9"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("5b7fd895-efe2-4a76-96c2-4ca4b1411e12"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("9452b9e2-3f57-4b86-9451-47cea79d5b7b"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("94eef234-7c1a-447c-ba99-5b21be5d5140"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("c2b9b425-9c81-4636-9f1b-cd2499349351"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("e225ae78-2b24-487a-9f38-dacc772b4432"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("e6e3523d-22ed-4fa1-bf2b-2110bc5145d8"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("f79c78bf-6277-4c31-8f74-197364d4523c"));

            migrationBuilder.DropColumn(
                name: "SproveduvacId",
                table: "Termini");

            migrationBuilder.RenameColumn(
                name: "ispitId",
                table: "Termini",
                newName: "IspitId");

            migrationBuilder.RenameIndex(
                name: "IX_Termini_ispitId",
                table: "Termini",
                newName: "IX_Termini_IspitId");

            migrationBuilder.AlterColumn<Guid>(
                name: "IspitId",
                table: "Termini",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProstorijaId",
                table: "Termini",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Dezuren",
                table: "Termini",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Predmet",
                table: "Termini",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prostorija",
                table: "Termini",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentiPolagaatVoTermin",
                table: "Termini",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sproveduvaci_Termini_SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Ispiti_IspitId",
                table: "Termini");

            migrationBuilder.DropForeignKey(
                name: "FK_Termini_Prostorii_ProstorijaId",
                table: "Termini");

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
                name: "Dezuren",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "Predmet",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "Prostorija",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "StudentiPolagaatVoTermin",
                table: "Termini");

            migrationBuilder.DropColumn(
                name: "SproveduvacDezuraVoTerminId",
                table: "Sproveduvaci");

            migrationBuilder.RenameColumn(
                name: "IspitId",
                table: "Termini",
                newName: "ispitId");

            migrationBuilder.RenameIndex(
                name: "IX_Termini_IspitId",
                table: "Termini",
                newName: "IX_Termini_ispitId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProstorijaId",
                table: "Termini",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ispitId",
                table: "Termini",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SproveduvacId",
                table: "Termini",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("72039313-b6bd-4885-817a-b57d57fd7270"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("decdb5b9-4e8a-475d-8c48-b86a1eecd510"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("528c0974-d2d8-483c-9b21-f2e013896111"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("62c78b25-166c-407b-af13-e384c09f3cdf"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("db499fbb-c799-4941-9558-bc2359388f41"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("007b7d16-db8f-4dcb-9968-3181af9a2ea0"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("a7ec30a5-f4a9-443f-8a47-2c138ca43718"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("0dea44af-796d-42f5-9709-8e71dcb74194"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("6a960216-955a-4f55-a191-6c282088cfe4"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("08ef73f5-8f6b-412d-8b9b-51ed0649bd89"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("7656c6ad-15cd-4918-889b-90a1bb2323cd"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("89ee444d-5492-4e13-bf5a-e394c890f213"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("ce53daf6-ca71-45f0-9554-e4ed62cf91ec"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("8b73299f-6c4b-4757-864c-d8a71867280c"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("d0bdff66-c125-44fe-af12-aaf3c23b55e3"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("24d9ba21-fd2d-47fe-abfd-c0f869fcfb18"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("6ef85bd6-4a9a-4ad1-80fb-42f6eae460ab"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("1a0e9332-df96-4adf-bf67-e57b2f217f50"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("20028133-714d-4e70-924d-2ae0a47e2716"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("d317a0a9-cd40-435c-9e41-e6797fb38163"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("e99fcef2-42aa-466e-8051-486f0df483e5"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b093684b-79fd-4029-b162-ea66c45b1cb0"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("ea7a6259-af58-4abf-91c7-78d491cfccde"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("d31f090e-7141-4b5e-9f5e-c92d115c1c6d"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("c66b78ca-6ff9-4e06-abff-67cf7ceb9d21"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("920c3bfc-8158-4aff-9967-89184124545d"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("1c807b7f-79fb-4762-85d5-434f7d891134"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1f89701f-f149-4510-86f8-dce2ab5b0c99"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("d735abd6-2cb5-4621-8cda-f750c8479412"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("ad21b128-0723-4aed-82ee-093cd82a6604"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e8c35391-f655-40e6-9e04-88e55f2247fc"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("4d849f08-fb67-4735-81ca-221362f8eb34"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("e39f2817-ad0e-4c82-80f3-7e9f6511c89d"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("6527352e-c4a0-4c2c-a977-44e760bda775"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("69c94d48-0b55-423a-8fa8-2428f725e57c"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("fbbfc827-5cdb-47c1-9417-d799da189c2b"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("2af4d82c-c56a-4436-8482-800761baa68d"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("3c635f2c-9452-4140-9180-7bd317e88a20"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("a94175c9-78f5-465e-840e-10951b6e1630"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("e93109d2-b1e6-42ea-b4b3-ca0b44cb10e3"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f0c56999-bd1f-42cb-a99c-b20fd0d02ff8"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("845c783f-22e0-472b-9f18-33b4a903b5b7"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("60a2940a-49b8-40b9-8a97-dea4a97bc5ba"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("5eb4243b-5272-43f0-8e29-3a2cac489714"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("6be98900-2dd5-4e0f-bf69-3656cf3a9e7e"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("f2c09e25-8120-4ba5-8cd8-3573d889fa16"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("a32e5998-974d-489c-9008-9bccfe30807b"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("9a3eca5d-3dc1-4e94-a67b-5597ddec05e2"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("6c247230-685c-4bb1-8bc7-49413ef5a50d"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("886c2eb5-30db-4c6c-a774-9c90bccd3e00"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("685b76aa-9eb4-4640-baa7-ed6849e504fb"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("61109feb-1bd7-4d25-8180-125c24f7b718"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("da5194cf-294c-4ae0-a24a-244f728c82ce"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("30fbfa9d-1348-4d42-a9b0-4db6d61872b3"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("e34fc304-3282-4c47-9536-b5f9844f639d"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("f9b52ed8-ce50-4c6b-a634-63bd7f84323c"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1ef441d1-0944-4ba8-a5a2-43b86bb27294"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5511eff9-300f-4034-a4a3-576d39b7dd3f"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("30df14eb-4234-429c-8582-ee71aa6f31f0"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("b6d3e23c-900b-4082-9354-dbe2cb17193b"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("a562e654-920b-4529-81c4-5d15689d81e2"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("2e0b1b64-c8d3-495d-85ce-c72a5f3475f1"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("644f96e3-4e39-435f-8bec-2859e9899cfc"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("8fe4b945-35f8-48c4-8d6e-542f514f8967"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("ae50c3ac-0413-48a4-b5b6-7c081fb8e15f"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("7f881092-209b-4211-8dd7-0eda21a6b2b2"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("6f489eaa-3256-4c75-9044-10ec5c3fd02e"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("f7a6b508-74a0-4460-a494-1cebaf121809"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("f443b3a7-0b42-4c85-b6c3-29a0a476571f"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("87da6f72-f145-4d46-9e27-ec106d3e3cee"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b32b3d5e-6b7b-4719-93ab-c52b7f1f39a8"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("161e6a33-a657-4fd7-a4a7-6ea2468c4ba4"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("34715873-aa57-4a61-96c3-48ab2b64553d"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("a5bfb4da-33ae-41a2-941a-aa4d41f951ff"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("a4a33ce3-5e2e-423e-b0d9-e8a6fcafcbb0"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("86cb57a3-84ad-4bda-b1d8-f09cd9165806"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("d36c2391-01dd-477c-90a5-9505285e05ff"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("b5fed29b-abda-4978-b1f7-ae4b31813a85"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("082ea15a-62ef-43bf-bed4-3c6216211a1f"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("c27ac53b-7b2f-46ab-ab2c-62ae0628fa78"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("64995b9c-7d65-4c69-b3fc-84609e37a90e"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("df0c446f-55d9-40ba-be50-11b6d0d103c0"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("46694e06-5eec-4302-8b71-ab70a79fbd0b"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("daa7f0e6-8ff5-46b9-9746-e7358b933461"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("de84654e-49d6-4e2c-90c3-bba7bdf36ef4"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("cdc48787-c78b-4671-b983-ca843a9a63b9"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("315dcae1-3d37-4601-b020-5d0eca9951e8"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("c54749a4-c440-4aed-95b2-147207660690"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("9452b9e2-3f57-4b86-9451-47cea79d5b7b"), "Lab8", 53 },
                    { new Guid("f79c78bf-6277-4c31-8f74-197364d4523c"), "Lab7", 66 },
                    { new Guid("c2b9b425-9c81-4636-9f1b-cd2499349351"), "Lab6", 67 },
                    { new Guid("18dd7d5b-547c-4422-800b-87c2cf12f72f"), "Lab5", 58 },
                    { new Guid("2678fa84-46b9-4471-ab51-ae4f2e971b98"), "Lab1", 56 },
                    { new Guid("4472e492-0eca-448f-84a4-7eb0cbddc0e9"), "Lab3", 45 },
                    { new Guid("e6e3523d-22ed-4fa1-bf2b-2110bc5145d8"), "Lab2", 55 },
                    { new Guid("e225ae78-2b24-487a-9f38-dacc772b4432"), "Lab9", 51 },
                    { new Guid("94eef234-7c1a-447c-ba99-5b21be5d5140"), "Lab4", 37 },
                    { new Guid("5b7fd895-efe2-4a76-96c2-4ca4b1411e12"), "Lab10", 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Termini_SproveduvacId",
                table: "Termini",
                column: "SproveduvacId",
                unique: true,
                filter: "[SproveduvacId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Prostorii_ProstorijaId",
                table: "Termini",
                column: "ProstorijaId",
                principalTable: "Prostorii",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Sproveduvaci_SproveduvacId",
                table: "Termini",
                column: "SproveduvacId",
                principalTable: "Sproveduvaci",
                principalColumn: "SproveduvacId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Termini_Ispiti_ispitId",
                table: "Termini",
                column: "ispitId",
                principalTable: "Ispiti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
