using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class SeedDataSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5fb6f7b-7859-47c9-a8b2-575da33a53dc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46e482b2-cf21-414d-9003-cc18ee4d225a", "40a2ad00-eb30-4bf1-8714-c7aadd809ecf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a3f90b3-f45f-42aa-b533-69159a70cfc6", "f45774a2-6135-4920-8368-60683c496bf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46e482b2-cf21-414d-9003-cc18ee4d225a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a3f90b3-f45f-42aa-b533-69159a70cfc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40a2ad00-eb30-4bf1-8714-c7aadd809ecf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f45774a2-6135-4920-8368-60683c496bf6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71db3f4a-582a-4823-ac38-b07069f2c058", "62c77d4c-d01f-4e5a-9e15-e8c3cdb56526", "User", "USER" },
                    { "bd2a1712-6eb2-4e61-b981-4780b2f3f847", "e670119a-fe3e-406c-a8d8-e73d408a97b9", "Admin", "ADMIN" },
                    { "e04dd46c-c7b9-4027-b5ae-61824adb2e7c", "705e7813-b56c-4372-a2a2-8694ca314798", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "8805b3a3-c184-40b9-965c-791ef2878349", 0, "System", "e1ebac52-2a61-4c2c-954d-e6c64daf3f96", new DateTime(2023, 10, 26, 13, 21, 18, 877, DateTimeKind.Local).AddTicks(3180), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAELj9zi3/UthYkCXqgDfm0KEeVTnrPOHEauCUNnNV0vs10hTIMuOhXP+Ukus/KTNHdA==", "+994513004484", true, null, null, "fc912cf0-6467-4e84-912b-a93d73577056", false, null, "RufatCode" },
                    { "cc278d60-10b0-4fe5-bbab-1f37f52ec6fc", 0, "System", "dc222511-2c15-4635-a4f7-a72e73bc01ba", new DateTime(2023, 10, 26, 13, 21, 18, 877, DateTimeKind.Local).AddTicks(3210), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEBAzx0LwyluNrC3MTX0xDFgpeHdVP9iPJ0nhfrUuRdernjXpvomlVVneX726WoIYaA==", "+994513004484", true, null, null, "b18ed504-773f-4d15-b870-a8b840218e86", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "4fd33652-f5be-4b11-b702-29199dfd9054", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3290), false, "Hotline", null, null, "+48 500 500 500" },
                    { "5457bafc-d225-4304-ab0e-0e11b1f703ad", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3320), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "76d79839-d2d6-4830-b742-582cdd445d24", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3300), false, "Logo", null, null, "logo.png" },
                    { "90c4b4a9-5ff6-4ac3-ab65-24863ac4056a", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3330), false, "Payment", null, null, "payment.png" },
                    { "c2ac7d8a-1df7-4803-83d2-b5ebd103bc76", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3310), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "e139ea9a-565d-4605-a8e2-231b0322d617", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3340), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "e9703f0b-1c16-4ad3-adac-7c6074b7838a", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3320), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "fcc4bc4d-b5c6-4a53-b1d7-fd85c76421a0", "System", new DateTime(2023, 10, 26, 13, 21, 18, 880, DateTimeKind.Local).AddTicks(3310), false, "PhoneNumber", null, null, "+994513004484" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2a1712-6eb2-4e61-b981-4780b2f3f847", "8805b3a3-c184-40b9-965c-791ef2878349" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e04dd46c-c7b9-4027-b5ae-61824adb2e7c", "cc278d60-10b0-4fe5-bbab-1f37f52ec6fc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71db3f4a-582a-4823-ac38-b07069f2c058");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2a1712-6eb2-4e61-b981-4780b2f3f847", "8805b3a3-c184-40b9-965c-791ef2878349" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e04dd46c-c7b9-4027-b5ae-61824adb2e7c", "cc278d60-10b0-4fe5-bbab-1f37f52ec6fc" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4fd33652-f5be-4b11-b702-29199dfd9054");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5457bafc-d225-4304-ab0e-0e11b1f703ad");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "76d79839-d2d6-4830-b742-582cdd445d24");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "90c4b4a9-5ff6-4ac3-ab65-24863ac4056a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c2ac7d8a-1df7-4803-83d2-b5ebd103bc76");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e139ea9a-565d-4605-a8e2-231b0322d617");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e9703f0b-1c16-4ad3-adac-7c6074b7838a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "fcc4bc4d-b5c6-4a53-b1d7-fd85c76421a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2a1712-6eb2-4e61-b981-4780b2f3f847");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04dd46c-c7b9-4027-b5ae-61824adb2e7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8805b3a3-c184-40b9-965c-791ef2878349");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc278d60-10b0-4fe5-bbab-1f37f52ec6fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46e482b2-cf21-414d-9003-cc18ee4d225a", "f4638bd2-53f9-43bd-abb6-3c8074942ad3", "SupperAdmin", "SUPPERADMIN" },
                    { "5a3f90b3-f45f-42aa-b533-69159a70cfc6", "c508d51a-02dd-418f-89b3-5d305aab0d27", "Admin", "ADMIN" },
                    { "e5fb6f7b-7859-47c9-a8b2-575da33a53dc", "5f432bb6-61c2-45ae-bf29-d7b465190662", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "40a2ad00-eb30-4bf1-8714-c7aadd809ecf", 0, "System", "2296f78f-7592-476d-961c-07d92f4801ce", new DateTime(2023, 10, 26, 12, 53, 55, 269, DateTimeKind.Local).AddTicks(9510), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEOWEvqLaZF29pTph1p1Aa9bRbVOaLTS8BlRCnIiDHKp4XUE5rgkpn2SbYNuNQCaHzA==", "+994513004484", true, null, null, "935b9700-5914-4a79-983c-6a01e604ee52", false, null, "Rufat_2003" },
                    { "f45774a2-6135-4920-8368-60683c496bf6", 0, "System", "93a9405c-9046-469f-803e-dd776a707e63", new DateTime(2023, 10, 26, 12, 53, 55, 269, DateTimeKind.Local).AddTicks(9470), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEHBxR6eya2YvBeHLdEPwDbGhKY0cMhNLlOOZ7Ses2YgHtEVjf0IQ8+GKU/P6xDDOGA==", "+994513004484", true, null, null, "bee73742-0189-419d-b6cd-4b4778317c57", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46e482b2-cf21-414d-9003-cc18ee4d225a", "40a2ad00-eb30-4bf1-8714-c7aadd809ecf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a3f90b3-f45f-42aa-b533-69159a70cfc6", "f45774a2-6135-4920-8368-60683c496bf6" });
        }
    }
}
