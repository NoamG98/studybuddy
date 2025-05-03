using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudyBuddyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCountriesAndStudyFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Communities");

            migrationBuilder.DropColumn(
                name: "StudyField",
                table: "Communities");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Communities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StudyFieldId",
                table: "Communities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02729c9b-6d02-45d4-8c1c-2bc9cf222653"), "Syrian Arab Republic" },
                    { new Guid("046c5558-5fd6-479d-89dd-adf80b80e901"), "Albania" },
                    { new Guid("04882456-928d-40c4-acd6-55e27ac439ce"), "Ukraine" },
                    { new Guid("07f55012-bcee-4c95-82eb-ad51d0f206f9"), "Libya" },
                    { new Guid("09e95bff-d03b-4153-8830-d0d88f313586"), "Slovakia" },
                    { new Guid("0ad4df47-7449-4ef9-a132-5b4e94fe7746"), "Paraguay" },
                    { new Guid("0b4e5e0f-74a4-4096-bcab-11bcdbd857cd"), "Central African Republic" },
                    { new Guid("0b7f70bc-fd1f-4f44-b392-d8559916d08d"), "South Sudan" },
                    { new Guid("0bebdab1-52c0-46d2-8ab4-16d3aca6c5e8"), "Suriname" },
                    { new Guid("0d73d747-95f9-4c0a-9a67-7dc9cfb82a97"), "Comoros" },
                    { new Guid("0d9acc80-62db-4e7d-af5b-1bbf364e8930"), "Greece" },
                    { new Guid("0f09b594-d8c3-403f-91a2-949517d598b7"), "Croatia" },
                    { new Guid("0f337c85-bd59-476b-9ea0-4a70f9aed37a"), "Tajikistan" },
                    { new Guid("0f637734-1d6f-4c19-b7f2-62188e0058f8"), "Indonesia" },
                    { new Guid("0f84e159-b841-4acb-9696-611e57f048ce"), "Kiribati" },
                    { new Guid("0f9621b5-aa9c-4af0-b1ec-6925fc383160"), "Oman" },
                    { new Guid("10c43568-6c6e-4376-91a4-c17f29d0de57"), "Uganda" },
                    { new Guid("11b036ea-bb03-4af6-9fa2-a6e3d788d225"), "Mauritania" },
                    { new Guid("120f334c-f9f5-4ffc-9d0c-f48a6df00760"), "Bahrain" },
                    { new Guid("12236298-fe9d-4f81-a918-5cced33708f3"), "Zambia" },
                    { new Guid("12ea6a42-2481-42e2-8061-ef1530b5e888"), "Benin" },
                    { new Guid("133ca96f-7d43-414b-88f5-3dfbc9e2ed99"), "Dominica" },
                    { new Guid("1453011e-1fac-4c4d-bf72-a0c13726f8af"), "Finland" },
                    { new Guid("16c8f6ca-ec10-47c0-ba97-2cccec093e3d"), "Democratic Republic of the Congo" },
                    { new Guid("1bea1f1b-41bb-47c1-910a-07a5ca2d2827"), "Cambodia" },
                    { new Guid("1fda15f1-dc18-40a4-9c5c-e51af24dd0ff"), "Somalia" },
                    { new Guid("2022ff84-33cb-4f74-ba6d-66c7840e452a"), "Cuba" },
                    { new Guid("221ba310-321a-4752-b243-2832c9f8822e"), "El Salvador" },
                    { new Guid("23990b5c-a17a-472b-98b1-27bdf8c92100"), "Viet Nam" },
                    { new Guid("251a9d92-8067-4431-87ff-b14703683cb0"), "Ghana" },
                    { new Guid("26a01476-506e-4625-a910-3f8c189118e3"), "Latvia" },
                    { new Guid("2814f88b-fd19-42e1-a0d0-1bef4e0a0660"), "Honduras" },
                    { new Guid("2ac08e07-851b-4f22-9a6e-a102391e6843"), "North Macedonia" },
                    { new Guid("2b4388e5-ea46-4431-ac61-5885ea8556ba"), "France" },
                    { new Guid("2ceec78d-43e8-4e4e-a2f4-a49b2e136b5d"), "Zimbabwe" },
                    { new Guid("2d4be2d5-2259-4dd9-9c39-b37b0f012f87"), "Sierra Leone" },
                    { new Guid("2ed3daed-98d0-4e7a-bf40-990469ecd6f7"), "Georgia" },
                    { new Guid("2f1de6ab-a699-4d7c-a988-21d5da541f02"), "Mozambique" },
                    { new Guid("3126f946-eb0a-4e70-8622-25b75249121d"), "Israel" },
                    { new Guid("31db0d74-622e-46f6-b1cc-b028bab580f5"), "Senegal" },
                    { new Guid("34a172ba-aa90-4a33-902d-8dff8f92020f"), "Iraq" },
                    { new Guid("35c5899d-6540-48f4-9d36-6155b4a348e2"), "United States of America" },
                    { new Guid("37ee2ea5-9bc8-4eeb-8aa5-bc10d04b8c90"), "Italy" },
                    { new Guid("3822acf5-eb03-4155-aae4-ddb0a10f9784"), "Timor-Leste" },
                    { new Guid("38d780cc-a84d-48c7-b2fd-f21c693b7c27"), "Uzbekistan" },
                    { new Guid("3a730958-b087-4b39-97bb-e348bec1dadb"), "Philippines" },
                    { new Guid("3b5b7bfb-3ead-4ffe-bfbd-2dffa569bcaa"), "Eritrea" },
                    { new Guid("3e03266f-1a1d-4020-acee-a5527a4a5bae"), "Liechtenstein" },
                    { new Guid("3e4122b5-fb4c-4424-b9c0-26e0815c4667"), "Malawi" },
                    { new Guid("3e60e0e4-5c73-445d-8877-37a41c9fa6e0"), "Cabo Verde" },
                    { new Guid("3fcbfb23-d438-4747-80a3-dca85bbaa995"), "Kuwait" },
                    { new Guid("40673ec5-19c7-4c1f-a614-3682da19e8b8"), "Canada" },
                    { new Guid("41639579-ec29-4dbe-8c95-fec7e0f73eba"), "Bolivia" },
                    { new Guid("4259daf6-fe8c-4de5-afe4-d10834a4858b"), "Mongolia" },
                    { new Guid("446aa948-2810-4dec-bb74-5fdcba2fbad9"), "Malta" },
                    { new Guid("45c8395b-9718-4a08-b1ff-9c798fa2a858"), "Guyana" },
                    { new Guid("45ee0ec0-e9dd-4c4b-a7da-ff8b99f92929"), "Estonia" },
                    { new Guid("46bef9d2-f2a7-43f5-be7f-60dc0864f22f"), "Egypt" },
                    { new Guid("474d94b2-3f93-4aa1-ab8f-7cf46c453910"), "Sri Lanka" },
                    { new Guid("49319d84-ab76-4894-89c6-7507a85eb7f9"), "Algeria" },
                    { new Guid("4a4def04-b3e2-424a-b18b-eb6e091a0a40"), "Slovenia" },
                    { new Guid("4c7663c7-3481-4d48-92e7-beca45d7ca06"), "Trinidad and Tobago" },
                    { new Guid("4d33a9a1-22d3-48a7-84d9-798b52b8ba02"), "Qatar" },
                    { new Guid("514c16ac-f203-4a00-a223-455900bd776a"), "Gambia" },
                    { new Guid("516ab0e2-4269-4845-b5ab-b031ab354599"), "Pakistan" },
                    { new Guid("531cb160-39f2-47a8-bb7a-faafb4a2620e"), "Barbados" },
                    { new Guid("535c3cdb-a7dd-4f22-bfdd-e7ff609456c1"), "Russian Federation" },
                    { new Guid("53a1a309-493a-4f56-aa09-b143e603c79d"), "Colombia" },
                    { new Guid("567183b0-ba1f-4705-9370-36a040f9f45b"), "Bangladesh" },
                    { new Guid("5931f4e6-d6ba-4640-a2d4-ed1b26989d9a"), "Mexico" },
                    { new Guid("5b71d373-e42a-42d6-b7c2-ea2d6f49079b"), "United Arab Emirates" },
                    { new Guid("6201a5d6-1dc0-44e4-9354-e3685c9c3099"), "Lebanon" },
                    { new Guid("627347f6-14f8-420e-9727-c5e3e8ef642f"), "Serbia" },
                    { new Guid("62f54c5b-8820-4062-8d8c-5ee4b33be570"), "South Africa" },
                    { new Guid("63ecc55a-ba55-4dee-a71a-572cb72f641a"), "Australia" },
                    { new Guid("653ac43b-4955-4974-9beb-158db4cbceb5"), "India" },
                    { new Guid("65dab921-49e0-4c71-b66e-a248aa1e0010"), "Cyprus" },
                    { new Guid("670a2d8a-f859-4e2a-8a0b-fdb5e064dfbf"), "United Kingdom" },
                    { new Guid("67e10589-e841-475f-a583-21b999679c5c"), "Liberia" },
                    { new Guid("696ca1ef-6b5a-42af-b2ba-36e9a0523daf"), "Kenya" },
                    { new Guid("6a38da21-46f0-4cfa-88c4-783eb6460e06"), "Mali" },
                    { new Guid("6d115e6e-9d40-49c6-81f6-11f6c41c9f05"), "Nicaragua" },
                    { new Guid("6dbf59e3-41ab-4a4a-97b5-d70398f97dd2"), "Hungary" },
                    { new Guid("6e659670-1123-4037-82ee-3e3bb1c2805d"), "Denmark" },
                    { new Guid("6fa1e520-9b1e-44af-8cfb-cfd06053c806"), "Lithuania" },
                    { new Guid("7268eee8-248c-4d48-8ff7-21dfa108486f"), "Andorra" },
                    { new Guid("7284ee72-995d-4c66-8895-39287bc93146"), "Venezuela" },
                    { new Guid("75d03d7a-e741-4c91-b5a2-b0510bf0624a"), "Palau" },
                    { new Guid("76a66870-14f4-4714-9cdf-2756f49c51e2"), "Thailand" },
                    { new Guid("797490a8-bc66-4583-90a1-c54be3693599"), "Chile" },
                    { new Guid("7a0699dc-8155-4ee8-b143-e2c6766134b4"), "Tonga" },
                    { new Guid("7cc9906a-b724-4565-8890-201649c0ff7f"), "Grenada" },
                    { new Guid("7dd9c2c2-b7ec-4f5e-9f1c-9a1741af4d7c"), "Maldives" },
                    { new Guid("7faf6989-d2b0-41d7-a7b0-b7a1013985b3"), "Bulgaria" },
                    { new Guid("80a64958-2622-4873-8b6d-2b0dfeb7648d"), "Eswatini" },
                    { new Guid("817cd976-9cfc-4b16-9c54-8a33965ec4c8"), "Equatorial Guinea" },
                    { new Guid("8304070f-1e65-4ac3-8657-cf9cba75b682"), "Congo" },
                    { new Guid("83aca59b-e255-43a0-8fdc-68bed2a3f5ef"), "Tuvalu" },
                    { new Guid("869c3664-608d-49a5-a453-3119f92260a7"), "Rwanda" },
                    { new Guid("8d69ab5c-cfc0-47cf-bbf9-b5c3637ed03f"), "Ecuador" },
                    { new Guid("8ddde4e8-a95f-4992-b947-0cb439765b6d"), "Bahamas" },
                    { new Guid("8e8a1433-606f-4c65-9289-444f1d49d43d"), "China" },
                    { new Guid("9033f063-73df-4857-ae4d-b9031d861eaf"), "Republic of Moldova" },
                    { new Guid("9057fa7e-2670-42ae-8b98-7af1b66e8927"), "Peru" },
                    { new Guid("90f97a4a-8a74-4dc8-8f1d-c980efb6a1d5"), "Marshall Islands" },
                    { new Guid("91010a25-6f81-40fb-8347-46a5fa3bc236"), "Mauritius" },
                    { new Guid("9291b844-899a-4d46-8cd6-dbf7b4b0adbb"), "Argentina" },
                    { new Guid("94ac689a-858c-4369-8850-d3a744368cc6"), "Bhutan" },
                    { new Guid("950b117a-b743-4d47-a9c2-e877f5346f66"), "Saudi Arabia" },
                    { new Guid("95104f7d-c554-4e40-aab9-0752750d3770"), "Jordan" },
                    { new Guid("9822ce99-239e-43a3-9c2f-4b19705ab344"), "Nigeria" },
                    { new Guid("98b58b04-f72d-492c-9fd2-e83709c294b2"), "Papua New Guinea" },
                    { new Guid("9a3251fa-8766-41fe-ab51-3a0e78dd8b3e"), "Madagascar" },
                    { new Guid("9b918c8f-e339-4122-9d5c-a15f83ac4a1b"), "Nauru" },
                    { new Guid("9cc5ac78-95a3-40f0-9993-35db7e25c10d"), "Ireland" },
                    { new Guid("9ce873e6-7dc3-4ff7-8b82-33689485354b"), "Ethiopia" },
                    { new Guid("9d7c5aa0-c7d9-43cf-bade-7498410fd13a"), "Romania" },
                    { new Guid("9f56322b-ca5a-4d79-addc-694f5222ab04"), "Namibia" },
                    { new Guid("a102952a-deb2-4400-9515-a086f1890901"), "United Republic of Tanzania" },
                    { new Guid("a14c65af-bbb7-4139-9a1e-b102ddf156cb"), "Saint Vincent and the Grenadines" },
                    { new Guid("a1b82506-8bea-4304-98ad-4ac2b05c8efe"), "Belarus" },
                    { new Guid("a1daac27-969c-416c-bb45-1a0fee755b52"), "Belize" },
                    { new Guid("a47848bc-a2e6-4e79-9a3c-7eae8d87238e"), "Haiti" },
                    { new Guid("a4b40144-f647-48a6-ab17-8d09b6ede3e7"), "Saint Kitts and Nevis" },
                    { new Guid("a6774ab3-97b7-48e1-9525-dc9b5ac04f24"), "Poland" },
                    { new Guid("a9d030e6-63e3-4f71-8c14-5ef997c313f3"), "Togo" },
                    { new Guid("af4bc7b7-e0e0-478b-91f5-acfddb35f5fb"), "Sudan" },
                    { new Guid("af799c77-a954-4dca-86ce-c1ce4dc723a5"), "Botswana" },
                    { new Guid("b1de5a52-c2ab-40ed-b8a3-bd6917d181da"), "Lesotho" },
                    { new Guid("b2ad7bf6-8742-4214-8d09-d9f5aa561fae"), "Solomon Islands" },
                    { new Guid("b3b96049-fc40-46ee-a83e-f9d8bdd4dc9d"), "Kazakhstan" },
                    { new Guid("b43ea0d5-9fb5-4039-ac96-7385bffd1e98"), "Djibouti" },
                    { new Guid("b52fd04c-9227-452d-9237-5eddde52a1cf"), "Cameroon" },
                    { new Guid("b602babe-a800-4b56-8c6c-403382c7275a"), "Tunisia" },
                    { new Guid("b6196cca-5858-4b56-85f1-9ced5c749d0e"), "Gabon" },
                    { new Guid("b65ff1fc-3c11-4380-9f21-09d38fe75903"), "Jamaica" },
                    { new Guid("b7d775f9-d240-4dff-b7e5-6a4a3e229a52"), "Burkina Faso" },
                    { new Guid("b805f79d-62ae-48a7-9dd7-67a24b9d3ad5"), "Norway" },
                    { new Guid("b85315dc-bbc6-4e77-a5b9-7ac73f0e0c1b"), "Brazil" },
                    { new Guid("b9a092d0-7d17-4988-9549-3d87b35128f1"), "Sweden" },
                    { new Guid("b9de8aa6-f1d3-47a0-b196-5626e3302868"), "Uruguay" },
                    { new Guid("bdadeb42-f785-41c7-9761-36f06d9c4e11"), "Singapore" },
                    { new Guid("be1dc743-6e09-4437-9498-35e02a76c0e9"), "Brunei Darussalam" },
                    { new Guid("bef30791-1acc-48c9-adf3-34fce7a15ef8"), "Azerbaijan" },
                    { new Guid("c0fe20c5-24ed-4c62-bdd9-d85a0d3027c2"), "Dominican Republic" },
                    { new Guid("c1899c85-39fb-4705-b322-a10e22d9553c"), "Armenia" },
                    { new Guid("c3b26868-5a13-4df9-b769-3e838c3c497f"), "Bosnia and Herzegovina" },
                    { new Guid("c5ea60d4-45f7-4cbd-a7be-d46bd82b98e4"), "Iran (Islamic Republic of)" },
                    { new Guid("c912cb43-a27d-4978-8b2a-081e32af3a2d"), "Turkey" },
                    { new Guid("cb3f1f99-5b34-4621-8c9e-ccd908fdf7ea"), "Sao Tome and Principe" },
                    { new Guid("cc2be861-055b-4cce-843a-e45782144aa2"), "Antigua and Barbuda" },
                    { new Guid("ce825e70-e3f8-4bde-87bc-99188ca4e01a"), "Morocco" },
                    { new Guid("d003c669-b7b8-4f17-813e-60c1bf4d8575"), "Japan" },
                    { new Guid("d13a2ca0-9cb8-49a1-a6a0-c792ee9bd721"), "Malaysia" },
                    { new Guid("d2632f8e-6864-4c76-b417-bb7ef0b0d302"), "Republic of Korea" },
                    { new Guid("d29ce18f-dbda-43f3-bb60-f5f333382e4d"), "Kyrgyzstan" },
                    { new Guid("d4a592e1-d0ea-4b46-816b-778b67690049"), "Switzerland" },
                    { new Guid("d6e65ba5-d41e-4f58-9296-c1b01cd45cf0"), "Saint Lucia" },
                    { new Guid("d81a0eac-c82d-42da-b660-4495416bf2db"), "Costa Rica" },
                    { new Guid("d87799bb-4a09-468e-8be4-bd0226e74e64"), "San Marino" },
                    { new Guid("d8a5167a-9620-49e2-9132-5c8712a9ad4e"), "Czech Republic" },
                    { new Guid("d9151cf3-bd91-4c1f-b95c-e3f010eba068"), "Samoa" },
                    { new Guid("dbc89541-a5c4-46bc-80a8-edebdc106834"), "Côte d'Ivoire" },
                    { new Guid("dcdbb25f-579b-4892-9905-5fb03551639c"), "Iceland" },
                    { new Guid("df4f3a44-53da-421d-94b3-15aa09278679"), "Vanuatu" },
                    { new Guid("e0b76f7b-68c3-46fe-9641-8c6dc2f780e7"), "Montenegro" },
                    { new Guid("e254e8f9-7d84-4373-93b9-d2c3732f8c50"), "New Zealand" },
                    { new Guid("e263e0db-a7e7-494b-962c-053cef197a03"), "Portugal" },
                    { new Guid("e277bdf4-911b-40c5-b71d-905bd671d14a"), "Belgium" },
                    { new Guid("e4ec341d-9331-441b-9f79-b3b90974bab8"), "Guinea-Bissau" },
                    { new Guid("e6eaa584-6bc2-44b1-a941-7ebfe5dedf88"), "Myanmar" },
                    { new Guid("e7e9e572-402c-4db5-83fd-5e747d7a0935"), "Austria" },
                    { new Guid("e7f10412-ee1e-4b53-b813-7e1fb6b3dec9"), "Lao People’s Democratic Republic" },
                    { new Guid("e8f77bff-1465-4396-a61a-bef2f12daa78"), "Spain" },
                    { new Guid("e923e537-beaf-4979-855f-1497109f2981"), "Angola" },
                    { new Guid("ecc1d25c-c839-4ff2-8d0a-6a1eb51c1a1b"), "Netherlands" },
                    { new Guid("edbdfe2a-78ca-43a3-8e1c-8ba90bcec869"), "Panama" },
                    { new Guid("eecbe572-28c3-457f-95fe-554285517910"), "Chad" },
                    { new Guid("f0147035-45cf-4282-8b9e-ee4e3378d545"), "Afghanistan" },
                    { new Guid("f17b0cd7-2b05-44b8-b4d1-ea71bbd651d2"), "Turkmenistan" },
                    { new Guid("f2e45b4d-ee78-4391-8b57-2e17d1084ed0"), "Federated States of Micronesia" },
                    { new Guid("f31ea62c-a7fe-424d-a1ae-135064aed21a"), "Seychelles" },
                    { new Guid("f348a303-a5b3-4a9e-95d4-c2398f7380d9"), "Germany" },
                    { new Guid("f51586b4-6bea-473d-bf7e-041a2e641ebc"), "Monaco" },
                    { new Guid("f5c6cc60-6163-4715-a0eb-2fc1d8739c9e"), "Niger" },
                    { new Guid("f732f725-bd71-45d8-88c8-ec23815960af"), "Burundi" },
                    { new Guid("f91c499f-1abd-4b19-9eb9-7e92a149a52b"), "Luxembourg" },
                    { new Guid("fac74c49-f1f7-41ad-b4fb-f4a78d5aeafa"), "Democratic People’s Republic of Korea" },
                    { new Guid("fbaad0fc-e325-43c6-be6e-46d39b49fe8d"), "Fiji" },
                    { new Guid("fbfb7476-9ecd-4782-9f76-b29d6cffa550"), "Guatemala" },
                    { new Guid("fd761d40-6929-4fac-b040-cc1e563b2896"), "Nepal" },
                    { new Guid("fdd85d97-e65c-48d5-8040-8cf15915d0fc"), "Guinea" },
                    { new Guid("fe9b259c-ca5e-4517-b827-a5300d103f54"), "Yemen" }
                });

            migrationBuilder.InsertData(
                table: "StudyFields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0012b848-8e09-4b65-ba47-044a31bde730"), "Linguistics" },
                    { new Guid("04efefa5-31f6-43fb-8137-77bf6f2324a0"), "Political Science" },
                    { new Guid("0688a803-b52a-4c27-b636-d9e24d30af83"), "Veterinary Medicine" },
                    { new Guid("0abe8eb0-8e40-4a5b-aa6f-c4e47084ff3c"), "Pharmacy" },
                    { new Guid("0c85d2fa-514a-444e-bc4a-1a62edec445e"), "Project Management" },
                    { new Guid("1db3fc26-8b38-440e-a532-7f705dab6b98"), "Frontend Development" },
                    { new Guid("28683798-2102-44b9-ab14-7f2f4b86274d"), "Backend Development" },
                    { new Guid("2a9616a0-3355-48a2-a427-3ef8d26c6279"), "Data Science" },
                    { new Guid("2b0006cf-f6ea-4245-bcc2-ac00210b6fec"), "Film Studies" },
                    { new Guid("388711b2-9194-48a4-9fed-26fa26f0b10b"), "Game Development" },
                    { new Guid("427a7c30-7ea6-4c84-83f7-7636b10c32f7"), "Law" },
                    { new Guid("42a3d7d4-795d-47ac-beb7-fa2d7a9f9603"), "Fashion Design" },
                    { new Guid("449cda0e-08dc-4fb8-ae60-b727c273b350"), "Communication" },
                    { new Guid("4665d2e5-7252-4896-a4cd-fa9e4e8c3704"), "Digital Marketing" },
                    { new Guid("46cfbcc8-04b8-469a-a921-2bbc5a05f3f8"), "Cyber Security" },
                    { new Guid("476b2fdf-ca8f-406a-b38d-35803cb718ba"), "Fullstack Development" },
                    { new Guid("4aa07cf9-4dbe-4a35-88fe-442ec63b86d1"), "Supply Chain Management" },
                    { new Guid("4c9fc116-c974-4bcc-9e1c-766e9009ee13"), "Anthropology" },
                    { new Guid("4f63138a-6e0a-403d-9212-2fa5cd06d7c9"), "Theology" },
                    { new Guid("5c95e2fa-cbf4-43bf-94c8-7b2aad69e95a"), "Civil Engineering" },
                    { new Guid("5f53da0f-3a78-4dab-831e-c63ca864bbf8"), "Mechanical Engineering" },
                    { new Guid("602b08fb-4cf3-4ab4-890e-4ea2d6452073"), "Mobile App Development" },
                    { new Guid("627a9fe3-2bb2-4581-89b3-b9fe733fe046"), "Journalism" },
                    { new Guid("6357464b-4355-44b6-8472-0261909844c5"), "DevOps Engineering" },
                    { new Guid("6850f04a-3f84-4601-ab56-312e8db348f2"), "Visual Arts" },
                    { new Guid("68b57276-8e20-45c9-b07b-8f1070ecdd63"), "Art History" },
                    { new Guid("786ce8b9-11ff-4908-a996-cd5ea1750c2d"), "Accounting" },
                    { new Guid("81f14cd3-aa07-44dd-9c48-fb922910a3fc"), "Business Administration" },
                    { new Guid("860511bb-163b-417b-b17a-c1d3cb47c3cd"), "Computer Science" },
                    { new Guid("862fd301-bd33-4606-bbba-03bc69e35409"), "International Relations" },
                    { new Guid("8837ecd7-f6b5-4142-827f-584ec8ba997a"), "History" },
                    { new Guid("92b91341-acae-4b15-938a-6967bb10f6d1"), "Philosophy" },
                    { new Guid("98ddda75-6f03-4123-932d-bb40702a1a8a"), "Sociology" },
                    { new Guid("9b075d2c-66aa-4c4c-b189-98d60d38e81e"), "Mathematics" },
                    { new Guid("9e0de510-84b0-427a-87c7-baed795ec8e6"), "Chemistry" },
                    { new Guid("9f14752b-9d1b-432e-b44c-42347ea88874"), "Interior Design" },
                    { new Guid("a43e1ab6-d0fc-48fb-9c7c-28637cd5194f"), "Graphic Design" },
                    { new Guid("a6740582-1c72-4b20-a3c0-531eea71dc70"), "E-commerce" },
                    { new Guid("a9288598-e1cc-42d0-9842-c9ea6133222c"), "Special Education" },
                    { new Guid("aca683c7-da1c-49d2-a208-92efb2892699"), "Marketing" },
                    { new Guid("acadf07b-d3ea-482b-80c4-380b7eb21371"), "Economics" },
                    { new Guid("aeba2b66-cf44-4855-b8d8-1b1cbd61bd4a"), "Animation and Multimedia" },
                    { new Guid("b14da07a-53f8-451f-8b9c-a0002e480016"), "Medicine" },
                    { new Guid("ba3f61a4-60a9-4d8d-b5db-bd6fd87e434e"), "Entrepreneurship" },
                    { new Guid("bdba169b-5ccd-42e9-aec0-acba026e2f93"), "Photography" },
                    { new Guid("bee5aefe-b5d1-4c4b-8df5-fe911a74d0e7"), "Machine Learning" },
                    { new Guid("c06978ef-a107-4f05-952a-012e8a920f62"), "Architecture" },
                    { new Guid("c0c9395c-01c9-4c86-84ea-c1ef9e9100c4"), "Psychology" },
                    { new Guid("c4b8ab8b-0c77-44e2-87dd-883c421569fb"), "UI/UX Design" },
                    { new Guid("d4c5ecd9-3230-4a10-9491-9e545b7b7c46"), "Business Intelligence" },
                    { new Guid("d6275abc-6a03-48eb-afda-a5fbdb003cd0"), "Human Resources" },
                    { new Guid("dc018ea1-5249-4997-b6d2-769068f66457"), "Education" },
                    { new Guid("e1fbaafc-496f-4108-bb8b-e733e8492de9"), "Music" },
                    { new Guid("e8bae4e4-acc0-481f-a57f-861c4338879b"), "Theater" },
                    { new Guid("f1620fcc-b5d4-4538-a3a4-0e7facca7752"), "Electrical Engineering" },
                    { new Guid("f2638369-7871-44c6-b491-2acdb4bb1847"), "Physics" },
                    { new Guid("f5043e65-4459-4ccd-9d02-202a40d4d2f7"), "Public Relations" },
                    { new Guid("f6036946-bb20-473d-936e-8d6d441a01d2"), "Artificial Intelligence" },
                    { new Guid("f61f121e-dc77-403b-a74b-d7ace942b615"), "Nursing" },
                    { new Guid("f6860e4d-3d4c-4340-bda8-00a23d317c73"), "Cloud Computing" },
                    { new Guid("f6cab0c1-458d-4c6f-bf7b-ce63a7b9de17"), "Finance" },
                    { new Guid("f8186281-3875-4223-9d49-6e7b00675e84"), "Biology" },
                    { new Guid("fbdb67f5-828d-416f-bf16-d7c15d8a8059"), "Environmental Science" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarUrl", "City", "CommunityId", "Country", "CreatedAt", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "Location", "PasswordHash", "Role", "StudyField" },
                values: new object[,]
                {
                    { new Guid("0c231cc3-bb6e-4ae5-8e9f-b28be9d0a8e4"), null, "New York", null, "USA", new DateTime(2025, 5, 2, 13, 52, 33, 251, DateTimeKind.Utc).AddTicks(3106), null, "admin2@studybuddy.com", "Admin", null, "Two", "USA", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", "Admin", null },
                    { new Guid("1e82d0fe-8789-4fef-b4e1-6fda69a0ef45"), null, "London", null, "UK", new DateTime(2025, 5, 2, 13, 52, 33, 251, DateTimeKind.Utc).AddTicks(5286), null, "admin3@studybuddy.com", "Admin", null, "Three", "UK", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", "Admin", null },
                    { new Guid("689692d9-1e80-4c66-88f7-762e04e19a27"), null, "Tel Aviv", null, "Israel", new DateTime(2025, 5, 2, 13, 52, 33, 243, DateTimeKind.Utc).AddTicks(8782), null, "admin1@studybuddy.com", "Admin", null, "One", "Israel", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", "Admin", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Communities_CountryId",
                table: "Communities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_StudyFieldId",
                table: "Communities",
                column: "StudyFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Communities_Countries_CountryId",
                table: "Communities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Communities_StudyFields_StudyFieldId",
                table: "Communities",
                column: "StudyFieldId",
                principalTable: "StudyFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Communities_Countries_CountryId",
                table: "Communities");

            migrationBuilder.DropForeignKey(
                name: "FK_Communities_StudyFields_StudyFieldId",
                table: "Communities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Communities_CountryId",
                table: "Communities");

            migrationBuilder.DropIndex(
                name: "IX_Communities_StudyFieldId",
                table: "Communities");

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0012b848-8e09-4b65-ba47-044a31bde730"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("04efefa5-31f6-43fb-8137-77bf6f2324a0"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0688a803-b52a-4c27-b636-d9e24d30af83"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0abe8eb0-8e40-4a5b-aa6f-c4e47084ff3c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("0c85d2fa-514a-444e-bc4a-1a62edec445e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("1db3fc26-8b38-440e-a532-7f705dab6b98"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("28683798-2102-44b9-ab14-7f2f4b86274d"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("2a9616a0-3355-48a2-a427-3ef8d26c6279"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("2b0006cf-f6ea-4245-bcc2-ac00210b6fec"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("388711b2-9194-48a4-9fed-26fa26f0b10b"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("427a7c30-7ea6-4c84-83f7-7636b10c32f7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("42a3d7d4-795d-47ac-beb7-fa2d7a9f9603"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("449cda0e-08dc-4fb8-ae60-b727c273b350"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4665d2e5-7252-4896-a4cd-fa9e4e8c3704"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("46cfbcc8-04b8-469a-a921-2bbc5a05f3f8"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("476b2fdf-ca8f-406a-b38d-35803cb718ba"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa07cf9-4dbe-4a35-88fe-442ec63b86d1"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4c9fc116-c974-4bcc-9e1c-766e9009ee13"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("4f63138a-6e0a-403d-9212-2fa5cd06d7c9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("5c95e2fa-cbf4-43bf-94c8-7b2aad69e95a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("5f53da0f-3a78-4dab-831e-c63ca864bbf8"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("602b08fb-4cf3-4ab4-890e-4ea2d6452073"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("627a9fe3-2bb2-4581-89b3-b9fe733fe046"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("6357464b-4355-44b6-8472-0261909844c5"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("6850f04a-3f84-4601-ab56-312e8db348f2"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("68b57276-8e20-45c9-b07b-8f1070ecdd63"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("786ce8b9-11ff-4908-a996-cd5ea1750c2d"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("81f14cd3-aa07-44dd-9c48-fb922910a3fc"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("860511bb-163b-417b-b17a-c1d3cb47c3cd"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("862fd301-bd33-4606-bbba-03bc69e35409"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("8837ecd7-f6b5-4142-827f-584ec8ba997a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("92b91341-acae-4b15-938a-6967bb10f6d1"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("98ddda75-6f03-4123-932d-bb40702a1a8a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9b075d2c-66aa-4c4c-b189-98d60d38e81e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9e0de510-84b0-427a-87c7-baed795ec8e6"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("9f14752b-9d1b-432e-b44c-42347ea88874"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a43e1ab6-d0fc-48fb-9c7c-28637cd5194f"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a6740582-1c72-4b20-a3c0-531eea71dc70"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("a9288598-e1cc-42d0-9842-c9ea6133222c"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("aca683c7-da1c-49d2-a208-92efb2892699"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("acadf07b-d3ea-482b-80c4-380b7eb21371"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("aeba2b66-cf44-4855-b8d8-1b1cbd61bd4a"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("b14da07a-53f8-451f-8b9c-a0002e480016"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("ba3f61a4-60a9-4d8d-b5db-bd6fd87e434e"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("bdba169b-5ccd-42e9-aec0-acba026e2f93"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("bee5aefe-b5d1-4c4b-8df5-fe911a74d0e7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c06978ef-a107-4f05-952a-012e8a920f62"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c0c9395c-01c9-4c86-84ea-c1ef9e9100c4"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("c4b8ab8b-0c77-44e2-87dd-883c421569fb"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d4c5ecd9-3230-4a10-9491-9e545b7b7c46"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("d6275abc-6a03-48eb-afda-a5fbdb003cd0"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("dc018ea1-5249-4997-b6d2-769068f66457"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("e1fbaafc-496f-4108-bb8b-e733e8492de9"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("e8bae4e4-acc0-481f-a57f-861c4338879b"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f1620fcc-b5d4-4538-a3a4-0e7facca7752"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f2638369-7871-44c6-b491-2acdb4bb1847"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f5043e65-4459-4ccd-9d02-202a40d4d2f7"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f6036946-bb20-473d-936e-8d6d441a01d2"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f61f121e-dc77-403b-a74b-d7ace942b615"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f6860e4d-3d4c-4340-bda8-00a23d317c73"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f6cab0c1-458d-4c6f-bf7b-ce63a7b9de17"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("f8186281-3875-4223-9d49-6e7b00675e84"));

            migrationBuilder.DeleteData(
                table: "StudyFields",
                keyColumn: "Id",
                keyValue: new Guid("fbdb67f5-828d-416f-bf16-d7c15d8a8059"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c231cc3-bb6e-4ae5-8e9f-b28be9d0a8e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e82d0fe-8789-4fef-b4e1-6fda69a0ef45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("689692d9-1e80-4c66-88f7-762e04e19a27"));

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Communities");

            migrationBuilder.DropColumn(
                name: "StudyFieldId",
                table: "Communities");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Communities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudyField",
                table: "Communities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
