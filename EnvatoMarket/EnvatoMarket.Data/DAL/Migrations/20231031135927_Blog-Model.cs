using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class BlogModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "116ab76a-bb74-4f31-9d99-94176af16d6d", "bb6e6f16-731e-4ece-a444-43c85506f574", "User", "USER" },
                    { "1551afba-409f-4b30-8f61-26b38f6dffad", "e5b9af61-6cdf-4db4-a281-33d02a63fa11", "SupperAdmin", "SUPPERADMIN" },
                    { "9be348e2-acde-4039-9901-cf2c0b88a217", "e447bdf5-e982-499c-b3e0-1533066ddb41", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "46533fbf-1ef4-4099-b994-a0e25ad08ecf", 0, "System", "374f7136-00e1-438d-9e96-fb8d5f8cf723", new DateTime(2023, 10, 31, 17, 59, 27, 692, DateTimeKind.Local).AddTicks(3960), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEMQ/okfJmMO8hZVard7/KCYqiza4I+h5f0QQgcsdo/38PTyfhZxH5R7bCAmRG6wh7Q==", "+994513004484", true, null, null, "d7c397f3-1848-4db1-8464-eacea95d5dcc", false, null, "Rufat_2003" },
                    { "5ae80f56-a257-4c98-916d-1aaf19fa0460", 0, "System", "2212af32-903d-43c2-beb9-ba5c4cd39f5a", new DateTime(2023, 10, 31, 17, 59, 27, 692, DateTimeKind.Local).AddTicks(3920), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEDIi8Qd7ct40JO/CMYe9LfoLHy8P4pjQd6kMqbAp+1A2LLptHLndcdLPnXFyh9nalQ==", "+994513004484", true, null, null, "fcf90c4f-3cdc-4650-baec-044142fce72c", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "1031104a-0f0a-4cc6-82bc-41636e2ad297", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4250), false, "PhoneNumber", null, null, "+994513004484" },
                    { "2f25cf98-d0f2-46fe-9c98-1cfa88d83c68", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4260), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "3befebbe-3000-4ea1-a0fb-2f65b5d3126d", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4290), false, "currency2", null, null, "EUR$" },
                    { "3d6838c2-fd3f-4953-8285-8898dd0f5ab3", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4320), false, "Flag2", null, null, "2.jpg" },
                    { "7f10c907-2f63-4c40-a936-8be3429f5f4f", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4300), false, "Language1", null, null, "English" },
                    { "8fcc6f59-bc0f-4fe2-81af-c3176a34c4db", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4300), false, "Language2", null, null, "Franch" },
                    { "96842835-83e3-490b-bdbd-a8e578dd55b9", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4240), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "a502301f-1ab4-41ed-a6ac-a0a20db922e9", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4230), false, "Hotline", null, null, "+48 500 500 500" },
                    { "c5664d71-a22c-419a-a5c2-bef61d4b2b49", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4310), false, "Flag1", null, null, "1.jpg" },
                    { "d3f46e9b-4f90-478c-a01f-f3a4066e5a40", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4280), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "d87992bf-0b98-4f1d-9361-8bdc944183e8", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4260), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "db67af74-dae3-4ece-a603-453b7d632c43", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4280), false, "currency1", null, null, "USD$" },
                    { "debeb58e-6f51-40b5-81b4-d21570dd2999", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4270), false, "Payment", null, null, "payment.png" },
                    { "edef1f93-4ab2-438d-b47b-65e643ba8fb2", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4240), false, "Logo", null, null, "logo.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1551afba-409f-4b30-8f61-26b38f6dffad", "46533fbf-1ef4-4099-b994-a0e25ad08ecf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9be348e2-acde-4039-9901-cf2c0b88a217", "5ae80f56-a257-4c98-916d-1aaf19fa0460" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "116ab76a-bb74-4f31-9d99-94176af16d6d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1551afba-409f-4b30-8f61-26b38f6dffad", "46533fbf-1ef4-4099-b994-a0e25ad08ecf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9be348e2-acde-4039-9901-cf2c0b88a217", "5ae80f56-a257-4c98-916d-1aaf19fa0460" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1031104a-0f0a-4cc6-82bc-41636e2ad297");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2f25cf98-d0f2-46fe-9c98-1cfa88d83c68");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3befebbe-3000-4ea1-a0fb-2f65b5d3126d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3d6838c2-fd3f-4953-8285-8898dd0f5ab3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7f10c907-2f63-4c40-a936-8be3429f5f4f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8fcc6f59-bc0f-4fe2-81af-c3176a34c4db");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "96842835-83e3-490b-bdbd-a8e578dd55b9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a502301f-1ab4-41ed-a6ac-a0a20db922e9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c5664d71-a22c-419a-a5c2-bef61d4b2b49");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d3f46e9b-4f90-478c-a01f-f3a4066e5a40");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d87992bf-0b98-4f1d-9361-8bdc944183e8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "db67af74-dae3-4ece-a603-453b7d632c43");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "debeb58e-6f51-40b5-81b4-d21570dd2999");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "edef1f93-4ab2-438d-b47b-65e643ba8fb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1551afba-409f-4b30-8f61-26b38f6dffad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be348e2-acde-4039-9901-cf2c0b88a217");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46533fbf-1ef4-4099-b994-a0e25ad08ecf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ae80f56-a257-4c98-916d-1aaf19fa0460");

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
    }
}
