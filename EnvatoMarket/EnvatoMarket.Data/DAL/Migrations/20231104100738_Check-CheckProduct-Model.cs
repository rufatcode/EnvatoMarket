using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class CheckCheckProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af51b444-d0c3-4eaa-b32e-0b81ee5c112b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3230a439-96cd-438b-a960-c8a006865765", "770289d3-0448-4e7e-ac8a-644398d8a63c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6", "d0719b20-84b1-4162-8bb2-d4a4abc12906" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0f0ead43-85d3-4033-9ba2-01925fac8dcb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "214042bd-9c3f-44fd-becb-c37004fca02e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "344a4521-bc34-4df4-bbbd-6d753ea4853e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "36da915b-59ee-475c-8be0-e92f916a6557");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4e7c4e5b-de5a-4d7f-a0ba-a7dead1d43e5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "570a298c-11b2-4a40-9eec-672a8d6e88fe");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "65cc02d1-a105-4641-a45f-3ab59e64882a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6a7adc9e-9482-48ae-b999-e58329ed5d57");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6b618db0-8a72-4f92-a37b-08e786f74ca1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "791af639-caf2-447a-a2a2-0277400d71bc");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "91c91da8-8816-45ec-abd1-f0c882659706");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b2152793-2bed-445d-8dbf-42ab52143b50");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d47042c1-9487-414c-b819-6888c8a962f2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f092a56a-3c92-4edf-b96a-f8d486872251");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3230a439-96cd-438b-a960-c8a006865765");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "770289d3-0448-4e7e-ac8a-644398d8a63c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0719b20-84b1-4162-8bb2-d4a4abc12906");

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalAmmount = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductCount = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckProducts_Checks_CheckId",
                        column: x => x.CheckId,
                        principalTable: "Checks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6431dd25-c940-4351-a41c-196fb2d5a384", "5c714324-9e68-448c-932b-b28f9bee98ad", "User", "USER" },
                    { "6cf28b69-d5a4-42b9-8671-0b7db0805745", "81c6cb99-3ba9-4c62-8622-41e7e11df750", "SupperAdmin", "SUPPERADMIN" },
                    { "f342de39-5a60-4be6-ad02-ebbd6c24d5a8", "8c4a2d1d-24ac-4993-92b9-6decbf410a3a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "46a19dab-f8cd-45fb-be00-7e25fb2ec7f5", 0, "System", "a546c754-d879-424f-8fa4-e8545369ca62", new DateTime(2023, 11, 4, 14, 7, 38, 546, DateTimeKind.Local).AddTicks(3600), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEGuBt03zyLe0Mr94GmzZ1wigU5C6f7eslNzPgreleptAmV4lVvaERqzwbRV3l+dYhg==", "+994513004484", true, null, null, "6921118b-c7b8-4f81-8bc2-83815f290678", false, null, "Rufat_2003" },
                    { "8ebb95fa-7d47-474b-9d6e-f804bcf188fe", 0, "System", "b3fb2d3a-cb5e-4d2d-88ca-2e7855b3d780", new DateTime(2023, 11, 4, 14, 7, 38, 546, DateTimeKind.Local).AddTicks(3570), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAECbKUJIOJPy0+NpbTK32VKpD3lGD5SPOdfloTn2+DGJT6Z3okjG3hW+ud2iPKT1IZA==", "+994513004484", true, null, null, "1117ab8d-b43f-42df-bc10-a4baea695b38", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0d23fd6d-7f4e-4a94-bd50-45d36ce4e7c0", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3680), false, "Hotline", null, null, "+48 500 500 500" },
                    { "1b680feb-ec7b-47bf-8d7e-4e314ed46243", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3730), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "36c167ac-5369-47fb-9216-443f692c311e", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3770), false, "Language2", null, null, "Franch" },
                    { "489a09c1-e6d4-4869-8b30-7f17265e429f", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3740), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "4a21d50e-8df3-4f2d-8e54-a4d031ba7b25", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3760), false, "currency2", null, null, "EUR$" },
                    { "65ff73c3-0167-4eb7-9311-e901a9fd7bb7", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3690), false, "Logo", null, null, "logo.png" },
                    { "70dc48e3-9984-40e5-a1b9-405cb234e733", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3700), false, "PhoneNumber", null, null, "+994513004484" },
                    { "9365155b-7198-401a-a1d5-dbe2ac645ff7", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3700), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "a325e5fa-6e50-4b27-9dc1-916187d913ba", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3790), false, "Flag2", null, null, "2.jpg" },
                    { "bfc15d80-4a17-466f-a345-400f0e654f54", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3770), false, "Language1", null, null, "English" },
                    { "e1ddd764-79c7-4070-9660-8490f8274b06", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3750), false, "currency1", null, null, "USD$" },
                    { "e2ca4689-c810-48e9-9dac-0531a9573100", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3740), false, "Payment", null, null, "payment.png" },
                    { "f1d40398-8eb0-4b7e-8283-d06f2900f38e", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3750), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "ff1d9fd9-0094-4a9a-a5a9-a22ea79abeb2", "System", new DateTime(2023, 11, 4, 14, 7, 38, 549, DateTimeKind.Local).AddTicks(3780), false, "Flag1", null, null, "1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6cf28b69-d5a4-42b9-8671-0b7db0805745", "46a19dab-f8cd-45fb-be00-7e25fb2ec7f5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f342de39-5a60-4be6-ad02-ebbd6c24d5a8", "8ebb95fa-7d47-474b-9d6e-f804bcf188fe" });

            migrationBuilder.CreateIndex(
                name: "IX_CheckProducts_CheckId",
                table: "CheckProducts",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckProducts_ProductId",
                table: "CheckProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_UserId",
                table: "Checks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckProducts");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6431dd25-c940-4351-a41c-196fb2d5a384");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6cf28b69-d5a4-42b9-8671-0b7db0805745", "46a19dab-f8cd-45fb-be00-7e25fb2ec7f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f342de39-5a60-4be6-ad02-ebbd6c24d5a8", "8ebb95fa-7d47-474b-9d6e-f804bcf188fe" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0d23fd6d-7f4e-4a94-bd50-45d36ce4e7c0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1b680feb-ec7b-47bf-8d7e-4e314ed46243");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "36c167ac-5369-47fb-9216-443f692c311e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "489a09c1-e6d4-4869-8b30-7f17265e429f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4a21d50e-8df3-4f2d-8e54-a4d031ba7b25");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "65ff73c3-0167-4eb7-9311-e901a9fd7bb7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "70dc48e3-9984-40e5-a1b9-405cb234e733");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9365155b-7198-401a-a1d5-dbe2ac645ff7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a325e5fa-6e50-4b27-9dc1-916187d913ba");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "bfc15d80-4a17-466f-a345-400f0e654f54");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e1ddd764-79c7-4070-9660-8490f8274b06");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e2ca4689-c810-48e9-9dac-0531a9573100");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f1d40398-8eb0-4b7e-8283-d06f2900f38e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ff1d9fd9-0094-4a9a-a5a9-a22ea79abeb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cf28b69-d5a4-42b9-8671-0b7db0805745");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f342de39-5a60-4be6-ad02-ebbd6c24d5a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46a19dab-f8cd-45fb-be00-7e25fb2ec7f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ebb95fa-7d47-474b-9d6e-f804bcf188fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3230a439-96cd-438b-a960-c8a006865765", "f75a7679-40de-4918-a617-2b5ea29199d0", "Admin", "ADMIN" },
                    { "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6", "fe1fc06d-29b5-4dfb-985b-469f1199600a", "SupperAdmin", "SUPPERADMIN" },
                    { "af51b444-d0c3-4eaa-b32e-0b81ee5c112b", "54e58824-e006-4f97-b2c4-ffb155b7f19b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "770289d3-0448-4e7e-ac8a-644398d8a63c", 0, "System", "c5f58c94-5434-403e-bba6-1421350a5166", new DateTime(2023, 11, 4, 10, 48, 36, 800, DateTimeKind.Local).AddTicks(4350), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEAzWAEXrOfvK+DXdGWnD+24IQU73U4XcjB6lRnTBhaYpJ1GWSPIqA12nR74jO/F45w==", "+994513004484", true, null, null, "4101b3ed-9420-4e25-9140-0b0333795522", false, null, "RufatCode" },
                    { "d0719b20-84b1-4162-8bb2-d4a4abc12906", 0, "System", "82211220-3fcf-478b-8a1c-9e464b87d585", new DateTime(2023, 11, 4, 10, 48, 36, 800, DateTimeKind.Local).AddTicks(4390), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEOaEGRERlcHPat0RT5YALx3UbIWmhteIL9FWceDR7ih+jEbFF/NesN4HQYvHmjYtZw==", "+994513004484", true, null, null, "b6417e11-fecc-405c-9af4-7acea785481f", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0f0ead43-85d3-4033-9ba2-01925fac8dcb", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4500), false, "currency1", null, null, "USD$" },
                    { "214042bd-9c3f-44fd-becb-c37004fca02e", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4460), false, "Payment", null, null, "payment.png" },
                    { "344a4521-bc34-4df4-bbbd-6d753ea4853e", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4510), false, "Language1", null, null, "English" },
                    { "36da915b-59ee-475c-8be0-e92f916a6557", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4450), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "4e7c4e5b-de5a-4d7f-a0ba-a7dead1d43e5", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4520), false, "Language2", null, null, "Franch" },
                    { "570a298c-11b2-4a40-9eec-672a8d6e88fe", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4430), false, "Logo", null, null, "logo.png" },
                    { "65cc02d1-a105-4641-a45f-3ab59e64882a", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4500), false, "currency2", null, null, "EUR$" },
                    { "6a7adc9e-9482-48ae-b999-e58329ed5d57", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4440), false, "PhoneNumber", null, null, "+994513004484" },
                    { "6b618db0-8a72-4f92-a37b-08e786f74ca1", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4470), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "791af639-caf2-447a-a2a2-0277400d71bc", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4460), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "91c91da8-8816-45ec-abd1-f0c882659706", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4520), false, "Flag1", null, null, "1.jpg" },
                    { "b2152793-2bed-445d-8dbf-42ab52143b50", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4420), false, "Hotline", null, null, "+48 500 500 500" },
                    { "d47042c1-9487-414c-b819-6888c8a962f2", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4530), false, "Flag2", null, null, "2.jpg" },
                    { "f092a56a-3c92-4edf-b96a-f8d486872251", "System", new DateTime(2023, 11, 4, 10, 48, 36, 803, DateTimeKind.Local).AddTicks(4440), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3230a439-96cd-438b-a960-c8a006865765", "770289d3-0448-4e7e-ac8a-644398d8a63c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8e86e0a6-53dc-4912-ab4c-4bdaa09f14c6", "d0719b20-84b1-4162-8bb2-d4a4abc12906" });
        }
    }
}
