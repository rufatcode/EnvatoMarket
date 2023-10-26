using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AddSeedDataSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0f009a8a-da9a-4fc7-aac3-7a792d214acb", "08113714-75e8-408c-b53a-53300eeccd5e", "Admin", "ADMIN" },
                    { "54933da0-cc91-405e-8023-93841f073c75", "b7c09a35-f888-48b5-b05b-95c8686bebce", "SupperAdmin", "SUPPERADMIN" },
                    { "b1dd2c8c-3a98-4cc4-87cd-7b92c1367bbf", "23fd077e-f51a-4d4e-bad0-c7b759f3b552", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "f10d8418-959d-479f-b291-45c2ea5bc213", 0, "System", "42f1454d-f439-4211-a588-39f9870a595c", new DateTime(2023, 10, 26, 15, 42, 19, 185, DateTimeKind.Local).AddTicks(3570), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAECkw4Gb1g6WoHdwoutPxsWM4TKdIOWKEchsF2yy1NSSaHQ7Qu2TEiEIZgv/g5/pR5g==", "+994513004484", true, null, null, "8e6d1297-9b12-4927-b332-49dadf22ff52", false, null, "Rufat_2003" },
                    { "f1e1ca42-2c2a-4f92-bad2-25906b6aa237", 0, "System", "1c684c9a-19da-424e-8fa7-7a76984d031c", new DateTime(2023, 10, 26, 15, 42, 19, 185, DateTimeKind.Local).AddTicks(3530), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEPYpIYG9ZkS0Y3vwEF59vuIKzzeni2MoXguplYy4uB4wCg5OIOM3potJs0kypTNTKA==", "+994513004484", true, null, null, "ec47e94a-a7e9-43fe-915e-0cd284ef4978", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "15e3d164-b0bb-44ac-bcff-006aefe50f1a", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4540), false, "Logo", null, null, "logo.png" },
                    { "1ef27972-2515-4ed6-a15f-6308a4d57461", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4610), false, "Flag1", null, null, "1.jpg" },
                    { "25567892-1794-4304-8da1-226b10afcaf8", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4580), false, "currency1", null, null, "USD$" },
                    { "33d913be-9d2b-494e-ba55-ae070b4d1598", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4620), false, "Flag2", null, null, "2.jpg" },
                    { "5cda7522-3dea-470f-a937-0ea290ee132a", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4540), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "71bc4fc6-6a0f-4fe4-86ba-785c3cb03187", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4550), false, "PhoneNumber", null, null, "+994513004484" },
                    { "a08ea523-0638-48be-941e-068d2bec1c7f", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4560), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "a70e1527-b672-44a6-bda6-5da2685f333b", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4560), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "b44e841a-0f0a-4217-b86c-c2378972623a", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4580), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "cf0adaad-d9f7-4680-bc96-f2a7a0822e7f", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4600), false, "Language1", null, null, "English" },
                    { "d5385635-aa7f-4be2-98fc-cb8288345d01", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4570), false, "Payment", null, null, "payment.png" },
                    { "e4abadee-bd9b-4c8d-92ca-f0932b3b6043", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4590), false, "currency2", null, null, "EUR$" },
                    { "f1bd57de-9ecf-459d-924d-719d8cb0c522", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4610), false, "Language2", null, null, "Franch" },
                    { "f2dcd7c1-cfb3-41e0-a7cd-e9a5fd5ac436", "System", new DateTime(2023, 10, 26, 15, 42, 19, 188, DateTimeKind.Local).AddTicks(4530), false, "Hotline", null, null, "+48 500 500 500" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "54933da0-cc91-405e-8023-93841f073c75", "f10d8418-959d-479f-b291-45c2ea5bc213" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f009a8a-da9a-4fc7-aac3-7a792d214acb", "f1e1ca42-2c2a-4f92-bad2-25906b6aa237" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1dd2c8c-3a98-4cc4-87cd-7b92c1367bbf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54933da0-cc91-405e-8023-93841f073c75", "f10d8418-959d-479f-b291-45c2ea5bc213" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f009a8a-da9a-4fc7-aac3-7a792d214acb", "f1e1ca42-2c2a-4f92-bad2-25906b6aa237" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "15e3d164-b0bb-44ac-bcff-006aefe50f1a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1ef27972-2515-4ed6-a15f-6308a4d57461");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "25567892-1794-4304-8da1-226b10afcaf8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "33d913be-9d2b-494e-ba55-ae070b4d1598");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5cda7522-3dea-470f-a937-0ea290ee132a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "71bc4fc6-6a0f-4fe4-86ba-785c3cb03187");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a08ea523-0638-48be-941e-068d2bec1c7f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a70e1527-b672-44a6-bda6-5da2685f333b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b44e841a-0f0a-4217-b86c-c2378972623a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cf0adaad-d9f7-4680-bc96-f2a7a0822e7f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d5385635-aa7f-4be2-98fc-cb8288345d01");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e4abadee-bd9b-4c8d-92ca-f0932b3b6043");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f1bd57de-9ecf-459d-924d-719d8cb0c522");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f2dcd7c1-cfb3-41e0-a7cd-e9a5fd5ac436");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f009a8a-da9a-4fc7-aac3-7a792d214acb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54933da0-cc91-405e-8023-93841f073c75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f10d8418-959d-479f-b291-45c2ea5bc213");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1e1ca42-2c2a-4f92-bad2-25906b6aa237");

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
    }
}
