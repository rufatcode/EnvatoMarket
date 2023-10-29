using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class TagModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "595ef103-20b1-4f79-9b90-b3300fdd027b", "e54b7719-45cd-4f77-8b7c-eb16af56a87c", "User", "USER" },
                    { "a6cc39f3-2570-4a36-ba6d-dec9545e6dcc", "a1849043-356d-4295-a612-c86f5b2aed1f", "SupperAdmin", "SUPPERADMIN" },
                    { "c065ab54-f5d1-455e-b84e-7f60dddd7244", "1bc4ac0a-39aa-42c0-a385-d8aafd539f55", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "1c825c52-5160-4ed0-ac8d-fdc66442bcf9", 0, "System", "7c7fc387-9807-486f-b920-908161de362b", new DateTime(2023, 10, 29, 22, 50, 51, 602, DateTimeKind.Local).AddTicks(1760), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEPObLT1s1w2K5ujH4UJ6oB7SmNrXXS0U+4QaBxASwlSTn17g8J/ezLhkEFJ5dAk9uw==", "+994513004484", true, null, null, "cfc72483-b5bf-471a-9e69-7a420fc4ea44", false, null, "Rufat_2003" },
                    { "a3057c88-1519-4b31-9ce0-af6fdb68c106", 0, "System", "4c9cf4a6-0316-490b-aa77-9f7d5ef2a826", new DateTime(2023, 10, 29, 22, 50, 51, 602, DateTimeKind.Local).AddTicks(1710), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEJ3AEbc4I8wFoQ18sCm6xc4I4o/Q0UPTLFN2qPexjn5zkK6wAreQTgmJvuoykWLoaQ==", "+994513004484", true, null, null, "a8193ec0-b4c4-4b09-a71d-bcf30ff413d9", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "13e8541c-9b31-4f57-8857-0615ceedeef2", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2010), false, "Hotline", null, null, "+48 500 500 500" },
                    { "1523e27d-2517-4d50-87d5-809e04ff96cf", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2040), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "2696346a-2e2f-4a1f-9565-6c4e274808d7", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2080), false, "Language2", null, null, "Franch" },
                    { "420982ff-a717-4bd4-b294-1875f996d392", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2060), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "541cd79a-54f6-4df6-8a3a-dd782b45ed97", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2040), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "80c4f897-bce0-41b9-a225-5f342b2cad24", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2090), false, "Flag1", null, null, "1.jpg" },
                    { "9903d949-9222-4fab-9e48-e307132310b7", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2020), false, "Logo", null, null, "logo.png" },
                    { "cc983aa4-298b-42f6-8ae2-4df518ec994a", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2070), false, "currency1", null, null, "USD$" },
                    { "cf4c5e83-5cc9-470e-9342-828048ce00a8", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2030), false, "PhoneNumber", null, null, "+994513004484" },
                    { "d2783400-b7c4-4bc0-86a4-43a577f3fea6", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2100), false, "Flag2", null, null, "2.jpg" },
                    { "e6e3f52a-c81b-488c-8ba2-ae2e58c290ab", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2080), false, "Language1", null, null, "English" },
                    { "e8e6bda2-80e6-49a2-9857-f5e9c80d8221", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2050), false, "Payment", null, null, "payment.png" },
                    { "f6919325-7f81-4f34-a1ce-914d128beaa8", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2020), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "f9f57e58-620f-4ae0-b949-fb5e150df1d6", "System", new DateTime(2023, 10, 29, 22, 50, 51, 605, DateTimeKind.Local).AddTicks(2070), false, "currency2", null, null, "EUR$" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6cc39f3-2570-4a36-ba6d-dec9545e6dcc", "1c825c52-5160-4ed0-ac8d-fdc66442bcf9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c065ab54-f5d1-455e-b84e-7f60dddd7244", "a3057c88-1519-4b31-9ce0-af6fdb68c106" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "595ef103-20b1-4f79-9b90-b3300fdd027b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6cc39f3-2570-4a36-ba6d-dec9545e6dcc", "1c825c52-5160-4ed0-ac8d-fdc66442bcf9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c065ab54-f5d1-455e-b84e-7f60dddd7244", "a3057c88-1519-4b31-9ce0-af6fdb68c106" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "13e8541c-9b31-4f57-8857-0615ceedeef2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1523e27d-2517-4d50-87d5-809e04ff96cf");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2696346a-2e2f-4a1f-9565-6c4e274808d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "420982ff-a717-4bd4-b294-1875f996d392");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "541cd79a-54f6-4df6-8a3a-dd782b45ed97");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "80c4f897-bce0-41b9-a225-5f342b2cad24");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9903d949-9222-4fab-9e48-e307132310b7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cc983aa4-298b-42f6-8ae2-4df518ec994a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "cf4c5e83-5cc9-470e-9342-828048ce00a8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d2783400-b7c4-4bc0-86a4-43a577f3fea6");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e6e3f52a-c81b-488c-8ba2-ae2e58c290ab");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e8e6bda2-80e6-49a2-9857-f5e9c80d8221");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f6919325-7f81-4f34-a1ce-914d128beaa8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f9f57e58-620f-4ae0-b949-fb5e150df1d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6cc39f3-2570-4a36-ba6d-dec9545e6dcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c065ab54-f5d1-455e-b84e-7f60dddd7244");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c825c52-5160-4ed0-ac8d-fdc66442bcf9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3057c88-1519-4b31-9ce0-af6fdb68c106");

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
    }
}
