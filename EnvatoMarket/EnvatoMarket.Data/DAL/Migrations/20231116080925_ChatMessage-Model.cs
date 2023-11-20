using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class ChatMessageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatMessages_AspNetUsers_FromUserId",
                        column: x => x.FromUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatMessages_AspNetUsers_ToUserId",
                        column: x => x.ToUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a6c41d97-4014-4462-96b8-333136cd21fe", "9ef2e396-aeb8-45fa-8fc0-3b0f614ee2f5", "Admin", "ADMIN" },
                    { "b033ffd7-92d3-4d6b-83ae-aae7dfd10466", "b4d659cf-fa7a-4679-8f7e-fe4ba859159d", "SupperAdmin", "SUPPERADMIN" },
                    { "eee91966-33a6-4660-ac6a-58a3e23d7500", "8d51ab21-f13f-413c-a394-a16b99058bfb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "438e22f4-1cb9-4466-b64d-2fb2c858c21f", 0, "System", "9d2432d1-4b24-4fa5-b8bd-7085de47e900", new DateTime(2023, 11, 16, 12, 9, 25, 673, DateTimeKind.Local).AddTicks(3650), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEK/cswjky0YdhjJxnde0xQaCZoTDWs8Tz+68gT+RS6WSywakr1J+0QqbbtDWRP7D0Q==", "+994513004484", true, null, null, "f38f2486-ce65-4781-9801-091b8e19f450", false, null, "Rufat_2003" },
                    { "f823f9b6-eb72-4ed5-9e24-887a51145924", 0, "System", "f1d8d712-b010-44ef-927c-5b629cc49ee4", new DateTime(2023, 11, 16, 12, 9, 25, 673, DateTimeKind.Local).AddTicks(3590), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEAqt1HxsImB3I/JFa1KAKD0VyNijRvFuiy/TDoMUpma3xK5to3UFbNiydWMIk+TSzA==", "+994513004484", true, null, null, "f0cbbfc2-e67e-4aa1-9093-a944ed7f24a6", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "1a6cda90-b895-43fe-8e22-64df774c4c2b", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3830), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "1b1374d9-3950-4369-b944-42b71704e471", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3830), false, "PhoneNumber", null, null, "+994513004484" },
                    { "3637aa8e-bd6e-4da3-8f85-348923104f80", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3850), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "3bdd1a3e-3295-436c-b6f6-532c039dff3a", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3850), false, "Payment", null, null, "payment.png" },
                    { "4820e8c3-6a50-47c6-9acd-3f08b3d3dd7f", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3820), false, "Logo", null, null, "logo.png" },
                    { "8c963d86-0628-410d-975c-347f19aea895", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3810), false, "Hotline", null, null, "+48 500 500 500" },
                    { "9374ca1e-dfd7-43e3-a9a1-ac79dd2f1357", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3860), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "9ca10217-56a8-4c14-888e-4292419de1b6", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3840), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "b0813cab-5cce-44d9-9b71-cb61f21fadf6", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3880), false, "Language1", null, null, "English" },
                    { "b1f01e1c-483a-4b35-b74d-3e9a1143a827", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3890), false, "Flag1", null, null, "1.jpg" },
                    { "c4bca35a-5873-4ced-bb89-1f01f834f9e9", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3900), false, "Flag2", null, null, "2.jpg" },
                    { "d8b71c47-5bf3-4ea2-a836-bf262e5fd3b2", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3870), false, "currency2", null, null, "EUR$" },
                    { "e3754d5d-944f-43b8-b71d-e99006af1b06", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3890), false, "Language2", null, null, "Franch" },
                    { "f81f4510-7a87-463e-aaba-74900fa07499", "System", new DateTime(2023, 11, 16, 12, 9, 25, 676, DateTimeKind.Local).AddTicks(3870), false, "currency1", null, null, "USD$" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b033ffd7-92d3-4d6b-83ae-aae7dfd10466", "438e22f4-1cb9-4466-b64d-2fb2c858c21f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6c41d97-4014-4462-96b8-333136cd21fe", "f823f9b6-eb72-4ed5-9e24-887a51145924" });

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_FromUserId",
                table: "ChatMessages",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatMessages_ToUserId",
                table: "ChatMessages",
                column: "ToUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatMessages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eee91966-33a6-4660-ac6a-58a3e23d7500");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b033ffd7-92d3-4d6b-83ae-aae7dfd10466", "438e22f4-1cb9-4466-b64d-2fb2c858c21f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6c41d97-4014-4462-96b8-333136cd21fe", "f823f9b6-eb72-4ed5-9e24-887a51145924" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1a6cda90-b895-43fe-8e22-64df774c4c2b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1b1374d9-3950-4369-b944-42b71704e471");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3637aa8e-bd6e-4da3-8f85-348923104f80");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3bdd1a3e-3295-436c-b6f6-532c039dff3a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4820e8c3-6a50-47c6-9acd-3f08b3d3dd7f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8c963d86-0628-410d-975c-347f19aea895");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9374ca1e-dfd7-43e3-a9a1-ac79dd2f1357");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9ca10217-56a8-4c14-888e-4292419de1b6");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b0813cab-5cce-44d9-9b71-cb61f21fadf6");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b1f01e1c-483a-4b35-b74d-3e9a1143a827");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c4bca35a-5873-4ced-bb89-1f01f834f9e9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d8b71c47-5bf3-4ea2-a836-bf262e5fd3b2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e3754d5d-944f-43b8-b71d-e99006af1b06");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f81f4510-7a87-463e-aaba-74900fa07499");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6c41d97-4014-4462-96b8-333136cd21fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b033ffd7-92d3-4d6b-83ae-aae7dfd10466");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "438e22f4-1cb9-4466-b64d-2fb2c858c21f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f823f9b6-eb72-4ed5-9e24-887a51145924");

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
    }
}
