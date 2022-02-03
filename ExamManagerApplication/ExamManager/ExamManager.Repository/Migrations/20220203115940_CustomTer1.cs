using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class CustomTer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_CustomTermini_CustomTerminId",
                table: "Studenti");

            migrationBuilder.DropTable(
                name: "CustomTermini");

            migrationBuilder.DropIndex(
                name: "IX_Studenti_CustomTerminId",
                table: "Studenti");

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0073536f-770c-43fd-a7c8-7670e5a678ed"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0436c671-bb2b-4f14-89c0-c13d021bc2fa"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("05f0dd9a-9c8a-4861-b401-477830ad39b3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("079196da-fec3-497e-a2ba-fdbe15115f5c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("081681e9-97b7-49c3-8102-2271ad650d8d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("081a0c95-5c73-40e0-80a2-b62c363dcfb0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("08f781a5-b43a-454f-b952-35dfa9328a06"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0ce4c9de-bb7a-4bff-9468-38ec79c642f2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("11457e73-469c-4b1c-9d01-2b623b11aea0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("136f180a-fc55-482e-bdad-f8925ebbc559"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("159d1080-3bcd-4247-83f2-7bf72165f7a8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("195f8ef1-ded2-415a-abd9-1371ee9e19e9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1dcd87c9-5f9f-4191-9a8a-083ae8a53596"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1e3c89f8-3480-44de-b2c4-74819bbaf475"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("213408b2-e062-431c-a762-3b732a9d2e98"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("22a58392-2299-4b48-8c4f-0de46f9961fb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2bdf4eea-7cc2-460c-abfe-657d789469d1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2e5301b7-5619-4dc5-9eac-21de97adf265"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2f39fa1a-c2a7-45ed-9ffd-9b8098d768f4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("30460fed-972b-4305-b9df-8512aebd983b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("30beaebf-5205-4b25-9b42-4fd91ecd70a2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("33b0d92e-ca82-4a96-85c0-b025b77dcc20"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("34195ed7-d59a-4955-a448-15b2eea7f373"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3487c1ec-4aab-4e53-90f7-2da21d386455"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3ee4deef-fd86-4fc2-b505-752392deb1e7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3fb9b84d-883b-43f0-80ef-49f0d61ed7e0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4053a5d4-ba3d-4b80-80b9-b021fdfff1a3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("425c4d68-6e2a-465c-8366-9b8d25d7afd1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("435cf35a-3772-4720-96f8-ad3e6df64d21"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("451d93d2-f194-4500-af91-259e69f46e18"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("45b86dea-5127-4118-8341-2adcdb53bb9b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4ba725a7-ad2f-4fa5-8c3f-95f094eac5d6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4c75f603-99bb-4a5a-87ba-2de7f802b8b6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4de50f54-4422-4d8d-853f-7bc725b89c17"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4e8137c7-43fd-440d-9e95-47d99fbf6f47"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4ea1b14b-619c-4f22-be29-acfbd28a100c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("54c00297-674b-466c-9b42-cfec4edef1bc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("58c57e0c-ba37-4f24-8f45-5cf79f87edfd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5a26978e-03ec-4dbf-8bf5-bd044c2df917"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5ed51765-2d26-4222-95b6-471e332696a5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("613dd6b2-4946-4597-b995-1771131c02ec"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("64e40e86-de1b-4966-ba1c-ef874fa9713d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("68fa744a-6de3-4474-8de3-acb482334e5a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6a51da4d-0f80-4019-a065-84ca117b9c88"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("703c6268-e543-4124-99a3-db41d246ec5f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("71d4f1a0-d1ff-4b8a-8002-3797ab1ee835"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7bdbe9cc-75e1-41b8-b217-20f70041f33a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("83655173-82ed-464b-b6f3-23b06c1030fc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("844b2fd8-52f1-4360-a8ba-486c9b782b2c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("86aa5242-8ff5-4a1b-903c-ec884ba394b3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("897fc451-d056-4b56-b7ce-90f5063d654d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8b4d29d7-c73c-48e4-9816-2123efab6d1f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8fbf6277-2ac8-4d97-871d-9710168b5d90"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("90d8c81b-e55b-484f-804f-658d9232b7cb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("95de80f4-d335-4939-84e0-6f6432e25ae0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a0fcb630-9f7e-49fb-9ab5-95c3157ce5bf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a7403048-cc44-451e-8ed2-7ce0466dbee5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a7a0d97b-5082-44a8-9a60-867c0fb0f6d1"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a8dda17d-8e1e-4ddb-8189-f91290cfa862"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("aa45f7e1-ee6e-47f7-a793-bfbb7c30e9e7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("acdcd97a-5ffe-4511-9c12-9a7cd3b275d6"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b26098f3-ebe2-4d16-ab6a-7e3bfbb66d75"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b4a73cf6-18a9-42c5-ad0c-3794fd4b4df3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b4e9bf3c-c4eb-4532-9364-e8cfffa20111"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b63cfa13-441d-4dcd-84e1-c67486d72394"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b9467fbe-c37e-4726-b2f2-55ab27c17198"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c3043089-cfd0-4e77-bd06-2b4056700624"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c38797d5-4271-40d1-8ef4-a121185062d7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cc7ee885-2aaa-4da8-a3df-92860dfcf199"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cd228039-1604-4e89-9452-31158fe4c4e3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cdecae76-42ca-471f-8394-932b15f00afc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cf4e65fa-e1a0-4980-83f7-688770b11a41"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("cfa76b68-1363-4b07-b416-0b2d24e32f35"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d163d951-53c1-4c2b-8de4-73381ff0bca5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d2fe8eea-f443-44ee-9797-9fa1c6df2228"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d63529f1-0a8f-4b3c-b89d-822ee0be0a38"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d6dd83e5-d501-4050-a1ad-717c8817eb8d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e0566a1b-4e06-4669-85c5-53b78afbed64"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e2fe47fb-0d3d-47ea-bfa4-00a98069d265"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e512a632-4425-44a6-98fc-185666b95fcc"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ef0fbe33-17bd-4173-8e5b-3c217d0e266e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f24ff960-10eb-4558-b5ef-5e4c7e99fbae"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f31526e3-ffb2-49c8-8a77-775baa16ab77"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f4c6eb5d-3687-4b6e-b440-d200159413d2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f636f0c7-054b-43b4-bc43-90e5fb44356f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fc226249-ae10-4df0-8e4b-cc17a620b792"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ff721149-276d-4a44-b02f-3dc7b08e491c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ff76901d-2a15-4e7f-9869-72c1be89411d"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("4dc93224-83d0-4023-81be-acda2b3f9709"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("6f27f03c-1e2b-4608-b7e0-9197ba17415e"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("7002ca17-8e69-40a8-bb52-2be7fed6eb1f"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("72864472-8b74-4343-816b-a4f10fb8ffa7"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("8b554385-5b5f-4799-bc3d-67a5d8c9e893"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("9445c39b-ca12-4e51-9229-ab949a450360"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("98350ffa-9104-46c4-b28d-ddbf58c4d737"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("a708169a-a72b-426d-8bbf-bd90fd23ef8c"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("acc1786e-6fd5-4e0b-96fb-3d90913d9e6c"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("c849a7db-c2cb-4b24-995f-0b0fbe837772"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "CustomTermini",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duration = table.Column<int>(type: "int", nullable: false),
                    examId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    roomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacherId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timeSlot = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomTermini", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("34195ed7-d59a-4955-a448-15b2eea7f373"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("83655173-82ed-464b-b6f3-23b06c1030fc"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("ff76901d-2a15-4e7f-9869-72c1be89411d"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("90d8c81b-e55b-484f-804f-658d9232b7cb"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("f636f0c7-054b-43b4-bc43-90e5fb44356f"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("4ea1b14b-619c-4f22-be29-acfbd28a100c"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("58c57e0c-ba37-4f24-8f45-5cf79f87edfd"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("0ce4c9de-bb7a-4bff-9468-38ec79c642f2"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("a7a0d97b-5082-44a8-9a60-867c0fb0f6d1"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("e0566a1b-4e06-4669-85c5-53b78afbed64"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d6dd83e5-d501-4050-a1ad-717c8817eb8d"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("213408b2-e062-431c-a762-3b732a9d2e98"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("f24ff960-10eb-4558-b5ef-5e4c7e99fbae"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("897fc451-d056-4b56-b7ce-90f5063d654d"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("c3043089-cfd0-4e77-bd06-2b4056700624"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("4c75f603-99bb-4a5a-87ba-2de7f802b8b6"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("ef0fbe33-17bd-4173-8e5b-3c217d0e266e"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("cd228039-1604-4e89-9452-31158fe4c4e3"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("5a26978e-03ec-4dbf-8bf5-bd044c2df917"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("cc7ee885-2aaa-4da8-a3df-92860dfcf199"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("d63529f1-0a8f-4b3c-b89d-822ee0be0a38"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("2e5301b7-5619-4dc5-9eac-21de97adf265"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("54c00297-674b-466c-9b42-cfec4edef1bc"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("45b86dea-5127-4118-8341-2adcdb53bb9b"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("3487c1ec-4aab-4e53-90f7-2da21d386455"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("4053a5d4-ba3d-4b80-80b9-b021fdfff1a3"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("081a0c95-5c73-40e0-80a2-b62c363dcfb0"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("a8dda17d-8e1e-4ddb-8189-f91290cfa862"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("c38797d5-4271-40d1-8ef4-a121185062d7"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("b9467fbe-c37e-4726-b2f2-55ab27c17198"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("aa45f7e1-ee6e-47f7-a793-bfbb7c30e9e7"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d163d951-53c1-4c2b-8de4-73381ff0bca5"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("136f180a-fc55-482e-bdad-f8925ebbc559"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("451d93d2-f194-4500-af91-259e69f46e18"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("3fb9b84d-883b-43f0-80ef-49f0d61ed7e0"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("703c6268-e543-4124-99a3-db41d246ec5f"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("1dcd87c9-5f9f-4191-9a8a-083ae8a53596"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("081681e9-97b7-49c3-8102-2271ad650d8d"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("8b4d29d7-c73c-48e4-9816-2123efab6d1f"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("844b2fd8-52f1-4360-a8ba-486c9b782b2c"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("ff721149-276d-4a44-b02f-3dc7b08e491c"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b26098f3-ebe2-4d16-ab6a-7e3bfbb66d75"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b63cfa13-441d-4dcd-84e1-c67486d72394"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("f4c6eb5d-3687-4b6e-b440-d200159413d2"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("b4e9bf3c-c4eb-4532-9364-e8cfffa20111"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("8fbf6277-2ac8-4d97-871d-9710168b5d90"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("acdcd97a-5ffe-4511-9c12-9a7cd3b275d6"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("b4a73cf6-18a9-42c5-ad0c-3794fd4b4df3"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("64e40e86-de1b-4966-ba1c-ef874fa9713d"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("079196da-fec3-497e-a2ba-fdbe15115f5c"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("3ee4deef-fd86-4fc2-b505-752392deb1e7"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("6a51da4d-0f80-4019-a065-84ca117b9c88"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("cfa76b68-1363-4b07-b416-0b2d24e32f35"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("2bdf4eea-7cc2-460c-abfe-657d789469d1"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("613dd6b2-4946-4597-b995-1771131c02ec"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("e2fe47fb-0d3d-47ea-bfa4-00a98069d265"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1e3c89f8-3480-44de-b2c4-74819bbaf475"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("cf4e65fa-e1a0-4980-83f7-688770b11a41"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("a0fcb630-9f7e-49fb-9ab5-95c3157ce5bf"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("68fa744a-6de3-4474-8de3-acb482334e5a"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("7bdbe9cc-75e1-41b8-b217-20f70041f33a"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("cdecae76-42ca-471f-8394-932b15f00afc"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("22a58392-2299-4b48-8c4f-0de46f9961fb"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("0436c671-bb2b-4f14-89c0-c13d021bc2fa"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("4de50f54-4422-4d8d-853f-7bc725b89c17"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("435cf35a-3772-4720-96f8-ad3e6df64d21"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e512a632-4425-44a6-98fc-185666b95fcc"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("11457e73-469c-4b1c-9d01-2b623b11aea0"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("33b0d92e-ca82-4a96-85c0-b025b77dcc20"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("0073536f-770c-43fd-a7c8-7670e5a678ed"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("05f0dd9a-9c8a-4861-b401-477830ad39b3"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("425c4d68-6e2a-465c-8366-9b8d25d7afd1"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("fc226249-ae10-4df0-8e4b-cc17a620b792"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("95de80f4-d335-4939-84e0-6f6432e25ae0"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("2f39fa1a-c2a7-45ed-9ffd-9b8098d768f4"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("a7403048-cc44-451e-8ed2-7ce0466dbee5"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("4ba725a7-ad2f-4fa5-8c3f-95f094eac5d6"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("86aa5242-8ff5-4a1b-903c-ec884ba394b3"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("30460fed-972b-4305-b9df-8512aebd983b"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("71d4f1a0-d1ff-4b8a-8002-3797ab1ee835"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("159d1080-3bcd-4247-83f2-7bf72165f7a8"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("195f8ef1-ded2-415a-abd9-1371ee9e19e9"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("d2fe8eea-f443-44ee-9797-9fa1c6df2228"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("30beaebf-5205-4b25-9b42-4fd91ecd70a2"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("5ed51765-2d26-4222-95b6-471e332696a5"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("4e8137c7-43fd-440d-9e95-47d99fbf6f47"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("f31526e3-ffb2-49c8-8a77-775baa16ab77"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("08f781a5-b43a-454f-b952-35dfa9328a06"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("9445c39b-ca12-4e51-9229-ab949a450360"), "Lab8", 27 },
                    { new Guid("6f27f03c-1e2b-4608-b7e0-9197ba17415e"), "Lab7", 53 },
                    { new Guid("4dc93224-83d0-4023-81be-acda2b3f9709"), "Lab6", 52 },
                    { new Guid("8b554385-5b5f-4799-bc3d-67a5d8c9e893"), "Lab5", 57 },
                    { new Guid("acc1786e-6fd5-4e0b-96fb-3d90913d9e6c"), "Lab1", 59 },
                    { new Guid("a708169a-a72b-426d-8bbf-bd90fd23ef8c"), "Lab3", 51 },
                    { new Guid("72864472-8b74-4343-816b-a4f10fb8ffa7"), "Lab2", 61 },
                    { new Guid("7002ca17-8e69-40a8-bb52-2be7fed6eb1f"), "Lab9", 60 },
                    { new Guid("c849a7db-c2cb-4b24-995f-0b0fbe837772"), "Lab4", 69 },
                    { new Guid("98350ffa-9104-46c4-b28d-ddbf58c4d737"), "Lab10", 65 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_CustomTerminId",
                table: "Studenti",
                column: "CustomTerminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_CustomTermini_CustomTerminId",
                table: "Studenti",
                column: "CustomTerminId",
                principalTable: "CustomTermini",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
