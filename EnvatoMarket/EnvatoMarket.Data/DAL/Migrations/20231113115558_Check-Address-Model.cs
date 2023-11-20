using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class CheckAddressModel : Migration
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
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addres1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addres2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalAmmount = table.Column<double>(type: "float", nullable: false),
                    AdressId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        name: "FK_Checks_Adresses_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checks_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_UserId",
                table: "Adresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckProducts_CheckId",
                table: "CheckProducts",
                column: "CheckId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckProducts_ProductId",
                table: "CheckProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_AdressId",
                table: "Checks",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_AppUserId",
                table: "Checks",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckProducts");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DropTable(
                name: "Adresses");

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
