using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AlterCategotyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0f4ff70-5dea-44ae-ac7c-24aa98ee0f76");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0f101d8-0373-482b-88d1-d60608c2d5c8", "0c2290c5-c81b-45a8-859b-11bdae2b0ffd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9add4e3-10b5-4871-90b1-99ef525bb011", "164a01ee-9d29-48c3-a573-3124b63ea804" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "016248d3-552c-4fb1-8fd2-deb44f323b0e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "09caad51-cf12-4a28-923d-594105404080");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0ae61f6d-3361-4ff2-a136-cfd62868d587");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "27769ab8-1119-43c5-adf0-2e0b512285e7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3e23563e-0fe8-49e8-a79f-0a54b31f2213");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4086ca05-ea55-4288-9c22-a93af93a63bb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7850f674-82c7-4dd4-873a-f03e5f5e2fae");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8b09342f-5aa1-4911-9f33-2adde3537edb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "918f6138-ea6c-4cfe-a1bc-fc26fe1b99d8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a221f0c4-f596-4159-a3e2-806cb179e3e3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a6961626-1eac-428c-9666-574ca268a537");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a7321b14-672e-4d39-91cb-c9fcb5a94022");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c677b225-2c72-4909-9ef4-03e92d473994");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f20be871-7d63-404f-bdbe-81ad4b882bf1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9add4e3-10b5-4871-90b1-99ef525bb011");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f101d8-0373-482b-88d1-d60608c2d5c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c2290c5-c81b-45a8-859b-11bdae2b0ffd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "164a01ee-9d29-48c3-a573-3124b63ea804");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "77c8594e-8323-4767-a723-643e040dc3aa", "2f7d55d7-cbaf-4239-9bc1-6f19b0a3004a", "User", "USER" },
                    { "dd7d1c98-a7eb-4129-9280-9bee374eb304", "da99c5b8-d43f-4ef3-86fb-0bd6c3084608", "Admin", "ADMIN" },
                    { "e6f881f4-3417-444f-9cd0-09852a6def35", "646e99a7-12be-417f-a471-ee18e9ffc88d", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "3c88aa9a-d89e-475c-920e-9a6fd2cc8d88", 0, "System", "0660bde2-5f8c-49b8-8c1a-461a2edcb654", new DateTime(2023, 10, 29, 5, 49, 43, 133, DateTimeKind.Local).AddTicks(3800), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEJv2T6JIjvv91qwvoQ/Z8+dw8ir5ZPwYbweQ5mu9JB5VeOkpHoU0qXIqkILFUmvu3w==", "+994513004484", true, null, null, "aae68ffd-7827-41df-ae6e-c933c7756682", false, null, "RufatCode" },
                    { "66872929-7419-4ccc-9aa7-fb8df8c57227", 0, "System", "d7e519f2-923c-45bc-b6ec-4a594b5e6f7b", new DateTime(2023, 10, 29, 5, 49, 43, 133, DateTimeKind.Local).AddTicks(3840), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEIkrtPuow8pmqB+RxUVeBJNGaXCWAb1UmMSrA6WfXPC4zyf34rd7ETR1qbU92lwCSA==", "+994513004484", true, null, null, "bec609e8-a519-40e3-96ef-abf230f5a5c9", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "336f1d95-bb23-4319-8235-583da2c951ce", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4350), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "529628f3-08fb-4d0e-9eb1-425d1885fd0d", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4340), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "5d661b4a-08ff-4c75-a237-1da581f3e7c6", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4360), false, "currency1", null, null, "USD$" },
                    { "71dc1d39-47ae-46c3-bd95-3f62593eed9d", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4300), false, "Hotline", null, null, "+48 500 500 500" },
                    { "8faa032a-20e0-4f1b-af48-9d0836b8b968", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4370), false, "currency2", null, null, "EUR$" },
                    { "a8bb925f-17be-4b99-b46c-6cdb89188c75", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4320), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "b044cf3d-4376-406a-b8a1-54b7d954c938", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4380), false, "Flag1", null, null, "1.jpg" },
                    { "b2414538-dcc3-470b-b693-72ff3f5646e2", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4390), false, "Flag2", null, null, "2.jpg" },
                    { "c1fe39e0-6dc1-4009-91d7-604be824f67f", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4330), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "c59c1802-4c5f-420a-9f21-0bf74a653bc4", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4330), false, "PhoneNumber", null, null, "+994513004484" },
                    { "d4b7b40a-0b37-4799-b227-4856ce4720d7", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4310), false, "Logo", null, null, "logo.png" },
                    { "e95a23cb-a240-4de2-a1b3-087d950b6fd0", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4380), false, "Language2", null, null, "Franch" },
                    { "fa285056-dc8a-4c5c-83ee-4717dbcdf8f4", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4350), false, "Payment", null, null, "payment.png" },
                    { "fe5ae378-1e6e-4f6f-9521-44d846732f46", "System", new DateTime(2023, 10, 29, 5, 49, 43, 136, DateTimeKind.Local).AddTicks(4370), false, "Language1", null, null, "English" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dd7d1c98-a7eb-4129-9280-9bee374eb304", "3c88aa9a-d89e-475c-920e-9a6fd2cc8d88" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e6f881f4-3417-444f-9cd0-09852a6def35", "66872929-7419-4ccc-9aa7-fb8df8c57227" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c8594e-8323-4767-a723-643e040dc3aa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd7d1c98-a7eb-4129-9280-9bee374eb304", "3c88aa9a-d89e-475c-920e-9a6fd2cc8d88" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6f881f4-3417-444f-9cd0-09852a6def35", "66872929-7419-4ccc-9aa7-fb8df8c57227" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "336f1d95-bb23-4319-8235-583da2c951ce");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "529628f3-08fb-4d0e-9eb1-425d1885fd0d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5d661b4a-08ff-4c75-a237-1da581f3e7c6");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "71dc1d39-47ae-46c3-bd95-3f62593eed9d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8faa032a-20e0-4f1b-af48-9d0836b8b968");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a8bb925f-17be-4b99-b46c-6cdb89188c75");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b044cf3d-4376-406a-b8a1-54b7d954c938");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b2414538-dcc3-470b-b693-72ff3f5646e2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c1fe39e0-6dc1-4009-91d7-604be824f67f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c59c1802-4c5f-420a-9f21-0bf74a653bc4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d4b7b40a-0b37-4799-b227-4856ce4720d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e95a23cb-a240-4de2-a1b3-087d950b6fd0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "fa285056-dc8a-4c5c-83ee-4717dbcdf8f4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "fe5ae378-1e6e-4f6f-9521-44d846732f46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd7d1c98-a7eb-4129-9280-9bee374eb304");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6f881f4-3417-444f-9cd0-09852a6def35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c88aa9a-d89e-475c-920e-9a6fd2cc8d88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66872929-7419-4ccc-9aa7-fb8df8c57227");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b0f4ff70-5dea-44ae-ac7c-24aa98ee0f76", "9225ae82-c05b-4706-a38b-2a588f294124", "User", "USER" },
                    { "e9add4e3-10b5-4871-90b1-99ef525bb011", "56e7c2e7-3cfe-42c3-99c0-00244ad94bf7", "SupperAdmin", "SUPPERADMIN" },
                    { "f0f101d8-0373-482b-88d1-d60608c2d5c8", "2606ed12-226e-4e94-b9bf-8d355a8af1d3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "0c2290c5-c81b-45a8-859b-11bdae2b0ffd", 0, "System", "53996673-c6c2-44cb-ad72-508583695fce", new DateTime(2023, 10, 29, 5, 23, 26, 590, DateTimeKind.Local).AddTicks(5160), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEHP9KQ75DU2ZkgYnXM5gwzuBgiVfmc/gIqK+eSj+/LiwM95Q/UHfZfO6oO+8x7F2bQ==", "+994513004484", true, null, null, "9ce8a287-bf4e-4011-ba79-5c4fcba42927", false, null, "RufatCode" },
                    { "164a01ee-9d29-48c3-a573-3124b63ea804", 0, "System", "11907aef-53e3-444f-98d4-91e76d3c78f4", new DateTime(2023, 10, 29, 5, 23, 26, 590, DateTimeKind.Local).AddTicks(5190), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEDAl3z7VWjx2myNOivDjhPx25wDi5LbPdLKEuM0HgDlXOw2NnIWcNK0WdDiBBEqE5A==", "+994513004484", true, null, null, "35e6e2b2-e0dd-4fa5-8b21-2ba058abf5d0", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "016248d3-552c-4fb1-8fd2-deb44f323b0e", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5210), false, "Language1", null, null, "English" },
                    { "09caad51-cf12-4a28-923d-594105404080", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5200), false, "currency1", null, null, "USD$" },
                    { "0ae61f6d-3361-4ff2-a136-cfd62868d587", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5180), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "27769ab8-1119-43c5-adf0-2e0b512285e7", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5220), false, "Language2", null, null, "Franch" },
                    { "3e23563e-0fe8-49e8-a79f-0a54b31f2213", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5180), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "4086ca05-ea55-4288-9c22-a93af93a63bb", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5160), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "7850f674-82c7-4dd4-873a-f03e5f5e2fae", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5170), false, "PhoneNumber", null, null, "+994513004484" },
                    { "8b09342f-5aa1-4911-9f33-2adde3537edb", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5150), false, "Hotline", null, null, "+48 500 500 500" },
                    { "918f6138-ea6c-4cfe-a1bc-fc26fe1b99d8", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5210), false, "currency2", null, null, "EUR$" },
                    { "a221f0c4-f596-4159-a3e2-806cb179e3e3", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5160), false, "Logo", null, null, "logo.png" },
                    { "a6961626-1eac-428c-9666-574ca268a537", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5230), false, "Flag1", null, null, "1.jpg" },
                    { "a7321b14-672e-4d39-91cb-c9fcb5a94022", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5190), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "c677b225-2c72-4909-9ef4-03e92d473994", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5230), false, "Flag2", null, null, "2.jpg" },
                    { "f20be871-7d63-404f-bdbe-81ad4b882bf1", "System", new DateTime(2023, 10, 29, 5, 23, 26, 593, DateTimeKind.Local).AddTicks(5190), false, "Payment", null, null, "payment.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f0f101d8-0373-482b-88d1-d60608c2d5c8", "0c2290c5-c81b-45a8-859b-11bdae2b0ffd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9add4e3-10b5-4871-90b1-99ef525bb011", "164a01ee-9d29-48c3-a573-3124b63ea804" });
        }
    }
}
