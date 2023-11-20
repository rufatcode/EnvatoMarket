using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class ChatImagesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03ce06c2-ef21-43dd-bfd6-1eb599de4c25");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d57c9a0f-aa54-457c-84c3-05a090daba9f", "93492ab7-dcc1-4ed1-8585-665919ef844c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "488b0ef8-a92c-481c-bb1c-ff75917bc9d7", "bbb8879f-975e-4ac4-9382-e7f50bd5adba" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "05eb06a7-1c55-40b3-b1fa-0a0b3b6c16f2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "08785909-6356-41c3-8881-19f71129df2f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1b875abc-c6ac-43bc-b366-f81dfb124d85");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "30812d0d-097a-4727-879a-048c3ce0548b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "63563ede-43cb-4212-8ccf-8576d070dd65");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7d41b614-63cf-46d6-b28d-85704d5d225d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7fb7c443-7efa-40ea-8a1f-1136fabfd3eb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8c3934c4-cbf7-425e-b1d1-c66beea1b4f7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9570314f-2c2d-4551-9172-faab4c6bcc52");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9610e4c0-2680-40a3-9794-1a53396041ad");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a7fde5cd-753f-43c9-863a-2af1a8fc9b7a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "bf03ea25-5914-43f6-86ed-620cb96f0302");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ca722abf-768d-43e9-8a73-de26a3cf4202");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ebc04493-5de0-4dbe-bb3e-dbf0dec05101");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "488b0ef8-a92c-481c-bb1c-ff75917bc9d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57c9a0f-aa54-457c-84c3-05a090daba9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93492ab7-dcc1-4ed1-8585-665919ef844c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbb8879f-975e-4ac4-9382-e7f50bd5adba");

            migrationBuilder.AddColumn<bool>(
                name: "IsSeen",
                table: "ChatMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ChatImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatImages_AspNetUsers_FromUserId",
                        column: x => x.FromUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatImages_AspNetUsers_ToUserId",
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
                    { "2ab32d03-2875-4341-bd40-da89cb198665", "5ec48e0a-4ba3-4e30-8f21-989011a1fe66", "SupperAdmin", "SUPPERADMIN" },
                    { "4d697c33-6610-4d01-a0bb-b9d50d4ef3d5", "4e12057e-21cc-437d-851d-59da1cb58fe3", "Admin", "ADMIN" },
                    { "ab035f8a-b9ff-4730-8a18-e481b95ca5c5", "b90cc25f-4ed5-42b9-bddc-6953e6316c57", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "ConnectionId", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName", "isOnline" },
                values: new object[,]
                {
                    { "29b036fd-74c0-4c79-b0ec-6a7106a6cdee", 0, "System", "4c4bf910-ad9a-43f1-a3dc-152a534d5cc5", null, new DateTime(2023, 11, 20, 7, 32, 41, 987, DateTimeKind.Local).AddTicks(2620), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAELn/DO81+a6GghiETftWq1S6UkyHZ+s3HZmDufXuxpG3zOhP2oD/734vU2CtQTTwwQ==", "+994513004484", true, null, null, "eefbbf3a-1ea3-44dc-85e4-14a2acfcae20", false, null, "Rufat_2003", false },
                    { "b502ef52-5da1-4f6b-865e-18b3cdfd7c2d", 0, "System", "6d6294f4-1da3-462b-a13e-feea71f4e529", null, new DateTime(2023, 11, 20, 7, 32, 41, 987, DateTimeKind.Local).AddTicks(2550), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEI9lP5MFRVh9MxWgWfOFrIKyVtNjdPvTUDKL4Crjz2Pq7yDM5zluN/AQXtAELwY3Pw==", "+994513004484", true, null, null, "05546593-91b5-46bf-ae41-1a179fd284fe", false, null, "RufatCode", false }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "20c0f735-11d3-4531-ae31-15307b091fc8", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3110), false, "currency1", null, null, "USD$" },
                    { "2a8dc527-c084-476c-879c-929c8ee68377", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3120), false, "Language1", null, null, "English" },
                    { "2fa567cb-061e-45a1-91e0-73d996be6a2a", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3090), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "352f5019-5aaa-4e05-8852-51b2a27bcc1a", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3070), false, "PhoneNumber", null, null, "+994513004484" },
                    { "4f56fedc-c382-40a7-a2f2-b975d461e9bf", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3100), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "620047f6-05ab-48d4-9ea9-f461754ec0dd", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3140), false, "Flag2", null, null, "2.jpg" },
                    { "7bbc3266-98fe-420f-83ef-f4b3ad76ecc2", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3050), false, "Logo", null, null, "logo.png" },
                    { "7dd7f08a-b212-4b9d-8e7b-18a68d9c804e", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3080), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "8e269fbb-207a-44c8-a014-6f1bbad20e0d", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3060), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "97650287-e92c-4722-ac3c-9c9e2114f437", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3120), false, "Language2", null, null, "Franch" },
                    { "aebd1670-7f66-4bad-9539-f374e1ffcf8c", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3050), false, "Hotline", null, null, "+48 500 500 500" },
                    { "cfcfe65e-a6df-4530-a0e9-24ae1e0c9fde", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3110), false, "currency2", null, null, "EUR$" },
                    { "dc961d3c-c2ba-4985-ae04-089b0a10caab", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3090), false, "Payment", null, null, "payment.png" },
                    { "e17806b6-01fd-4fbc-9b43-745676efa5b0", "System", new DateTime(2023, 11, 20, 7, 32, 41, 990, DateTimeKind.Local).AddTicks(3130), false, "Flag1", null, null, "1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ab32d03-2875-4341-bd40-da89cb198665", "29b036fd-74c0-4c79-b0ec-6a7106a6cdee" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d697c33-6610-4d01-a0bb-b9d50d4ef3d5", "b502ef52-5da1-4f6b-865e-18b3cdfd7c2d" });

            migrationBuilder.CreateIndex(
                name: "IX_ChatImages_FromUserId",
                table: "ChatImages",
                column: "FromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatImages_ToUserId",
                table: "ChatImages",
                column: "ToUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatImages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab035f8a-b9ff-4730-8a18-e481b95ca5c5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ab32d03-2875-4341-bd40-da89cb198665", "29b036fd-74c0-4c79-b0ec-6a7106a6cdee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d697c33-6610-4d01-a0bb-b9d50d4ef3d5", "b502ef52-5da1-4f6b-865e-18b3cdfd7c2d" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "20c0f735-11d3-4531-ae31-15307b091fc8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2a8dc527-c084-476c-879c-929c8ee68377");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2fa567cb-061e-45a1-91e0-73d996be6a2a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "352f5019-5aaa-4e05-8852-51b2a27bcc1a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4f56fedc-c382-40a7-a2f2-b975d461e9bf");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "620047f6-05ab-48d4-9ea9-f461754ec0dd");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7bbc3266-98fe-420f-83ef-f4b3ad76ecc2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7dd7f08a-b212-4b9d-8e7b-18a68d9c804e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8e269fbb-207a-44c8-a014-6f1bbad20e0d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "97650287-e92c-4722-ac3c-9c9e2114f437");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "aebd1670-7f66-4bad-9539-f374e1ffcf8c");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cfcfe65e-a6df-4530-a0e9-24ae1e0c9fde");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "dc961d3c-c2ba-4985-ae04-089b0a10caab");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e17806b6-01fd-4fbc-9b43-745676efa5b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ab32d03-2875-4341-bd40-da89cb198665");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d697c33-6610-4d01-a0bb-b9d50d4ef3d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29b036fd-74c0-4c79-b0ec-6a7106a6cdee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b502ef52-5da1-4f6b-865e-18b3cdfd7c2d");

            migrationBuilder.DropColumn(
                name: "IsSeen",
                table: "ChatMessages");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03ce06c2-ef21-43dd-bfd6-1eb599de4c25", "a2b8af46-efaa-48e1-baef-461d03cb8cbc", "User", "USER" },
                    { "488b0ef8-a92c-481c-bb1c-ff75917bc9d7", "730deba8-8642-4239-8e7c-5ceac34b05b1", "Admin", "ADMIN" },
                    { "d57c9a0f-aa54-457c-84c3-05a090daba9f", "134e8da0-bd50-4900-9e13-21df71e4dd80", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "ConnectionId", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName", "isOnline" },
                values: new object[,]
                {
                    { "93492ab7-dcc1-4ed1-8585-665919ef844c", 0, "System", "7e894702-e3aa-4885-ab5c-4414cbdc493d", null, new DateTime(2023, 11, 16, 12, 18, 52, 885, DateTimeKind.Local).AddTicks(6850), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEBbOnD3osRrQIVXmEPFGemSzVO4viYtB7igPV//SjB1HLmdjFPBt6zIp7NrTOgB5Og==", "+994513004484", true, null, null, "9c10c1af-a07b-40e8-88ff-b8098229ea94", false, null, "Rufat_2003", false },
                    { "bbb8879f-975e-4ac4-9382-e7f50bd5adba", 0, "System", "3e4b286c-60b6-4422-a943-5779ece14d40", null, new DateTime(2023, 11, 16, 12, 18, 52, 885, DateTimeKind.Local).AddTicks(6810), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEG93Wc0KA3sXgpHzRRZaGzrKqmFHOuocy4n5sEpgwFuW5YJPY3/4el+lOKD5UVUMRw==", "+994513004484", true, null, null, "ad96376f-fe8a-4a65-9bc0-6dbc51436585", false, null, "RufatCode", false }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "05eb06a7-1c55-40b3-b1fa-0a0b3b6c16f2", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7010), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "08785909-6356-41c3-8881-19f71129df2f", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7040), false, "Language2", null, null, "Franch" },
                    { "1b875abc-c6ac-43bc-b366-f81dfb124d85", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(6970), false, "Logo", null, null, "logo.png" },
                    { "30812d0d-097a-4727-879a-048c3ce0548b", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7020), false, "currency1", null, null, "USD$" },
                    { "63563ede-43cb-4212-8ccf-8576d070dd65", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7040), false, "Flag1", null, null, "1.jpg" },
                    { "7d41b614-63cf-46d6-b28d-85704d5d225d", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7030), false, "Language1", null, null, "English" },
                    { "7fb7c443-7efa-40ea-8a1f-1136fabfd3eb", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7010), false, "Payment", null, null, "payment.png" },
                    { "8c3934c4-cbf7-425e-b1d1-c66beea1b4f7", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7050), false, "Flag2", null, null, "2.jpg" },
                    { "9570314f-2c2d-4551-9172-faab4c6bcc52", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(6990), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "9610e4c0-2680-40a3-9794-1a53396041ad", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(6960), false, "Hotline", null, null, "+48 500 500 500" },
                    { "a7fde5cd-753f-43c9-863a-2af1a8fc9b7a", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7030), false, "currency2", null, null, "EUR$" },
                    { "bf03ea25-5914-43f6-86ed-620cb96f0302", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(6980), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "ca722abf-768d-43e9-8a73-de26a3cf4202", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(7000), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "ebc04493-5de0-4dbe-bb3e-dbf0dec05101", "System", new DateTime(2023, 11, 16, 12, 18, 52, 888, DateTimeKind.Local).AddTicks(6990), false, "PhoneNumber", null, null, "+994513004484" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d57c9a0f-aa54-457c-84c3-05a090daba9f", "93492ab7-dcc1-4ed1-8585-665919ef844c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "488b0ef8-a92c-481c-bb1c-ff75917bc9d7", "bbb8879f-975e-4ac4-9382-e7f50bd5adba" });
        }
    }
}
