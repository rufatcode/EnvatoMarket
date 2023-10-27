using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class SliderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13cad7c1-3ff8-4085-b22c-faf7f48d82c3", "f3acb702-b6f3-4da1-9576-01005768fa99", "User", "USER" },
                    { "8ff757ef-cb02-4336-b7af-6c551ff8d660", "3673f12f-8ee9-49f3-88b9-66651a787eee", "SupperAdmin", "SUPPERADMIN" },
                    { "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82", "cb108a99-12c9-450c-a147-d78325e6f193", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "4f18dd5b-3242-4700-9c18-55053e21f8d0", 0, "System", "1211e6dc-c4d2-4556-bdc9-f26032cce955", new DateTime(2023, 10, 27, 15, 17, 8, 822, DateTimeKind.Local).AddTicks(9830), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEIne1aeXlMmyo4MsL4QQ6x7pLEpPKc434xIGRWaYgTY0n0BB1CkKwzjstHigvZGk1A==", "+994513004484", true, null, null, "08d77937-4ec5-4490-8d16-081dbc9fc9dd", false, null, "RufatCode" },
                    { "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6", 0, "System", "3bc81311-e283-4b12-a4a5-f3e60d38b999", new DateTime(2023, 10, 27, 15, 17, 8, 822, DateTimeKind.Local).AddTicks(9870), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAELuqdvcvHGI6h+v/fR1y628aGSZTuOe+8/PbWAXIofqvwt1vqDwDu+n3BidzRcVjsg==", "+994513004484", true, null, null, "02563ed5-fbfe-4a50-b671-ae2b5485f68f", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "076519ce-da54-460d-8b10-5f3f48f86cbb", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(860), false, "Payment", null, null, "payment.png" },
                    { "18bb6124-0b68-401c-890d-cf2eda9c4915", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(890), false, "Language1", null, null, "English" },
                    { "1bba2a6a-6bf4-446a-babe-c0fd180aab92", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(830), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "33d0af2b-16a5-4b14-a555-74a9c9e2356d", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(850), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "59576887-0af9-4d94-89f1-02e0fdea56b3", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(910), false, "Flag2", null, null, "2.jpg" },
                    { "7d4459f1-5031-4b3c-9b92-835191af0cbf", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(820), false, "Hotline", null, null, "+48 500 500 500" },
                    { "99b2c592-50db-4abb-8f43-c4fa872d10b4", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(900), false, "Flag1", null, null, "1.jpg" },
                    { "9f574046-1192-4dca-80b4-6b2686fdb8d7", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(870), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "be41e6cb-a420-4fd2-a86d-6af5b5af9ee2", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(890), false, "Language2", null, null, "Franch" },
                    { "d31a3e27-f745-4e7e-b1b6-db0c4c3ece95", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(830), false, "Logo", null, null, "logo.png" },
                    { "e504fc56-3647-4fd2-af11-1904473cf338", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(870), false, "currency1", null, null, "USD$" },
                    { "f67b03df-f705-4276-a74d-f87e9b81492e", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(850), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "f8a8c633-dd3a-4ea9-a780-13396de6d903", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(880), false, "currency2", null, null, "EUR$" },
                    { "f962c4c4-f466-4e35-b5de-ba6aaf456923", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(840), false, "PhoneNumber", null, null, "+994513004484" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82", "4f18dd5b-3242-4700-9c18-55053e21f8d0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8ff757ef-cb02-4336-b7af-6c551ff8d660", "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cad7c1-3ff8-4085-b22c-faf7f48d82c3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82", "4f18dd5b-3242-4700-9c18-55053e21f8d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ff757ef-cb02-4336-b7af-6c551ff8d660", "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "076519ce-da54-460d-8b10-5f3f48f86cbb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "18bb6124-0b68-401c-890d-cf2eda9c4915");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1bba2a6a-6bf4-446a-babe-c0fd180aab92");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "33d0af2b-16a5-4b14-a555-74a9c9e2356d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "59576887-0af9-4d94-89f1-02e0fdea56b3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7d4459f1-5031-4b3c-9b92-835191af0cbf");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "99b2c592-50db-4abb-8f43-c4fa872d10b4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9f574046-1192-4dca-80b4-6b2686fdb8d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "be41e6cb-a420-4fd2-a86d-6af5b5af9ee2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d31a3e27-f745-4e7e-b1b6-db0c4c3ece95");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e504fc56-3647-4fd2-af11-1904473cf338");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f67b03df-f705-4276-a74d-f87e9b81492e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f8a8c633-dd3a-4ea9-a780-13396de6d903");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f962c4c4-f466-4e35-b5de-ba6aaf456923");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ff757ef-cb02-4336-b7af-6c551ff8d660");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f18dd5b-3242-4700-9c18-55053e21f8d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6");

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
    }
}
