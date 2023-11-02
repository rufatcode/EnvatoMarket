using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AlterCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa3ca08f-4093-42e4-a7b5-f5a45ab7a071");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "236ad124-4df7-411b-8956-e4ad0346fa6d", "4d84c2a7-09bb-4eeb-869a-493cbc9609de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e1bdb35-2f93-41d4-8e76-3fa2e4367016", "ea8cf0c6-3c95-4139-9dce-46cd8f78c169" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "05fa0b50-c1e0-46a6-9356-ecba86696fc0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "10deeda9-2ed5-4eb7-b607-c21f001ae063");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "146c8b18-7069-4bbc-8f7a-52ea6eb162ff");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1898eda1-8250-4e51-95c8-4abbb3fa01fa");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1d288eb3-1de8-4348-81e3-3e9784d01af2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "22811f5b-00f2-4439-9f16-e0dc982902e8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "235937cd-4285-4e5f-ad97-22b7e41905d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "23709a95-017d-4281-ac1e-a9fa83690f0a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "32b5889a-5c93-41e4-b78b-b25b3e435156");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5947c2dc-76dc-472a-b6c7-0517cbbcf6bb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5a90dd89-4e95-48e1-8b56-3a39ed44ddf4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6b2e4fb2-afe5-4248-a273-f6fdaf2fda82");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f3744af7-858f-4fed-b57e-8f361fef588a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f4c3b18e-d912-4ebb-838e-27d2a38dac54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "236ad124-4df7-411b-8956-e4ad0346fa6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e1bdb35-2f93-41d4-8e76-3fa2e4367016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d84c2a7-09bb-4eeb-869a-493cbc9609de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea8cf0c6-3c95-4139-9dce-46cd8f78c169");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "236ad124-4df7-411b-8956-e4ad0346fa6d", "e578f00f-7946-4080-a5f5-d465793b8a90", "Admin", "ADMIN" },
                    { "9e1bdb35-2f93-41d4-8e76-3fa2e4367016", "d9bbe75e-e351-433f-8a6e-72ac162e59a9", "SupperAdmin", "SUPPERADMIN" },
                    { "aa3ca08f-4093-42e4-a7b5-f5a45ab7a071", "762a6518-3e4d-4c5a-a68d-7354c7a0da22", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "4d84c2a7-09bb-4eeb-869a-493cbc9609de", 0, "System", "9d60d9fd-b9d8-475c-a4a4-73a75d776dc4", new DateTime(2023, 11, 2, 17, 14, 46, 750, DateTimeKind.Local).AddTicks(9230), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEAfw3B3zVyr9BREUlEjtc5g1axOGRUP/C6FsrBtNk740oDkTwXDUJyBjFtOs12fomw==", "+994513004484", true, null, null, "0e3f7a31-99f3-407c-936f-b1c1613adeb4", false, null, "RufatCode" },
                    { "ea8cf0c6-3c95-4139-9dce-46cd8f78c169", 0, "System", "06ed1aa8-4fd6-4c93-ad88-30021fa1e81b", new DateTime(2023, 11, 2, 17, 14, 46, 750, DateTimeKind.Local).AddTicks(9260), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEMfdn5sy5lyjS1oooZRLPez+jtnbbjUkfwTRL/9OwLruZr+AZZ8JLTwU0xty6Q1e3Q==", "+994513004484", true, null, null, "8b9bbd5e-0edf-4481-8394-a5f8abc9a39f", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "05fa0b50-c1e0-46a6-9356-ecba86696fc0", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9010), false, "Hotline", null, null, "+48 500 500 500" },
                    { "10deeda9-2ed5-4eb7-b607-c21f001ae063", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9090), false, "Flag1", null, null, "1.jpg" },
                    { "146c8b18-7069-4bbc-8f7a-52ea6eb162ff", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9040), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "1898eda1-8250-4e51-95c8-4abbb3fa01fa", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9030), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "1d288eb3-1de8-4348-81e3-3e9784d01af2", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9090), false, "Flag2", null, null, "2.jpg" },
                    { "22811f5b-00f2-4439-9f16-e0dc982902e8", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9070), false, "Language1", null, null, "English" },
                    { "235937cd-4285-4e5f-ad97-22b7e41905d7", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9020), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "23709a95-017d-4281-ac1e-a9fa83690f0a", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9030), false, "PhoneNumber", null, null, "+994513004484" },
                    { "32b5889a-5c93-41e4-b78b-b25b3e435156", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9050), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "5947c2dc-76dc-472a-b6c7-0517cbbcf6bb", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9020), false, "Logo", null, null, "logo.png" },
                    { "5a90dd89-4e95-48e1-8b56-3a39ed44ddf4", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9050), false, "Payment", null, null, "payment.png" },
                    { "6b2e4fb2-afe5-4248-a273-f6fdaf2fda82", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9070), false, "currency2", null, null, "EUR$" },
                    { "f3744af7-858f-4fed-b57e-8f361fef588a", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9060), false, "currency1", null, null, "USD$" },
                    { "f4c3b18e-d912-4ebb-838e-27d2a38dac54", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9080), false, "Language2", null, null, "Franch" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "236ad124-4df7-411b-8956-e4ad0346fa6d", "4d84c2a7-09bb-4eeb-869a-493cbc9609de" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e1bdb35-2f93-41d4-8e76-3fa2e4367016", "ea8cf0c6-3c95-4139-9dce-46cd8f78c169" });
        }
    }
}
