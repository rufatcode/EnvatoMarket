using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AlterCommentModelAddContentColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea8d8bbf-038a-46e1-a442-987f83729c85");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb1e2f85-4d44-4c7e-ba0e-dd9ef9fbaa66", "3ddd7f02-1d48-4c64-b0d7-ecee10396636" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6df36631-9ec9-497d-ad63-90854378898a", "6f2ef681-a262-4fc5-955d-4079d69c34c7" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0825cf89-51d5-4066-887a-4fbb6aef3a2a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0c4a96f9-134d-480d-94f1-b6946d46103e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1918d17c-cc80-4bd9-ab1c-938e45c84cda");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "48d8add8-6fee-47fc-84e8-46cb196f12b1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4f41a723-6a77-4ef9-9e52-7252a0bcc213");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "61e52dda-2bae-4595-94b9-759852da724d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9f532b5a-3c77-486d-9ec3-a7f778720f3a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a7ffb274-eee2-4cbb-8057-4939e2d8654a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cab17f51-0fb7-47f8-a100-473ec22cbd4c");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cd6a5c6e-d3bc-4745-b398-671899dd92c9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cdf7fff3-de8d-4db5-9b5f-4b4a7649736b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e4d45339-7450-4a61-86c4-3a9973d9393d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ec21568c-6037-41f5-9828-87bbbb35c17a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f7af11fa-5848-45a0-9df9-73d238912a53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6df36631-9ec9-497d-ad63-90854378898a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb1e2f85-4d44-4c7e-ba0e-dd9ef9fbaa66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ddd7f02-1d48-4c64-b0d7-ecee10396636");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f2ef681-a262-4fc5-955d-4079d69c34c7");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6df36631-9ec9-497d-ad63-90854378898a", "ebdd5034-6ae8-4dde-8089-9b3be501d61b", "SupperAdmin", "SUPPERADMIN" },
                    { "cb1e2f85-4d44-4c7e-ba0e-dd9ef9fbaa66", "fa9469c2-bc13-46ba-894c-cb28f49ffa9b", "Admin", "ADMIN" },
                    { "ea8d8bbf-038a-46e1-a442-987f83729c85", "e4b906ed-9b52-472d-9c1e-0f541c66ec35", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "3ddd7f02-1d48-4c64-b0d7-ecee10396636", 0, "System", "1ac4a83c-4605-4aa9-8fc7-0ec43036d1c6", new DateTime(2023, 11, 2, 17, 28, 58, 667, DateTimeKind.Local).AddTicks(3750), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEGCm+lmUQ+Pr1AN2LO7+7pOHdCU2AYUxA2XeODG/yB4SrbXpIzWeOoch2gFiB9zKUQ==", "+994513004484", true, null, null, "b4d371f2-a3d4-48a4-aead-31fa94ea252d", false, null, "RufatCode" },
                    { "6f2ef681-a262-4fc5-955d-4079d69c34c7", 0, "System", "1a94d65a-1343-44a1-974f-cccc4f011925", new DateTime(2023, 11, 2, 17, 28, 58, 667, DateTimeKind.Local).AddTicks(3790), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEE3wWuZ0xzqHMLcvKJQEt6o0ZWRPOayAqCu5YyJre9dPjipoJ7YjA6xue8UEka/izQ==", "+994513004484", true, null, null, "17e2b6dd-08c3-4878-89cb-52c65f5820a9", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0825cf89-51d5-4066-887a-4fbb6aef3a2a", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3910), false, "Logo", null, null, "logo.png" },
                    { "0c4a96f9-134d-480d-94f1-b6946d46103e", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3970), false, "Language1", null, null, "English" },
                    { "1918d17c-cc80-4bd9-ab1c-938e45c84cda", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3930), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "48d8add8-6fee-47fc-84e8-46cb196f12b1", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3950), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "4f41a723-6a77-4ef9-9e52-7252a0bcc213", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3940), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "61e52dda-2bae-4595-94b9-759852da724d", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3990), false, "Flag1", null, null, "1.jpg" },
                    { "9f532b5a-3c77-486d-9ec3-a7f778720f3a", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3960), false, "currency1", null, null, "USD$" },
                    { "a7ffb274-eee2-4cbb-8057-4939e2d8654a", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3920), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "cab17f51-0fb7-47f8-a100-473ec22cbd4c", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3970), false, "currency2", null, null, "EUR$" },
                    { "cd6a5c6e-d3bc-4745-b398-671899dd92c9", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3990), false, "Flag2", null, null, "2.jpg" },
                    { "cdf7fff3-de8d-4db5-9b5f-4b4a7649736b", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3930), false, "PhoneNumber", null, null, "+994513004484" },
                    { "e4d45339-7450-4a61-86c4-3a9973d9393d", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3910), false, "Hotline", null, null, "+48 500 500 500" },
                    { "ec21568c-6037-41f5-9828-87bbbb35c17a", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3950), false, "Payment", null, null, "payment.png" },
                    { "f7af11fa-5848-45a0-9df9-73d238912a53", "System", new DateTime(2023, 11, 2, 17, 28, 58, 670, DateTimeKind.Local).AddTicks(3980), false, "Language2", null, null, "Franch" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cb1e2f85-4d44-4c7e-ba0e-dd9ef9fbaa66", "3ddd7f02-1d48-4c64-b0d7-ecee10396636" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6df36631-9ec9-497d-ad63-90854378898a", "6f2ef681-a262-4fc5-955d-4079d69c34c7" });
        }
    }
}
