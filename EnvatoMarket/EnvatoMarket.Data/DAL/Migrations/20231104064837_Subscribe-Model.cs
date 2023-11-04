using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class SubscribeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e180337-8cf5-4046-a3e9-d39df6859d0d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "981ecd05-1285-4962-be23-33e54e96fcc8", "1e6ae1d4-d45c-4ab9-84b7-7af0fb966dff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3868637-1fb8-4e1d-864c-66f84711e6da", "de7bccc8-d238-447a-8f1f-e74bf79cfec6" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "26384a47-cd30-433c-91ea-f05e0b522cf8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2ea88765-2ba1-4677-99e6-0b02e004bec7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2f815134-c0d3-47d4-9d08-40529440d81e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "31e0f3ed-4e8a-4225-80b7-b0c228d24e49");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "40c34dd4-c1fc-4c40-9e59-70719f13c7c5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6049d5fb-5016-404d-bd51-9d0fd35a546e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "657c01de-bd4d-4c15-969e-186b7e98c833");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "789e5efd-3ed1-46a5-8290-db3ac9f19dda");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "88800fd7-7a85-40b4-a239-bda3f782fdaf");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b4edde1b-9130-4b00-b68d-55cbadf5517e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c395310b-799c-4608-ae09-a0dd4dbb041d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cd857e1a-8789-4105-8866-6f4fe76b1e9d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e2d0ac41-09c3-4a26-afc8-970806ffaf4b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f23d44a5-601d-4407-9f5a-e91813436d15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "981ecd05-1285-4962-be23-33e54e96fcc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3868637-1fb8-4e1d-864c-66f84711e6da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e6ae1d4-d45c-4ab9-84b7-7af0fb966dff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de7bccc8-d238-447a-8f1f-e74bf79cfec6");

            migrationBuilder.AddColumn<string>(
                name: "Replay",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Subscribes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3230a439-96cd-438b-a960-c8a006865765", "f75a7679-40de-4918-a617-2b5ea29199d0", "Admin", "ADMIN" },
                    { "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6", "fe1fc06d-29b5-4dfb-985b-469f1199600a", "SupperAdmin", "SUPPERADMIN" },
                    { "af51b444-d0c3-4eaa-b32e-0b81ee5c112b", "54e58824-e006-4f97-b2c4-ffb155b7f19b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "770289d3-0448-4e7e-ac8a-644398d8a63c", 0, "System", "c5f58c94-5434-403e-bba6-1421350a5166", new DateTime(2023, 11, 4, 10, 48, 36, 800, DateTimeKind.Local).AddTicks(4350), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEAzWAEXrOfvK+DXdGWnD+24IQU73U4XcjB6lRnTBhaYpJ1GWSPIqA12nR74jO/F45w==", "+994513004484", true, null, null, "4101b3ed-9420-4e25-9140-0b0333795522", false, null, "RufatCode" },
                    { "d0719b20-84b1-4162-8bb2-d4a4abc12906", 0, "System", "82211220-3fcf-478b-8a1c-9e464b87d585", new DateTime(2023, 11, 4, 10, 48, 36, 800, DateTimeKind.Local).AddTicks(4390), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEOaEGRERlcHPat0RT5YALx3UbIWmhteIL9FWceDR7ih+jEbFF/NesN4HQYvHmjYtZw==", "+994513004484", true, null, null, "b6417e11-fecc-405c-9af4-7acea785481f", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0f0ead43-85d3-4033-9ba2-01925fac8dcb", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4500), false, "currency1", null, null, "USD$" },
                    { "214042bd-9c3f-44fd-becb-c37004fca02e", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4460), false, "Payment", null, null, "payment.png" },
                    { "344a4521-bc34-4df4-bbbd-6d753ea4853e", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4510), false, "Language1", null, null, "English" },
                    { "36da915b-59ee-475c-8be0-e92f916a6557", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4450), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "4e7c4e5b-de5a-4d7f-a0ba-a7dead1d43e5", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4520), false, "Language2", null, null, "Franch" },
                    { "570a298c-11b2-4a40-9eec-672a8d6e88fe", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4430), false, "Logo", null, null, "logo.png" },
                    { "65cc02d1-a105-4641-a45f-3ab59e64882a", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4500), false, "currency2", null, null, "EUR$" },
                    { "6a7adc9e-9482-48ae-b999-e58329ed5d57", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4440), false, "PhoneNumber", null, null, "+994513004484" },
                    { "6b618db0-8a72-4f92-a37b-08e786f74ca1", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4470), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "791af639-caf2-447a-a2a2-0277400d71bc", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4460), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "91c91da8-8816-45ec-abd1-f0c882659706", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4520), false, "Flag1", null, null, "1.jpg" },
                    { "b2152793-2bed-445d-8dbf-42ab52143b50", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4420), false, "Hotline", null, null, "+48 500 500 500" },
                    { "d47042c1-9487-414c-b819-6888c8a962f2", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4530), false, "Flag2", null, null, "2.jpg" },
                    { "f092a56a-3c92-4edf-b96a-f8d486872251", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4440), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3230a439-96cd-438b-a960-c8a006865765", "770289d3-0448-4e7e-ac8a-644398d8a63c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6", "d0719b20-84b1-4162-8bb2-d4a4abc12906" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af51b444-d0c3-4eaa-b32e-0b81ee5c112b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3230a439-96cd-438b-a960-c8a006865765", "770289d3-0448-4e7e-ac8a-644398d8a63c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6", "d0719b20-84b1-4162-8bb2-d4a4abc12906" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0f0ead43-85d3-4033-9ba2-01925fac8dcb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "214042bd-9c3f-44fd-becb-c37004fca02e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "344a4521-bc34-4df4-bbbd-6d753ea4853e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "36da915b-59ee-475c-8be0-e92f916a6557");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4e7c4e5b-de5a-4d7f-a0ba-a7dead1d43e5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "570a298c-11b2-4a40-9eec-672a8d6e88fe");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "65cc02d1-a105-4641-a45f-3ab59e64882a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6a7adc9e-9482-48ae-b999-e58329ed5d57");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6b618db0-8a72-4f92-a37b-08e786f74ca1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "791af639-caf2-447a-a2a2-0277400d71bc");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "91c91da8-8816-45ec-abd1-f0c882659706");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b2152793-2bed-445d-8dbf-42ab52143b50");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d47042c1-9487-414c-b819-6888c8a962f2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f092a56a-3c92-4edf-b96a-f8d486872251");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3230a439-96cd-438b-a960-c8a006865765");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770289d3-0448-4e7e-ac8a-644398d8a63c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0719b20-84b1-4162-8bb2-d4a4abc12906");

            migrationBuilder.DropColumn(
                name: "Replay",
                table: "Contacts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e180337-8cf5-4046-a3e9-d39df6859d0d", "b5ff6161-152d-4069-86d8-ddd7fd9a2809", "User", "USER" },
                    { "981ecd05-1285-4962-be23-33e54e96fcc8", "b6ce807e-6d52-4a67-9c12-0621d9dad50b", "Admin", "ADMIN" },
                    { "c3868637-1fb8-4e1d-864c-66f84711e6da", "1ce17c26-62b7-4acd-bf1a-84aaa35e217b", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "1e6ae1d4-d45c-4ab9-84b7-7af0fb966dff", 0, "System", "066bcb1d-fd24-4bdd-a5d8-cb1e7a33f685", new DateTime(2023, 11, 3, 21, 6, 41, 489, DateTimeKind.Local).AddTicks(6940), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAELjEdebVc51kf8G0spB4CD0Cz0ZJ/7yGurdbb0odU+gcG/60tT9aHq05VSh1TIFcRw==", "+994513004484", true, null, null, "4376e17f-9b3c-4536-b233-111611d7e276", false, null, "RufatCode" },
                    { "de7bccc8-d238-447a-8f1f-e74bf79cfec6", 0, "System", "bd945fe3-58c3-4218-aa55-1c17efa849dd", new DateTime(2023, 11, 3, 21, 6, 41, 489, DateTimeKind.Local).AddTicks(6970), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEC3O5LxXtNlDiPaXiBc6RgE71eKiAF3eK+yympaSci9Qpq4YW24fC7Bva0KteSZ7RA==", "+994513004484", true, null, null, "1baabae2-30ff-42af-9663-863628edfa60", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "26384a47-cd30-433c-91ea-f05e0b522cf8", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7620), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "2ea88765-2ba1-4677-99e6-0b02e004bec7", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7680), false, "Language2", null, null, "Franch" },
                    { "2f815134-c0d3-47d4-9d08-40529440d81e", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7670), false, "currency2", null, null, "EUR$" },
                    { "31e0f3ed-4e8a-4225-80b7-b0c228d24e49", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7680), false, "Language1", null, null, "English" },
                    { "40c34dd4-c1fc-4c40-9e59-70719f13c7c5", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7620), false, "Logo", null, null, "logo.png" },
                    { "6049d5fb-5016-404d-bd51-9d0fd35a546e", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7650), false, "Payment", null, null, "payment.png" },
                    { "657c01de-bd4d-4c15-969e-186b7e98c833", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7690), false, "Flag1", null, null, "1.jpg" },
                    { "789e5efd-3ed1-46a5-8290-db3ac9f19dda", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7640), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "88800fd7-7a85-40b4-a239-bda3f782fdaf", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7660), false, "currency1", null, null, "USD$" },
                    { "b4edde1b-9130-4b00-b68d-55cbadf5517e", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7660), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "c395310b-799c-4608-ae09-a0dd4dbb041d", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7690), false, "Flag2", null, null, "2.jpg" },
                    { "cd857e1a-8789-4105-8866-6f4fe76b1e9d", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7610), false, "Hotline", null, null, "+48 500 500 500" },
                    { "e2d0ac41-09c3-4a26-afc8-970806ffaf4b", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7630), false, "PhoneNumber", null, null, "+994513004484" },
                    { "f23d44a5-601d-4407-9f5a-e91813436d15", "System", new DateTime(2023, 11, 3, 21, 6, 41, 492, DateTimeKind.Local).AddTicks(7640), false, "Email", null, null, "rufatri@code.edu.az" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "981ecd05-1285-4962-be23-33e54e96fcc8", "1e6ae1d4-d45c-4ab9-84b7-7af0fb966dff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c3868637-1fb8-4e1d-864c-66f84711e6da", "de7bccc8-d238-447a-8f1f-e74bf79cfec6" });
        }
    }
}
