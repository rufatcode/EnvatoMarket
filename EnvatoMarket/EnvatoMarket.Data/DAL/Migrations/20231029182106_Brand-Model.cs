using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class BrandModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76dc2131-d62f-413e-86af-c3152df266fc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd6a8e3f-e7e2-4df0-b522-e7c868e08c01", "878dea67-4254-4c58-a823-9e583e9bedd4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eea8dd39-821f-4093-b2c5-1542f4831ec7", "abc9c90e-36f0-479d-be54-9117bc768767" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "561551e2-a600-4fa6-92c2-f6c3fea9f21c");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "61a2a6c4-866f-4fbd-8c94-f8c6fdc103d1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "84ddf5a5-208d-4a6f-a292-e16e0ed1773a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "934225c5-8168-4820-8534-c064e94f9b0b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9bcdd4fb-2798-49f6-bdd1-496dabba3edf");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c8ece87f-4f17-499e-aa36-ca4a28565d6a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ce240b2a-8d72-4eec-99f9-688642850310");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "da4a2083-9d2c-4751-afd0-4b85ffcb6fd3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "da4f6830-bc5c-4391-88cc-92d2454be950");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "dcc14104-c311-47e3-b37a-7dcb5b43f208");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "dd0e34d4-b02b-4c62-bca7-f244cb4d7be1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e01cd7e8-de26-46c8-9c9e-c4930167ffa7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e23cdaa5-96fc-464e-9dc2-dad077c5feb8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f9bc47b5-9577-4e1c-8cab-2e4df65f1b7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd6a8e3f-e7e2-4df0-b522-e7c868e08c01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eea8dd39-821f-4093-b2c5-1542f4831ec7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "878dea67-4254-4c58-a823-9e583e9bedd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc9c90e-36f0-479d-be54-9117bc768767");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "164531b1-33b2-4bc6-ac6c-0162fd0857f3", "55b624bc-ad79-4992-8d4e-2985c2a2e4fc", "SupperAdmin", "SUPPERADMIN" },
                    { "668450d2-8ff1-43f5-960c-e4d71cef0ee6", "df444149-fb94-44b5-9a31-edb09aaa5e5d", "Admin", "ADMIN" },
                    { "ef3a580f-890a-4580-89ea-49971fffdfc1", "57eb6935-bf47-4535-b1fd-b46ad55eca9b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "339fbb10-bc40-4b99-ae98-1381aefb2d48", 0, "System", "a3bd77ab-525e-4bce-a67a-b73b86e23671", new DateTime(2023, 10, 29, 22, 21, 6, 200, DateTimeKind.Local).AddTicks(330), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAENmrYAzWMVqYbtKpK0lQVbId1MgtSRKh+Kz/roLHnKKVjM9nTL4utF3GRmlG3kUvXA==", "+994513004484", true, null, null, "8ca8a39d-eb81-4daf-b705-974bb9e478c3", false, null, "Rufat_2003" },
                    { "5dca4cf2-1ff8-48ea-bc16-22de7075aab0", 0, "System", "3d9e749e-cc0e-4ddd-a830-ac1bcd347b55", new DateTime(2023, 10, 29, 22, 21, 6, 200, DateTimeKind.Local).AddTicks(290), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEAaV/V98OKasEGGYsCAs94TKBXFZZanv6PWV8svqvnzBIuSPO7rYZCm9us1payJ6CQ==", "+994513004484", true, null, null, "0b28da98-e0e4-4954-bd8c-3973641cd62f", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "2205e56f-1bfa-4e54-9379-fbe62624bb77", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(550), false, "currency1", null, null, "USD$" },
                    { "300b9ccc-fffb-44f2-b86d-d149bf830fa2", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(470), false, "PhoneNumber", null, null, "+994513004484" },
                    { "3da312c2-9f00-444c-92c3-84b75232c5c7", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(490), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "51982451-7adc-4dcf-a16e-07f7550cb79a", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(500), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "558616a1-2e4f-4954-b8d9-533f60c1ef49", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(570), false, "Language2", null, null, "Franch" },
                    { "58400cf5-1a76-4cde-9831-8c60ffe78eac", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(480), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "5bc7cd32-b9a9-47e6-abbb-c14c623427ca", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(570), false, "Flag1", null, null, "1.jpg" },
                    { "60649775-ac7e-406c-8b17-abf865ceb542", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(470), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "a9c9e1b8-72b9-4538-9e13-9f87ca76a755", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(490), false, "Payment", null, null, "payment.png" },
                    { "ac1b54e9-e608-464d-ada1-fca25c4a8d3b", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(580), false, "Flag2", null, null, "2.jpg" },
                    { "c5c386d3-a1d6-47c4-a45c-7d410bdd89be", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(450), false, "Hotline", null, null, "+48 500 500 500" },
                    { "c6667c45-05c8-41da-9f38-97893e926c67", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(560), false, "currency2", null, null, "EUR$" },
                    { "ccba8eda-9575-4322-94a2-94dd1c362f5e", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(560), false, "Language1", null, null, "English" },
                    { "e120adc9-ce46-4a9e-ab7a-d78af0bd30cd", "System", new DateTime(2023, 10, 29, 22, 21, 6, 203, DateTimeKind.Local).AddTicks(460), false, "Logo", null, null, "logo.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "164531b1-33b2-4bc6-ac6c-0162fd0857f3", "339fbb10-bc40-4b99-ae98-1381aefb2d48" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "668450d2-8ff1-43f5-960c-e4d71cef0ee6", "5dca4cf2-1ff8-48ea-bc16-22de7075aab0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef3a580f-890a-4580-89ea-49971fffdfc1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "164531b1-33b2-4bc6-ac6c-0162fd0857f3", "339fbb10-bc40-4b99-ae98-1381aefb2d48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "668450d2-8ff1-43f5-960c-e4d71cef0ee6", "5dca4cf2-1ff8-48ea-bc16-22de7075aab0" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2205e56f-1bfa-4e54-9379-fbe62624bb77");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "300b9ccc-fffb-44f2-b86d-d149bf830fa2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3da312c2-9f00-444c-92c3-84b75232c5c7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "51982451-7adc-4dcf-a16e-07f7550cb79a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "558616a1-2e4f-4954-b8d9-533f60c1ef49");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "58400cf5-1a76-4cde-9831-8c60ffe78eac");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5bc7cd32-b9a9-47e6-abbb-c14c623427ca");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "60649775-ac7e-406c-8b17-abf865ceb542");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a9c9e1b8-72b9-4538-9e13-9f87ca76a755");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ac1b54e9-e608-464d-ada1-fca25c4a8d3b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c5c386d3-a1d6-47c4-a45c-7d410bdd89be");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c6667c45-05c8-41da-9f38-97893e926c67");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ccba8eda-9575-4322-94a2-94dd1c362f5e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e120adc9-ce46-4a9e-ab7a-d78af0bd30cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "164531b1-33b2-4bc6-ac6c-0162fd0857f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "668450d2-8ff1-43f5-960c-e4d71cef0ee6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "339fbb10-bc40-4b99-ae98-1381aefb2d48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dca4cf2-1ff8-48ea-bc16-22de7075aab0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76dc2131-d62f-413e-86af-c3152df266fc", "96d15778-fbd2-49f2-bf6c-9c475f8a2dac", "User", "USER" },
                    { "bd6a8e3f-e7e2-4df0-b522-e7c868e08c01", "b45354a3-5506-4c57-92a3-49b59c11ba8c", "Admin", "ADMIN" },
                    { "eea8dd39-821f-4093-b2c5-1542f4831ec7", "26ccc0ad-237a-4c55-9faf-be92f3343689", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "878dea67-4254-4c58-a823-9e583e9bedd4", 0, "System", "e64290a6-a763-43a8-92cd-43a42f47cf1f", new DateTime(2023, 10, 29, 7, 35, 47, 481, DateTimeKind.Local).AddTicks(6280), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEPGp2ZXCp+lbty2VzjSf+fS4UdO4UiYD8jjok+Z1gkvT6L2ceFg1QYXC36d3mjEOsA==", "+994513004484", true, null, null, "499698b9-c820-47b5-80f9-2a0ea4e59f98", false, null, "RufatCode" },
                    { "abc9c90e-36f0-479d-be54-9117bc768767", 0, "System", "9d73a20d-d75c-4828-9ce0-5ad29ac7e6f8", new DateTime(2023, 10, 29, 7, 35, 47, 481, DateTimeKind.Local).AddTicks(6310), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEPvys9riZo8KVFtY2WBfkA+ff2iPFm4wnhuQTvDD+5QIc2CdZ2ia3KjjN/uCcy5NrQ==", "+994513004484", true, null, null, "c1af5d00-ac0e-4dc2-8ab9-836d92153349", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "561551e2-a600-4fa6-92c2-f6c3fea9f21c", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6390), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "61a2a6c4-866f-4fbd-8c94-f8c6fdc103d1", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6440), false, "Language2", null, null, "Franch" },
                    { "84ddf5a5-208d-4a6f-a292-e16e0ed1773a", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6350), false, "Hotline", null, null, "+48 500 500 500" },
                    { "934225c5-8168-4820-8534-c064e94f9b0b", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6390), false, "Payment", null, null, "payment.png" },
                    { "9bcdd4fb-2798-49f6-bdd1-496dabba3edf", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6420), false, "Language1", null, null, "English" },
                    { "c8ece87f-4f17-499e-aa36-ca4a28565d6a", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6400), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "ce240b2a-8d72-4eec-99f9-688642850310", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6400), false, "currency1", null, null, "USD$" },
                    { "da4a2083-9d2c-4751-afd0-4b85ffcb6fd3", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6410), false, "currency2", null, null, "EUR$" },
                    { "da4f6830-bc5c-4391-88cc-92d2454be950", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6370), false, "PhoneNumber", null, null, "+994513004484" },
                    { "dcc14104-c311-47e3-b37a-7dcb5b43f208", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6450), false, "Flag1", null, null, "1.jpg" },
                    { "dd0e34d4-b02b-4c62-bca7-f244cb4d7be1", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6380), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "e01cd7e8-de26-46c8-9c9e-c4930167ffa7", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6370), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "e23cdaa5-96fc-464e-9dc2-dad077c5feb8", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6360), false, "Logo", null, null, "logo.png" },
                    { "f9bc47b5-9577-4e1c-8cab-2e4df65f1b7c", "System", new DateTime(2023, 10, 29, 7, 35, 47, 484, DateTimeKind.Local).AddTicks(6460), false, "Flag2", null, null, "2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd6a8e3f-e7e2-4df0-b522-e7c868e08c01", "878dea67-4254-4c58-a823-9e583e9bedd4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "eea8dd39-821f-4093-b2c5-1542f4831ec7", "abc9c90e-36f0-479d-be54-9117bc768767" });
        }
    }
}
