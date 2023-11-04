using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class ContactModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e60c8ccc-502a-4c70-ba1c-66763d8bede7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff82a119-d71f-44c5-8071-f03e7f87c8d5", "32a57a4c-a967-49d6-a9fc-a6b8e34b7f60" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "890d96a6-a475-410f-8a29-4ff501701d08", "fbef1242-4a4b-47b3-a048-5f27f84c3ce1" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0537e61a-bdd2-42c6-9e5e-ba0205e65253");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "23a7fe20-d201-4c8d-9fb1-41ec2985838f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "260a5d67-4ba8-4403-a94c-5654a8647052");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "54d58a10-b68a-4554-8720-045b73d065bb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8b15228d-b3a8-45e1-ade7-84644a3d835a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a19444aa-0de1-44f6-b1b0-8f0d8ff121cb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a39cbc7a-2ef4-4a63-9372-b2b0f1a021f4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a5353c67-a27f-42c9-b118-544323150fa4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a822e42f-58da-47b9-b71d-93ed2dbe5708");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "aa07f446-7839-45ba-9b11-8968310c8298");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "bc1621b3-073d-49f8-a046-c28bd6829d59");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d367467b-eccc-4174-9a9b-94283471ca42");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e2ad5123-cdc6-4139-9519-1a2520501d80");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "fc87c615-5888-4133-add0-40a2e1fb62aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "890d96a6-a475-410f-8a29-4ff501701d08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff82a119-d71f-44c5-8071-f03e7f87c8d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32a57a4c-a967-49d6-a9fc-a6b8e34b7f60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef1242-4a4b-47b3-a048-5f27f84c3ce1");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "890d96a6-a475-410f-8a29-4ff501701d08", "471d024b-997a-47c9-86ff-1dbd2023ed4d", "Admin", "ADMIN" },
                    { "e60c8ccc-502a-4c70-ba1c-66763d8bede7", "9248af87-cfa5-4a05-8c0b-ca69bb9d8380", "User", "USER" },
                    { "ff82a119-d71f-44c5-8071-f03e7f87c8d5", "37e5aabe-7863-4ee4-bbf5-458be5146fe4", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "32a57a4c-a967-49d6-a9fc-a6b8e34b7f60", 0, "System", "83f73c3b-ad3a-4793-8664-83c4c6f35c4b", new DateTime(2023, 11, 3, 0, 56, 55, 922, DateTimeKind.Local).AddTicks(8950), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEHcUWQ6PejXeKFnrHSOgSGxP3v7kfI9fBzpwl66ntVdNft3xBfZBqNeFaQhTwIo6RA==", "+994513004484", true, null, null, "e68e63de-3599-4a86-ac9c-a40a2b678343", false, null, "Rufat_2003" },
                    { "fbef1242-4a4b-47b3-a048-5f27f84c3ce1", 0, "System", "06a87253-1e96-4026-b1a3-1929d2a48a74", new DateTime(2023, 11, 3, 0, 56, 55, 922, DateTimeKind.Local).AddTicks(8910), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEL/XZfMDh/Vuw6X8J+abYulCtaM1N5GYLSTpgY9U6/5BzjHVzpdGbxpZLGvXqOrBWA==", "+994513004484", true, null, null, "01576e1d-6778-42dc-b7e1-022697b21d41", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0537e61a-bdd2-42c6-9e5e-ba0205e65253", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8780), false, "PhoneNumber", null, null, "+994513004484" },
                    { "23a7fe20-d201-4c8d-9fb1-41ec2985838f", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8830), false, "Language1", null, null, "English" },
                    { "260a5d67-4ba8-4403-a94c-5654a8647052", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8800), false, "Payment", null, null, "payment.png" },
                    { "54d58a10-b68a-4554-8720-045b73d065bb", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8840), false, "Language2", null, null, "Franch" },
                    { "8b15228d-b3a8-45e1-ade7-84644a3d835a", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8790), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "a19444aa-0de1-44f6-b1b0-8f0d8ff121cb", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8760), false, "Logo", null, null, "logo.png" },
                    { "a39cbc7a-2ef4-4a63-9372-b2b0f1a021f4", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8810), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "a5353c67-a27f-42c9-b118-544323150fa4", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8790), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "a822e42f-58da-47b9-b71d-93ed2dbe5708", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8840), false, "Flag1", null, null, "1.jpg" },
                    { "aa07f446-7839-45ba-9b11-8968310c8298", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8850), false, "Flag2", null, null, "2.jpg" },
                    { "bc1621b3-073d-49f8-a046-c28bd6829d59", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8820), false, "currency1", null, null, "USD$" },
                    { "d367467b-eccc-4174-9a9b-94283471ca42", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8820), false, "currency2", null, null, "EUR$" },
                    { "e2ad5123-cdc6-4139-9519-1a2520501d80", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8770), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "fc87c615-5888-4133-add0-40a2e1fb62aa", "System", new DateTime(2023, 11, 3, 0, 56, 55, 925, DateTimeKind.Local).AddTicks(8750), false, "Hotline", null, null, "+48 500 500 500" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff82a119-d71f-44c5-8071-f03e7f87c8d5", "32a57a4c-a967-49d6-a9fc-a6b8e34b7f60" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "890d96a6-a475-410f-8a29-4ff501701d08", "fbef1242-4a4b-47b3-a048-5f27f84c3ce1" });
        }
    }
}
