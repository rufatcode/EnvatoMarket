using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AlterAppUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ConnectionId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isOnline",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ConnectionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isOnline",
                table: "AspNetUsers");

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
        }
    }
}
