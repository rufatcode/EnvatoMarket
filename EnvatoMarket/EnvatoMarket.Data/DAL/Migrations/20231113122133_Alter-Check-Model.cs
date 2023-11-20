using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AlterCheckModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "633c4bb7-186b-4d8a-9500-dc8388b14db1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b996a394-8ea0-477e-84f1-581e5e4fea25", "0fc77e06-ffdf-445b-bd1d-3099a0419f99" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b9b68c1-9b17-4e5a-9c18-0e3b2dcdc9b0", "6c90522e-9c2f-46a2-a163-a2d03f3bf3e2" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "07fe2ee8-8606-4d55-b5a0-72f98073880a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "14816f54-4c62-4214-b5c1-f2b5be165bb2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "16c9eef8-9e79-4776-87f7-df0b08d06d45");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2c361242-f52c-4e4b-9e4e-f9370d4894f8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "39954f82-3b2b-4a7e-9b74-0d1b21906206");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4ee292c9-42a0-4195-a5c6-21499592e74e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "63c9ac6a-14b3-45f6-a8bf-9f43956e4725");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8aa52071-2d71-41ce-afb9-b0aa3ef272b8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9d665388-eba1-487d-9d5c-7bdb5007ddbc");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a865bed1-3e39-4d74-b906-33e8f34f00e9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "beb0ede8-fc32-456a-aead-2024b0fdb7cb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c037bdc1-33dd-4a66-8d3b-7b6ecc31c8c1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d8039701-b92b-4c4f-a6df-fe8ccdac7cac");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e14566d6-5c7c-47f8-9c69-ab327a2ddb71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b9b68c1-9b17-4e5a-9c18-0e3b2dcdc9b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b996a394-8ea0-477e-84f1-581e5e4fea25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fc77e06-ffdf-445b-bd1d-3099a0419f99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c90522e-9c2f-46a2-a163-a2d03f3bf3e2");

            migrationBuilder.AddColumn<double>(
                name: "Sale",
                table: "Checks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17388819-c5cd-44d6-b988-4ca7e919b92b", "748d7a00-f7ec-40e1-8f45-052ca65fdf8b", "User", "USER" },
                    { "46f5d017-3669-4012-8d6c-6d64625c6bcc", "de0e7e62-6102-4f41-82f9-8d0caaa727df", "Admin", "ADMIN" },
                    { "673811a5-177e-4e9a-8fd3-53e2255ab17a", "3e923c1b-85fd-4f20-956f-843ffd0c2f24", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "af7f6d25-61d8-4900-906e-1e0b90494699", 0, "System", "bc58d01e-fd05-432f-85b5-380b7199721c", new DateTime(2023, 11, 13, 16, 21, 33, 66, DateTimeKind.Local).AddTicks(7230), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEAb1a4MqCGG8c4DLCj3ZGBjKwW6le9dtzCoxoPEHcdl6KNq2b/zAX2I2vs+TtmZYYA==", "+994513004484", true, null, null, "524202eb-a92a-44b6-a63c-19f14cba48ca", false, null, "Rufat_2003" },
                    { "f63fe4d2-c61c-4b83-a984-64f35d693952", 0, "System", "f31fe3c4-5b11-4e1b-b21f-42eee3ed3823", new DateTime(2023, 11, 13, 16, 21, 33, 66, DateTimeKind.Local).AddTicks(7190), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEJCSqXRKDTcni1pOKjbUnoS8xuU1PyUZF+Bv8lvwtekeVQKyYGLExM9nDOO5ZPgQyg==", "+994513004484", true, null, null, "eb47b2dd-36da-4dd1-a398-88668767c4e1", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "06d4363f-9add-45c1-a11b-482333b9d6d1", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7650), false, "PhoneNumber", null, null, "+994513004484" },
                    { "1f96f179-2704-4f78-a65b-af5bdd4b1a8e", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7710), false, "Language2", null, null, "Franch" },
                    { "2cace45f-42a0-441f-8579-089d66e922bb", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7700), false, "Language1", null, null, "English" },
                    { "3f637bac-4dbb-489b-b441-8eec9b949aba", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7720), false, "Flag2", null, null, "2.jpg" },
                    { "45ced4fc-5c16-4f2a-9687-f081098ada6d", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7640), false, "Logo", null, null, "logo.png" },
                    { "4cdba188-3a02-4cd6-a89f-cd51a2b1c65f", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7650), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "5047694c-4b69-4ebe-a4e0-716885bcd9d7", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7690), false, "currency2", null, null, "EUR$" },
                    { "5eecd530-00ad-4cfd-8fd2-802cd4c0102d", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7690), false, "currency1", null, null, "USD$" },
                    { "6cb74620-ba45-456d-a1ea-0a7f2dbb0b30", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7710), false, "Flag1", null, null, "1.jpg" },
                    { "833f4b63-ecd0-416c-86cf-055c1f8182af", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7660), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "9a284d32-2605-4ee1-b008-c0cd74f97c9a", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7670), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "a4ccc033-1b64-4042-b652-a6341f23c0fa", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7630), false, "Hotline", null, null, "+48 500 500 500" },
                    { "ddad2e6a-1d13-4fad-af38-5440470b83b7", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7680), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "e18d26d9-da94-4c35-b8bf-e5f8bed797a8", "System", new DateTime(2023, 11, 13, 16, 21, 33, 69, DateTimeKind.Local).AddTicks(7670), false, "Payment", null, null, "payment.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "673811a5-177e-4e9a-8fd3-53e2255ab17a", "af7f6d25-61d8-4900-906e-1e0b90494699" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46f5d017-3669-4012-8d6c-6d64625c6bcc", "f63fe4d2-c61c-4b83-a984-64f35d693952" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17388819-c5cd-44d6-b988-4ca7e919b92b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "673811a5-177e-4e9a-8fd3-53e2255ab17a", "af7f6d25-61d8-4900-906e-1e0b90494699" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46f5d017-3669-4012-8d6c-6d64625c6bcc", "f63fe4d2-c61c-4b83-a984-64f35d693952" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "06d4363f-9add-45c1-a11b-482333b9d6d1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1f96f179-2704-4f78-a65b-af5bdd4b1a8e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2cace45f-42a0-441f-8579-089d66e922bb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3f637bac-4dbb-489b-b441-8eec9b949aba");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "45ced4fc-5c16-4f2a-9687-f081098ada6d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4cdba188-3a02-4cd6-a89f-cd51a2b1c65f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5047694c-4b69-4ebe-a4e0-716885bcd9d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5eecd530-00ad-4cfd-8fd2-802cd4c0102d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6cb74620-ba45-456d-a1ea-0a7f2dbb0b30");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "833f4b63-ecd0-416c-86cf-055c1f8182af");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9a284d32-2605-4ee1-b008-c0cd74f97c9a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a4ccc033-1b64-4042-b652-a6341f23c0fa");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ddad2e6a-1d13-4fad-af38-5440470b83b7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e18d26d9-da94-4c35-b8bf-e5f8bed797a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46f5d017-3669-4012-8d6c-6d64625c6bcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "673811a5-177e-4e9a-8fd3-53e2255ab17a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af7f6d25-61d8-4900-906e-1e0b90494699");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f63fe4d2-c61c-4b83-a984-64f35d693952");

            migrationBuilder.DropColumn(
                name: "Sale",
                table: "Checks");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b9b68c1-9b17-4e5a-9c18-0e3b2dcdc9b0", "b7186b44-af00-44d6-8c74-32edcced0444", "Admin", "ADMIN" },
                    { "633c4bb7-186b-4d8a-9500-dc8388b14db1", "921eba5f-a2f8-408f-a417-9449b1391779", "User", "USER" },
                    { "b996a394-8ea0-477e-84f1-581e5e4fea25", "ca73b25a-a058-475a-8577-991167bda5c3", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "0fc77e06-ffdf-445b-bd1d-3099a0419f99", 0, "System", "55fcfa37-fc22-4eee-8022-12f85472cac8", new DateTime(2023, 11, 13, 15, 55, 57, 815, DateTimeKind.Local).AddTicks(6810), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEC4F7PwlMBbhPtNHH1kQj3nknjJepu1cmZdWOqsHrTHmAGydtD1vshvcWLp8V5E5xQ==", "+994513004484", true, null, null, "5653e2f5-a5e8-4ddc-95f1-8689d82f4364", false, null, "Rufat_2003" },
                    { "6c90522e-9c2f-46a2-a163-a2d03f3bf3e2", 0, "System", "8053f6b7-6e07-4252-8c92-5ba68c238f5f", new DateTime(2023, 11, 13, 15, 55, 57, 815, DateTimeKind.Local).AddTicks(6780), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEOdejOmqN3twjMxSa1JpREsULnsj+F+VMdcvDUve0cXRw7mI5MdzWOif67RCdGFTfg==", "+994513004484", true, null, null, "185d2c6b-d056-4e33-ac5f-946afff6b624", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "07fe2ee8-8606-4d55-b5a0-72f98073880a", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7990), false, "currency1", null, null, "USD$" },
                    { "14816f54-4c62-4214-b5c1-f2b5be165bb2", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(8020), false, "Flag2", null, null, "2.jpg" },
                    { "16c9eef8-9e79-4776-87f7-df0b08d06d45", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7990), false, "currency2", null, null, "EUR$" },
                    { "2c361242-f52c-4e4b-9e4e-f9370d4894f8", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7970), false, "Payment", null, null, "payment.png" },
                    { "39954f82-3b2b-4a7e-9b74-0d1b21906206", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7950), false, "PhoneNumber", null, null, "+994513004484" },
                    { "4ee292c9-42a0-4195-a5c6-21499592e74e", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7960), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "63c9ac6a-14b3-45f6-a8bf-9f43956e4725", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(8010), false, "Flag1", null, null, "1.jpg" },
                    { "8aa52071-2d71-41ce-afb9-b0aa3ef272b8", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7930), false, "Hotline", null, null, "+48 500 500 500" },
                    { "9d665388-eba1-487d-9d5c-7bdb5007ddbc", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(8000), false, "Language1", null, null, "English" },
                    { "a865bed1-3e39-4d74-b906-33e8f34f00e9", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7970), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "beb0ede8-fc32-456a-aead-2024b0fdb7cb", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7940), false, "Logo", null, null, "logo.png" },
                    { "c037bdc1-33dd-4a66-8d3b-7b6ecc31c8c1", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7950), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "d8039701-b92b-4c4f-a6df-fe8ccdac7cac", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(8010), false, "Language2", null, null, "Franch" },
                    { "e14566d6-5c7c-47f8-9c69-ab327a2ddb71", "System", new DateTime(2023, 11, 13, 15, 55, 57, 818, DateTimeKind.Local).AddTicks(7980), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b996a394-8ea0-477e-84f1-581e5e4fea25", "0fc77e06-ffdf-445b-bd1d-3099a0419f99" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b9b68c1-9b17-4e5a-9c18-0e3b2dcdc9b0", "6c90522e-9c2f-46a2-a163-a2d03f3bf3e2" });
        }
    }
}
