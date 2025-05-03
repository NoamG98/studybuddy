using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFriendRequestStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02c27073-a83a-4a1e-8ae5-dfd0f8563a8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02da320d-bfd5-487e-bc48-edb870cc420e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0454dd99-2206-4e90-98b5-225f91f97300"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04f68471-1b22-4012-b759-bba4715592a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0865a6c6-51ff-49cf-aff4-09f1f641e07e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08bad423-b9db-4115-a830-39ed398973c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08e4ee4f-aa0c-4160-9c7d-ceba3e408fe0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0ad27e9e-c5f3-49e0-8197-09cf65fd37fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d3d90d5-86b8-4a6f-a10f-38fe0f23d47a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d4b6fd6-5ae7-4baa-a4d6-e12aa0503efb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("10f7eec9-296e-482a-ab68-e290c29b51d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("111898b2-3aaa-4268-bfe4-7969f283d4bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1336df21-c69f-41f8-901a-4ca027d773e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("141f6ddf-1878-4d78-8a05-d64dea52687b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15c6fb24-2684-4f60-bc33-d2f1d41b42d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a31705e-c513-4730-9fb6-87486f498935"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a7c629e-3bd3-4f84-ad6b-0fd33b9760e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ac63b6b-7d4d-43ec-b67b-033ce0a24bd6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1afc6161-706b-4b82-9005-f7e791b57144"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ee1d4a1-f256-4b2d-a3ac-c70ed7b65f1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fda00b2-f2a7-406c-bc65-c1a2720e0fde"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20481f14-68ad-41f4-9a41-a9b28889d223"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20638166-1419-40a2-bf88-368e15c0badb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20c63948-0534-4e2e-8ee8-f11c3273aafe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("221f3c69-023e-4e0e-9007-d3f17d7adf51"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22fc1b2b-e19d-4022-b43e-3c42398970c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2442368f-67e4-4b7e-8704-169dc2632c25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("246605d5-174b-46c8-8124-53b271f5c03a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25cca9d8-e76d-4c6e-80a5-762a2e08d8e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26544ad9-3ee5-46a8-9908-4f35754647ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("292b5a45-6186-4edd-b9f8-c1bc776ccd1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("298149fa-1b79-4974-9f0d-fbaf2e20de83"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c2d9fc4-85e1-4f63-aca5-a35243f95a4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c815689-d213-4653-a549-1ada98daa40e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30d93526-8c51-4316-b0de-7f30abac01ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("339e6f4b-54d7-4f71-8677-b8f0f7d01d40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3481464c-46ff-4f25-b6fb-cf3fd71bb7ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("359e8700-7d19-47a1-802d-f408fc0adfe9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35d361de-a82a-4bdc-8cd6-9ae30fedb921"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37e872b7-cc8e-4ef9-a54b-de90ca70fcb6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b209592-bbd3-445a-8fc4-ee507fa1fe04"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d057b0c-bec8-4f43-8f89-649ff17a0c40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3de26b80-241e-4159-81ca-3a4f358d30c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e53eab3-d2c0-413f-a86b-08c4fb8b7ff1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ec088fd-c6e1-4746-9b79-68e601f9d84f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("405795c4-5ba8-43e6-99be-aedb153ada56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43ed6e4d-d23a-4325-8640-266609b2d690"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43fdd93b-41e9-43a3-baf8-b8057c7ebe33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("451a0559-1e6c-41df-ab68-5bbeb74cc1c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4520e66b-93db-4d26-94dd-8da20120bfd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45b5486c-7341-46f1-81d8-0bfff3eb55e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46b4a1f2-c28f-41fa-8228-4e67df403f40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4737cb89-a840-4223-b24f-4de46427d1e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4917f085-e3b6-4943-8169-9430a0a6d01e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49cd3429-ee3c-4d02-9262-04f8a4059782"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a904a1c-e34b-4e72-a336-42d4d4c8c669"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4acc4eb8-518d-4df9-b0b1-3e32b33e2170"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e04532a-77e7-4f90-8aed-679a714f7070"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51ce7a95-64da-45f7-b3ef-2ed6953a5703"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5208e37a-6e8c-46bf-aae3-4cd21c94039c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("522a1072-5543-4543-9462-4d9534b93edf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("553f96f6-febe-4dbf-ad54-44d630235051"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55e6c82a-24d2-4009-b2e8-d3295dd098db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55e88e73-1303-4256-91ac-9c53b2bffa31"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("591dd074-e4cd-4df0-b4b0-59582ccf6948"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59a962e4-c655-40fb-9982-300f228c9c8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c74debc-25fd-4a41-a5c5-2fda9553d3ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d297cfe-4188-4b21-8411-7e4dc156f650"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5d360dc8-f3f8-4f17-a174-bc1453b3304a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ee1ce1c-0248-4535-80ae-264008bee994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fb1d3c2-bbbc-442a-b90a-847e7b0aa192"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fbafd93-2a09-4fca-9f55-07bcb14152ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fff9e97-498b-42a7-bb7c-1be3463f5d44"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6148d21f-209a-4ba4-b9ce-f8467973e8f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63804032-ad5e-4876-8ed5-8ac87ec534b8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63f6bf6f-3a8a-4418-928b-bf69fa1d5961"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64a5c17e-8a5f-4987-a15c-0337d5e16baa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6607d312-42dd-4f8d-ad7a-8e06c2361c8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66f4335a-2979-4598-b871-7791c6b2b383"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6708579e-651b-4b6f-a87f-aac9c13539af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6aac487f-fead-48b9-9099-abf315c5d15c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6afdc26f-0a1e-4a13-8ea9-fd5db7975952"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c325dd6-66d1-46aa-9322-df65e3c2b898"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6ece6e95-9c7d-400e-baeb-8dbb181a1e19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fef24b8-6f59-48ae-9f32-5c85daec66b2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70f32a33-b7a8-49c8-beec-02535c9cf521"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72d06884-81c0-451a-a74d-a812e7499dca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("737f8ca5-6c0b-4745-9d30-4a64f6ca3b3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7439bfac-1d61-4dca-8dfe-787c159ae536"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("763d7c36-820c-4ef3-99d1-5571ec16a99b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("763fb15a-970a-4b76-807c-cfa44438884c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("767d0adc-5e73-436f-af77-62e5206c6b73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76cf5534-22b5-42e1-ade0-b61c2b232526"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7988ed95-3499-42c8-9eb7-57e28455a6b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a854bdd-c0a0-4f33-99c0-136a744f7b5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ebd1f27-a052-4629-9432-e4caf4198b7b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80953555-8971-4f10-8ea1-9f05e32d05d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81f5500a-f6f0-4d26-8a86-fcfa4f663170"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8212b670-9fb4-499e-a4f0-f7f175ba8676"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82c44a64-7838-4c2b-a673-bf6a08729eb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83e01d5e-1c4a-4154-ba48-951765f8f17f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85df3099-dac8-437e-8b17-a7c2cff39364"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87344ea7-6564-430a-86b5-60d74b228231"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("879fc656-5747-4d14-a422-2107bcbfb6a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89783845-c6e5-488c-bb9a-f52ad360ec5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89a509bf-110b-46fe-b814-77aa57828ba9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89fc1866-1bf8-44ef-bddf-704badf91530"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a37e7aa-feaf-4090-949f-63aeafd67192"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ac7a2b5-2216-413f-aaf2-a27830d35c33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b526a1c-c0af-4eec-a644-7ad33c6adee9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c33eafd-d4f7-43aa-9d1d-303bde2bdcbd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8dfa1454-5721-4957-b207-e61c2d441649"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91a63a49-9a69-4675-b6cf-3c3843ef46ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("925cfa44-9322-4c43-9511-e045fceb6b7d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9289511b-22ae-4e9b-9b38-fb1019ba1fa6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93376b5a-eae1-4bd3-9cac-6e3159440d85"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("936ead80-17d1-4ed0-8382-514dd4dc7696"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("958c6524-e557-4307-9581-275a066e41aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96a446fb-2cfe-4852-9f25-b8f180ae7fcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99a82519-b1a6-431c-a400-80b2af8a6e1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b21a88d-7bf6-4af9-9462-9d153d40333d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b926b14-2c76-4926-a7d2-6f91e81122d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d2f9c81-d7ff-49c6-a7eb-2489dc66f0e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9da58c99-7a60-405d-86d0-0ee57977eec7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f006d53-b33b-439f-8189-5f8a97dba81b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9f374410-f44e-4847-a796-d386545053f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a571624d-453c-45db-a011-ab5b53ca96c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a923d462-d423-4e29-a394-aad88bfdc43a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac93353c-aedd-4cd9-9265-d57367dcb473"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aec7c6fc-eda5-4bf0-befc-da1cd076c159"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("afd9301c-3783-4daa-9179-93314a5ca3db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b130465c-7633-4206-a049-190886673c27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b15181e5-9ca3-453a-b0d2-51aa9b903ec5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b26424b7-67f4-4c68-a0db-060175c110ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2d3c7b0-8035-4ea7-8c87-bf15b00a6568"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b521fb62-7265-4d43-a014-daf0e3444436"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b72e2c1c-bf60-4f16-abe7-60e18338a900"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b855bc3e-3574-471a-a2b9-101d8f3fc91f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b934b198-79d9-445b-a9b7-bb8db62e38a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba6d36bb-2c8a-499a-b850-0bd90966b0bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bac8298c-f332-4312-8160-6d247b2440fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd9f8561-fb76-4823-bebb-247211f95d3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf1fecb1-daea-47c0-9a31-4e7ba87e3b8f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c07da7e5-d83a-49ef-8087-d7a1c10237c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3c5d486-2c19-4ef6-b4d5-9d8a05963ba4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3d70cbb-b421-4e84-9996-d121b5cdf40c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6512784-f8bd-4ec6-aa07-97a8e08c837a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6584382-3733-4b22-ba5b-e433e7b85685"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7943c1a-bd5f-469d-a509-dc2e7a2ecc88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7bae37b-c15e-48d6-a019-f22673b48370"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7dccee1-1ee7-4928-ab2a-bbe3ac51327b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c81e51e5-8122-457c-af52-a75bdf93d671"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8a643e9-66e6-4148-bb29-49727976dc05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9122bec-144f-415e-9bff-3176671af921"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cabb3e02-eede-4991-9057-ab0d8a0b79a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb75d2e9-d793-464c-ab41-f135e2989b0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ccfdf511-34fc-417b-b338-51a76153234f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ce790418-de15-4d7e-a754-07fca2aecdff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d06b83a6-69f2-4844-a914-96d3c90dcc37"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0b0285b-99b6-4b8a-aa65-7df6abaed306"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d15a2d21-ed39-4a9c-8ed2-5621fcd166cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d48f7d87-696c-46cc-8868-e71ed9f8618f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d64dc6a1-2eca-4f7f-b5c1-f77b850ebe94"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d659e744-9ef7-4b76-9d9d-997a6f07c7c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d804ed1c-b725-4ae6-a29c-e111294255d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9f051dc-86c5-4150-8e2a-eb3179f8f7cf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc031d7f-0981-418a-9a7a-b9459153bd88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dcb321dd-4eb9-46b4-a858-5c30d136b216"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de176fe1-cc5c-4984-a1ca-05a923825e5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de1fc034-9a2f-4729-860e-30834957b610"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("def41c5e-cef0-4f44-8464-fee728ee988f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e61b9167-5a5d-4ad6-afcc-a958ce42adac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ea8e364c-a193-48a9-af84-e6c41a0913c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb6f04c5-1d89-419b-b0e6-00a0445556b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed624080-56f7-4533-9c15-adb9feae4f0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ede0dbe0-7e8e-4343-a76d-52b6de4ff191"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efa5883e-bb0b-424c-ab3c-851f0d830523"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efc81a4a-662e-4799-8623-3c3e3c4f6eda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f055930e-0385-4f51-acaf-867fec21f9c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f19701cb-a319-46a7-9f53-ea36829e84a0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1ca1e71-a080-43c5-b571-c73f86d9e97a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4554fbc-5d8e-473a-81a0-7f3aea7b04bb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4cde409-dc29-4d6d-befa-176534adb934"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f550e29d-e8c2-43e3-b900-10bc19fcee50"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f577e1c2-c85d-4ffe-907b-1ac824809e0f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f60e4d99-6e2f-4c88-a160-2cc63b36ca0a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f80faaa8-8012-4a34-819f-cbcd69bfb427"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8f66c1c-8450-4ea9-9862-242bf28d59d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9c4b9c8-589d-40d0-9cba-3a9920c57e17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbea90a2-ffc9-4288-bb9d-dac171a332ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fdcd76a8-071c-40bc-aa26-bdf11b1ba67b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff86b003-8b8e-46c6-a078-ad1ed263d1c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffbaf164-eee5-4036-8e54-bceeed9e10cf"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("01caacbc-2020-4143-a580-f53a22cbc4c6"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("047366ea-fc96-4d77-b4c7-89587cc12a0e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("05c77e8a-61e5-4198-ad04-a8787f771da7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("07ecf088-07b9-47b5-9b73-02f92f4419c9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("087509e1-ae96-4fcc-92ad-867bd7ba7c87"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0c04ecbf-b73d-4834-acb1-424624193f2d"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0f8e3549-1cde-4fcd-bf2a-8af277256798"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("112553e0-9446-42f3-b986-e59e50f749b3"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("12664761-c91c-4a25-9622-9c07a1b644f0"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("17a39e46-c86a-45ed-8b6b-3e695c8deabd"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("183d8c84-a332-4356-907e-efccdf686e02"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("1e5d7666-c1db-44ab-aae9-5e3b6c7e6631"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("1e764495-1675-497a-b622-e0271500b09b"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("227c7578-16b8-4a0e-88f6-813505ed0c35"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("299d4710-2037-4c21-a435-6e95beb40834"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("29d47cf0-5ba8-466a-b65a-8d3033d57cf9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("2caa1b6e-e70e-4727-b1b3-c4c3f1344d07"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("367a7d1f-38c3-4861-a6ed-c952a5199ef1"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("374239ac-586b-4ef4-8960-efe7b1ef8b08"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("37f93db9-781b-4717-bf39-92263822c318"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("3b9a8006-0ba3-47ff-b71b-e206d043da6d"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("430db5c9-f5fe-46d0-b934-360f940f4d43"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4ba8d26b-ea38-4110-a7bb-cec361162704"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("5321d575-8553-46fe-b66c-c265c35e0d55"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("54960527-aa39-4ae1-8c7c-dd71bd26dd9a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("58065f87-9a9c-40e6-8718-ae6d17355625"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("5e7f5ed6-ae52-4c7c-8e34-65ff3a454401"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("638a62d5-75b0-49e3-9851-f20c9f49b083"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("6711c543-f446-4a0f-b846-0636bf2d96fe"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("6ba2cb6d-4793-48ec-a84c-affb48381d44"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("6d03f262-dfd5-4f4f-8fe7-37cad73ea000"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("731fa297-a0c5-47a6-9337-a938df8a8825"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("7c3a9ce7-e6cb-4855-ba74-4d76a9da0fcb"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("7dad8bd4-891f-4f99-b27e-e9bde64fa002"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("7f009c3d-4875-4d3c-94a2-b22698cd26c7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("80678138-1d50-4dbe-9c70-48321191b04c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("81932a0a-9f17-44fe-a6ae-3f34663b855e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("8cb4d364-9736-4f84-b4df-23c3dcfadae0"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("91295781-ddf7-47d2-95fb-75bd69e9b1af"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("91751257-539f-450c-a0eb-3d79d035df4e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("97bf5ad4-c61c-497c-98f0-14ae61306d76"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("98709cc6-5c10-40ae-890d-a0bee4e6f30f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9ab9dc78-4b22-4c33-95c2-96bc5fbbc665"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9c275769-a9f2-41ae-bf25-4e7a05125e63"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9d52fc60-fef9-4291-9e0b-d6bc587931d7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a1113cdb-2466-4047-9247-536990365b58"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a26e2961-a7b1-4f33-af63-d84a86bffea3"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a2c93008-1efa-4d7d-b849-c2fe23cd7cd9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a3577ad3-46a6-4645-9c8b-6e8c912a9df2"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b2958f64-fcd1-48e7-ad9b-82a8e85bea11"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b7cc7ffb-4efc-41ee-880f-12a85fe86b28"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c2608c60-cf75-4b94-b472-0bdcb10c0305"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c2f9439a-6ad3-41b6-9d8a-66b25de6039c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("cfd38d81-1738-48b8-913a-fd72d2b856bb"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d79bc758-fcd8-46e7-bb8a-0c5330a5ae7c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d7ee1a7b-a437-4ce8-925d-8549f24cb908"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d83ec927-4efc-47df-a431-dcbc6fe6c620"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("ee475313-c274-4142-8384-2d2b529d95ad"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f4b9a123-2527-4fc0-be47-3eb5d3cbe470"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f62e324c-a800-4e38-8b3e-28327f0ac9f8"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f88412e4-6970-415c-a746-c7010325326f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f8dc0f17-381f-4c9f-9280-75b126c17bea"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("fe524395-0203-4c46-8498-8b14de36cc3b"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01dfe0eb-a6be-4032-833e-dc5e6231d0d2"), "Ethiopia" },
                    { new Guid("03cb8bc7-f1c8-4469-9a2c-4acfc39a0cfd"), "Ecuador" },
                    { new Guid("0438d38f-20df-4fa2-bbf5-612430901cbc"), "South Sudan" },
                    { new Guid("04fbbaba-9af8-448b-80a4-1a863196436e"), "Zimbabwe" },
                    { new Guid("07a89dee-0934-49ab-bed7-0ee3bdcb254b"), "Angola" },
                    { new Guid("0a803ee3-24cb-4639-99ba-a2a165b02cf4"), "Andorra" },
                    { new Guid("0aad2f1c-9c46-4f56-936a-f77f715babce"), "Nigeria" },
                    { new Guid("0b50ab45-553d-4208-b85d-324e05654885"), "Honduras" },
                    { new Guid("0bbb40b9-9975-49ac-ace8-9c760e82a832"), "Luxembourg" },
                    { new Guid("0be1b234-36db-4ce7-94d9-855bd6207dc2"), "Egypt" },
                    { new Guid("11e31301-8b86-4237-b974-79af2181ecb3"), "Nicaragua" },
                    { new Guid("12c2dcf7-69b1-4652-8a7d-31f670756fba"), "Republic of Moldova" },
                    { new Guid("12d391a0-ced4-42d0-a37a-b4a128eb73ed"), "Singapore" },
                    { new Guid("135aa121-ec33-4c6b-a29b-982a0f07fd5b"), "Indonesia" },
                    { new Guid("18e3c74e-dfad-4f1a-9d0b-7418d5a4a5ff"), "Kenya" },
                    { new Guid("196b7843-849e-4c69-8a39-e59d96c3f5ab"), "Guinea" },
                    { new Guid("1973fe82-e191-4c65-a67c-17e4d6305430"), "Malawi" },
                    { new Guid("1a3e2c8a-86b2-4368-adc6-85253a3e12e0"), "Bulgaria" },
                    { new Guid("1b0b45b7-4100-48cd-b00f-a378b4471a1a"), "Romania" },
                    { new Guid("1d07c226-d742-46b7-9c89-b499ad690fef"), "Brazil" },
                    { new Guid("1d0f3e39-fb2c-4c8e-92cb-82c1e0a75cb5"), "Philippines" },
                    { new Guid("1e2d9fcf-4efc-442c-a059-296026134fd0"), "Netherlands" },
                    { new Guid("1e4d08b6-6c86-4139-84aa-9ab1e9358ea5"), "Solomon Islands" },
                    { new Guid("1fe64ca5-6b7e-4c02-b966-a55d45f1df86"), "Bhutan" },
                    { new Guid("1fea5174-4398-43d1-8df9-c0a6b2a0596a"), "Comoros" },
                    { new Guid("22a08c9f-1737-4611-af31-da3fd94d32cd"), "Kazakhstan" },
                    { new Guid("2775da5a-72fc-4486-8240-425e7baf00be"), "Bahamas" },
                    { new Guid("28d2e71d-43c7-44ae-95a3-4121a9bbbc93"), "Afghanistan" },
                    { new Guid("29788eb1-9a58-4f6d-9890-6f6a6901bc43"), "Slovenia" },
                    { new Guid("2a92d724-06cf-444c-bc8c-30d4ce0d86b6"), "Congo" },
                    { new Guid("2fc03a73-b536-477e-aa4f-bdb4e1e6efdf"), "Tunisia" },
                    { new Guid("302097e5-8e42-458f-92db-e330b534a343"), "Switzerland" },
                    { new Guid("305ab8e5-677d-496c-9d5a-625d7e1ce330"), "El Salvador" },
                    { new Guid("32488630-e393-48f1-a95a-5e786de6296b"), "Rwanda" },
                    { new Guid("32c0c9b9-eb8d-4393-bf0e-14d2fd05587a"), "Paraguay" },
                    { new Guid("3460a6dc-84a7-4518-96df-40ec83ee0aec"), "Marshall Islands" },
                    { new Guid("3dc14a29-4203-4d72-84a3-a8ef611f0e70"), "Lesotho" },
                    { new Guid("3e793c97-cd37-4321-83f0-30c5e4e2e678"), "Antigua and Barbuda" },
                    { new Guid("3f07d0b8-c822-43ec-b176-664bf04b4303"), "Norway" },
                    { new Guid("422576d1-a274-4f2a-aece-18e1bedce757"), "Cuba" },
                    { new Guid("435572f6-7aa8-43f2-a9fc-5924cdc6815f"), "Saint Vincent and the Grenadines" },
                    { new Guid("4377ca18-d482-4411-b002-8275ffe30220"), "Lithuania" },
                    { new Guid("4439e524-5ba2-40cf-82e4-7f30ddc52035"), "Burundi" },
                    { new Guid("46db81ed-afd2-47e3-8fd6-dbb813866a3d"), "Mali" },
                    { new Guid("4b7550fb-4b99-44a0-808e-b397d6b542e6"), "Trinidad and Tobago" },
                    { new Guid("4c26443b-d087-433e-982f-c48293a111c1"), "Armenia" },
                    { new Guid("4cf8eb5c-34c0-4464-a661-438407fcd502"), "China" },
                    { new Guid("4f1143cf-3abb-486f-a73e-96e676ef49bf"), "Timor-Leste" },
                    { new Guid("5178b48a-4f92-44e5-bc0f-fa84fc6b9abf"), "Lao People’s Democratic Republic" },
                    { new Guid("52820378-3c8e-4eec-8433-5a1f606d6eb0"), "Mauritania" },
                    { new Guid("53f01b28-0c65-4bde-95f8-84c6752b85d6"), "United Arab Emirates" },
                    { new Guid("547135ab-2133-4a7c-90de-73b8f3dca225"), "Austria" },
                    { new Guid("54df6b79-1cd4-4005-b888-01975ba9b7d0"), "Sierra Leone" },
                    { new Guid("55cb6e43-06fd-4f66-b398-1e371b4d01c5"), "Suriname" },
                    { new Guid("55dfcd2b-e10e-4feb-bfb3-4e0aa95fcb07"), "Jordan" },
                    { new Guid("566bd8a7-3aa4-4b5c-a236-6b8d71e2de31"), "Czech Republic" },
                    { new Guid("58724290-e7b2-46e6-b7b3-053715cb5df0"), "Libya" },
                    { new Guid("5aba4aba-e223-47b7-b431-3866bdb73795"), "Albania" },
                    { new Guid("5b537236-775b-44ae-9f34-3e54d0f8c9e5"), "Tonga" },
                    { new Guid("5cbfc4aa-6adc-488d-9d7f-5cd27c418193"), "Togo" },
                    { new Guid("5cda8c05-3506-4114-bc9d-f0eb17cffc13"), "United Republic of Tanzania" },
                    { new Guid("5f2e541a-a337-4c39-8661-23994a812b19"), "Iceland" },
                    { new Guid("5f6d65c4-b7d2-4dea-beb2-b49625308bce"), "Seychelles" },
                    { new Guid("5fbb7313-a2d5-4a06-ab96-b90a7d1b0d13"), "Kyrgyzstan" },
                    { new Guid("5fcf3cf3-35ff-4a75-bd75-17864742b671"), "Iraq" },
                    { new Guid("61ca5cb7-e3a5-4042-901e-264094dd02fe"), "Gambia" },
                    { new Guid("67265964-0aab-4b23-b9b4-27eb3202e55a"), "Botswana" },
                    { new Guid("6847c0d3-b291-4b43-891c-68fcb8d373d3"), "Morocco" },
                    { new Guid("6864d55e-6881-47ce-ac20-ed39c127cc80"), "United Kingdom" },
                    { new Guid("6873cf41-f87e-4aaf-92d2-54a3a24bf8d1"), "India" },
                    { new Guid("699198a7-e435-43fd-84d4-46da07d3aaf5"), "Barbados" },
                    { new Guid("6a151c8f-86f7-4d95-a104-a53eed632a2f"), "Sao Tome and Principe" },
                    { new Guid("6de3fe33-7f67-4659-bfd3-559f1bb54439"), "Burkina Faso" },
                    { new Guid("6e82d7ba-e6c0-49b6-a48f-33d52d9819a6"), "Israel" },
                    { new Guid("6f02df1b-bed0-4f03-8582-17fbd3bf7ae5"), "Sweden" },
                    { new Guid("701df095-0fca-42aa-a624-f6705671809e"), "Malta" },
                    { new Guid("727135a3-6b9b-4842-8a1d-b4f3da9eb8b9"), "Cambodia" },
                    { new Guid("7437f036-e903-49be-8f8b-047f135d9334"), "Dominican Republic" },
                    { new Guid("7463b716-55d1-4efc-b7a3-1a6b04d7ac9d"), "Djibouti" },
                    { new Guid("7745c43b-31be-4ae3-b83c-80df0d50a02f"), "Uzbekistan" },
                    { new Guid("778a9256-8754-4862-9c12-059c5efae752"), "Eswatini" },
                    { new Guid("779598b0-4f44-41cf-bd8e-e2cb26d482b1"), "Costa Rica" },
                    { new Guid("7bb842dd-51c0-41b8-83ea-fcfb886c0332"), "Canada" },
                    { new Guid("7ec12d93-4453-4e7b-9316-cb174278fd27"), "Mexico" },
                    { new Guid("7f83ff4f-38c4-4c10-b281-c1dec7dbd191"), "Palau" },
                    { new Guid("80aa188e-a10c-47b1-82a3-2ff126d0ac05"), "North Macedonia" },
                    { new Guid("827f4abd-78a8-40d8-b857-82b519974ab0"), "Benin" },
                    { new Guid("83d30710-c640-47f3-9220-77911665bfb5"), "Portugal" },
                    { new Guid("84a9a00e-f7f5-428a-904b-5b1f65c32706"), "Panama" },
                    { new Guid("858604fb-7007-43b3-978c-6b4946f831d8"), "Spain" },
                    { new Guid("85893731-e04f-4eb0-b47d-1c36864ecb77"), "Democratic People’s Republic of Korea" },
                    { new Guid("861d7b70-c33b-4549-8a12-be54c8562b2f"), "Kiribati" },
                    { new Guid("87119888-7057-4117-8904-b4b25799ff77"), "Niger" },
                    { new Guid("87b6f2a2-5b43-4f77-9b92-d20073366fee"), "Nauru" },
                    { new Guid("8b50a33b-950b-4262-8af4-cd01f3779dd8"), "Qatar" },
                    { new Guid("8b76a361-7bf5-4a2d-b145-8682e11e0b76"), "Colombia" },
                    { new Guid("8cbebd8b-1757-421d-9b20-045da41727f2"), "Kuwait" },
                    { new Guid("8e0a0eae-1b2a-43a6-97fc-9165a47f429a"), "Malaysia" },
                    { new Guid("8eec4eed-e816-4180-9a1c-12bb8cfd1974"), "Montenegro" },
                    { new Guid("911ed22b-6e24-4359-aad3-00f05d7a0c8b"), "Central African Republic" },
                    { new Guid("91656314-397f-4cc6-a763-5e9e5ae7997d"), "Lebanon" },
                    { new Guid("9271ed71-393b-41e4-b1a4-ca9a2c3a8144"), "Senegal" },
                    { new Guid("93025720-16db-4631-8dc1-ffcff3ecb809"), "Chile" },
                    { new Guid("93740b65-b5bc-441a-b861-3f7e552d1a41"), "Serbia" },
                    { new Guid("95bcb57d-df6c-46db-9314-d6fd2ce4dc18"), "San Marino" },
                    { new Guid("970c1ef5-7497-49b9-ad45-eaa70e6f77d4"), "Oman" },
                    { new Guid("9832e863-cbde-4119-94c5-88d9e14b8ec3"), "Brunei Darussalam" },
                    { new Guid("9a9e0029-2f48-4951-93fb-890ebddf7d3c"), "Ghana" },
                    { new Guid("9b176776-9da7-4d25-9a7a-fb562a2e138d"), "Japan" },
                    { new Guid("9b9154d1-76ed-4cc1-91f3-032097c9ccc2"), "Monaco" },
                    { new Guid("9c038faf-2c39-4fcc-b4e1-7a0176f986ba"), "Chad" },
                    { new Guid("9c29c723-07c6-48ef-8c4e-d1af2df7a58d"), "Eritrea" },
                    { new Guid("9cf40b01-1216-424d-9844-a3fd98e8b248"), "Latvia" },
                    { new Guid("9dbd61b2-1102-4611-bc40-980284c5de6d"), "Zambia" },
                    { new Guid("a0dedc08-99cd-40fd-a482-9a8b343617bd"), "Belgium" },
                    { new Guid("a5f6d64d-dc93-4909-a015-d2258b645173"), "Bolivia" },
                    { new Guid("a6d131cf-9409-4c3c-a21d-fbd3db21a85d"), "Turkmenistan" },
                    { new Guid("a725076f-fb26-48f7-a5ef-64c99495780a"), "Peru" },
                    { new Guid("a735837d-db31-49b6-8dd2-032600a2dc12"), "Equatorial Guinea" },
                    { new Guid("a9e99422-e4ed-4f29-aaf4-3766e040c170"), "Turkey" },
                    { new Guid("aa0b84da-c7b1-4ed5-bfae-df69b5465cce"), "Saint Kitts and Nevis" },
                    { new Guid("aa9d94cc-b978-4874-9601-d3b9a5025504"), "Myanmar" },
                    { new Guid("adcfd3dd-0cc8-4856-814c-e21d82a5af98"), "Maldives" },
                    { new Guid("af2af0aa-be11-42f6-851e-989f8ab42b39"), "Sri Lanka" },
                    { new Guid("b12c2357-303d-4fb1-8c72-26615a494122"), "Dominica" },
                    { new Guid("b155d9c9-ab6b-4e6a-bdf9-3e519837ac48"), "Fiji" },
                    { new Guid("b2efabb2-e4cb-4421-9b45-fdf6f515f1a5"), "Bangladesh" },
                    { new Guid("b33b0edb-bc8b-4c96-8725-89d31fa6b3ce"), "Jamaica" },
                    { new Guid("b3a781ba-da50-4ae8-ae0a-07ab21dba91b"), "Guinea-Bissau" },
                    { new Guid("b6245d4c-2e0f-40e4-bf2c-213955ed11e7"), "Pakistan" },
                    { new Guid("b69d0703-adc1-4431-a46e-c534d679022e"), "Venezuela" },
                    { new Guid("b6a87fcd-bdc2-48d1-ad6c-508bb0ae15de"), "Mauritius" },
                    { new Guid("b93a5537-1e4b-4275-944d-a48951d5d635"), "Germany" },
                    { new Guid("bb0b9af2-c0fc-4a4f-a75d-cac9bf24bbbf"), "France" },
                    { new Guid("bb1931e7-2285-448e-9ff6-1f63f8fa0b62"), "Vanuatu" },
                    { new Guid("bd0b36fd-fe83-4ccb-8d01-147c0d4b81ae"), "Thailand" },
                    { new Guid("bdb7d94d-a1db-45e0-876c-7c933e61c428"), "Belarus" },
                    { new Guid("bdc5ec28-c987-41a8-aac7-8680db2d74e3"), "United States of America" },
                    { new Guid("bdfa3acc-701f-4f04-b0e0-2a0320e0d471"), "Sudan" },
                    { new Guid("bfc2a7a8-99a0-41ee-8b87-a9d9ca29270d"), "Greece" },
                    { new Guid("c01bf9ed-4038-4344-b1bc-1fc5e00bb2a7"), "Hungary" },
                    { new Guid("c320e7e1-c9b9-4abb-aab0-87030dd835ee"), "Uganda" },
                    { new Guid("c55b5212-d152-430b-a928-4423182cc229"), "Belize" },
                    { new Guid("c9346bc6-06a9-4fda-a8cc-159292efd2a4"), "Samoa" },
                    { new Guid("cb1ce783-448f-4344-b80f-578be82b4ea6"), "Nepal" },
                    { new Guid("cccfd682-7fa5-46c6-8491-8820a5960bb7"), "Cyprus" },
                    { new Guid("cd5d3de3-b029-4b5f-b872-83987e086d29"), "Georgia" },
                    { new Guid("cef6cdbc-2b50-4b57-9753-a3195974f19c"), "Estonia" },
                    { new Guid("d0d16798-69e3-4faf-99fe-63c8ea1f7d84"), "Iran (Islamic Republic of)" },
                    { new Guid("d20d3ed4-1be5-4b5e-a5bc-fc7243173fa3"), "Guatemala" },
                    { new Guid("d317c6b8-08a3-4044-9371-b53380bf1735"), "Ireland" },
                    { new Guid("d426bcac-7ec8-4df7-b890-0d37d0091f54"), "Somalia" },
                    { new Guid("d4483dde-ef03-45a8-be7e-926c554d795e"), "Madagascar" },
                    { new Guid("d4567278-6eb9-46d1-8cea-decf9432ce63"), "Ukraine" },
                    { new Guid("d503a736-d5fb-46df-ab7c-e01eac0ec9c6"), "Argentina" },
                    { new Guid("d56f75d1-55ec-4323-8069-2a7e1bf6c670"), "Federated States of Micronesia" },
                    { new Guid("d67bc1f9-2562-43e0-b334-e01d43d1c65a"), "Papua New Guinea" },
                    { new Guid("d6d7766b-3224-4902-b7d0-fe5eea61a396"), "Côte d'Ivoire" },
                    { new Guid("db319ff9-6623-454b-a6a7-5864a19a46fc"), "Liberia" },
                    { new Guid("db399bd1-8649-40b0-bd05-146831314cc6"), "Uruguay" },
                    { new Guid("db78df66-546c-4d6c-987c-d3d5b985d638"), "New Zealand" },
                    { new Guid("dcfa2291-f376-4bc8-b390-36d581942541"), "Tuvalu" },
                    { new Guid("dfaaf017-b9b6-4127-a1ac-9b5cd96e36c8"), "Republic of Korea" },
                    { new Guid("dfaf57e2-da73-4276-8d50-72565fc96efb"), "Viet Nam" },
                    { new Guid("dfd2e77f-77f9-41b4-9b92-3a9f3bd51a72"), "Algeria" },
                    { new Guid("dff3edf0-4c2a-403f-8606-9e2f6202f890"), "Haiti" },
                    { new Guid("e0493d74-3f19-47c4-b9c0-79debcf7ec3b"), "Mozambique" },
                    { new Guid("e169b7bb-59ae-4bd1-8bc6-769b61eec44e"), "Italy" },
                    { new Guid("e1fb5ec9-8830-420d-b98c-f98c9a9283bd"), "Syrian Arab Republic" },
                    { new Guid("e5b85da8-9a4a-45cc-861e-48f6e89513e1"), "Namibia" },
                    { new Guid("e73a91b1-6024-485b-b482-3474b153f40c"), "South Africa" },
                    { new Guid("e80c16d0-279e-413e-92f5-cc7e09d5e121"), "Azerbaijan" },
                    { new Guid("e835f912-3585-4098-a9ed-1ae92c554b90"), "Finland" },
                    { new Guid("e87db04c-d4c4-4aed-81b1-17dbd0ae8d5f"), "Australia" },
                    { new Guid("e8e6e268-38b7-4e8d-84be-c395f877d84b"), "Slovakia" },
                    { new Guid("eaab0e66-99d0-4e7e-a9db-52fcad984832"), "Yemen" },
                    { new Guid("eb7a42a3-b458-4c4c-ac3a-a494f3e1f77f"), "Saudi Arabia" },
                    { new Guid("ec46f6d0-3b57-4da8-a9e4-cafd141c0699"), "Russian Federation" },
                    { new Guid("ec9ac822-428f-4d81-9fa0-8751f15d4bf2"), "Denmark" },
                    { new Guid("eeb867bd-4e24-4ae4-adad-0b19ba1d8d27"), "Bosnia and Herzegovina" },
                    { new Guid("ef1e74c9-b677-498a-b1b1-f5c9553982dd"), "Mongolia" },
                    { new Guid("ef62e852-ce1d-4778-9eaf-814f95d3f9ac"), "Cameroon" },
                    { new Guid("efb0728f-a9fd-43ee-bfbb-42e2ab90d7e8"), "Croatia" },
                    { new Guid("eff84e70-5ac6-4fe4-9d38-20ca354daeb4"), "Democratic Republic of the Congo" },
                    { new Guid("f037fa9c-6b84-4f56-92f1-5dd846d65805"), "Guyana" },
                    { new Guid("f04414b8-0f9e-4c35-9083-a66eac529881"), "Gabon" },
                    { new Guid("f04eaa59-ca14-4343-8f3b-babb93691d6d"), "Poland" },
                    { new Guid("f2439764-b418-46f2-9542-9d990780cf80"), "Tajikistan" },
                    { new Guid("f289d1d2-dc17-46e8-adaf-e2477c952d4c"), "Liechtenstein" },
                    { new Guid("f638ea9c-5f87-4a54-b62d-c76ba89f9b75"), "Cabo Verde" },
                    { new Guid("f985fa46-031a-4a84-8f60-939f3b2ad911"), "Bahrain" },
                    { new Guid("fbc014da-eb19-4e82-a057-48d41c4f24f2"), "Saint Lucia" },
                    { new Guid("fc859792-5aa3-40b5-8b44-c3f0d9731ba7"), "Grenada" }
                });

            migrationBuilder.InsertData(
                table: "StudyFields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("096592b0-d76c-459a-bc95-396eecb7c1fa"), "Economics" },
                    { new Guid("0be48275-5fff-4a26-a5dc-36628d3a587a"), "Linguistics" },
                    { new Guid("15da1414-b415-4b11-b29e-f37b22fc3627"), "Fashion Design" },
                    { new Guid("19d7753b-6804-469a-b9c8-356bbc4b7846"), "Interior Design" },
                    { new Guid("1e95f577-4769-4ca5-9a98-1067ad5dcbb2"), "Machine Learning" },
                    { new Guid("1eebf596-a929-4b29-ab9d-d105f4343e80"), "DevOps Engineering" },
                    { new Guid("28088522-81c2-4d98-9c3c-db39b4627104"), "Visual Arts" },
                    { new Guid("2972f468-d26d-438c-90c7-4e013844a544"), "Business Intelligence" },
                    { new Guid("30b7d3fd-ace0-4c2b-add0-ef74e6fd979b"), "Psychology" },
                    { new Guid("34b83f47-3d6d-4848-aa09-d92624ec8575"), "Frontend Development" },
                    { new Guid("37319a56-51a9-4091-a443-31e716425f87"), "Supply Chain Management" },
                    { new Guid("37b93fb0-6731-4d6f-afc6-ba542d8fb120"), "Human Resources" },
                    { new Guid("3bbf41da-d036-4ce8-9fc4-2780b350b10b"), "Fullstack Development" },
                    { new Guid("3d5e7a17-a066-4054-978c-da384685beb9"), "Mechanical Engineering" },
                    { new Guid("40b9bd84-e547-4c85-82a3-51173c60ef61"), "Marketing" },
                    { new Guid("468b856e-2e6e-49b8-92e5-d81151fd1436"), "Law" },
                    { new Guid("4be06e4a-f62f-4913-9211-f51502fa2dd5"), "Artificial Intelligence" },
                    { new Guid("4bf21188-9565-4255-8d7f-9a88a08c89e7"), "Photography" },
                    { new Guid("4cec58f5-2c2d-4aab-a5ff-09d36994662d"), "Finance" },
                    { new Guid("58978c23-0e12-4b01-ba53-a8b2f0468754"), "Graphic Design" },
                    { new Guid("6104d628-68a3-4fe6-9de2-5907c5fb834e"), "Sociology" },
                    { new Guid("71d95e66-50b6-4e41-b8ce-f811b803d374"), "Political Science" },
                    { new Guid("76bff00e-2dcd-4140-acbc-25f1a1fa1746"), "UI/UX Design" },
                    { new Guid("77da1caf-c033-4515-b06e-523a69a836d4"), "Special Education" },
                    { new Guid("7ae85a4d-5ff0-424e-a997-fb6dd39732a3"), "E-commerce" },
                    { new Guid("7e634b93-f1bb-40cd-b267-0625b11a447a"), "Project Management" },
                    { new Guid("85796b3d-7cb8-402c-928e-e3a131691e09"), "Public Relations" },
                    { new Guid("88231da4-db4b-490c-afad-4418b1dfe568"), "Accounting" },
                    { new Guid("8af77a66-4e8b-456c-91e8-cfe5fc622dfb"), "Anthropology" },
                    { new Guid("91eeba56-d00f-4931-884e-433caeefa7cf"), "Art History" },
                    { new Guid("93990923-2321-4b2b-aec9-f55b2100c7a0"), "Theater" },
                    { new Guid("964cc71f-ee6f-4257-b7cb-2acc1d38b0b7"), "Digital Marketing" },
                    { new Guid("9663b2fc-be8a-415e-94a7-e3c16751d0f9"), "Entrepreneurship" },
                    { new Guid("96b7b826-455c-44f6-b4de-c6a252dd98d3"), "Communication" },
                    { new Guid("9b172370-6588-4e8f-928b-bc43b04960a4"), "Architecture" },
                    { new Guid("9dcc5bd5-5047-40a0-ad58-0f376f90673f"), "Cloud Computing" },
                    { new Guid("a0ef38ab-c35d-4791-bfd0-3c22b62f68e8"), "Theology" },
                    { new Guid("a55ea99b-fc17-49e9-b716-16cdd850fece"), "Veterinary Medicine" },
                    { new Guid("a7d7ccfc-7cea-454a-b71d-cf87b8ea51f8"), "Nursing" },
                    { new Guid("ab3ba727-450f-46b2-adfb-1f7e9759eb44"), "Electrical Engineering" },
                    { new Guid("ad406199-c5e9-4f9f-9cbe-e26b189cb16a"), "Education" },
                    { new Guid("ae3e3b32-221d-4228-8892-9f92184adfbc"), "Game Development" },
                    { new Guid("b2ef8dbe-f4f4-40b8-98ae-68df5bce701d"), "Data Science" },
                    { new Guid("b5009d91-8407-43cb-8dd2-d74e66d9e720"), "Philosophy" },
                    { new Guid("b59350d3-3e66-4bb4-ab15-2aaeabe15e64"), "Mobile App Development" },
                    { new Guid("b740054c-0611-4dcd-872b-05c992f2749f"), "Chemistry" },
                    { new Guid("bc2b6101-387b-40ee-af1f-cbd32bc74eeb"), "History" },
                    { new Guid("bdde1db6-25e5-4191-a8d1-10e40ed45166"), "Music" },
                    { new Guid("c0819505-7512-4b4a-83ea-b791429eddcc"), "Animation and Multimedia" },
                    { new Guid("c363bbb2-4c42-4fa5-83d0-22143bfae779"), "Environmental Science" },
                    { new Guid("c4abbb3f-b82d-4cd8-b257-808805cae199"), "Biology" },
                    { new Guid("cb0933c3-64d9-436a-9157-b56e4200442f"), "Backend Development" },
                    { new Guid("d86db8cb-0f2e-422d-90a9-b324e469c578"), "Computer Science" },
                    { new Guid("d911493b-1141-4bd1-8d9d-8b9e6d5a13ed"), "Business Administration" },
                    { new Guid("d9161652-f95d-4af4-a14a-d2abd5f0f969"), "Civil Engineering" },
                    { new Guid("dea6d09e-49d5-49e5-90c8-85c0d2d7f55e"), "Journalism" },
                    { new Guid("df8683db-7dc7-4e64-b1cf-0e4ce8e2869c"), "International Relations" },
                    { new Guid("e0ce9094-91f3-475c-b23b-c0c61b7cdc1f"), "Physics" },
                    { new Guid("e298f5b6-9eb7-412a-a84b-ff363d623c29"), "Pharmacy" },
                    { new Guid("ea77928f-9d2c-4fec-b721-fb9f5777deac"), "Film Studies" },
                    { new Guid("eb280417-c4ac-4c78-b745-0b74d29f838c"), "Cyber Security" },
                    { new Guid("f07c256b-461d-4c7d-80f1-f195a0cedea3"), "Mathematics" },
                    { new Guid("f5be7490-6a02-4a8c-a571-7f1cc9f7cc2a"), "Medicine" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarUrl", "City", "CommunityId", "Country", "CreatedAt", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Location", "PasswordHash", "RefreshToken", "RefreshTokenExpiry", "Role", "StudyField" },
                values: new object[,]
                {
                    { new Guid("4090ae7d-6d47-4050-85a5-4bb4f091812a"), null, "Tel Aviv", null, "Israel", new DateTime(2025, 5, 3, 18, 12, 3, 495, DateTimeKind.Utc).AddTicks(5510), null, "admin1@studybuddy.com", "Admin", null, "One", "Israel", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", null, null, "Admin", null },
                    { new Guid("60084c26-ce58-4a4e-b74f-ebe9775ff783"), null, "New York", null, "USA", new DateTime(2025, 5, 3, 18, 12, 3, 504, DateTimeKind.Utc).AddTicks(9322), null, "admin2@studybuddy.com", "Admin", null, "Two", "USA", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", null, null, "Admin", null },
                    { new Guid("921d4776-fdd5-4ad5-a5d6-c5c4dee92a82"), null, "London", null, "UK", new DateTime(2025, 5, 3, 18, 12, 3, 505, DateTimeKind.Utc).AddTicks(1271), null, "admin3@studybuddy.com", "Admin", null, "Three", "UK", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", null, null, "Admin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01dfe0eb-a6be-4032-833e-dc5e6231d0d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("03cb8bc7-f1c8-4469-9a2c-4acfc39a0cfd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0438d38f-20df-4fa2-bbf5-612430901cbc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04fbbaba-9af8-448b-80a4-1a863196436e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07a89dee-0934-49ab-bed7-0ee3bdcb254b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a803ee3-24cb-4639-99ba-a2a165b02cf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0aad2f1c-9c46-4f56-936a-f77f715babce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b50ab45-553d-4208-b85d-324e05654885"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bbb40b9-9975-49ac-ace8-9c760e82a832"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0be1b234-36db-4ce7-94d9-855bd6207dc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11e31301-8b86-4237-b974-79af2181ecb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12c2dcf7-69b1-4652-8a7d-31f670756fba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12d391a0-ced4-42d0-a37a-b4a128eb73ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("135aa121-ec33-4c6b-a29b-982a0f07fd5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18e3c74e-dfad-4f1a-9d0b-7418d5a4a5ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("196b7843-849e-4c69-8a39-e59d96c3f5ab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1973fe82-e191-4c65-a67c-17e4d6305430"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1a3e2c8a-86b2-4368-adc6-85253a3e12e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b0b45b7-4100-48cd-b00f-a378b4471a1a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d07c226-d742-46b7-9c89-b499ad690fef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d0f3e39-fb2c-4c8e-92cb-82c1e0a75cb5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e2d9fcf-4efc-442c-a059-296026134fd0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e4d08b6-6c86-4139-84aa-9ab1e9358ea5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fe64ca5-6b7e-4c02-b966-a55d45f1df86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1fea5174-4398-43d1-8df9-c0a6b2a0596a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("22a08c9f-1737-4611-af31-da3fd94d32cd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2775da5a-72fc-4486-8240-425e7baf00be"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28d2e71d-43c7-44ae-95a3-4121a9bbbc93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29788eb1-9a58-4f6d-9890-6f6a6901bc43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a92d724-06cf-444c-bc8c-30d4ce0d86b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2fc03a73-b536-477e-aa4f-bdb4e1e6efdf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("302097e5-8e42-458f-92db-e330b534a343"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("305ab8e5-677d-496c-9d5a-625d7e1ce330"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32488630-e393-48f1-a95a-5e786de6296b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32c0c9b9-eb8d-4393-bf0e-14d2fd05587a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3460a6dc-84a7-4518-96df-40ec83ee0aec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3dc14a29-4203-4d72-84a3-a8ef611f0e70"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e793c97-cd37-4321-83f0-30c5e4e2e678"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f07d0b8-c822-43ec-b176-664bf04b4303"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("422576d1-a274-4f2a-aece-18e1bedce757"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("435572f6-7aa8-43f2-a9fc-5924cdc6815f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4377ca18-d482-4411-b002-8275ffe30220"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4439e524-5ba2-40cf-82e4-7f30ddc52035"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("46db81ed-afd2-47e3-8fd6-dbb813866a3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b7550fb-4b99-44a0-808e-b397d6b542e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c26443b-d087-433e-982f-c48293a111c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4cf8eb5c-34c0-4464-a661-438407fcd502"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f1143cf-3abb-486f-a73e-96e676ef49bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5178b48a-4f92-44e5-bc0f-fa84fc6b9abf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("52820378-3c8e-4eec-8433-5a1f606d6eb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53f01b28-0c65-4bde-95f8-84c6752b85d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("547135ab-2133-4a7c-90de-73b8f3dca225"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("54df6b79-1cd4-4005-b888-01975ba9b7d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55cb6e43-06fd-4f66-b398-1e371b4d01c5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55dfcd2b-e10e-4feb-bfb3-4e0aa95fcb07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("566bd8a7-3aa4-4b5c-a236-6b8d71e2de31"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58724290-e7b2-46e6-b7b3-053715cb5df0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5aba4aba-e223-47b7-b431-3866bdb73795"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5b537236-775b-44ae-9f34-3e54d0f8c9e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5cbfc4aa-6adc-488d-9d7f-5cd27c418193"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5cda8c05-3506-4114-bc9d-f0eb17cffc13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f2e541a-a337-4c39-8661-23994a812b19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5f6d65c4-b7d2-4dea-beb2-b49625308bce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fbb7313-a2d5-4a06-ab96-b90a7d1b0d13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fcf3cf3-35ff-4a75-bd75-17864742b671"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61ca5cb7-e3a5-4042-901e-264094dd02fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67265964-0aab-4b23-b9b4-27eb3202e55a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6847c0d3-b291-4b43-891c-68fcb8d373d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6864d55e-6881-47ce-ac20-ed39c127cc80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6873cf41-f87e-4aaf-92d2-54a3a24bf8d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("699198a7-e435-43fd-84d4-46da07d3aaf5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6a151c8f-86f7-4d95-a104-a53eed632a2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6de3fe33-7f67-4659-bfd3-559f1bb54439"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e82d7ba-e6c0-49b6-a48f-33d52d9819a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f02df1b-bed0-4f03-8582-17fbd3bf7ae5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("701df095-0fca-42aa-a624-f6705671809e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("727135a3-6b9b-4842-8a1d-b4f3da9eb8b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7437f036-e903-49be-8f8b-047f135d9334"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7463b716-55d1-4efc-b7a3-1a6b04d7ac9d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7745c43b-31be-4ae3-b83c-80df0d50a02f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("778a9256-8754-4862-9c12-059c5efae752"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("779598b0-4f44-41cf-bd8e-e2cb26d482b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7bb842dd-51c0-41b8-83ea-fcfb886c0332"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ec12d93-4453-4e7b-9316-cb174278fd27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f83ff4f-38c4-4c10-b281-c1dec7dbd191"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80aa188e-a10c-47b1-82a3-2ff126d0ac05"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("827f4abd-78a8-40d8-b857-82b519974ab0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83d30710-c640-47f3-9220-77911665bfb5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84a9a00e-f7f5-428a-904b-5b1f65c32706"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("858604fb-7007-43b3-978c-6b4946f831d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85893731-e04f-4eb0-b47d-1c36864ecb77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("861d7b70-c33b-4549-8a12-be54c8562b2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87119888-7057-4117-8904-b4b25799ff77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87b6f2a2-5b43-4f77-9b92-d20073366fee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b50a33b-950b-4262-8af4-cd01f3779dd8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b76a361-7bf5-4a2d-b145-8682e11e0b76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cbebd8b-1757-421d-9b20-045da41727f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e0a0eae-1b2a-43a6-97fc-9165a47f429a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8eec4eed-e816-4180-9a1c-12bb8cfd1974"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("911ed22b-6e24-4359-aad3-00f05d7a0c8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91656314-397f-4cc6-a763-5e9e5ae7997d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9271ed71-393b-41e4-b1a4-ca9a2c3a8144"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93025720-16db-4631-8dc1-ffcff3ecb809"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93740b65-b5bc-441a-b861-3f7e552d1a41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("95bcb57d-df6c-46db-9314-d6fd2ce4dc18"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("970c1ef5-7497-49b9-ad45-eaa70e6f77d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9832e863-cbde-4119-94c5-88d9e14b8ec3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a9e0029-2f48-4951-93fb-890ebddf7d3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b176776-9da7-4d25-9a7a-fb562a2e138d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b9154d1-76ed-4cc1-91f3-032097c9ccc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c038faf-2c39-4fcc-b4e1-7a0176f986ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c29c723-07c6-48ef-8c4e-d1af2df7a58d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9cf40b01-1216-424d-9844-a3fd98e8b248"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9dbd61b2-1102-4611-bc40-980284c5de6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0dedc08-99cd-40fd-a482-9a8b343617bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a5f6d64d-dc93-4909-a015-d2258b645173"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6d131cf-9409-4c3c-a21d-fbd3db21a85d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a725076f-fb26-48f7-a5ef-64c99495780a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a735837d-db31-49b6-8dd2-032600a2dc12"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9e99422-e4ed-4f29-aaf4-3766e040c170"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa0b84da-c7b1-4ed5-bfae-df69b5465cce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa9d94cc-b978-4874-9601-d3b9a5025504"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("adcfd3dd-0cc8-4856-814c-e21d82a5af98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af2af0aa-be11-42f6-851e-989f8ab42b39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b12c2357-303d-4fb1-8c72-26615a494122"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b155d9c9-ab6b-4e6a-bdf9-3e519837ac48"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2efabb2-e4cb-4421-9b45-fdf6f515f1a5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b33b0edb-bc8b-4c96-8725-89d31fa6b3ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3a781ba-da50-4ae8-ae0a-07ab21dba91b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6245d4c-2e0f-40e4-bf2c-213955ed11e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b69d0703-adc1-4431-a46e-c534d679022e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6a87fcd-bdc2-48d1-ad6c-508bb0ae15de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b93a5537-1e4b-4275-944d-a48951d5d635"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb0b9af2-c0fc-4a4f-a75d-cac9bf24bbbf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb1931e7-2285-448e-9ff6-1f63f8fa0b62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd0b36fd-fe83-4ccb-8d01-147c0d4b81ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdb7d94d-a1db-45e0-876c-7c933e61c428"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdc5ec28-c987-41a8-aac7-8680db2d74e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdfa3acc-701f-4f04-b0e0-2a0320e0d471"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfc2a7a8-99a0-41ee-8b87-a9d9ca29270d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c01bf9ed-4038-4344-b1bc-1fc5e00bb2a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c320e7e1-c9b9-4abb-aab0-87030dd835ee"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c55b5212-d152-430b-a928-4423182cc229"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9346bc6-06a9-4fda-a8cc-159292efd2a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb1ce783-448f-4344-b80f-578be82b4ea6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cccfd682-7fa5-46c6-8491-8820a5960bb7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd5d3de3-b029-4b5f-b872-83987e086d29"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cef6cdbc-2b50-4b57-9753-a3195974f19c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0d16798-69e3-4faf-99fe-63c8ea1f7d84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d20d3ed4-1be5-4b5e-a5bc-fc7243173fa3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d317c6b8-08a3-4044-9371-b53380bf1735"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d426bcac-7ec8-4df7-b890-0d37d0091f54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4483dde-ef03-45a8-be7e-926c554d795e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d4567278-6eb9-46d1-8cea-decf9432ce63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d503a736-d5fb-46df-ab7c-e01eac0ec9c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d56f75d1-55ec-4323-8069-2a7e1bf6c670"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d67bc1f9-2562-43e0-b334-e01d43d1c65a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6d7766b-3224-4902-b7d0-fe5eea61a396"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db319ff9-6623-454b-a6a7-5864a19a46fc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db399bd1-8649-40b0-bd05-146831314cc6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db78df66-546c-4d6c-987c-d3d5b985d638"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dcfa2291-f376-4bc8-b390-36d581942541"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfaaf017-b9b6-4127-a1ac-9b5cd96e36c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfaf57e2-da73-4276-8d50-72565fc96efb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfd2e77f-77f9-41b4-9b92-3a9f3bd51a72"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dff3edf0-4c2a-403f-8606-9e2f6202f890"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0493d74-3f19-47c4-b9c0-79debcf7ec3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e169b7bb-59ae-4bd1-8bc6-769b61eec44e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1fb5ec9-8830-420d-b98c-f98c9a9283bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5b85da8-9a4a-45cc-861e-48f6e89513e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e73a91b1-6024-485b-b482-3474b153f40c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e80c16d0-279e-413e-92f5-cc7e09d5e121"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e835f912-3585-4098-a9ed-1ae92c554b90"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e87db04c-d4c4-4aed-81b1-17dbd0ae8d5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8e6e268-38b7-4e8d-84be-c395f877d84b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eaab0e66-99d0-4e7e-a9db-52fcad984832"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb7a42a3-b458-4c4c-ac3a-a494f3e1f77f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec46f6d0-3b57-4da8-a9e4-cafd141c0699"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec9ac822-428f-4d81-9fa0-8751f15d4bf2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eeb867bd-4e24-4ae4-adad-0b19ba1d8d27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef1e74c9-b677-498a-b1b1-f5c9553982dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ef62e852-ce1d-4778-9eaf-814f95d3f9ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efb0728f-a9fd-43ee-bfbb-42e2ab90d7e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eff84e70-5ac6-4fe4-9d38-20ca354daeb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f037fa9c-6b84-4f56-92f1-5dd846d65805"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f04414b8-0f9e-4c35-9083-a66eac529881"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f04eaa59-ca14-4343-8f3b-babb93691d6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2439764-b418-46f2-9542-9d990780cf80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f289d1d2-dc17-46e8-adaf-e2477c952d4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f638ea9c-5f87-4a54-b62d-c76ba89f9b75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f985fa46-031a-4a84-8f60-939f3b2ad911"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbc014da-eb19-4e82-a057-48d41c4f24f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc859792-5aa3-40b5-8b44-c3f0d9731ba7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("096592b0-d76c-459a-bc95-396eecb7c1fa"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0be48275-5fff-4a26-a5dc-36628d3a587a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("15da1414-b415-4b11-b29e-f37b22fc3627"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("19d7753b-6804-469a-b9c8-356bbc4b7846"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("1e95f577-4769-4ca5-9a98-1067ad5dcbb2"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("1eebf596-a929-4b29-ab9d-d105f4343e80"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("28088522-81c2-4d98-9c3c-db39b4627104"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("2972f468-d26d-438c-90c7-4e013844a544"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("30b7d3fd-ace0-4c2b-add0-ef74e6fd979b"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("34b83f47-3d6d-4848-aa09-d92624ec8575"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("37319a56-51a9-4091-a443-31e716425f87"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("37b93fb0-6731-4d6f-afc6-ba542d8fb120"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("3bbf41da-d036-4ce8-9fc4-2780b350b10b"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("3d5e7a17-a066-4054-978c-da384685beb9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("40b9bd84-e547-4c85-82a3-51173c60ef61"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("468b856e-2e6e-49b8-92e5-d81151fd1436"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4be06e4a-f62f-4913-9211-f51502fa2dd5"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4bf21188-9565-4255-8d7f-9a88a08c89e7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4cec58f5-2c2d-4aab-a5ff-09d36994662d"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("58978c23-0e12-4b01-ba53-a8b2f0468754"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("6104d628-68a3-4fe6-9de2-5907c5fb834e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("71d95e66-50b6-4e41-b8ce-f811b803d374"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("76bff00e-2dcd-4140-acbc-25f1a1fa1746"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("77da1caf-c033-4515-b06e-523a69a836d4"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("7ae85a4d-5ff0-424e-a997-fb6dd39732a3"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("7e634b93-f1bb-40cd-b267-0625b11a447a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("85796b3d-7cb8-402c-928e-e3a131691e09"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("88231da4-db4b-490c-afad-4418b1dfe568"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("8af77a66-4e8b-456c-91e8-cfe5fc622dfb"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("91eeba56-d00f-4931-884e-433caeefa7cf"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("93990923-2321-4b2b-aec9-f55b2100c7a0"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("964cc71f-ee6f-4257-b7cb-2acc1d38b0b7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9663b2fc-be8a-415e-94a7-e3c16751d0f9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("96b7b826-455c-44f6-b4de-c6a252dd98d3"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9b172370-6588-4e8f-928b-bc43b04960a4"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9dcc5bd5-5047-40a0-ad58-0f376f90673f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a0ef38ab-c35d-4791-bfd0-3c22b62f68e8"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a55ea99b-fc17-49e9-b716-16cdd850fece"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a7d7ccfc-7cea-454a-b71d-cf87b8ea51f8"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("ab3ba727-450f-46b2-adfb-1f7e9759eb44"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("ad406199-c5e9-4f9f-9cbe-e26b189cb16a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("ae3e3b32-221d-4228-8892-9f92184adfbc"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b2ef8dbe-f4f4-40b8-98ae-68df5bce701d"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b5009d91-8407-43cb-8dd2-d74e66d9e720"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b59350d3-3e66-4bb4-ab15-2aaeabe15e64"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b740054c-0611-4dcd-872b-05c992f2749f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("bc2b6101-387b-40ee-af1f-cbd32bc74eeb"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("bdde1db6-25e5-4191-a8d1-10e40ed45166"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c0819505-7512-4b4a-83ea-b791429eddcc"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c363bbb2-4c42-4fa5-83d0-22143bfae779"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c4abbb3f-b82d-4cd8-b257-808805cae199"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("cb0933c3-64d9-436a-9157-b56e4200442f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d86db8cb-0f2e-422d-90a9-b324e469c578"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d911493b-1141-4bd1-8d9d-8b9e6d5a13ed"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d9161652-f95d-4af4-a14a-d2abd5f0f969"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("dea6d09e-49d5-49e5-90c8-85c0d2d7f55e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("df8683db-7dc7-4e64-b1cf-0e4ce8e2869c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("e0ce9094-91f3-475c-b23b-c0c61b7cdc1f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("e298f5b6-9eb7-412a-a84b-ff363d623c29"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("ea77928f-9d2c-4fec-b721-fb9f5777deac"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("eb280417-c4ac-4c78-b745-0b74d29f838c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f07c256b-461d-4c7d-80f1-f195a0cedea3"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f5be7490-6a02-4a8c-a571-7f1cc9f7cc2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4090ae7d-6d47-4050-85a5-4bb4f091812a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60084c26-ce58-4a4e-b74f-ebe9775ff783"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("921d4776-fdd5-4ad5-a5d6-c5c4dee92a82"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02c27073-a83a-4a1e-8ae5-dfd0f8563a8d"), "Greece" },
                    { new Guid("02da320d-bfd5-487e-bc48-edb870cc420e"), "France" },
                    { new Guid("0454dd99-2206-4e90-98b5-225f91f97300"), "Marshall Islands" },
                    { new Guid("04f68471-1b22-4012-b759-bba4715592a6"), "Lesotho" },
                    { new Guid("0865a6c6-51ff-49cf-aff4-09f1f641e07e"), "Benin" },
                    { new Guid("08bad423-b9db-4115-a830-39ed398973c2"), "South Sudan" },
                    { new Guid("08e4ee4f-aa0c-4160-9c7d-ceba3e408fe0"), "Iran (Islamic Republic of)" },
                    { new Guid("0ad27e9e-c5f3-49e0-8197-09cf65fd37fa"), "Liberia" },
                    { new Guid("0d3d90d5-86b8-4a6f-a10f-38fe0f23d47a"), "Gambia" },
                    { new Guid("0d4b6fd6-5ae7-4baa-a4d6-e12aa0503efb"), "Guyana" },
                    { new Guid("10f7eec9-296e-482a-ab68-e290c29b51d4"), "Syrian Arab Republic" },
                    { new Guid("111898b2-3aaa-4268-bfe4-7969f283d4bc"), "Kiribati" },
                    { new Guid("1336df21-c69f-41f8-901a-4ca027d773e4"), "Somalia" },
                    { new Guid("141f6ddf-1878-4d78-8a05-d64dea52687b"), "Venezuela" },
                    { new Guid("15c6fb24-2684-4f60-bc33-d2f1d41b42d5"), "Andorra" },
                    { new Guid("1a31705e-c513-4730-9fb6-87486f498935"), "China" },
                    { new Guid("1a7c629e-3bd3-4f84-ad6b-0fd33b9760e8"), "Georgia" },
                    { new Guid("1ac63b6b-7d4d-43ec-b67b-033ce0a24bd6"), "Ukraine" },
                    { new Guid("1afc6161-706b-4b82-9005-f7e791b57144"), "Czech Republic" },
                    { new Guid("1ee1d4a1-f256-4b2d-a3ac-c70ed7b65f1f"), "Djibouti" },
                    { new Guid("1fda00b2-f2a7-406c-bc65-c1a2720e0fde"), "Tajikistan" },
                    { new Guid("20481f14-68ad-41f4-9a41-a9b28889d223"), "Iceland" },
                    { new Guid("20638166-1419-40a2-bf88-368e15c0badb"), "Armenia" },
                    { new Guid("20c63948-0534-4e2e-8ee8-f11c3273aafe"), "Croatia" },
                    { new Guid("221f3c69-023e-4e0e-9007-d3f17d7adf51"), "Democratic Republic of the Congo" },
                    { new Guid("22fc1b2b-e19d-4022-b43e-3c42398970c3"), "Maldives" },
                    { new Guid("2442368f-67e4-4b7e-8704-169dc2632c25"), "Eswatini" },
                    { new Guid("246605d5-174b-46c8-8124-53b271f5c03a"), "Latvia" },
                    { new Guid("25cca9d8-e76d-4c6e-80a5-762a2e08d8e6"), "Barbados" },
                    { new Guid("26544ad9-3ee5-46a8-9908-4f35754647ed"), "Sudan" },
                    { new Guid("292b5a45-6186-4edd-b9f8-c1bc776ccd1d"), "Ireland" },
                    { new Guid("298149fa-1b79-4974-9f0d-fbaf2e20de83"), "Italy" },
                    { new Guid("2c2d9fc4-85e1-4f63-aca5-a35243f95a4c"), "South Africa" },
                    { new Guid("2c815689-d213-4653-a549-1ada98daa40e"), "Chad" },
                    { new Guid("30d93526-8c51-4316-b0de-7f30abac01ef"), "Denmark" },
                    { new Guid("339e6f4b-54d7-4f71-8677-b8f0f7d01d40"), "Netherlands" },
                    { new Guid("3481464c-46ff-4f25-b6fb-cf3fd71bb7ee"), "Comoros" },
                    { new Guid("359e8700-7d19-47a1-802d-f408fc0adfe9"), "Costa Rica" },
                    { new Guid("35d361de-a82a-4bdc-8cd6-9ae30fedb921"), "Lithuania" },
                    { new Guid("37e872b7-cc8e-4ef9-a54b-de90ca70fcb6"), "Dominican Republic" },
                    { new Guid("3b209592-bbd3-445a-8fc4-ee507fa1fe04"), "Burundi" },
                    { new Guid("3d057b0c-bec8-4f43-8f89-649ff17a0c40"), "Tunisia" },
                    { new Guid("3de26b80-241e-4159-81ca-3a4f358d30c7"), "Ecuador" },
                    { new Guid("3e53eab3-d2c0-413f-a86b-08c4fb8b7ff1"), "Saint Lucia" },
                    { new Guid("3ec088fd-c6e1-4746-9b79-68e601f9d84f"), "Mexico" },
                    { new Guid("405795c4-5ba8-43e6-99be-aedb153ada56"), "Estonia" },
                    { new Guid("43ed6e4d-d23a-4325-8640-266609b2d690"), "Saint Kitts and Nevis" },
                    { new Guid("43fdd93b-41e9-43a3-baf8-b8057c7ebe33"), "Viet Nam" },
                    { new Guid("451a0559-1e6c-41df-ab68-5bbeb74cc1c1"), "Panama" },
                    { new Guid("4520e66b-93db-4d26-94dd-8da20120bfd8"), "Yemen" },
                    { new Guid("45b5486c-7341-46f1-81d8-0bfff3eb55e8"), "New Zealand" },
                    { new Guid("46b4a1f2-c28f-41fa-8228-4e67df403f40"), "Portugal" },
                    { new Guid("4737cb89-a840-4223-b24f-4de46427d1e4"), "Philippines" },
                    { new Guid("4917f085-e3b6-4943-8169-9430a0a6d01e"), "Monaco" },
                    { new Guid("49cd3429-ee3c-4d02-9262-04f8a4059782"), "Niger" },
                    { new Guid("4a904a1c-e34b-4e72-a336-42d4d4c8c669"), "Slovenia" },
                    { new Guid("4acc4eb8-518d-4df9-b0b1-3e32b33e2170"), "Uganda" },
                    { new Guid("4e04532a-77e7-4f90-8aed-679a714f7070"), "Kenya" },
                    { new Guid("51ce7a95-64da-45f7-b3ef-2ed6953a5703"), "Sierra Leone" },
                    { new Guid("5208e37a-6e8c-46bf-aae3-4cd21c94039c"), "Republic of Korea" },
                    { new Guid("522a1072-5543-4543-9462-4d9534b93edf"), "Malta" },
                    { new Guid("553f96f6-febe-4dbf-ad54-44d630235051"), "Togo" },
                    { new Guid("55e6c82a-24d2-4009-b2e8-d3295dd098db"), "Uzbekistan" },
                    { new Guid("55e88e73-1303-4256-91ac-9c53b2bffa31"), "Liechtenstein" },
                    { new Guid("591dd074-e4cd-4df0-b4b0-59582ccf6948"), "Suriname" },
                    { new Guid("59a962e4-c655-40fb-9982-300f228c9c8d"), "Germany" },
                    { new Guid("5c74debc-25fd-4a41-a5c5-2fda9553d3ee"), "Bangladesh" },
                    { new Guid("5d297cfe-4188-4b21-8411-7e4dc156f650"), "Uruguay" },
                    { new Guid("5d360dc8-f3f8-4f17-a174-bc1453b3304a"), "Hungary" },
                    { new Guid("5ee1ce1c-0248-4535-80ae-264008bee994"), "Russian Federation" },
                    { new Guid("5fb1d3c2-bbbc-442a-b90a-847e7b0aa192"), "Brazil" },
                    { new Guid("5fbafd93-2a09-4fca-9f55-07bcb14152ad"), "Bulgaria" },
                    { new Guid("5fff9e97-498b-42a7-bb7c-1be3463f5d44"), "Guinea" },
                    { new Guid("6148d21f-209a-4ba4-b9ce-f8467973e8f8"), "Nauru" },
                    { new Guid("63804032-ad5e-4876-8ed5-8ac87ec534b8"), "Norway" },
                    { new Guid("63f6bf6f-3a8a-4418-928b-bf69fa1d5961"), "Nigeria" },
                    { new Guid("64a5c17e-8a5f-4987-a15c-0337d5e16baa"), "Dominica" },
                    { new Guid("6607d312-42dd-4f8d-ad7a-8e06c2361c8a"), "Tonga" },
                    { new Guid("66f4335a-2979-4598-b871-7791c6b2b383"), "Sri Lanka" },
                    { new Guid("6708579e-651b-4b6f-a87f-aac9c13539af"), "Bahrain" },
                    { new Guid("6aac487f-fead-48b9-9099-abf315c5d15c"), "Vanuatu" },
                    { new Guid("6afdc26f-0a1e-4a13-8ea9-fd5db7975952"), "Nicaragua" },
                    { new Guid("6c325dd6-66d1-46aa-9322-df65e3c2b898"), "Serbia" },
                    { new Guid("6ece6e95-9c7d-400e-baeb-8dbb181a1e19"), "Bhutan" },
                    { new Guid("6fef24b8-6f59-48ae-9f32-5c85daec66b2"), "Cuba" },
                    { new Guid("70f32a33-b7a8-49c8-beec-02535c9cf521"), "Oman" },
                    { new Guid("72d06884-81c0-451a-a74d-a812e7499dca"), "Luxembourg" },
                    { new Guid("737f8ca5-6c0b-4745-9d30-4a64f6ca3b3b"), "Libya" },
                    { new Guid("7439bfac-1d61-4dca-8dfe-787c159ae536"), "Solomon Islands" },
                    { new Guid("763d7c36-820c-4ef3-99d1-5571ec16a99b"), "Cyprus" },
                    { new Guid("763fb15a-970a-4b76-807c-cfa44438884c"), "Guatemala" },
                    { new Guid("767d0adc-5e73-436f-af77-62e5206c6b73"), "Azerbaijan" },
                    { new Guid("76cf5534-22b5-42e1-ade0-b61c2b232526"), "Singapore" },
                    { new Guid("7988ed95-3499-42c8-9eb7-57e28455a6b0"), "Namibia" },
                    { new Guid("7a854bdd-c0a0-4f33-99c0-136a744f7b5b"), "Zambia" },
                    { new Guid("7ebd1f27-a052-4629-9432-e4caf4198b7b"), "Bosnia and Herzegovina" },
                    { new Guid("80953555-8971-4f10-8ea1-9f05e32d05d4"), "Chile" },
                    { new Guid("81f5500a-f6f0-4d26-8a86-fcfa4f663170"), "Mongolia" },
                    { new Guid("8212b670-9fb4-499e-a4f0-f7f175ba8676"), "Central African Republic" },
                    { new Guid("82c44a64-7838-4c2b-a673-bf6a08729eb8"), "Grenada" },
                    { new Guid("83e01d5e-1c4a-4154-ba48-951765f8f17f"), "Seychelles" },
                    { new Guid("85df3099-dac8-437e-8b17-a7c2cff39364"), "Ethiopia" },
                    { new Guid("87344ea7-6564-430a-86b5-60d74b228231"), "Democratic People’s Republic of Korea" },
                    { new Guid("879fc656-5747-4d14-a422-2107bcbfb6a0"), "Cameroon" },
                    { new Guid("89783845-c6e5-488c-bb9a-f52ad360ec5e"), "Qatar" },
                    { new Guid("89a509bf-110b-46fe-b814-77aa57828ba9"), "Australia" },
                    { new Guid("89fc1866-1bf8-44ef-bddf-704badf91530"), "Myanmar" },
                    { new Guid("8a37e7aa-feaf-4090-949f-63aeafd67192"), "Algeria" },
                    { new Guid("8ac7a2b5-2216-413f-aaf2-a27830d35c33"), "Trinidad and Tobago" },
                    { new Guid("8b526a1c-c0af-4eec-a644-7ad33c6adee9"), "Switzerland" },
                    { new Guid("8c33eafd-d4f7-43aa-9d1d-303bde2bdcbd"), "Timor-Leste" },
                    { new Guid("8dfa1454-5721-4957-b207-e61c2d441649"), "Turkmenistan" },
                    { new Guid("91a63a49-9a69-4675-b6cf-3c3843ef46ab"), "Mauritius" },
                    { new Guid("925cfa44-9322-4c43-9511-e045fceb6b7d"), "Montenegro" },
                    { new Guid("9289511b-22ae-4e9b-9b38-fb1019ba1fa6"), "Kazakhstan" },
                    { new Guid("93376b5a-eae1-4bd3-9cac-6e3159440d85"), "India" },
                    { new Guid("936ead80-17d1-4ed0-8382-514dd4dc7696"), "Gabon" },
                    { new Guid("958c6524-e557-4307-9581-275a066e41aa"), "Iraq" },
                    { new Guid("96a446fb-2cfe-4852-9f25-b8f180ae7fcb"), "Mozambique" },
                    { new Guid("99a82519-b1a6-431c-a400-80b2af8a6e1f"), "Jamaica" },
                    { new Guid("9b21a88d-7bf6-4af9-9462-9d153d40333d"), "Sao Tome and Principe" },
                    { new Guid("9b926b14-2c76-4926-a7d2-6f91e81122d6"), "Egypt" },
                    { new Guid("9d2f9c81-d7ff-49c6-a7eb-2489dc66f0e7"), "Austria" },
                    { new Guid("9da58c99-7a60-405d-86d0-0ee57977eec7"), "Japan" },
                    { new Guid("9f006d53-b33b-439f-8189-5f8a97dba81b"), "Saudi Arabia" },
                    { new Guid("9f374410-f44e-4847-a796-d386545053f5"), "Federated States of Micronesia" },
                    { new Guid("a571624d-453c-45db-a011-ab5b53ca96c7"), "Burkina Faso" },
                    { new Guid("a923d462-d423-4e29-a394-aad88bfdc43a"), "Haiti" },
                    { new Guid("ac93353c-aedd-4cd9-9265-d57367dcb473"), "Palau" },
                    { new Guid("aec7c6fc-eda5-4bf0-befc-da1cd076c159"), "Kyrgyzstan" },
                    { new Guid("afd9301c-3783-4daa-9179-93314a5ca3db"), "Turkey" },
                    { new Guid("b130465c-7633-4206-a049-190886673c27"), "Honduras" },
                    { new Guid("b15181e5-9ca3-453a-b0d2-51aa9b903ec5"), "United Kingdom" },
                    { new Guid("b26424b7-67f4-4c68-a0db-060175c110ea"), "Malawi" },
                    { new Guid("b2d3c7b0-8035-4ea7-8c87-bf15b00a6568"), "Cambodia" },
                    { new Guid("b521fb62-7265-4d43-a014-daf0e3444436"), "Brunei Darussalam" },
                    { new Guid("b72e2c1c-bf60-4f16-abe7-60e18338a900"), "Spain" },
                    { new Guid("b855bc3e-3574-471a-a2b9-101d8f3fc91f"), "Guinea-Bissau" },
                    { new Guid("b934b198-79d9-445b-a9b7-bb8db62e38a2"), "Finland" },
                    { new Guid("ba6d36bb-2c8a-499a-b850-0bd90966b0bc"), "Antigua and Barbuda" },
                    { new Guid("bac8298c-f332-4312-8160-6d247b2440fe"), "Samoa" },
                    { new Guid("bd9f8561-fb76-4823-bebb-247211f95d3d"), "United Arab Emirates" },
                    { new Guid("bf1fecb1-daea-47c0-9a31-4e7ba87e3b8f"), "Jordan" },
                    { new Guid("c07da7e5-d83a-49ef-8087-d7a1c10237c2"), "El Salvador" },
                    { new Guid("c3c5d486-2c19-4ef6-b4d5-9d8a05963ba4"), "Angola" },
                    { new Guid("c3d70cbb-b421-4e84-9996-d121b5cdf40c"), "United Republic of Tanzania" },
                    { new Guid("c6512784-f8bd-4ec6-aa07-97a8e08c837a"), "Afghanistan" },
                    { new Guid("c6584382-3733-4b22-ba5b-e433e7b85685"), "Botswana" },
                    { new Guid("c7943c1a-bd5f-469d-a509-dc2e7a2ecc88"), "Belgium" },
                    { new Guid("c7bae37b-c15e-48d6-a019-f22673b48370"), "Bolivia" },
                    { new Guid("c7dccee1-1ee7-4928-ab2a-bbe3ac51327b"), "Mauritania" },
                    { new Guid("c81e51e5-8122-457c-af52-a75bdf93d671"), "Thailand" },
                    { new Guid("c8a643e9-66e6-4148-bb29-49727976dc05"), "Pakistan" },
                    { new Guid("c9122bec-144f-415e-9bff-3176671af921"), "Senegal" },
                    { new Guid("cabb3e02-eede-4991-9057-ab0d8a0b79a0"), "Romania" },
                    { new Guid("cb75d2e9-d793-464c-ab41-f135e2989b0d"), "Rwanda" },
                    { new Guid("ccfdf511-34fc-417b-b338-51a76153234f"), "Israel" },
                    { new Guid("ce790418-de15-4d7e-a754-07fca2aecdff"), "Fiji" },
                    { new Guid("d06b83a6-69f2-4844-a914-96d3c90dcc37"), "San Marino" },
                    { new Guid("d0b0285b-99b6-4b8a-aa65-7df6abaed306"), "Peru" },
                    { new Guid("d15a2d21-ed39-4a9c-8ed2-5621fcd166cd"), "Bahamas" },
                    { new Guid("d48f7d87-696c-46cc-8868-e71ed9f8618f"), "Ghana" },
                    { new Guid("d64dc6a1-2eca-4f7f-b5c1-f77b850ebe94"), "Eritrea" },
                    { new Guid("d659e744-9ef7-4b76-9d9d-997a6f07c7c5"), "Cabo Verde" },
                    { new Guid("d804ed1c-b725-4ae6-a29c-e111294255d0"), "Kuwait" },
                    { new Guid("d9f051dc-86c5-4150-8e2a-eb3179f8f7cf"), "Saint Vincent and the Grenadines" },
                    { new Guid("dc031d7f-0981-418a-9a7a-b9459153bd88"), "Morocco" },
                    { new Guid("dcb321dd-4eb9-46b4-a858-5c30d136b216"), "Congo" },
                    { new Guid("de176fe1-cc5c-4984-a1ca-05a923825e5a"), "Republic of Moldova" },
                    { new Guid("de1fc034-9a2f-4729-860e-30834957b610"), "Nepal" },
                    { new Guid("def41c5e-cef0-4f44-8464-fee728ee988f"), "Slovakia" },
                    { new Guid("e61b9167-5a5d-4ad6-afcc-a958ce42adac"), "Colombia" },
                    { new Guid("ea8e364c-a193-48a9-af84-e6c41a0913c4"), "Albania" },
                    { new Guid("eb6f04c5-1d89-419b-b0e6-00a0445556b3"), "Zimbabwe" },
                    { new Guid("ed624080-56f7-4533-9c15-adb9feae4f0d"), "Madagascar" },
                    { new Guid("ede0dbe0-7e8e-4343-a76d-52b6de4ff191"), "Canada" },
                    { new Guid("efa5883e-bb0b-424c-ab3c-851f0d830523"), "Côte d'Ivoire" },
                    { new Guid("efc81a4a-662e-4799-8623-3c3e3c4f6eda"), "North Macedonia" },
                    { new Guid("f055930e-0385-4f51-acaf-867fec21f9c4"), "Paraguay" },
                    { new Guid("f19701cb-a319-46a7-9f53-ea36829e84a0"), "Mali" },
                    { new Guid("f1ca1e71-a080-43c5-b571-c73f86d9e97a"), "Malaysia" },
                    { new Guid("f4554fbc-5d8e-473a-81a0-7f3aea7b04bb"), "Equatorial Guinea" },
                    { new Guid("f4cde409-dc29-4d6d-befa-176534adb934"), "United States of America" },
                    { new Guid("f550e29d-e8c2-43e3-b900-10bc19fcee50"), "Lebanon" },
                    { new Guid("f577e1c2-c85d-4ffe-907b-1ac824809e0f"), "Argentina" },
                    { new Guid("f60e4d99-6e2f-4c88-a160-2cc63b36ca0a"), "Indonesia" },
                    { new Guid("f80faaa8-8012-4a34-819f-cbcd69bfb427"), "Lao People’s Democratic Republic" },
                    { new Guid("f8f66c1c-8450-4ea9-9862-242bf28d59d1"), "Tuvalu" },
                    { new Guid("f9c4b9c8-589d-40d0-9cba-3a9920c57e17"), "Belarus" },
                    { new Guid("fbea90a2-ffc9-4288-bb9d-dac171a332ca"), "Poland" },
                    { new Guid("fdcd76a8-071c-40bc-aa26-bdf11b1ba67b"), "Sweden" },
                    { new Guid("ff86b003-8b8e-46c6-a078-ad1ed263d1c3"), "Belize" },
                    { new Guid("ffbaf164-eee5-4036-8e54-bceeed9e10cf"), "Papua New Guinea" }
                });

            migrationBuilder.InsertData(
                table: "StudyFields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01caacbc-2020-4143-a580-f53a22cbc4c6"), "Philosophy" },
                    { new Guid("047366ea-fc96-4d77-b4c7-89587cc12a0e"), "Frontend Development" },
                    { new Guid("05c77e8a-61e5-4198-ad04-a8787f771da7"), "Finance" },
                    { new Guid("07ecf088-07b9-47b5-9b73-02f92f4419c9"), "Animation and Multimedia" },
                    { new Guid("087509e1-ae96-4fcc-92ad-867bd7ba7c87"), "History" },
                    { new Guid("0c04ecbf-b73d-4834-acb1-424624193f2d"), "E-commerce" },
                    { new Guid("0f8e3549-1cde-4fcd-bf2a-8af277256798"), "Architecture" },
                    { new Guid("112553e0-9446-42f3-b986-e59e50f749b3"), "Nursing" },
                    { new Guid("12664761-c91c-4a25-9622-9c07a1b644f0"), "Sociology" },
                    { new Guid("17a39e46-c86a-45ed-8b6b-3e695c8deabd"), "UI/UX Design" },
                    { new Guid("183d8c84-a332-4356-907e-efccdf686e02"), "Film Studies" },
                    { new Guid("1e5d7666-c1db-44ab-aae9-5e3b6c7e6631"), "Artificial Intelligence" },
                    { new Guid("1e764495-1675-497a-b622-e0271500b09b"), "Game Development" },
                    { new Guid("227c7578-16b8-4a0e-88f6-813505ed0c35"), "Economics" },
                    { new Guid("299d4710-2037-4c21-a435-6e95beb40834"), "Civil Engineering" },
                    { new Guid("29d47cf0-5ba8-466a-b65a-8d3033d57cf9"), "Political Science" },
                    { new Guid("2caa1b6e-e70e-4727-b1b3-c4c3f1344d07"), "Public Relations" },
                    { new Guid("367a7d1f-38c3-4861-a6ed-c952a5199ef1"), "Mechanical Engineering" },
                    { new Guid("374239ac-586b-4ef4-8960-efe7b1ef8b08"), "Mathematics" },
                    { new Guid("37f93db9-781b-4717-bf39-92263822c318"), "Machine Learning" },
                    { new Guid("3b9a8006-0ba3-47ff-b71b-e206d043da6d"), "Marketing" },
                    { new Guid("430db5c9-f5fe-46d0-b934-360f940f4d43"), "Theater" },
                    { new Guid("4ba8d26b-ea38-4110-a7bb-cec361162704"), "Environmental Science" },
                    { new Guid("5321d575-8553-46fe-b66c-c265c35e0d55"), "Special Education" },
                    { new Guid("54960527-aa39-4ae1-8c7c-dd71bd26dd9a"), "Education" },
                    { new Guid("58065f87-9a9c-40e6-8718-ae6d17355625"), "Communication" },
                    { new Guid("5e7f5ed6-ae52-4c7c-8e34-65ff3a454401"), "DevOps Engineering" },
                    { new Guid("638a62d5-75b0-49e3-9851-f20c9f49b083"), "Business Administration" },
                    { new Guid("6711c543-f446-4a0f-b846-0636bf2d96fe"), "Cloud Computing" },
                    { new Guid("6ba2cb6d-4793-48ec-a84c-affb48381d44"), "Business Intelligence" },
                    { new Guid("6d03f262-dfd5-4f4f-8fe7-37cad73ea000"), "Interior Design" },
                    { new Guid("731fa297-a0c5-47a6-9337-a938df8a8825"), "Supply Chain Management" },
                    { new Guid("7c3a9ce7-e6cb-4855-ba74-4d76a9da0fcb"), "Theology" },
                    { new Guid("7dad8bd4-891f-4f99-b27e-e9bde64fa002"), "Accounting" },
                    { new Guid("7f009c3d-4875-4d3c-94a2-b22698cd26c7"), "Digital Marketing" },
                    { new Guid("80678138-1d50-4dbe-9c70-48321191b04c"), "Photography" },
                    { new Guid("81932a0a-9f17-44fe-a6ae-3f34663b855e"), "Music" },
                    { new Guid("8cb4d364-9736-4f84-b4df-23c3dcfadae0"), "Entrepreneurship" },
                    { new Guid("91295781-ddf7-47d2-95fb-75bd69e9b1af"), "Anthropology" },
                    { new Guid("91751257-539f-450c-a0eb-3d79d035df4e"), "Medicine" },
                    { new Guid("97bf5ad4-c61c-497c-98f0-14ae61306d76"), "International Relations" },
                    { new Guid("98709cc6-5c10-40ae-890d-a0bee4e6f30f"), "Visual Arts" },
                    { new Guid("9ab9dc78-4b22-4c33-95c2-96bc5fbbc665"), "Human Resources" },
                    { new Guid("9c275769-a9f2-41ae-bf25-4e7a05125e63"), "Fullstack Development" },
                    { new Guid("9d52fc60-fef9-4291-9e0b-d6bc587931d7"), "Project Management" },
                    { new Guid("a1113cdb-2466-4047-9247-536990365b58"), "Graphic Design" },
                    { new Guid("a26e2961-a7b1-4f33-af63-d84a86bffea3"), "Psychology" },
                    { new Guid("a2c93008-1efa-4d7d-b849-c2fe23cd7cd9"), "Electrical Engineering" },
                    { new Guid("a3577ad3-46a6-4645-9c8b-6e8c912a9df2"), "Data Science" },
                    { new Guid("b2958f64-fcd1-48e7-ad9b-82a8e85bea11"), "Mobile App Development" },
                    { new Guid("b7cc7ffb-4efc-41ee-880f-12a85fe86b28"), "Art History" },
                    { new Guid("c2608c60-cf75-4b94-b472-0bdcb10c0305"), "Law" },
                    { new Guid("c2f9439a-6ad3-41b6-9d8a-66b25de6039c"), "Computer Science" },
                    { new Guid("cfd38d81-1738-48b8-913a-fd72d2b856bb"), "Chemistry" },
                    { new Guid("d79bc758-fcd8-46e7-bb8a-0c5330a5ae7c"), "Linguistics" },
                    { new Guid("d7ee1a7b-a437-4ce8-925d-8549f24cb908"), "Biology" },
                    { new Guid("d83ec927-4efc-47df-a431-dcbc6fe6c620"), "Physics" },
                    { new Guid("ee475313-c274-4142-8384-2d2b529d95ad"), "Backend Development" },
                    { new Guid("f4b9a123-2527-4fc0-be47-3eb5d3cbe470"), "Journalism" },
                    { new Guid("f62e324c-a800-4e38-8b3e-28327f0ac9f8"), "Pharmacy" },
                    { new Guid("f88412e4-6970-415c-a746-c7010325326f"), "Cyber Security" },
                    { new Guid("f8dc0f17-381f-4c9f-9280-75b126c17bea"), "Fashion Design" },
                    { new Guid("fe524395-0203-4c46-8498-8b14de36cc3b"), "Veterinary Medicine" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarUrl", "City", "CommunityId", "Country", "CreatedAt", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Location", "PasswordHash", "RefreshToken", "RefreshTokenExpiry", "Role", "StudyField" },
                values: new object[,]
                {
                    { new Guid("321f783a-0ac5-462f-b1aa-bb589fec369a"), null, "Tel Aviv", null, "Israel", new DateTime(2025, 5, 3, 14, 23, 44, 636, DateTimeKind.Utc).AddTicks(1015), null, "admin1@studybuddy.com", "Admin", null, "One", "Israel", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", null, null, "Admin", null },
                    { new Guid("3288ed3e-e1d9-43ed-88b6-8b456321bf9c"), null, "New York", null, "USA", new DateTime(2025, 5, 3, 14, 23, 44, 640, DateTimeKind.Utc).AddTicks(9218), null, "admin2@studybuddy.com", "Admin", null, "Two", "USA", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", null, null, "Admin", null },
                    { new Guid("fd57cee6-0780-4a2b-a2bb-effa0a6d5822"), null, "London", null, "UK", new DateTime(2025, 5, 3, 14, 23, 44, 640, DateTimeKind.Utc).AddTicks(9593), null, "admin3@studybuddy.com", "Admin", null, "Three", "UK", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", null, null, "Admin", null }
                });
        }
    }
}
