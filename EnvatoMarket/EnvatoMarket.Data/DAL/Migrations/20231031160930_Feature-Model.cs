using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class FeatureModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "223cfc5c-99a2-4c69-ae6d-e056a8b5919c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "56806c2e-c095-4fd1-abb3-c60938af8884", "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dec07f4c-b59e-47ec-a105-a6183a2b24f0", "c2a19149-d453-412c-b753-50be308a9e08" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "02864753-8021-42f1-be4d-5cb160e44fb1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "033573fd-ab60-4aa1-b9a0-6132dc536c1f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3157f4eb-a11b-4d37-b51b-ba2c12354f2b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "348e7387-0ad8-4b8b-855a-5797cc0cbac1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4560aaa6-386b-468d-b1a3-c7ecff23e22b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "462795e8-b68a-4559-9c43-5e6566e65304");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4b960752-c99a-4f98-b931-e0cf0585feb5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5ecc1c44-7c58-407b-aad6-34fbb297330e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8e68ac2f-1201-4a5a-a727-8db131b86d12");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9a22248f-ad7b-401c-9f56-0ea1060dc970");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a61fac6b-344a-4c19-ad7b-e8198c3d694a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c41787c5-429f-432f-b1e9-276655d6d1ae");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d1928f56-77e8-4421-ad50-8728edf658ed");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d93963f5-051c-40e1-aabe-6853e65d87ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56806c2e-c095-4fd1-abb3-c60938af8884");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dec07f4c-b59e-47ec-a105-a6183a2b24f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2a19149-d453-412c-b753-50be308a9e08");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "248a822b-fe31-4c88-93b8-0a94cbef753d", "bf642eb0-00df-427e-8500-9f47664dfeae", "Admin", "ADMIN" },
                    { "b07c9057-e50b-487f-8a9b-f44bbfb38fa7", "4de6df9c-e01b-4e38-a967-4787e78c3e26", "SupperAdmin", "SUPPERADMIN" },
                    { "e0758940-10b0-4dd7-a530-6a5da8116e6e", "d7ef4b5c-1210-475a-b8ce-d4747b02001c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "37c0e899-2349-4cc2-8054-25feaa34ebf2", 0, "System", "e2bc15e7-7997-4f83-9054-b7c56b982fd5", new DateTime(2023, 10, 31, 20, 9, 29, 792, DateTimeKind.Local).AddTicks(7680), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAECTUx5KymG+izHEGkjo37022AVpfaKQYfmFOFVaIjOZyW0ZWYDG6G34R4mJWOTW7ww==", "+994513004484", true, null, null, "ca3e56f9-a687-4fcb-9918-42df5f376e2e", false, null, "RufatCode" },
                    { "38062ec5-9ecf-44b7-b51f-9add232c608b", 0, "System", "142eeea1-bd62-4a02-8e22-4d9bfa50f392", new DateTime(2023, 10, 31, 20, 9, 29, 792, DateTimeKind.Local).AddTicks(7710), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEL7D+8VR29tLhUYTOibwh35LhuvKf/qX8WId8xVMPm7eGg5ZO+TWN572erG9kujU/A==", "+994513004484", true, null, null, "39869f30-0e16-463c-9d2b-1e3a6e7f3bcc", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "2731d4eb-43df-4602-bbc9-568e7e8f785c", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8280), false, "Flag2", null, null, "2.jpg" },
                    { "30e107d2-4a93-4056-b7da-c738311a8e5e", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8270), false, "Language2", null, null, "Franch" },
                    { "35c8364f-dc93-45b7-8f4f-4aaeb4eff4df", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8260), false, "Language1", null, null, "English" },
                    { "35de94a2-e80d-4b81-abc5-6332616a07dc", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8240), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "3df58921-2a58-4b17-aca6-e9694bd49a9a", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8190), false, "Hotline", null, null, "+48 500 500 500" },
                    { "3e4aee71-7482-4702-a26f-5a8bfda7b464", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8260), false, "currency2", null, null, "EUR$" },
                    { "4f76c245-82c7-48eb-a2b3-6fd27de37584", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8240), false, "Payment", null, null, "payment.png" },
                    { "5b6fc348-8aac-4548-90bd-a8bd778c0f66", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8210), false, "PhoneNumber", null, null, "+994513004484" },
                    { "7a7398c5-2d6f-4036-aa5d-4286dfd441a0", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8220), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "7f8d9b93-17fb-4418-b7bc-cd55ab64266b", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8200), false, "Logo", null, null, "logo.png" },
                    { "8ef0c11e-fe9c-4126-9c2b-69a223faccc8", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8230), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "90c926b9-e296-4f6f-9191-8b3e0f474cee", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8210), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "a80afa00-c4e1-44be-bdd7-c86eae6df2c5", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8270), false, "Flag1", null, null, "1.jpg" },
                    { "ced3e1fe-dd73-4543-b477-0a8fddb35a98", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8250), false, "currency1", null, null, "USD$" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "248a822b-fe31-4c88-93b8-0a94cbef753d", "37c0e899-2349-4cc2-8054-25feaa34ebf2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b07c9057-e50b-487f-8a9b-f44bbfb38fa7", "38062ec5-9ecf-44b7-b51f-9add232c608b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0758940-10b0-4dd7-a530-6a5da8116e6e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "248a822b-fe31-4c88-93b8-0a94cbef753d", "37c0e899-2349-4cc2-8054-25feaa34ebf2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b07c9057-e50b-487f-8a9b-f44bbfb38fa7", "38062ec5-9ecf-44b7-b51f-9add232c608b" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2731d4eb-43df-4602-bbc9-568e7e8f785c");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "30e107d2-4a93-4056-b7da-c738311a8e5e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "35c8364f-dc93-45b7-8f4f-4aaeb4eff4df");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "35de94a2-e80d-4b81-abc5-6332616a07dc");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3df58921-2a58-4b17-aca6-e9694bd49a9a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3e4aee71-7482-4702-a26f-5a8bfda7b464");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4f76c245-82c7-48eb-a2b3-6fd27de37584");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5b6fc348-8aac-4548-90bd-a8bd778c0f66");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7a7398c5-2d6f-4036-aa5d-4286dfd441a0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7f8d9b93-17fb-4418-b7bc-cd55ab64266b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8ef0c11e-fe9c-4126-9c2b-69a223faccc8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "90c926b9-e296-4f6f-9191-8b3e0f474cee");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a80afa00-c4e1-44be-bdd7-c86eae6df2c5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ced3e1fe-dd73-4543-b477-0a8fddb35a98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "248a822b-fe31-4c88-93b8-0a94cbef753d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b07c9057-e50b-487f-8a9b-f44bbfb38fa7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37c0e899-2349-4cc2-8054-25feaa34ebf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38062ec5-9ecf-44b7-b51f-9add232c608b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "223cfc5c-99a2-4c69-ae6d-e056a8b5919c", "edb100b4-93e3-4db0-844e-7fb9d18ab597", "User", "USER" },
                    { "56806c2e-c095-4fd1-abb3-c60938af8884", "000a237d-e7a8-4296-8ead-3c2430391cb4", "Admin", "ADMIN" },
                    { "dec07f4c-b59e-47ec-a105-a6183a2b24f0", "66103e9d-ae3c-46b9-ba69-2e5368a43520", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca", 0, "System", "5cf09031-dbbd-46fe-986c-255a2568b675", new DateTime(2023, 10, 31, 19, 22, 17, 68, DateTimeKind.Local).AddTicks(1540), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEJnF9q6x7AlSoaAc2zA+HgLK2vNjuSwMZEJuJEhrLzxBF1rSuGP9jk6yuB4k7v+V5Q==", "+994513004484", true, null, null, "565d88c6-bb10-4a4e-a3be-79bb31ee11e1", false, null, "RufatCode" },
                    { "c2a19149-d453-412c-b753-50be308a9e08", 0, "System", "09456434-25b8-4933-a518-3c778b708b64", new DateTime(2023, 10, 31, 19, 22, 17, 68, DateTimeKind.Local).AddTicks(1580), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEAC9Z7eMzY3GpHa8oBQn6cBTf6yNgPtQsk6U45BdpTvNEtKwjZVIvmJLQIUByBRvKA==", "+994513004484", true, null, null, "49401c03-f530-4343-8936-407103412a50", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "02864753-8021-42f1-be4d-5cb160e44fb1", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1050), false, "Hotline", null, null, "+48 500 500 500" },
                    { "033573fd-ab60-4aa1-b9a0-6132dc536c1f", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1130), false, "Flag1", null, null, "1.jpg" },
                    { "3157f4eb-a11b-4d37-b51b-ba2c12354f2b", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1070), false, "PhoneNumber", null, null, "+994513004484" },
                    { "348e7387-0ad8-4b8b-855a-5797cc0cbac1", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1090), false, "Payment", null, null, "payment.png" },
                    { "4560aaa6-386b-468d-b1a3-c7ecff23e22b", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1100), false, "currency1", null, null, "USD$" },
                    { "462795e8-b68a-4559-9c43-5e6566e65304", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1090), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "4b960752-c99a-4f98-b931-e0cf0585feb5", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1120), false, "Language2", null, null, "Franch" },
                    { "5ecc1c44-7c58-407b-aad6-34fbb297330e", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1130), false, "Flag2", null, null, "2.jpg" },
                    { "8e68ac2f-1201-4a5a-a727-8db131b86d12", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1070), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "9a22248f-ad7b-401c-9f56-0ea1060dc970", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1110), false, "currency2", null, null, "EUR$" },
                    { "a61fac6b-344a-4c19-ad7b-e8198c3d694a", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1060), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "c41787c5-429f-432f-b1e9-276655d6d1ae", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1050), false, "Logo", null, null, "logo.png" },
                    { "d1928f56-77e8-4421-ad50-8728edf658ed", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1080), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "d93963f5-051c-40e1-aabe-6853e65d87ec", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1110), false, "Language1", null, null, "English" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "56806c2e-c095-4fd1-abb3-c60938af8884", "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dec07f4c-b59e-47ec-a105-a6183a2b24f0", "c2a19149-d453-412c-b753-50be308a9e08" });
        }
    }
}
