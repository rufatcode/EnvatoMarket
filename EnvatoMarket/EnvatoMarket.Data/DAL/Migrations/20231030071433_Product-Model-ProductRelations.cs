using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class ProductModelProductRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SalePercentage = table.Column<double>(type: "float", nullable: false),
                    StarsCount = table.Column<int>(type: "int", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    IsAvailability = table.Column<bool>(type: "bit", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BrandId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    IsHover = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TagId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "046a54b6-f2e6-4f6d-86b5-c2d61f461fec", "bee25fe6-fa13-4f4f-a6fe-07f854aa7a66", "Admin", "ADMIN" },
                    { "a24acf62-18fa-43d2-a950-6ecfc014aeaa", "fd6a3254-d5da-4bde-88fb-26e6e1a5bf77", "User", "USER" },
                    { "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52", "7fea7eb1-318a-4860-9349-9602da0fb199", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12", 0, "System", "a6953121-ab24-474c-a18b-39ff103f44f2", new DateTime(2023, 10, 30, 11, 14, 32, 959, DateTimeKind.Local).AddTicks(9630), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEPTD7JPH8SpFRsIypzLn1nS7gkGEnGqVQgPhj69dg/2WHRxaPRUm9E0hMuyXM4gXsg==", "+994513004484", true, null, null, "65d5825d-8621-4238-b968-27605c76473d", false, null, "RufatCode" },
                    { "2396a0e9-8506-4482-80e6-4c191682af70", 0, "System", "b007d73c-9d31-410d-8d65-4ed6bab6ddb6", new DateTime(2023, 10, 30, 11, 14, 32, 959, DateTimeKind.Local).AddTicks(9670), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEHV73dDO1hR84csJfiyaQnFmmxeIZxPUMflnNIHCdWxgm2P+awCb0ti6BglhqM0ETQ==", "+994513004484", true, null, null, "21f5a604-8a4c-4989-a8dc-e2cf9bc9cc55", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "0102dec9-63ea-4ae5-9447-1edaaf3f5e7b", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9690), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "330767e0-6062-4edd-8d4d-82aea3920814", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9730), false, "Flag2", null, null, "2.jpg" },
                    { "3f5c5234-2744-4df7-9eb2-6d25e581a8c0", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9700), false, "currency2", null, null, "EUR$" },
                    { "65a5c00b-dca7-4ae6-994c-6928c22e2bd7", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9650), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "7471a151-6867-4364-9bd6-b22c870e5096", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9670), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "7fcbac19-8c08-4990-8bf4-838640f3871f", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9710), false, "Language1", null, null, "English" },
                    { "9f77a6d2-641f-44a3-81b2-fcb4ea80cb88", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9640), false, "Hotline", null, null, "+48 500 500 500" },
                    { "bae02bd4-dde9-4511-b5ba-3f6b646d78c3", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9680), false, "Payment", null, null, "payment.png" },
                    { "beb1b622-ef00-4a26-9211-1c0455556bc1", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9690), false, "currency1", null, null, "USD$" },
                    { "c51f2d2c-6f39-4505-9076-61629bd68c2f", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9720), false, "Flag1", null, null, "1.jpg" },
                    { "d1a8fd8c-b16c-4346-a922-7fed7aae3569", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9660), false, "PhoneNumber", null, null, "+994513004484" },
                    { "e0bd17b8-b16f-43b0-8cf3-4c33afcade67", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9650), false, "Logo", null, null, "logo.png" },
                    { "e3df2ae8-c0ed-4b59-9930-ed5665954af4", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9710), false, "Language2", null, null, "Franch" },
                    { "f44aac1a-c006-4981-9c1d-06e5fc1bc302", "System", new DateTime(2023, 10, 30, 11, 14, 32, 962, DateTimeKind.Local).AddTicks(9670), false, "Email", null, null, "rufatri@code.edu.az" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "046a54b6-f2e6-4f6d-86b5-c2d61f461fec", "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52", "2396a0e9-8506-4482-80e6-4c191682af70" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a24acf62-18fa-43d2-a950-6ecfc014aeaa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "046a54b6-f2e6-4f6d-86b5-c2d61f461fec", "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52", "2396a0e9-8506-4482-80e6-4c191682af70" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "0102dec9-63ea-4ae5-9447-1edaaf3f5e7b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "330767e0-6062-4edd-8d4d-82aea3920814");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3f5c5234-2744-4df7-9eb2-6d25e581a8c0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "65a5c00b-dca7-4ae6-994c-6928c22e2bd7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7471a151-6867-4364-9bd6-b22c870e5096");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7fcbac19-8c08-4990-8bf4-838640f3871f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9f77a6d2-641f-44a3-81b2-fcb4ea80cb88");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "bae02bd4-dde9-4511-b5ba-3f6b646d78c3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "beb1b622-ef00-4a26-9211-1c0455556bc1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c51f2d2c-6f39-4505-9076-61629bd68c2f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d1a8fd8c-b16c-4346-a922-7fed7aae3569");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e0bd17b8-b16f-43b0-8cf3-4c33afcade67");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e3df2ae8-c0ed-4b59-9930-ed5665954af4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f44aac1a-c006-4981-9c1d-06e5fc1bc302");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "046a54b6-f2e6-4f6d-86b5-c2d61f461fec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0ed302b-7e4b-4a1f-a73b-a050a22b0e52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21f8baa8-4043-4e8d-b4e9-b8d8fd630e12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2396a0e9-8506-4482-80e6-4c191682af70");

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
    }
}
