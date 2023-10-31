using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AuthorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a24acf62-18fa-43d2-a950-6ecfc014aeaa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "046a54b6-f2e6-4f6d-86b5-c2d61f461fec", "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52", "2396a0e9-8506-4482-80e6-4c191682af70" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0102dec9-63ea-4ae5-9447-1edaaf3f5e7b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "330767e0-6062-4edd-8d4d-82aea3920814");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3f5c5234-2744-4df7-9eb2-6d25e581a8c0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "65a5c00b-dca7-4ae6-994c-6928c22e2bd7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7471a151-6867-4364-9bd6-b22c870e5096");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7fcbac19-8c08-4990-8bf4-838640f3871f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9f77a6d2-641f-44a3-81b2-fcb4ea80cb88");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "bae02bd4-dde9-4511-b5ba-3f6b646d78c3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "beb1b622-ef00-4a26-9211-1c0455556bc1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c51f2d2c-6f39-4505-9076-61629bd68c2f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d1a8fd8c-b16c-4346-a922-7fed7aae3569");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e0bd17b8-b16f-43b0-8cf3-4c33afcade67");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e3df2ae8-c0ed-4b59-9930-ed5665954af4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f44aac1a-c006-4981-9c1d-06e5fc1bc302");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "046a54b6-f2e6-4f6d-86b5-c2d61f461fec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2396a0e9-8506-4482-80e6-4c191682af70");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5877243-a494-4dac-b140-a1379fd141c5", "cfaced97-c27b-4b6c-8f9d-4f6457a902d9", "User", "USER" },
                    { "e2f4dc26-21f7-40e3-8459-935632e21735", "9678d2fa-6cac-4bc1-9a55-baf5d10cfbb2", "Admin", "ADMIN" },
                    { "f370f573-d228-499d-b81a-38bd68e70ea0", "1fdaf7f7-28dd-4e85-8c90-931a00f0b36c", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "8644abc0-7fbb-4e94-8bd2-e1dbf6f933bf", 0, "System", "49894417-f358-4cc8-bc23-8f3731c2c1d8", new DateTime(2023, 10, 31, 16, 8, 59, 374, DateTimeKind.Local).AddTicks(2290), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEPuZPQrvq1DchIKi9ffEqWo+/+vRqHQ653V0Nt/93yy73wV9iSy9LNC0+b22Amr5Tw==", "+994513004484", true, null, null, "255b51c1-579f-45fb-9961-d6bc91953364", false, null, "Rufat_2003" },
                    { "f8f68d10-131c-4c25-bacb-1fffebb57254", 0, "System", "dce07472-0041-4fa1-918d-e82398cd94d8", new DateTime(2023, 10, 31, 16, 8, 59, 374, DateTimeKind.Local).AddTicks(2260), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEG0Y4GoQEC7HY2UBFePZOkmcqjqRJaTRxiPnTgide8VLdXj881GJbDBwgIGhl0QpKA==", "+994513004484", true, null, null, "e510c1e0-58f2-4c45-a430-1609f373669b", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0c444972-d647-4c7f-af08-78e71844d2da", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2390), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "2799ff19-0699-4e20-9af7-b5fdf390de39", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2430), false, "Flag2", null, null, "2.jpg" },
                    { "5ff5f622-d33c-457a-9caa-62a79577b3c4", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2360), false, "PhoneNumber", null, null, "+994513004484" },
                    { "63ae8329-dae6-4fa7-ac88-c45555cae241", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2400), false, "currency1", null, null, "USD$" },
                    { "63ccbfb0-7c81-4da9-b59e-ff850f0c353f", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2370), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "742b5ce5-e479-4cb1-9072-0122bbc79a91", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2350), false, "Logo", null, null, "logo.png" },
                    { "8c8be647-fe3b-4ef0-8f69-e6c2e1fd3d2f", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2430), false, "Flag1", null, null, "1.jpg" },
                    { "915da678-b47a-4953-acf1-0811b1cd4eff", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2410), false, "Language1", null, null, "English" },
                    { "a691edd6-08a5-468e-9018-12f441e866c4", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2380), false, "Payment", null, null, "payment.png" },
                    { "ac1fe6e6-e12e-46ae-90ed-1117270cfed1", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2360), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "b5144226-600c-48d6-bb21-cf37be3eab85", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2340), false, "Hotline", null, null, "+48 500 500 500" },
                    { "ce5eba32-bca3-4870-a0ed-9df3df3a7879", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2410), false, "currency2", null, null, "EUR$" },
                    { "d3c8bc9e-c99c-41d8-8667-253efa8cc2b3", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2420), false, "Language2", null, null, "Franch" },
                    { "e2a88049-9ece-49de-bee3-044b211c866b", "System", new DateTime(2023, 10, 31, 16, 8, 59, 377, DateTimeKind.Local).AddTicks(2380), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f370f573-d228-499d-b81a-38bd68e70ea0", "8644abc0-7fbb-4e94-8bd2-e1dbf6f933bf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2f4dc26-21f7-40e3-8459-935632e21735", "f8f68d10-131c-4c25-bacb-1fffebb57254" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877243-a494-4dac-b140-a1379fd141c5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f370f573-d228-499d-b81a-38bd68e70ea0", "8644abc0-7fbb-4e94-8bd2-e1dbf6f933bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2f4dc26-21f7-40e3-8459-935632e21735", "f8f68d10-131c-4c25-bacb-1fffebb57254" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0c444972-d647-4c7f-af08-78e71844d2da");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2799ff19-0699-4e20-9af7-b5fdf390de39");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5ff5f622-d33c-457a-9caa-62a79577b3c4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "63ae8329-dae6-4fa7-ac88-c45555cae241");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "63ccbfb0-7c81-4da9-b59e-ff850f0c353f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "742b5ce5-e479-4cb1-9072-0122bbc79a91");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8c8be647-fe3b-4ef0-8f69-e6c2e1fd3d2f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "915da678-b47a-4953-acf1-0811b1cd4eff");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a691edd6-08a5-468e-9018-12f441e866c4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ac1fe6e6-e12e-46ae-90ed-1117270cfed1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b5144226-600c-48d6-bb21-cf37be3eab85");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ce5eba32-bca3-4870-a0ed-9df3df3a7879");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d3c8bc9e-c99c-41d8-8667-253efa8cc2b3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e2a88049-9ece-49de-bee3-044b211c866b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2f4dc26-21f7-40e3-8459-935632e21735");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f370f573-d228-499d-b81a-38bd68e70ea0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8644abc0-7fbb-4e94-8bd2-e1dbf6f933bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8f68d10-131c-4c25-bacb-1fffebb57254");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "046a54b6-f2e6-4f6d-86b5-c2d61f461fec", "bee25fe6-fa13-4f4f-a6fe-07f854aa7a66", "Admin", "ADMIN" },
                    { "a24acf62-18fa-43d2-a950-6ecfc014aeaa", "fd6a3254-d5da-4bde-88fb-26e6e1a5bf77", "User", "USER" },
                    { "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52", "7fea7eb1-318a-4860-9349-9602da0fb199", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12", 0, "System", "a6953121-ab24-474c-a18b-39ff103f44f2", new DateTime(2023, 10, 30, 11, 14, 32, 959, DateTimeKind.Local).AddTicks(9630), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEPTD7JPH8SpFRsIypzLn1nS7gkGEnGqVQgPhj69dg/2WHRxaPRUm9E0hMuyXM4gXsg==", "+994513004484", true, null, null, "65d5825d-8621-4238-b968-27605c76473d", false, null, "RufatCode" },
                    { "2396a0e9-8506-4482-80e6-4c191682af70", 0, "System", "b007d73c-9d31-410d-8d65-4ed6bab6ddb6", new DateTime(2023, 10, 30, 11, 14, 32, 959, DateTimeKind.Local).AddTicks(9670), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEHV73dDO1hR84csJfiyaQnFmmxeIZxPUMflnNIHCdWxgm2P+awCb0ti6BglhqM0ETQ==", "+994513004484", true, null, null, "21f5a604-8a4c-4989-a8dc-e2cf9bc9cc55", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0102dec9-63ea-4ae5-9447-1edaaf3f5e7b", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9690), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "330767e0-6062-4edd-8d4d-82aea3920814", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9730), false, "Flag2", null, null, "2.jpg" },
                    { "3f5c5234-2744-4df7-9eb2-6d25e581a8c0", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9700), false, "currency2", null, null, "EUR$" },
                    { "65a5c00b-dca7-4ae6-994c-6928c22e2bd7", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9650), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "7471a151-6867-4364-9bd6-b22c870e5096", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9670), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "7fcbac19-8c08-4990-8bf4-838640f3871f", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9710), false, "Language1", null, null, "English" },
                    { "9f77a6d2-641f-44a3-81b2-fcb4ea80cb88", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9640), false, "Hotline", null, null, "+48 500 500 500" },
                    { "bae02bd4-dde9-4511-b5ba-3f6b646d78c3", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9680), false, "Payment", null, null, "payment.png" },
                    { "beb1b622-ef00-4a26-9211-1c0455556bc1", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9690), false, "currency1", null, null, "USD$" },
                    { "c51f2d2c-6f39-4505-9076-61629bd68c2f", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9720), false, "Flag1", null, null, "1.jpg" },
                    { "d1a8fd8c-b16c-4346-a922-7fed7aae3569", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9660), false, "PhoneNumber", null, null, "+994513004484" },
                    { "e0bd17b8-b16f-43b0-8cf3-4c33afcade67", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9650), false, "Logo", null, null, "logo.png" },
                    { "e3df2ae8-c0ed-4b59-9930-ed5665954af4", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9710), false, "Language2", null, null, "Franch" },
                    { "f44aac1a-c006-4981-9c1d-06e5fc1bc302", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9670), false, "Email", null, null, "rufatri@code.edu.az" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "046a54b6-f2e6-4f6d-86b5-c2d61f461fec", "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52", "2396a0e9-8506-4482-80e6-4c191682af70" });
        }
    }
}
