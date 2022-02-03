using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamManager.Repository.Migrations
{
    public partial class finalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ispiti",
                columns: new[] { "Id", "BrojNaTermin", "KodNaPredmet", "PolaganjeDo", "PolaganjeOd", "VremetraenjeNaTerminVoMinuti" },
                values: new object[,]
                {
                    { new Guid("b265f643-d630-4b98-b1d9-959d30a70ea9"), 6, "F18L2W046", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("550b57e2-31ef-40a1-81c1-016cd54599b4"), 4, "F18L1S015", new DateTime(2021, 9, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("eb36668c-9fe7-4ccc-98fa-73ccbb59f2b4"), 3, "F18L1S034", new DateTime(2021, 9, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("0c3a8413-b6f1-44b2-a91d-b72f457c69bf"), 2, "F18L2S110", new DateTime(2021, 9, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("6a0df84c-679e-4065-882b-d43621fce6de"), 4, "F18L3S091", new DateTime(2021, 9, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d68bcd09-4647-4585-b5dc-ceba3715f042"), 2, "F18L3S141", new DateTime(2021, 9, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("2899b72c-fbb8-4d7b-a731-9e6c8e36aec2"), 4, "F18L1S023", new DateTime(2021, 9, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("1125fcd2-9b99-47a3-8340-2a247ab52923"), 2, "F18L3S059", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("3691a82a-896e-4db5-b1c9-a461368ddb28"), 3, "F18L3S094", new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("4877ff6d-f22c-4efc-9abe-939e0b52807d"), 2, "F18L2S082", new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("ad55146e-1312-4414-8fd6-efbd4366ce31"), 2, "F18L2S017", new DateTime(2021, 9, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("82f3a0e7-7271-4011-bf09-ce91a19a6285"), 2, "F18L3S138", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("a9a1d5ef-b97b-4601-b1ae-c51f266c9cac"), 3, "F18L2S030", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("5e6cfc62-4155-4ab4-98c6-5998435a7592"), 3, "F18L3S107", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("9358c2ca-d0bd-4d4d-810f-230f02a5f66e"), 2, "F18L3S019", new DateTime(2021, 9, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("4a186f1e-c04e-461f-85d1-c923cfbe7e25"), 3, "F18L3S086", new DateTime(2021, 9, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("5778e364-dd31-4e10-976d-14c81d50b8ad"), 2, "F18L1S032", new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("50acf34b-9e40-4a9c-a266-a49d960fd9b7"), 6, "F18L1S045", new DateTime(2021, 9, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("19aedfd9-552c-43d8-af1a-69787ab4446e"), 2, "F18L3S155", new DateTime(2021, 9, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7a2728c3-30c9-4150-8393-fbc6b5501829"), 4, "F18L3S130", new DateTime(2021, 9, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("92e7a9e4-4a1e-4436-8d67-b860450af8bd"), 5, "F18L2S029", new DateTime(2021, 9, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d2bbb885-d0a6-4fcd-86ec-7eb1a70ec851"), 3, "F18L1S016", new DateTime(2021, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("01e98aef-f6d6-4e48-8703-16075691f0f2"), 4, "F18L3S010", new DateTime(2021, 9, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("61492afc-9cfe-4076-844b-64ee093c6bf8"), 2, "F18L3S122", new DateTime(2021, 9, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("1b1bfdb8-a9b5-428f-88c1-38aa6224b495"), 2, "F18L3W043", new DateTime(2021, 9, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("dbbf66f3-718c-4146-ab31-527b68c7b176"), 4, "F18L2S119", new DateTime(2021, 9, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("bcdb2b58-a4c4-4885-b95f-ec69d4b100bd"), 4, "F18L1S120", new DateTime(2021, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("8f8923a9-87b5-4fcd-99a9-959cd0914235"), 4, "F18L1S026", new DateTime(2021, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("91e6e48c-1ac6-463a-ad43-6b562d0c6c99"), 4, "F18L2S097", new DateTime(2021, 9, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("133c23ea-2f69-488e-9a41-7420bd05ecc8"), 4, "F18L3S028", new DateTime(2021, 9, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("688ce181-7eeb-4ef8-a46c-f0a0bf4e7187"), 3, "F18L3S025", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("567e0654-c24e-4442-be04-2133bd188a0b"), 3, "F18L1S116", new DateTime(2021, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d29edecd-44a6-4614-89e3-563b96673df0"), 4, "F18L1S146", new DateTime(2021, 9, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("894e61d8-69f6-41e5-b548-5b3bebbfefbd"), 2, "F18L3S118", new DateTime(2021, 9, 13, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("9fce1bf2-53ab-4557-aaf8-015a02b20c12"), 2, "F18L3S135", new DateTime(2021, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("2ad3624b-348b-4247-9b1a-7068e0279846"), 4, "F18L3S157", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("7767a523-62f2-4ad2-9396-22403010545c"), 6, "F18L2S084", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("980bfa04-3f24-4fb9-a88a-b6ba50049bcf"), 3, "F18L1S003", new DateTime(2021, 9, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("810cdf53-fd1b-4fd3-814e-3fafa713e019"), 4, "F18L3W085", new DateTime(2021, 9, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("2d4dac3c-e7b5-4bd0-ab6b-bce1dd396da2"), 4, "F18L1W070", new DateTime(2021, 9, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("d8ea2d24-d2a8-4fd4-b4fb-34c388471f29"), 4, "F18L3S022", new DateTime(2021, 9, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("f4b7c1eb-3c02-43dd-9d28-884639c1cf0b"), 4, "F18L2S124", new DateTime(2021, 9, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("b768e3a0-024d-41b8-92ee-472d872716b7"), 4, "F18L3S063", new DateTime(2021, 9, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("8015e74e-edfe-460b-9673-b38f166d36c7"), 4, "F18L3S166", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("b0153766-7968-443e-9e9a-ff4cb5e5a378"), 4, "F18L3S077", new DateTime(2021, 9, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("a2c69f65-8839-4489-98ee-579ccc6bb2cd"), 3, "F18L2S002", new DateTime(2021, 9, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { new Guid("50d8f2c8-d252-4783-95cb-fc25539e9482"), 6, "F18L2W001", new DateTime(2021, 8, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("ba01ca22-5d16-461b-b46d-9aac15f0295a"), 4, "F18L3W027", new DateTime(2021, 8, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("fb192fbc-cb7d-46f2-91b1-b620e9671920"), 4, "F18L1W041", new DateTime(2021, 8, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("70f2590f-f53a-4bb5-8b56-199621280c66"), 6, "F18L3W126", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("7cd06f10-91d5-4260-948c-d361a4641736"), 3, "F18L3W044", new DateTime(2021, 8, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("f7001188-7078-4d90-aee9-85b41efc1d76"), 4, "F18L1W020", new DateTime(2021, 8, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("ec109d4b-e89d-4478-b1cf-440199b855ba"), 3, "F18L3W004", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("e6e05e84-cd7b-4f92-8955-fe0edec51815"), 2, "F18L1W033", new DateTime(2021, 8, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("0a874255-de1e-45ca-9865-53f54e8bb116"), 4, "F18L3W075", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("73537052-56ef-4ed3-bd9f-d606aded422f"), 3, "F18L3W008", new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("b77af795-bcc7-4ed0-ac9f-7117b2c496cb"), 4, "F18L3W064", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("061e8493-046a-4e6f-a724-f207b54aa92b"), 4, "F18L3W060", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("b15e9313-81d2-4c0c-9142-917c7dcd85ac"), 4, "F18L3W134", new DateTime(2021, 8, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("ae396f59-d57c-4cbb-89a1-2436c56e71b5"), 2, "F18L2W006", new DateTime(2021, 8, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), 180 },
                    { new Guid("94cd40a4-6a9f-4880-9e8a-fccf97ec2dfd"), 2, "F18L1W007", new DateTime(2021, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("88ca8043-7d3c-4c74-b353-891d6ffd87b0"), 3, "F18L3W024", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("1cfc115e-1880-4c63-8ddb-9ff165efbcd5"), 5, "F18L3W103", new DateTime(2021, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("4e2f9586-2ef1-4326-bd2b-05f4ba7255c8"), 4, "F18L1W031", new DateTime(2021, 8, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("7145adb0-7b6f-4080-a6d5-2c2d89532b2d"), 2, "F18L2S099", new DateTime(2021, 9, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("33cfb530-92e1-49a0-8d01-6fe100c2e242"), 2, "F18L3W105", new DateTime(2021, 8, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("818bca71-1ab2-4df8-b388-0ab2eafbcaf7"), 2, "F18L2W104", new DateTime(2021, 8, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("443f875e-d467-4fd0-a236-b22b5fdbc41d"), 2, "F18L1S013", new DateTime(2021, 8, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("ffd00e05-a1e0-48b9-a804-57ce9e075b87"), 3, "F18L3W136", new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("a0e4bb09-d55d-4164-9dc6-7b1924a55a7f"), 4, "F18L1S052", new DateTime(2021, 9, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("598adeb5-f96a-4476-8a8c-1df78e749daa"), 3, "F18L3S036", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("947d5a01-0633-40c6-b8bc-fe42361956ba"), 3, "F18L1W049", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("f8c1fb81-834b-47b8-b670-7f5524a6a732"), 2, "F18L3W035", new DateTime(2021, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("b351c8c8-b314-4114-bafd-c22b7b7d61a4"), 2, "F18L3W137", new DateTime(2021, 9, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("e5358be6-1a3a-4a61-a373-c90ff77f8395"), 2, "F18L2W109", new DateTime(2021, 9, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { new Guid("16f93991-664f-4965-9bce-1e246a1303e3"), 4, "F18L1W011", new DateTime(2021, 9, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { new Guid("c312dba8-ad7f-480c-b8bd-b48fd6749bda"), 4, "F18L1W005", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("3d0d580a-5317-4d15-9ebe-f647465cbaba"), 2, "F18L3W129", new DateTime(2021, 8, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("102c52bd-d0c9-4edb-8e9e-843538559100"), 4, "F18L2W067", new DateTime(2021, 9, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("e82e32a2-71f5-48f3-84b3-6de8aa5263ef"), 4, "F18L3S040", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("57e8dcf7-4a23-457d-aeb3-337d333b8968"), 6, "F18L3W060", new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("edff7351-e80e-4587-bcd8-b7de3d698d0f"), 6, "F18L3W009", new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { new Guid("1b80ee6c-b7b3-4a52-89f4-a3f7d9cc6b3e"), 2, "F18L2W140", new DateTime(2021, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { new Guid("e7902c71-34f6-4834-992e-fbed7425030e"), 4, "F18L3W037", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("07682800-fe32-46a4-b10a-b8256bd763ba"), 2, "F18L3W079", new DateTime(2021, 8, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("7ff3db87-7575-49d7-b1b6-c1199aae9b86"), 4, "F18L2W167", new DateTime(2021, 8, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { new Guid("d47422a0-6bdd-427a-ad2d-8572cd729c09"), 4, "F18L2S100", new DateTime(2021, 8, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 11, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { new Guid("e49796f8-c5be-454c-b13f-d86fc071e11e"), 4, "F18L3W050", new DateTime(2021, 8, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 45 }
                });

            migrationBuilder.InsertData(
                table: "PredmetiOdStudiskaPrograma",
                columns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                values: new object[,]
                {
                    { "F18L3W074", "Software engineering and information systems" },
                    { "F18L3W075", "Компјутерски науки" },
                    { "F18L3W075", "Software engineering and information systems" },
                    { "F18L3W075", "Софтверско инженерство и информациски системи" },
                    { "F18L3W074", "Компјутерски науки" },
                    { "F18L3W074", "Интернет мрежи и безбедност" },
                    { "F18L3W074", "Компјутерско инженерство" },
                    { "F18L3W075", "Интернет мрежи и безбедност" },
                    { "F18L3W075", "Примена на информациски технологии" },
                    { "F18L3W079", "Примена на информациски технологии" },
                    { "F18L3W085", "Компјутерски науки" },
                    { "F18L3W079", "Software engineering and information systems" },
                    { "F18L3W079", "Компјутерски науки" },
                    { "F18L3W079", "Компјутерско инженерство" },
                    { "F18L3W079", "Интернет мрежи и безбедност" },
                    { "F18L3W085", "Примена на информациски технологии" },
                    { "F18L3W085", "Софтверско инженерство и информациски системи" },
                    { "F18L3W085", "Software engineering and information systems" },
                    { "F18L3W085", "Компјутерско инженерство" },
                    { "F18L3W074", "Софтверско инженерство и информациски системи" },
                    { "F18L3W079", "Софтверско инженерство и информациски системи" },
                    { "F18L3W074", "Примена на информациски технологии" },
                    { "F18L3S047", "Software engineering and information systems" },
                    { "F18L3W068", "Компјутерско инженерство" },
                    { "F18L3W085", "Компјутерска едукација" },
                    { "F18L3S047", "Софтверско инженерство и информациски системи" },
                    { "F18L3S047", "Компјутерски науки" },
                    { "F18L3S047", "Компјутерско инженерство" },
                    { "F18L3S158", "Компјутерски науки" },
                    { "F18L3S158", "Компјутерско инженерство" },
                    { "F18L3S163", "Софтверско инженерство и информациски системи" },
                    { "F18L3S163", "Software engineering and information systems" },
                    { "F18L3S163", "Компјутерски науки" },
                    { "F18L3W068", "Интернет мрежи и безбедност" },
                    { "F18L3S163", "Компјутерско инженерство" },
                    { "F18L3S153", "Компјутерско инженерство" },
                    { "F18L3S166", "Компјутерска едукација" },
                    { "F18L3W064", "Компјутерски науки" },
                    { "F18L3W064", "Компјутерско инженерство" },
                    { "F18L3W064", "Интернет мрежи и безбедност" },
                    { "F18L3W068", "Примена на информациски технологии" },
                    { "F18L3W068", "Софтверско инженерство и информациски системи" },
                    { "F18L3W068", "Software engineering and information systems" },
                    { "F18L3W068", "Компјутерски науки" },
                    { "F18L3S153", "Компјутерски науки" },
                    { "F18L3W085", "Интернет мрежи и безбедност" },
                    { "F18L3W128", "Компјутерски науки" },
                    { "F18L3W088", "Софтверско инженерство и информациски системи" },
                    { "F18L3W123", "Софтверско инженерство и информациски системи" },
                    { "F18L3W123", "Software engineering and information systems" },
                    { "F18L3W123", "Компјутерски науки" },
                    { "F18L3W123", "Компјутерско инженерство" },
                    { "F18L3W123", "Компјутерска едукација" },
                    { "F18L3W123", "Интернет мрежи и безбедност" },
                    { "F18L3W126", "Примена на информациски технологии" },
                    { "F18L3W126", "Софтверско инженерство и информациски системи" },
                    { "F18L3W126", "Software engineering and information systems" },
                    { "F18L3W123", "Примена на информациски технологии" },
                    { "F18L3W126", "Компјутерски науки" },
                    { "F18L3W126", "Компјутерска едукација" },
                    { "F18L3W126", "Интернет мрежи и безбедност" },
                    { "F18L3W128", "Примена на информациски технологии" },
                    { "F18L3W128", "Софтверско инженерство и информациски системи" },
                    { "F18L3W128", "Software engineering and information systems" },
                    { "F18L3S150", "Компјутерско инженерство" },
                    { "F18L3W128", "Компјутерско инженерство" },
                    { "F18L3W128", "Компјутерска едукација" },
                    { "F18L3W128", "Интернет мрежи и безбедност" },
                    { "F18L3W126", "Компјутерско инженерство" },
                    { "F18L3W105", "Интернет мрежи и безбедност" },
                    { "F18L3W105", "Software engineering and information systems" },
                    { "F18L3W105", "Софтверско инженерство и информациски системи" },
                    { "F18L3W088", "Software engineering and information systems" },
                    { "F18L3W088", "Компјутерски науки" },
                    { "F18L3W088", "Компјутерско инженерство" },
                    { "F18L3W088", "Интернет мрежи и безбедност" },
                    { "F18L3W092", "Примена на информациски технологии" },
                    { "F18L3W092", "Софтверско инженерство и информациски системи" },
                    { "F18L3W092", "Software engineering and information systems" },
                    { "F18L3W092", "Компјутерски науки" },
                    { "F18L3W092", "Компјутерско инженерство" },
                    { "F18L3W092", "Компјутерска едукација" },
                    { "F18L3W092", "Интернет мрежи и безбедност" },
                    { "F18L3W098", "Компјутерско инженерство" },
                    { "F18L3W098", "Интернет мрежи и безбедност" },
                    { "F18L3W103", "Примена на информациски технологии" },
                    { "F18L3W103", "Софтверско инженерство и информациски системи" },
                    { "F18L3W103", "Software engineering and information systems" },
                    { "F18L3W103", "Компјутерски науки" },
                    { "F18L3W103", "Компјутерско инженерство" },
                    { "F18L3W103", "Компјутерска едукација" },
                    { "F18L3W103", "Интернет мрежи и безбедност" },
                    { "F18L3W105", "Примена на информациски технологии" },
                    { "F18L3W088", "Примена на информациски технологии" },
                    { "F18L3S150", "Компјутерски науки" },
                    { "F18L3S135", "Компјутерско инженерство" },
                    { "F18L3S150", "Софтверско инженерство и информациски системи" },
                    { "F18L3S010", "Компјутерски науки" },
                    { "F18L3S010", "Компјутерско инженерство" },
                    { "F18L3S010", "Компјутерска едукација" },
                    { "F18L3S010", "Интернет мрежи и безбедност" },
                    { "F18L3S025", "Примена на информациски технологии" },
                    { "F18L3S025", "Софтверско инженерство и информациски системи" },
                    { "F18L3S025", "Software engineering and information systems" },
                    { "F18L3S025", "Компјутерски науки" },
                    { "F18L3S025", "Интернет мрежи и безбедност" },
                    { "F18L3S010", "Software engineering and information systems" },
                    { "F18L3S111", "Интернет мрежи и безбедност" },
                    { "F18L3S118", "Софтверско инженерство и информациски системи" },
                    { "F18L3S118", "Software engineering and information systems" },
                    { "F18L3S118", "Компјутерски науки" },
                    { "F18L3S118", "Компјутерско инженерство" },
                    { "F18L3S118", "Компјутерска едукација" },
                    { "F18L3S118", "Интернет мрежи и безбедност" },
                    { "F18L3S122", "Компјутерски науки" },
                    { "F18L3S122", "Компјутерско инженерство" },
                    { "F18L3S122", "Интернет мрежи и безбедност" },
                    { "F18L3S118", "Примена на информациски технологии" },
                    { "F18L3S125", "Компјутерски науки" },
                    { "F18L3S010", "Софтверско инженерство и информациски системи" },
                    { "F18L3S093", "Интернет мрежи и безбедност" },
                    { "F18L3S077", "Компјутерски науки" },
                    { "F18L3S077", "Компјутерско инженерство" },
                    { "F18L3S077", "Интернет мрежи и безбедност" },
                    { "F18L3S040", "Примена на информациски технологии" },
                    { "F18L3S040", "Софтверско инженерство и информациски системи" },
                    { "F18L3S040", "Software engineering and information systems" },
                    { "F18L3S040", "Компјутерски науки" },
                    { "F18L3S040", "Компјутерско инженерство" },
                    { "F18L3S040", "Интернет мрежи и безбедност" },
                    { "F18L3S010", "Примена на информациски технологии" },
                    { "F18L3S087", "Примена на информациски технологии" },
                    { "F18L3S087", "Software engineering and information systems" },
                    { "F18L3S087", "Компјутерски науки" },
                    { "F18L3S087", "Компјутерско инженерство" },
                    { "F18L3S087", "Интернет мрежи и безбедност" },
                    { "F18L3S093", "Софтверско инженерство и информациски системи" },
                    { "F18L3S093", "Software engineering and information systems" },
                    { "F18L3S093", "Компјутерски науки" },
                    { "F18L3S093", "Компјутерско инженерство" },
                    { "F18L3S093", "Компјутерска едукација" },
                    { "F18L3S087", "Софтверско инженерство и информациски системи" },
                    { "F18L3S125", "Компјутерско инженерство" },
                    { "F18L3S125", "Интернет мрежи и безбедност" },
                    { "F18L3S135", "Примена на информациски технологии" },
                    { "F18L3S019", "Компјутерско инженерство" },
                    { "F18L3S019", "Компјутерска едукација" },
                    { "F18L3S036", "Примена на информациски технологии" },
                    { "F18L3S036", "Софтверско инженерство и информациски системи" },
                    { "F18L3S036", "Software engineering and information systems" },
                    { "F18L3S036", "Компјутерски науки" },
                    { "F18L3S036", "Компјутерско инженерство" },
                    { "F18L3S039", "Софтверско инженерство и информациски системи" },
                    { "F18L3S039", "Software engineering and information systems" },
                    { "F18L3S019", "Компјутерски науки" },
                    { "F18L3S039", "Компјутерски науки" },
                    { "F18L3S012", "Софтверско инженерство и информациски системи" },
                    { "F18L3S012", "Software engineering and information systems" },
                    { "F18L3S012", "Компјутерски науки" },
                    { "F18L3S012", "Компјутерско инженерство" },
                    { "F18L3S149", "Софтверско инженерство и информациски системи" },
                    { "F18L3S149", "Software engineering and information systems" },
                    { "F18L3S149", "Компјутерски науки" },
                    { "F18L3S149", "Компјутерско инженерство" },
                    { "F18L3S150", "Примена на информациски технологии" },
                    { "F18L3S012", "Примена на информациски технологии" },
                    { "F18L3S019", "Software engineering and information systems" },
                    { "F18L3S019", "Софтверско инженерство и информациски системи" },
                    { "F18L3S019", "Примена на информациски технологии" },
                    { "F18L3S135", "Софтверско инженерство и информациски системи" },
                    { "F18L3S135", "Software engineering and information systems" },
                    { "F18L3S135", "Компјутерски науки" },
                    { "F18L3W129", "Примена на информациски технологии" },
                    { "F18L3S135", "Компјутерска едукација" },
                    { "F18L3S135", "Интернет мрежи и безбедност" },
                    { "F18L3S155", "Примена на информациски технологии" },
                    { "F18L3S155", "Софтверско инженерство и информациски системи" },
                    { "F18L3S155", "Software engineering and information systems" },
                    { "F18L3S155", "Компјутерски науки" },
                    { "F18L3S155", "Компјутерско инженерство" },
                    { "F18L3S155", "Компјутерска едукација" },
                    { "F18L3S155", "Интернет мрежи и безбедност" },
                    { "F18L3S159", "Примена на информациски технологии" },
                    { "F18L3S159", "Софтверско инженерство и информациски системи" },
                    { "F18L3S159", "Software engineering and information systems" },
                    { "F18L3S159", "Интернет мрежи и безбедност" },
                    { "F18L3S056", "Компјутерска едукација" },
                    { "F18L3S071", "Компјутерска едукација" },
                    { "F18L3S057", "Компјутерска едукација" },
                    { "F18L3S094", "Компјутерска едукација" },
                    { "F18L3S150", "Software engineering and information systems" },
                    { "F18L3W129", "Софтверско инженерство и информациски системи" },
                    { "F18L3W072", "Компјутерско инженерство" },
                    { "F18L3W129", "Компјутерски науки" },
                    { "F18L3S132", "Компјутерски науки" },
                    { "F18L3S132", "Компјутерско инженерство" },
                    { "F18L3S132", "Интернет мрежи и безбедност" },
                    { "F18L3S138", "Примена на информациски технологии" },
                    { "F18L3S138", "Софтверско инженерство и информациски системи" },
                    { "F18L3S138", "Software engineering and information systems" },
                    { "F18L3S138", "Компјутерски науки" },
                    { "F18L3S138", "Компјутерско инженерство" },
                    { "F18L3S138", "Интернет мрежи и безбедност" },
                    { "F18L3S132", "Software engineering and information systems" },
                    { "F18L3S139", "Компјутерски науки" },
                    { "F18L3S141", "Примена на информациски технологии" },
                    { "F18L3S141", "Софтверско инженерство и информациски системи" },
                    { "F18L3S141", "Software engineering and information systems" },
                    { "F18L3S141", "Компјутерски науки" },
                    { "F18L3S141", "Компјутерско инженерство" },
                    { "F18L3S141", "Компјутерска едукација" },
                    { "F18L3S141", "Интернет мрежи и безбедност" },
                    { "F18L3S028", "Примена на информациски технологии" },
                    { "F18L3S028", "Софтверско инженерство и информациски системи" },
                    { "F18L3S139", "Интернет мрежи и безбедност" },
                    { "F18L3S028", "Software engineering and information systems" },
                    { "F18L3S132", "Софтверско инженерство и информациски системи" },
                    { "F18L3S130", "Интернет мрежи и безбедност" },
                    { "F18L3S091", "Интернет мрежи и безбедност" },
                    { "F18L3S101", "Компјутерско инженерство" },
                    { "F18L3S101", "Интернет мрежи и безбедност" },
                    { "F18L3S107", "Примена на информациски технологии" },
                    { "F18L3S107", "Софтверско инженерство и информациски системи" },
                    { "F18L3S107", "Software engineering and information systems" },
                    { "F18L3S107", "Компјутерски науки" },
                    { "F18L3S107", "Компјутерско инженерство" },
                    { "F18L3S107", "Компјутерска едукација" },
                    { "F18L3S132", "Примена на информациски технологии" },
                    { "F18L3S107", "Интернет мрежи и безбедност" },
                    { "F18L3S127", "Софтверско инженерство и информациски системи" },
                    { "F18L3S127", "Software engineering and information systems" },
                    { "F18L3S127", "Компјутерски науки" },
                    { "F18L3S127", "Компјутерско инженерство" },
                    { "F18L3S127", "Компјутерска едукација" },
                    { "F18L3S127", "Интернет мрежи и безбедност" },
                    { "F18L3S130", "Примена на информациски технологии" },
                    { "F18L3S130", "Софтверско инженерство и информациски системи" },
                    { "F18L3S130", "Software engineering and information systems" },
                    { "F18L3S127", "Примена на информациски технологии" },
                    { "F18L3S028", "Компјутерски науки" },
                    { "F18L3S028", "Компјутерско инженерство" },
                    { "F18L3S028", "Компјутерска едукација" },
                    { "F18L3S113", "Софтверско инженерство и информациски системи" },
                    { "F18L3S113", "Software engineering and information systems" },
                    { "F18L3S113", "Компјутерски науки" },
                    { "F18L3S113", "Компјутерско инженерство" },
                    { "F18L3S113", "Компјутерска едукација" },
                    { "F18L3S07", "Примена на информациски технологии" },
                    { "F18L3S07", "Софтверско инженерство и информациски системи" },
                    { "F18L3S07", "Software engineering and information systems" },
                    { "F18L3S07", "Компјутерски науки" },
                    { "F18L3S113", "Примена на информациски технологии" },
                    { "F18L3S07", "Компјутерско инженерство" },
                    { "F18L3S102", "Софтверско инженерство и информациски системи" },
                    { "F18L3S102", "Software engineering and information systems" },
                    { "F18L3S102", "Компјутерски науки" },
                    { "F18L3S106", "Примена на информациски технологии" },
                    { "F18L3S106", "Софтверско инженерство и информациски системи" },
                    { "F18L3S106", "Software engineering and information systems" },
                    { "F18L3S106", "Компјутерски науки" },
                    { "F18L3S151", "Компјутерски науки" },
                    { "F18L3S112", "Компјутерски науки" },
                    { "F18L3S102", "Примена на информациски технологии" },
                    { "F18L3S086", "Компјутерска едукација" },
                    { "F18L3S086", "Компјутерско инженерство" },
                    { "F18L3S086", "Компјутерски науки" },
                    { "F18L3S028", "Интернет мрежи и безбедност" },
                    { "F18L3S157", "Примена на информациски технологии" },
                    { "F18L3S157", "Софтверско инженерство и информациски системи" },
                    { "F18L3S157", "Software engineering and information systems" },
                    { "F18L3S157", "Компјутерски науки" },
                    { "F18L3S157", "Интернет мрежи и безбедност" },
                    { "F18L3S022", "Примена на информациски технологии" },
                    { "F18L3S022", "Софтверско инженерство и информациски системи" },
                    { "F18L3S022", "Software engineering and information systems" },
                    { "F18L3S022", "Компјутерски науки" },
                    { "F18L3S022", "Компјутерско инженерство" },
                    { "F18L3S022", "Компјутерска едукација" },
                    { "F18L3S022", "Интернет мрежи и безбедност" },
                    { "F18L3S083", "Софтверско инженерство и информациски системи" },
                    { "F18L3S083", "Software engineering and information systems" },
                    { "F18L3S083", "Компјутерски науки" },
                    { "F18L3S083", "Компјутерско инженерство" },
                    { "F18L3S083", "Компјутерска едукација" },
                    { "F18L3S086", "Примена на информациски технологии" },
                    { "F18L3S086", "Софтверско инженерство и информациски системи" },
                    { "F18L3S086", "Software engineering and information systems" },
                    { "F18L3S091", "Компјутерски науки" },
                    { "F18L3S091", "Software engineering and information systems" },
                    { "F18L3S091", "Софтверско инженерство и информациски системи" },
                    { "F18L3S091", "Примена на информациски технологии" },
                    { "F18L3W152", "Компјутерска едукација" },
                    { "F18L3W161", "Примена на информациски технологии" },
                    { "F18L3W161", "Софтверско инженерство и информациски системи" },
                    { "F18L3W161", "Software engineering and information systems" },
                    { "F18L3W161", "Компјутерски науки" },
                    { "F18L3W161", "Компјутерско инженерство" },
                    { "F18L3W161", "Компјутерска едукација" },
                    { "F18L3W038", "Примена на информациски технологии" },
                    { "F18L3W038", "Софтверско инженерство и информациски системи" },
                    { "F18L3W152", "Компјутерско инженерство" },
                    { "F18L3W038", "Software engineering and information systems" },
                    { "F18L3W038", "Компјутерско инженерство" },
                    { "F18L3W072", "Примена на информациски технологии" },
                    { "F18L3W072", "Софтверско инженерство и информациски системи" },
                    { "F18L3W072", "Software engineering and information systems" },
                    { "F18L3W072", "Компјутерски науки" },
                    { "F18L3S077", "Software engineering and information systems" },
                    { "F18L3W076", "Компјутерски науки" },
                    { "F18L3W089", "Примена на информациски технологии" },
                    { "F18L3W089", "Софтверско инженерство и информациски системи" },
                    { "F18L3W038", "Компјутерски науки" },
                    { "F18L3W152", "Компјутерски науки" },
                    { "F18L3W152", "Software engineering and information systems" },
                    { "F18L3W152", "Софтверско инженерство и информациски системи" },
                    { "F18L3W129", "Компјутерско инженерство" },
                    { "F18L3W129", "Компјутерска едукација" },
                    { "F18L3W129", "Интернет мрежи и безбедност" },
                    { "F18L3W133", "Компјутерско инженерство" },
                    { "F18L3W133", "Интернет мрежи и безбедност" },
                    { "F18L3W145", "Компјутерски науки" },
                    { "F18L3W145", "Компјутерско инженерство" },
                    { "F18L3W145", "Интернет мрежи и безбедност" },
                    { "F18L3W108", "Примена на информациски технологии" },
                    { "F18L3W108", "Софтверско инженерство и информациски системи" },
                    { "F18L3W108", "Software engineering and information systems" },
                    { "F18L3W108", "Компјутерски науки" },
                    { "F18L3W108", "Компјутерско инженерство" },
                    { "F18L3W108", "Компјутерска едукација" },
                    { "F18L3W137", "Примена на информациски технологии" },
                    { "F18L3W137", "Софтверско инженерство и информациски системи" },
                    { "F18L3W137", "Software engineering and information systems" },
                    { "F18L3W137", "Компјутерски науки" },
                    { "F18L3W137", "Компјутерско инженерство" },
                    { "F18L3W137", "Компјутерска едукација" },
                    { "F18L3W152", "Примена на информациски технологии" },
                    { "F18L3W089", "Software engineering and information systems" },
                    { "F18L3W129", "Software engineering and information systems" },
                    { "F18L3W089", "Компјутерски науки" },
                    { "F18L3W131", "Компјутерски науки" },
                    { "F18L3W048", "Компјутерско инженерство" },
                    { "F18L3W160", "Примена на информациски технологии" },
                    { "F18L3W160", "Софтверско инженерство и информациски системи" },
                    { "F18L3W160", "Software engineering and information systems" },
                    { "F18L3W160", "Интернет мрежи и безбедност" },
                    { "F18L3S063", "Компјутерско инженерство" },
                    { "F18L3S063", "Интернет мрежи и безбедност" },
                    { "F18L3S121", "Примена на информациски технологии" },
                    { "F18L3S121", "Софтверско инженерство и информациски системи" },
                    { "F18L3W048", "Компјутерски науки" },
                    { "F18L3S121", "Software engineering and information systems" },
                    { "F18L3S121", "Компјутерско инженерство" },
                    { "F18L3S121", "Компјутерска едукација" },
                    { "F18L3S121", "Интернет мрежи и безбедност" },
                    { "F18L3S080", "Примена на информациски технологии" },
                    { "F18L3S080", "Софтверско инженерство и информациски системи" },
                    { "F18L3S080", "Software engineering and information systems" },
                    { "F18L3S080", "Компјутерски науки" },
                    { "F18L3S080", "Компјутерско инженерство" },
                    { "F18L3S080", "Интернет мрежи и безбедност" },
                    { "F18L3S121", "Компјутерски науки" },
                    { "F18L3W048", "Software engineering and information systems" },
                    { "F18L3W048", "Софтверско инженерство и информациски системи" },
                    { "F18L3W048", "Примена на информациски технологии" },
                    { "F18L3W131", "Компјутерско инженерство" },
                    { "F18L3W142", "Софтверско инженерство и информациски системи" },
                    { "F18L3W142", "Software engineering and information systems" },
                    { "F18L3W142", "Компјутерски науки" },
                    { "F18L3W144", "Софтверско инженерство и информациски системи" },
                    { "F18L3W144", "Software engineering and information systems" },
                    { "F18L3W144", "Компјутерски науки" },
                    { "F18L3W144", "Компјутерско инженерство" },
                    { "F18L3W154", "Софтверско инженерство и информациски системи" },
                    { "F18L3W154", "Software engineering and information systems" },
                    { "F18L3W154", "Компјутерски науки" },
                    { "F18L3W156", "Примена на информациски технологии" },
                    { "F18L3W156", "Софтверско инженерство и информациски системи" },
                    { "F18L3W156", "Software engineering and information systems" },
                    { "F18L3W156", "Компјутерски науки" },
                    { "F18L3W117", "Компјутерско инженерство" },
                    { "F18L3W027", "Примена на информациски технологии" },
                    { "F18L3W027", "Софтверско инженерство и информациски системи" },
                    { "F18L3W027", "Software engineering and information systems" },
                    { "F18L3W027", "Компјутерски науки" },
                    { "F18L3W027", "Компјутерско инженерство" },
                    { "F18L3W089", "Компјутерско инженерство" },
                    { "F18L3S077", "Софтверско инженерство и информациски системи" },
                    { "F18L3W037", "Компјутерски науки" },
                    { "F18L3S073", "Интернет мрежи и безбедност" },
                    { "F18L2W046", "Интернет мрежи и безбедност" },
                    { "F18L2W067", "Интернет мрежи и безбедност" },
                    { "F18L2W104", "Софтверско инженерство и информациски системи" },
                    { "F18L2W104", "Software engineering and information systems" },
                    { "F18L2W104", "Компјутерски науки" },
                    { "F18L2W104", "Компјутерско инженерство" },
                    { "F18L2W104", "Интернет мрежи и безбедност" },
                    { "F18L2W109", "Примена на информациски технологии" },
                    { "F18L2W109", "Софтверско инженерство и информациски системи" },
                    { "F18L2W046", "Компјутерско инженерство" },
                    { "F18L2W109", "Software engineering and information systems" },
                    { "F18L2W109", "Компјутерско инженерство" },
                    { "F18L2W109", "Компјутерска едукација" },
                    { "F18L2W109", "Интернет мрежи и безбедност" },
                    { "F18L2W140", "Примена на информациски технологии" },
                    { "F18L2W140", "Софтверско инженерство и информациски системи" },
                    { "F18L2W140", "Software engineering and information systems" },
                    { "F18L2W140", "Компјутерски науки" },
                    { "F18L2W140", "Компјутерско инженерство" },
                    { "F18L2W140", "Компјутерска едукација" },
                    { "F18L2W109", "Компјутерски науки" },
                    { "F18L2W140", "Интернет мрежи и безбедност" },
                    { "F18L3W055", "Компјутерска едукација" },
                    { "F18L2W001", "Компјутерска едукација" },
                    { "F18L1S003", "Софтверско инженерство и информациски системи" },
                    { "F18L1S003", "Software engineering and information systems" },
                    { "F18L1S003", "Компјутерски науки" },
                    { "F18L1S146", "Примена на информациски технологии" },
                    { "F18L1S146", "Софтверско инженерство и информациски системи" },
                    { "F18L1S146", "Software engineering and information systems" },
                    { "F18L1S146", "Компјутерски науки" },
                    { "F18L1S146", "Компјутерско инженерство" },
                    { "F18L1S146", "Компјутерска едукација" },
                    { "F18L2W001", "Интернет мрежи и безбедност" },
                    { "F18L1S146", "Интернет мрежи и безбедност" },
                    { "F18L2W014", "Софтверско инженерство и информациски системи" },
                    { "F18L2W014", "Software engineering and information systems" },
                    { "F18L2W014", "Компјутерски науки" },
                    { "F18L2W014", "Компјутерска едукација" },
                    { "F18L2W001", "Примена на информациски технологии" },
                    { "F18L2W001", "Софтверско инженерство и информациски системи" },
                    { "F18L2W001", "Software engineering and information systems" },
                    { "F18L2W001", "Компјутерски науки" },
                    { "F18L2W001", "Компјутерско инженерство" },
                    { "F18L2W014", "Примена на информациски технологии" },
                    { "F18L2W006", "Софтверско инженерство и информациски системи" },
                    { "F18L2W006", "Software engineering and information systems" },
                    { "F18L2W006", "Компјутерски науки" },
                    { "F18L2S061", "Компјутерски науки" },
                    { "F18L2S061", "Компјутерско инженерство" },
                    { "F18L2S061", "Интернет мрежи и безбедност" },
                    { "F18L2S017", "Примена на информациски технологии" },
                    { "F18L2S017", "Софтверско инженерство и информациски системи" },
                    { "F18L2S017", "Software engineering and information systems" },
                    { "F18L2S017", "Компјутерски науки" },
                    { "F18L2S017", "Компјутерско инженерство" },
                    { "F18L2S017", "Компјутерска едукација" },
                    { "F18L2S061", "Software engineering and information systems" },
                    { "F18L2S017", "Интернет мрежи и безбедност" },
                    { "F18L2S030", "Софтверско инженерство и информациски системи" },
                    { "F18L2S030", "Software engineering and information systems" },
                    { "F18L2S030", "Компјутерски науки" },
                    { "F18L2S030", "Компјутерско инженерство" },
                    { "F18L2S030", "Компјутерска едукација" },
                    { "F18L2S030", "Интернет мрежи и безбедност" },
                    { "F18L2S082", "Примена на информациски технологии" },
                    { "F18L2S082", "Софтверско инженерство и информациски системи" },
                    { "F18L2S082", "Software engineering and information systems" },
                    { "F18L2S030", "Примена на информациски технологии" },
                    { "F18L2S061", "Софтверско инженерство и информациски системи" },
                    { "F18L3S077", "Примена на информациски технологии" },
                    { "F18L2W165", "Интернет мрежи и безбедност" },
                    { "F18L2W006", "Компјутерско инженерство" },
                    { "F18L2W006", "Компјутерска едукација" },
                    { "F18L2W096", "Примена на информациски технологии" },
                    { "F18L2W096", "Компјутерска едукација" },
                    { "F18L2W167", "Примена на информациски технологии" },
                    { "F18L2W167", "Софтверско инженерство и информациски системи" },
                    { "F18L2W167", "Software engineering and information systems" },
                    { "F18L2W167", "Компјутерски науки" },
                    { "F18L2W167", "Компјутерско инженерство" },
                    { "F18L2W167", "Компјутерска едукација" },
                    { "F18L2W147", "Компјутерско инженерство" },
                    { "F18L2W147", "Интернет мрежи и безбедност" },
                    { "F18L2S100", "Примена на информациски технологии" },
                    { "F18L2S100", "Софтверско инженерство и информациски системи" },
                    { "F18L2S100", "Software engineering and information systems" },
                    { "F18L2W165", "Примена на информациски технологии" },
                    { "F18L2W165", "Софтверско инженерство и информациски системи" },
                    { "F18L2W165", "Software engineering and information systems" },
                    { "F18L2W165", "Компјутерски науки" },
                    { "F18L2W165", "Компјутерско инженерство" },
                    { "F18L2W165", "Компјутерска едукација" },
                    { "F18L1S003", "Примена на информациски технологии" },
                    { "F18L1S052", "Компјутерска едукација" },
                    { "F18L1S052", "Примена на информациски технологии" },
                    { "F18L1S015", "Интернет мрежи и безбедност" },
                    { "F18L1W020", "Software engineering and information systems" },
                    { "F18L1W020", "Компјутерски науки" },
                    { "F18L1W020", "Компјутерско инженерство" },
                    { "F18L1W020", "Компјутерска едукација" },
                    { "F18L1W020", "Интернет мрежи и безбедност" },
                    { "F18L1W031", "Компјутерски науки" },
                    { "F18L1W033", "Компјутерски науки" },
                    { "F18L1W033", "Компјутерско инженерство" },
                    { "F18L1W041", "Компјутерско инженерство" },
                    { "F18L1W020", "Софтверско инженерство и информациски системи" },
                    { "F18L1W049", "Компјутерско инженерство" },
                    { "F18L1W011", "Примена на информациски технологии" },
                    { "F18L1W011", "Софтверско инженерство и информациски системи" },
                    { "F18L1W011", "Software engineering and information systems" },
                    { "F18L1W011", "Компјутерско инженерство" },
                    { "F18L1W011", "Компјутерска едукација" },
                    { "F18L1W011", "Интернет мрежи и безбедност" },
                    { "F18L1S045", "Компјутерско инженерство" },
                    { "F18L1S045", "Компјутерска едукација" },
                    { "F18L1S045", "Интернет мрежи и безбедност" },
                    { "F18L1W070", "Компјутерска едукација" },
                    { "F18L1W020", "Примена на информациски технологии" },
                    { "F18L1W018", "Интернет мрежи и безбедност" },
                    { "F18L1W018", "Компјутерска едукација" },
                    { "F18L1W005", "Примена на информациски технологии" },
                    { "F18L1W005", "Софтверско инженерство и информациски системи" },
                    { "F18L1W005", "Software engineering and information systems" },
                    { "F18L1W005", "Компјутерска едукација" },
                    { "F18L1W005", "Интернет мрежи и безбедност" },
                    { "F18L1W007", "Примена на информациски технологии" },
                    { "F18L1W007", "Софтверско инженерство и информациски системи" },
                    { "F18L1W007", "Software engineering and information systems" },
                    { "F18L1W007", "Компјутерски науки" },
                    { "F18L1W007", "Компјутерска едукација" },
                    { "F18L1W007", "Интернет мрежи и безбедност" },
                    { "F18L1S013", "Примена на информациски технологии" },
                    { "F18L1S013", "Софтверско инженерство и информациски системи" },
                    { "F18L1S013", "Software engineering and information systems" },
                    { "F18L1S013", "Компјутерска едукација" },
                    { "F18L1S013", "Интернет мрежи и безбедност" },
                    { "F18L1W018", "Примена на информациски технологии" },
                    { "F18L1W018", "Софтверско инженерство и информациски системи" },
                    { "F18L1W018", "Software engineering and information systems" },
                    { "F18L1W018", "Компјутерски науки" },
                    { "F18L1W018", "Компјутерско инженерство" },
                    { "F18L1S016", "Примена на информациски технологии" },
                    { "F18L2S082", "Компјутерски науки" },
                    { "F18L1S016", "Софтверско инженерство и информациски системи" },
                    { "F18L1S016", "Компјутерски науки" },
                    { "F18L1S120", "Примена на информациски технологии" },
                    { "F18L1S120", "Софтверско инженерство и информациски системи" },
                    { "F18L1S120", "Software engineering and information systems" },
                    { "F18L1S120", "Компјутерски науки" },
                    { "F18L1S120", "Компјутерско инженерство" },
                    { "F18L1S120", "Компјутерска едукација" },
                    { "F18L1S120", "Интернет мрежи и безбедност" },
                    { "F18L1S026", "Примена на информациски технологии" },
                    { "F18L1S026", "Софтверско инженерство и информациски системи" },
                    { "F18L1S116", "Интернет мрежи и безбедност" },
                    { "F18L1S026", "Software engineering and information systems" },
                    { "F18L1S026", "Компјутерско инженерство" },
                    { "F18L1S026", "Компјутерска едукација" },
                    { "F18L1S026", "Интернет мрежи и безбедност" },
                    { "F18L1S015", "Примена на информациски технологии" },
                    { "F18L1S015", "Софтверско инженерство и информациски системи" },
                    { "F18L1S015", "Software engineering and information systems" },
                    { "F18L1S015", "Компјутерски науки" },
                    { "F18L1S015", "Компјутерско инженерство" },
                    { "F18L1S015", "Компјутерска едукација" },
                    { "F18L1S026", "Компјутерски науки" },
                    { "F18L1S116", "Компјутерска едукација" },
                    { "F18L1S116", "Компјутерско инженерство" },
                    { "F18L1S116", "Компјутерски науки" },
                    { "F18L1S016", "Компјутерско инженерство" },
                    { "F18L1S016", "Компјутерска едукација" },
                    { "F18L1S016", "Интернет мрежи и безбедност" },
                    { "F18L1S066", "Софтверско инженерство и информациски системи" },
                    { "F18L1S066", "Software engineering and information systems" },
                    { "F18L1S066", "Компјутерско инженерство" },
                    { "F18L1S066", "Интернет мрежи и безбедност" },
                    { "F18L1S023", "Примена на информациски технологии" },
                    { "F18L1S023", "Компјутерска едукација" },
                    { "F18L1S023", "Интернет мрежи и безбедност" },
                    { "F18L1S032", "Компјутерски науки" },
                    { "F18L1S034", "Примена на информациски технологии" },
                    { "F18L1S034", "Софтверско инженерство и информациски системи" },
                    { "F18L1S034", "Software engineering and information systems" },
                    { "F18L1S034", "Компјутерски науки" },
                    { "F18L1S034", "Компјутерско инженерство" },
                    { "F18L1S034", "Компјутерска едукација" },
                    { "F18L1S034", "Интернет мрежи и безбедност" },
                    { "F18L1S116", "Примена на информациски технологии" },
                    { "F18L1S116", "Софтверско инженерство и информациски системи" },
                    { "F18L1S116", "Software engineering and information systems" },
                    { "F18L1S016", "Software engineering and information systems" },
                    { "F18L2S082", "Компјутерско инженерство" },
                    { "F18L2S061", "Примена на информациски технологии" },
                    { "F18L2S082", "Интернет мрежи и безбедност" },
                    { "F18L3W043", "Компјутерски науки" },
                    { "F18L3W043", "Компјутерско инженерство" },
                    { "F18L3W043", "Компјутерска едукација" },
                    { "F18L3W043", "Интернет мрежи и безбедност" },
                    { "F18L3W053", "Примена на информациски технологии" },
                    { "F18L3W053", "Софтверско инженерство и информациски системи" },
                    { "F18L3W053", "Software engineering and information systems" },
                    { "F18L3W053", "Компјутерски науки" },
                    { "F18L3W053", "Компјутерско инженерство" },
                    { "F18L3W043", "Software engineering and information systems" },
                    { "F18L3W053", "Компјутерска едукација" },
                    { "F18L3W115", "Примена на информациски технологии" },
                    { "F18L3W115", "Софтверско инженерство и информациски системи" },
                    { "F18L3W115", "Software engineering and information systems" },
                    { "F18L3W115", "Компјутерски науки" },
                    { "F18L3W115", "Компјутерско инженерство" },
                    { "F18L3W115", "Компјутерска едукација" },
                    { "F18L3W115", "Интернет мрежи и безбедност" },
                    { "F18L3W035", "Примена на информациски технологии" },
                    { "F18L3W035", "Софтверско инженерство и информациски системи" },
                    { "F18L3W053", "Интернет мрежи и безбедност" },
                    { "F18L3W035", "Software engineering and information systems" },
                    { "F18L2S082", "Компјутерска едукација" },
                    { "F18L3W008", "Интернет мрежи и безбедност" },
                    { "F18L3W024", "Примена на информациски технологии" },
                    { "F18L3W024", "Софтверско инженерство и информациски системи" },
                    { "F18L3W024", "Software engineering and information systems" },
                    { "F18L3W024", "Компјутерски науки" },
                    { "F18L3W024", "Компјутерско инженерство" },
                    { "F18L3W024", "Компјутерска едукација" },
                    { "F18L3W024", "Интернет мрежи и безбедност" },
                    { "F18L3W081", "Примена на информациски технологии" },
                    { "F18L3W081", "Софтверско инженерство и информациски системи" },
                    { "F18L3W043", "Примена на информациски технологии" },
                    { "F18L3W081", "Software engineering and information systems" },
                    { "F18L3W081", "Компјутерско инженерство" },
                    { "F18L3W081", "Компјутерска едукација" },
                    { "F18L3W081", "Интернет мрежи и безбедност" },
                    { "F18L3W008", "Примена на информациски технологии" },
                    { "F18L3W008", "Софтверско инженерство и информациски системи" },
                    { "F18L3W008", "Software engineering and information systems" },
                    { "F18L3W008", "Компјутерски науки" },
                    { "F18L3W008", "Компјутерско инженерство" },
                    { "F18L3W008", "Компјутерска едукација" },
                    { "F18L3W081", "Компјутерски науки" },
                    { "F18L3W035", "Компјутерски науки" },
                    { "F18L3W035", "Компјутерско инженерство" },
                    { "F18L3W035", "Компјутерска едукација" },
                    { "F18L3W136", "Компјутерски науки" },
                    { "F18L3W136", "Компјутерско инженерство" },
                    { "F18L3W136", "Компјутерска едукација" },
                    { "F18L3W037", "Компјутерско инженерство" },
                    { "F18L3W037", "Интернет мрежи и безбедност" },
                    { "F18L3S059", "Компјутерски науки" },
                    { "F18L3S059", "Компјутерско инженерство" },
                    { "F18L3S059", "Интернет мрежи и безбедност" },
                    { "F18L3S062", "Примена на информациски технологии" },
                    { "F18L3W136", "Software engineering and information systems" },
                    { "F18L3S062", "Софтверско инженерство и информациски системи" },
                    { "F18L3S062", "Компјутерски науки" },
                    { "F18L3S062", "Компјутерско инженерство" },
                    { "F18L3S062", "Компјутерска едукација" },
                    { "F18L3S062", "Интернет мрежи и безбедност" },
                    { "F18L3S073", "Примена на информациски технологии" },
                    { "F18L3S073", "Софтверско инженерство и информациски системи" },
                    { "F18L3S073", "Software engineering and information systems" },
                    { "F18L3S073", "Компјутерски науки" },
                    { "F18L3S073", "Компјутерско инженерство" },
                    { "F18L3S062", "Software engineering and information systems" },
                    { "F18L3W136", "Софтверско инженерство и информациски системи" },
                    { "F18L3W136", "Примена на информациски технологии" },
                    { "F18L3W044", "Компјутерско инженерство" },
                    { "F18L3W035", "Интернет мрежи и безбедност" },
                    { "F18L3W134", "Примена на информациски технологии" },
                    { "F18L3W134", "Софтверско инженерство и информациски системи" },
                    { "F18L3W134", "Software engineering and information systems" },
                    { "F18L3W134", "Компјутерски науки" },
                    { "F18L3W134", "Компјутерско инженерство" },
                    { "F18L3W134", "Компјутерска едукација" },
                    { "F18L3W134", "Интернет мрежи и безбедност" },
                    { "F18L3W148", "Примена на информациски технологии" },
                    { "F18L3W148", "Софтверско инженерство и информациски системи" },
                    { "F18L3W148", "Software engineering and information systems" },
                    { "F18L3W148", "Компјутерски науки" },
                    { "F18L3W148", "Компјутерско инженерство" },
                    { "F18L3W148", "Компјутерска едукација" },
                    { "F18L3W148", "Интернет мрежи и безбедност" },
                    { "F18L3W050", "Компјутерска едукација" },
                    { "F18L3W009", "Примена на информациски технологии" },
                    { "F18L3W009", "Софтверско инженерство и информациски системи" },
                    { "F18L3W009", "Software engineering and information systems" },
                    { "F18L3W009", "Компјутерски науки" },
                    { "F18L3W009", "Компјутерско инженерство" },
                    { "F18L3W065", "Интернет мрежи и безбедност" },
                    { "F18L3W065", "Компјутерско инженерство" },
                    { "F18L3W043", "Софтверско инженерство и информациски системи" },
                    { "F18L3W004", "Интернет мрежи и безбедност" },
                    { "F18L2S124", "Компјутерско инженерство" },
                    { "F18L2S124", "Компјутерска едукација" },
                    { "F18L2S124", "Интернет мрежи и безбедност" },
                    { "F18L2S143", "Компјутерско инженерство" },
                    { "F18L2S143", "Интернет мрежи и безбедност" },
                    { "F18L2S097", "Примена на информациски технологии" },
                    { "F18L2S097", "Софтверско инженерство и информациски системи" },
                    { "F18L2S097", "Software engineering and information systems" },
                    { "F18L2S097", "Компјутерски науки" },
                    { "F18L2S124", "Компјутерски науки" },
                    { "F18L2S097", "Компјутерско инженерство" },
                    { "F18L2S099", "Примена на информациски технологии" },
                    { "F18L2S099", "Софтверско инженерство и информациски системи" },
                    { "F18L2S099", "Software engineering and information systems" },
                    { "F18L2S099", "Компјутерска едукација" },
                    { "F18L2S042", "Примена на информациски технологии" },
                    { "F18L2S042", "Софтверско инженерство и информациски системи" },
                    { "F18L2S042", "Software engineering and information systems" },
                    { "F18L2S042", "Компјутерски науки" },
                    { "F18L2S042", "Компјутерско инженерство" },
                    { "F18L2S097", "Компјутерска едукација" },
                    { "F18L2S042", "Компјутерска едукација" },
                    { "F18L2S124", "Software engineering and information systems" },
                    { "F18L2S124", "Примена на информациски технологии" },
                    { "F18L2S084", "Примена на информациски технологии" },
                    { "F18L2S084", "Софтверско инженерство и информациски системи" },
                    { "F18L2S084", "Software engineering and information systems" },
                    { "F18L2S084", "Компјутерски науки" },
                    { "F18L2S084", "Компјутерско инженерство" },
                    { "F18L2S084", "Компјутерска едукација" },
                    { "F18L2S084", "Интернет мрежи и безбедност" },
                    { "F18L2S090", "Примена на информациски технологии" },
                    { "F18L2S090", "Софтверско инженерство и информациски системи" },
                    { "F18L3W065", "Компјутерски науки" },
                    { "F18L2S090", "Software engineering and information systems" },
                    { "F18L2S090", "Компјутерско инженерство" },
                    { "F18L2S090", "Интернет мрежи и безбедност" },
                    { "F18L2S110", "Примена на информациски технологии" },
                    { "F18L2S110", "Софтверско инженерство и информациски системи" },
                    { "F18L2S110", "Software engineering and information systems" },
                    { "F18L2S110", "Компјутерски науки" },
                    { "F18L2S110", "Компјутерско инженерство" },
                    { "F18L2S110", "Компјутерска едукација" },
                    { "F18L2S110", "Интернет мрежи и безбедност" },
                    { "F18L2S090", "Компјутерски науки" },
                    { "F18L2S114", "Примена на информациски технологии" },
                    { "F18L2S124", "Софтверско инженерство и информациски системи" },
                    { "F18L2S114", "Software engineering and information systems" },
                    { "F18L2S119", "Software engineering and information systems" },
                    { "F18L2S029", "Примена на информациски технологии" },
                    { "F18L2S029", "Компјутерски науки" },
                    { "F18L2S029", "Компјутерско инженерство" },
                    { "F18L2S029", "Компјутерска едукација" },
                    { "F18L2S029", "Интернет мрежи и безбедност" },
                    { "F18L3W060", "Примена на информациски технологии" },
                    { "F18L3W060", "Софтверско инженерство и информациски системи" },
                    { "F18L3W060", "Software engineering and information systems" },
                    { "F18L2S119", "Софтверско инженерство и информациски системи" },
                    { "F18L3W060", "Компјутерски науки" },
                    { "F18L3W060", "Компјутерска едукација" },
                    { "F18L3W060", "Интернет мрежи и безбедност" },
                    { "F18L3W004", "Примена на информациски технологии" },
                    { "F18L3W004", "Софтверско инженерство и информациски системи" },
                    { "F18L3W004", "Software engineering and information systems" },
                    { "F18L3W004", "Компјутерски науки" },
                    { "F18L3W004", "Компјутерско инженерство" },
                    { "F18L3W004", "Компјутерска едукација" },
                    { "F18L2S114", "Софтверско инженерство и информациски системи" },
                    { "F18L3W060", "Компјутерско инженерство" },
                    { "F18L2S164", "Компјутерско инженерство" },
                    { "F18L2S119", "Примена на информациски технологии" },
                    { "F18L2S164", "Software engineering and information systems" },
                    { "F18L2S114", "Компјутерски науки" },
                    { "F18L2S114", "Компјутерско инженерство" },
                    { "F18L2S114", "Компјутерска едукација" },
                    { "F18L3S162", "Примена на информациски технологии" },
                    { "F18L3S162", "Софтверско инженерство и информациски системи" },
                    { "F18L3S162", "Software engineering and information systems" },
                    { "F18L3S162", "Компјутерски науки" },
                    { "F18L3S162", "Компјутерско инженерство" },
                    { "F18L3S162", "Компјутерска едукација" },
                    { "F18L3S162", "Интернет мрежи и безбедност" },
                    { "F18L2S164", "Компјутерски науки" },
                    { "F18L2S051", "Компјутерска едукација" },
                    { "F18L2S002", "Софтверско инженерство и информациски системи" },
                    { "F18L2S002", "Software engineering and information systems" },
                    { "F18L2S002", "Компјутерски науки" },
                    { "F18L2S002", "Компјутерско инженерство" },
                    { "F18L2S095", "Софтверско инженерство и информациски системи" },
                    { "F18L2S095", "Software engineering and information systems" },
                    { "F18L2S095", "Компјутерски науки" },
                    { "F18L2S095", "Компјутерско инженерство" },
                    { "F18L2S164", "Софтверско инженерство и информациски системи" },
                    { "F18L2S002", "Примена на информациски технологии" }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("97885a82-b611-4e1c-a230-243f7b866444"), "Lab10", 33 },
                    { new Guid("fe53f8ef-4bd2-43aa-8d92-3e0d989ea341"), "Lab9", 60 },
                    { new Guid("59bbe8fa-b820-483d-9891-72e4c76dc673"), "Lab7", 67 },
                    { new Guid("2d0731ae-e4bd-4e05-b192-635a247611f7"), "Lab8", 49 },
                    { new Guid("768f2be3-627d-4f3a-907a-0eef04ce9f65"), "Lab6", 33 },
                    { new Guid("fdcbeced-614f-4510-a048-4b3eba9d2cc1"), "Lab2", 32 }
                });

            migrationBuilder.InsertData(
                table: "Prostorii",
                columns: new[] { "Id", "Ime", "Kapacitet" },
                values: new object[,]
                {
                    { new Guid("b4468c03-2e05-4612-8db7-7676852ac8d5"), "Lab4", 33 },
                    { new Guid("169f3173-e6b7-44e1-9740-7eadb7700a43"), "Lab3", 42 },
                    { new Guid("165adbd2-c483-4f70-be3c-0894a046d847"), "Lab1", 42 },
                    { new Guid("7e638131-c103-486a-881d-25018da360e0"), "Lab5", 44 }
                });

            migrationBuilder.InsertData(
                table: "Sproveduvaci",
                columns: new[] { "SproveduvacId", "ImePrezime" },
                values: new object[,]
                {
                    { "SP120", "Sproveduvac20" },
                    { "SP121", "Sproveduvac21" },
                    { "SP122", "Sproveduvac22" },
                    { "SP123", "Sproveduvac23" },
                    { "SP124", "Sproveduvac24" },
                    { "SP125", "Sproveduvac25" },
                    { "SP126", "Sproveduvac26" },
                    { "SP127", "Sproveduvac27" },
                    { "SP129", "Sproveduvac29" },
                    { "SP130", "Sproveduvac30" },
                    { "SP131", "Sproveduvac31" },
                    { "SP132", "Sproveduvac32" },
                    { "SP133", "Sproveduvac33" },
                    { "SP134", "Sproveduvac34" },
                    { "SP135", "Sproveduvac35" },
                    { "SP136", "Sproveduvac36" },
                    { "SP137", "Sproveduvac37" },
                    { "SP128", "Sproveduvac28" },
                    { "SP119", "Sproveduvac19" },
                    { "SP117", "Sproveduvac17" },
                    { "SP116", "Sproveduvac16" },
                    { "SP138", "Sproveduvac38" },
                    { "SP100", "Sproveduvac0" },
                    { "SP101", "Sproveduvac1" },
                    { "SP102", "Sproveduvac2" },
                    { "SP103", "Sproveduvac3" },
                    { "SP104", "Sproveduvac4" },
                    { "SP105", "Sproveduvac5" },
                    { "SP106", "Sproveduvac6" },
                    { "SP107", "Sproveduvac7" },
                    { "SP108", "Sproveduvac8" },
                    { "SP109", "Sproveduvac9" },
                    { "SP110", "Sproveduvac10" },
                    { "SP111", "Sproveduvac11" },
                    { "SP112", "Sproveduvac12" },
                    { "SP113", "Sproveduvac13" },
                    { "SP114", "Sproveduvac14" },
                    { "SP115", "Sproveduvac15" },
                    { "SP118", "Sproveduvac18" },
                    { "SP139", "Sproveduvac39" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("01e98aef-f6d6-4e48-8703-16075691f0f2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("061e8493-046a-4e6f-a724-f207b54aa92b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("07682800-fe32-46a4-b10a-b8256bd763ba"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0a874255-de1e-45ca-9865-53f54e8bb116"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("0c3a8413-b6f1-44b2-a91d-b72f457c69bf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("102c52bd-d0c9-4edb-8e9e-843538559100"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1125fcd2-9b99-47a3-8340-2a247ab52923"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("133c23ea-2f69-488e-9a41-7420bd05ecc8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("16f93991-664f-4965-9bce-1e246a1303e3"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("19aedfd9-552c-43d8-af1a-69787ab4446e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1b1bfdb8-a9b5-428f-88c1-38aa6224b495"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1b80ee6c-b7b3-4a52-89f4-a3f7d9cc6b3e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("1cfc115e-1880-4c63-8ddb-9ff165efbcd5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2899b72c-fbb8-4d7b-a731-9e6c8e36aec2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2ad3624b-348b-4247-9b1a-7068e0279846"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("2d4dac3c-e7b5-4bd0-ab6b-bce1dd396da2"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("33cfb530-92e1-49a0-8d01-6fe100c2e242"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3691a82a-896e-4db5-b1c9-a461368ddb28"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("3d0d580a-5317-4d15-9ebe-f647465cbaba"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("443f875e-d467-4fd0-a236-b22b5fdbc41d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4877ff6d-f22c-4efc-9abe-939e0b52807d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4a186f1e-c04e-461f-85d1-c923cfbe7e25"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("4e2f9586-2ef1-4326-bd2b-05f4ba7255c8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("50acf34b-9e40-4a9c-a266-a49d960fd9b7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("50d8f2c8-d252-4783-95cb-fc25539e9482"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("550b57e2-31ef-40a1-81c1-016cd54599b4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("567e0654-c24e-4442-be04-2133bd188a0b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5778e364-dd31-4e10-976d-14c81d50b8ad"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("57e8dcf7-4a23-457d-aeb3-337d333b8968"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("598adeb5-f96a-4476-8a8c-1df78e749daa"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("5e6cfc62-4155-4ab4-98c6-5998435a7592"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("61492afc-9cfe-4076-844b-64ee093c6bf8"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("688ce181-7eeb-4ef8-a46c-f0a0bf4e7187"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("6a0df84c-679e-4065-882b-d43621fce6de"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("70f2590f-f53a-4bb5-8b56-199621280c66"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7145adb0-7b6f-4080-a6d5-2c2d89532b2d"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("73537052-56ef-4ed3-bd9f-d606aded422f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7767a523-62f2-4ad2-9396-22403010545c"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7a2728c3-30c9-4150-8393-fbc6b5501829"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7cd06f10-91d5-4260-948c-d361a4641736"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("7ff3db87-7575-49d7-b1b6-c1199aae9b86"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8015e74e-edfe-460b-9673-b38f166d36c7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("810cdf53-fd1b-4fd3-814e-3fafa713e019"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("818bca71-1ab2-4df8-b388-0ab2eafbcaf7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("82f3a0e7-7271-4011-bf09-ce91a19a6285"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("88ca8043-7d3c-4c74-b353-891d6ffd87b0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("894e61d8-69f6-41e5-b548-5b3bebbfefbd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("8f8923a9-87b5-4fcd-99a9-959cd0914235"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("91e6e48c-1ac6-463a-ad43-6b562d0c6c99"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("92e7a9e4-4a1e-4436-8d67-b860450af8bd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9358c2ca-d0bd-4d4d-810f-230f02a5f66e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("947d5a01-0633-40c6-b8bc-fe42361956ba"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("94cd40a4-6a9f-4880-9e8a-fccf97ec2dfd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("980bfa04-3f24-4fb9-a88a-b6ba50049bcf"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("9fce1bf2-53ab-4557-aaf8-015a02b20c12"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a0e4bb09-d55d-4164-9dc6-7b1924a55a7f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a2c69f65-8839-4489-98ee-579ccc6bb2cd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("a9a1d5ef-b97b-4601-b1ae-c51f266c9cac"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ad55146e-1312-4414-8fd6-efbd4366ce31"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ae396f59-d57c-4cbb-89a1-2436c56e71b5"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b0153766-7968-443e-9e9a-ff4cb5e5a378"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b15e9313-81d2-4c0c-9142-917c7dcd85ac"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b265f643-d630-4b98-b1d9-959d30a70ea9"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b351c8c8-b314-4114-bafd-c22b7b7d61a4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b768e3a0-024d-41b8-92ee-472d872716b7"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("b77af795-bcc7-4ed0-ac9f-7117b2c496cb"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ba01ca22-5d16-461b-b46d-9aac15f0295a"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("bcdb2b58-a4c4-4885-b95f-ec69d4b100bd"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("c312dba8-ad7f-480c-b8bd-b48fd6749bda"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d29edecd-44a6-4614-89e3-563b96673df0"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d2bbb885-d0a6-4fcd-86ec-7eb1a70ec851"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d47422a0-6bdd-427a-ad2d-8572cd729c09"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d68bcd09-4647-4585-b5dc-ceba3715f042"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("d8ea2d24-d2a8-4fd4-b4fb-34c388471f29"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("dbbf66f3-718c-4146-ab31-527b68c7b176"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e49796f8-c5be-454c-b13f-d86fc071e11e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e5358be6-1a3a-4a61-a373-c90ff77f8395"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e6e05e84-cd7b-4f92-8955-fe0edec51815"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e7902c71-34f6-4834-992e-fbed7425030e"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("e82e32a2-71f5-48f3-84b3-6de8aa5263ef"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("eb36668c-9fe7-4ccc-98fa-73ccbb59f2b4"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ec109d4b-e89d-4478-b1cf-440199b855ba"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("edff7351-e80e-4587-bcd8-b7de3d698d0f"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f4b7c1eb-3c02-43dd-9d28-884639c1cf0b"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f7001188-7078-4d90-aee9-85b41efc1d76"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("f8c1fb81-834b-47b8-b670-7f5524a6a732"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("fb192fbc-cb7d-46f2-91b1-b620e9671920"));

            migrationBuilder.DeleteData(
                table: "Ispiti",
                keyColumn: "Id",
                keyValue: new Guid("ffd00e05-a1e0-48b9-a804-57ce9e075b87"));

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S003", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S003", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S003", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S003", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S013", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S013", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S013", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S013", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S013", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S015", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S016", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S023", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S023", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S023", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S026", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S032", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S034", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S045", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S045", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S045", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S052", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S052", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S066", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S066", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S066", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S066", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S116", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S120", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1S146", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W005", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W005", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W005", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W005", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W005", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W007", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W007", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W007", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W007", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W007", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W007", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W011", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W011", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W011", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W011", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W011", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W011", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W018", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W020", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W031", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W033", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W033", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W041", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W049", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L1W070", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S002", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S002", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S002", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S002", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S002", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S017", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S029", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S029", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S029", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S029", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S029", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S030", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S042", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S042", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S042", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S042", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S042", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S042", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S051", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S061", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S061", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S061", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S061", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S061", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S061", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S082", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S084", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S090", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S090", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S090", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S090", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S090", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S090", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S095", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S095", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S095", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S095", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S097", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S097", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S097", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S097", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S097", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S097", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S099", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S099", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S099", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S099", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S100", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S100", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S100", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S110", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S114", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S114", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S114", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S114", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S114", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S114", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S119", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S119", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S119", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S124", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S143", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S143", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S164", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S164", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S164", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2S164", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W001", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W006", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W006", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W006", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W006", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W006", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W014", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W014", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W014", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W014", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W014", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W046", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W046", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W067", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W096", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W096", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W104", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W104", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W104", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W104", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W104", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W109", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W140", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W147", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W147", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W165", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W167", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W167", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W167", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W167", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W167", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L2W167", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S010", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S012", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S012", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S012", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S012", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S012", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S019", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S019", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S019", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S019", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S019", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S019", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S022", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S025", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S025", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S025", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S025", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S025", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S028", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S036", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S036", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S036", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S036", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S036", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S039", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S039", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S039", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S040", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S040", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S040", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S040", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S040", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S040", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S047", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S047", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S047", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S047", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S056", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S057", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S059", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S059", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S059", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S062", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S063", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S063", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S07", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S07", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S07", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S07", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S07", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S071", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S073", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S073", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S073", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S073", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S073", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S073", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S077", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S077", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S077", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S077", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S077", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S077", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S080", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S080", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S080", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S080", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S080", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S080", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S083", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S083", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S083", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S083", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S083", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S086", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S086", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S086", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S086", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S086", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S086", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S087", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S087", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S087", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S087", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S087", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S087", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S091", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S091", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S091", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S091", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S091", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S093", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S093", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S093", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S093", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S093", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S093", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S094", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S101", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S101", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S102", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S102", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S102", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S102", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S106", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S106", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S106", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S106", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S107", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S111", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S112", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S113", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S113", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S113", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S113", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S113", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S113", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S118", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S121", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S122", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S122", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S122", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S125", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S125", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S125", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S127", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S130", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S130", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S130", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S130", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S132", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S132", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S132", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S132", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S132", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S132", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S135", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S138", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S138", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S138", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S138", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S138", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S138", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S139", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S139", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S141", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S149", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S149", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S149", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S149", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S150", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S150", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S150", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S150", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S150", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S151", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S153", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S153", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S155", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S157", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S157", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S157", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S157", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S157", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S158", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S158", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S159", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S159", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S159", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S159", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S162", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S163", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S163", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S163", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S163", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3S166", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W004", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W008", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W009", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W009", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W009", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W009", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W009", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W024", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W027", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W027", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W027", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W027", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W027", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W035", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W037", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W037", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W037", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W038", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W038", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W038", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W038", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W038", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W043", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W044", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W048", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W048", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W048", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W048", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W048", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W050", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W053", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W055", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W060", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W064", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W064", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W064", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W065", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W065", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W065", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W068", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W068", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W068", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W068", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W068", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W068", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W072", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W072", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W072", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W072", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W072", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W074", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W074", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W074", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W074", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W074", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W074", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W075", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W075", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W075", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W075", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W075", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W076", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W079", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W079", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W079", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W079", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W079", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W079", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W081", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W085", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W088", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W088", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W088", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W088", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W088", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W088", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W089", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W089", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W089", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W089", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W089", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W092", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W098", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W098", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W103", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W105", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W105", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W105", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W105", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W108", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W108", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W108", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W108", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W108", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W108", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W115", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W117", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W123", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W126", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W128", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W129", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W131", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W131", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W133", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W133", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W134", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W136", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W136", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W136", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W136", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W136", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W136", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W137", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W137", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W137", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W137", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W137", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W137", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W142", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W142", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W142", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W144", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W144", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W144", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W144", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W145", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W145", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W145", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W148", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W152", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W152", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W152", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W152", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W152", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W152", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W154", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W154", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W154", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W156", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W156", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W156", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W156", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W160", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W160", "Интернет мрежи и безбедност" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W160", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W160", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W161", "Software engineering and information systems" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W161", "Компјутерска едукација" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W161", "Компјутерски науки" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W161", "Компјутерско инженерство" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W161", "Примена на информациски технологии" });

            migrationBuilder.DeleteData(
                table: "PredmetiOdStudiskaPrograma",
                keyColumns: new[] { "KodNaPredmet", "ImeNaStudiskaPrograma" },
                keyValues: new object[] { "F18L3W161", "Софтверско инженерство и информациски системи" });

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("165adbd2-c483-4f70-be3c-0894a046d847"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("169f3173-e6b7-44e1-9740-7eadb7700a43"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("2d0731ae-e4bd-4e05-b192-635a247611f7"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("59bbe8fa-b820-483d-9891-72e4c76dc673"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("768f2be3-627d-4f3a-907a-0eef04ce9f65"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("7e638131-c103-486a-881d-25018da360e0"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("97885a82-b611-4e1c-a230-243f7b866444"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("b4468c03-2e05-4612-8db7-7676852ac8d5"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("fdcbeced-614f-4510-a048-4b3eba9d2cc1"));

            migrationBuilder.DeleteData(
                table: "Prostorii",
                keyColumn: "Id",
                keyValue: new Guid("fe53f8ef-4bd2-43aa-8d92-3e0d989ea341"));

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP100");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP101");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP102");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP103");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP104");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP105");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP106");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP107");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP108");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP109");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP110");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP111");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP112");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP113");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP114");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP115");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP116");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP117");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP118");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP119");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP120");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP121");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP122");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP123");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP124");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP125");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP126");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP127");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP128");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP129");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP130");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP131");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP132");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP133");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP134");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP135");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP136");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP137");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP138");

            migrationBuilder.DeleteData(
                table: "Sproveduvaci",
                keyColumn: "SproveduvacId",
                keyValue: "SP139");
        }
    }
}
