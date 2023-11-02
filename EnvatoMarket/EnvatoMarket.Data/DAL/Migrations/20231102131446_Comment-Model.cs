using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class CommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0758940-10b0-4dd7-a530-6a5da8116e6e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "248a822b-fe31-4c88-93b8-0a94cbef753d", "37c0e899-2349-4cc2-8054-25feaa34ebf2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b07c9057-e50b-487f-8a9b-f44bbfb38fa7", "38062ec5-9ecf-44b7-b51f-9add232c608b" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2731d4eb-43df-4602-bbc9-568e7e8f785c");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "30e107d2-4a93-4056-b7da-c738311a8e5e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "35c8364f-dc93-45b7-8f4f-4aaeb4eff4df");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "35de94a2-e80d-4b81-abc5-6332616a07dc");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3df58921-2a58-4b17-aca6-e9694bd49a9a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3e4aee71-7482-4702-a26f-5a8bfda7b464");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4f76c245-82c7-48eb-a2b3-6fd27de37584");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5b6fc348-8aac-4548-90bd-a8bd778c0f66");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7a7398c5-2d6f-4036-aa5d-4286dfd441a0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7f8d9b93-17fb-4418-b7bc-cd55ab64266b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8ef0c11e-fe9c-4126-9c2b-69a223faccc8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "90c926b9-e296-4f6f-9191-8b3e0f474cee");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a80afa00-c4e1-44be-bdd7-c86eae6df2c5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "ced3e1fe-dd73-4543-b477-0a8fddb35a98");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "248a822b-fe31-4c88-93b8-0a94cbef753d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b07c9057-e50b-487f-8a9b-f44bbfb38fa7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37c0e899-2349-4cc2-8054-25feaa34ebf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38062ec5-9ecf-44b7-b51f-9add232c608b");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
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
                    { "236ad124-4df7-411b-8956-e4ad0346fa6d", "e578f00f-7946-4080-a5f5-d465793b8a90", "Admin", "ADMIN" },
                    { "9e1bdb35-2f93-41d4-8e76-3fa2e4367016", "d9bbe75e-e351-433f-8a6e-72ac162e59a9", "SupperAdmin", "SUPPERADMIN" },
                    { "aa3ca08f-4093-42e4-a7b5-f5a45ab7a071", "762a6518-3e4d-4c5a-a68d-7354c7a0da22", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "4d84c2a7-09bb-4eeb-869a-493cbc9609de", 0, "System", "9d60d9fd-b9d8-475c-a4a4-73a75d776dc4", new DateTime(2023, 11, 2, 17, 14, 46, 750, DateTimeKind.Local).AddTicks(9230), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEAfw3B3zVyr9BREUlEjtc5g1axOGRUP/C6FsrBtNk740oDkTwXDUJyBjFtOs12fomw==", "+994513004484", true, null, null, "0e3f7a31-99f3-407c-936f-b1c1613adeb4", false, null, "RufatCode" },
                    { "ea8cf0c6-3c95-4139-9dce-46cd8f78c169", 0, "System", "06ed1aa8-4fd6-4c93-ad88-30021fa1e81b", new DateTime(2023, 11, 2, 17, 14, 46, 750, DateTimeKind.Local).AddTicks(9260), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEMfdn5sy5lyjS1oooZRLPez+jtnbbjUkfwTRL/9OwLruZr+AZZ8JLTwU0xty6Q1e3Q==", "+994513004484", true, null, null, "8b9bbd5e-0edf-4481-8394-a5f8abc9a39f", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "05fa0b50-c1e0-46a6-9356-ecba86696fc0", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9010), false, "Hotline", null, null, "+48 500 500 500" },
                    { "10deeda9-2ed5-4eb7-b607-c21f001ae063", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9090), false, "Flag1", null, null, "1.jpg" },
                    { "146c8b18-7069-4bbc-8f7a-52ea6eb162ff", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9040), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "1898eda1-8250-4e51-95c8-4abbb3fa01fa", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9030), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "1d288eb3-1de8-4348-81e3-3e9784d01af2", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9090), false, "Flag2", null, null, "2.jpg" },
                    { "22811f5b-00f2-4439-9f16-e0dc982902e8", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9070), false, "Language1", null, null, "English" },
                    { "235937cd-4285-4e5f-ad97-22b7e41905d7", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9020), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "23709a95-017d-4281-ac1e-a9fa83690f0a", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9030), false, "PhoneNumber", null, null, "+994513004484" },
                    { "32b5889a-5c93-41e4-b78b-b25b3e435156", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9050), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "5947c2dc-76dc-472a-b6c7-0517cbbcf6bb", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9020), false, "Logo", null, null, "logo.png" },
                    { "5a90dd89-4e95-48e1-8b56-3a39ed44ddf4", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9050), false, "Payment", null, null, "payment.png" },
                    { "6b2e4fb2-afe5-4248-a273-f6fdaf2fda82", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9070), false, "currency2", null, null, "EUR$" },
                    { "f3744af7-858f-4fed-b57e-8f361fef588a", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9060), false, "currency1", null, null, "USD$" },
                    { "f4c3b18e-d912-4ebb-838e-27d2a38dac54", "System", new DateTime(2023, 11, 2, 17, 14, 46, 753, DateTimeKind.Local).AddTicks(9080), false, "Language2", null, null, "Franch" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "236ad124-4df7-411b-8956-e4ad0346fa6d", "4d84c2a7-09bb-4eeb-869a-493cbc9609de" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e1bdb35-2f93-41d4-8e76-3fa2e4367016", "ea8cf0c6-3c95-4139-9dce-46cd8f78c169" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa3ca08f-4093-42e4-a7b5-f5a45ab7a071");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "236ad124-4df7-411b-8956-e4ad0346fa6d", "4d84c2a7-09bb-4eeb-869a-493cbc9609de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e1bdb35-2f93-41d4-8e76-3fa2e4367016", "ea8cf0c6-3c95-4139-9dce-46cd8f78c169" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "05fa0b50-c1e0-46a6-9356-ecba86696fc0");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "10deeda9-2ed5-4eb7-b607-c21f001ae063");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "146c8b18-7069-4bbc-8f7a-52ea6eb162ff");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1898eda1-8250-4e51-95c8-4abbb3fa01fa");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1d288eb3-1de8-4348-81e3-3e9784d01af2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "22811f5b-00f2-4439-9f16-e0dc982902e8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "235937cd-4285-4e5f-ad97-22b7e41905d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "23709a95-017d-4281-ac1e-a9fa83690f0a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "32b5889a-5c93-41e4-b78b-b25b3e435156");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5947c2dc-76dc-472a-b6c7-0517cbbcf6bb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5a90dd89-4e95-48e1-8b56-3a39ed44ddf4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6b2e4fb2-afe5-4248-a273-f6fdaf2fda82");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f3744af7-858f-4fed-b57e-8f361fef588a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f4c3b18e-d912-4ebb-838e-27d2a38dac54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "236ad124-4df7-411b-8956-e4ad0346fa6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e1bdb35-2f93-41d4-8e76-3fa2e4367016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d84c2a7-09bb-4eeb-869a-493cbc9609de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea8cf0c6-3c95-4139-9dce-46cd8f78c169");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "248a822b-fe31-4c88-93b8-0a94cbef753d", "bf642eb0-00df-427e-8500-9f47664dfeae", "Admin", "ADMIN" },
                    { "b07c9057-e50b-487f-8a9b-f44bbfb38fa7", "4de6df9c-e01b-4e38-a967-4787e78c3e26", "SupperAdmin", "SUPPERADMIN" },
                    { "e0758940-10b0-4dd7-a530-6a5da8116e6e", "d7ef4b5c-1210-475a-b8ce-d4747b02001c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "37c0e899-2349-4cc2-8054-25feaa34ebf2", 0, "System", "e2bc15e7-7997-4f83-9054-b7c56b982fd5", new DateTime(2023, 10, 31, 20, 9, 29, 792, DateTimeKind.Local).AddTicks(7680), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAECTUx5KymG+izHEGkjo37022AVpfaKQYfmFOFVaIjOZyW0ZWYDG6G34R4mJWOTW7ww==", "+994513004484", true, null, null, "ca3e56f9-a687-4fcb-9918-42df5f376e2e", false, null, "RufatCode" },
                    { "38062ec5-9ecf-44b7-b51f-9add232c608b", 0, "System", "142eeea1-bd62-4a02-8e22-4d9bfa50f392", new DateTime(2023, 10, 31, 20, 9, 29, 792, DateTimeKind.Local).AddTicks(7710), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEL7D+8VR29tLhUYTOibwh35LhuvKf/qX8WId8xVMPm7eGg5ZO+TWN572erG9kujU/A==", "+994513004484", true, null, null, "39869f30-0e16-463c-9d2b-1e3a6e7f3bcc", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "2731d4eb-43df-4602-bbc9-568e7e8f785c", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8280), false, "Flag2", null, null, "2.jpg" },
                    { "30e107d2-4a93-4056-b7da-c738311a8e5e", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8270), false, "Language2", null, null, "Franch" },
                    { "35c8364f-dc93-45b7-8f4f-4aaeb4eff4df", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8260), false, "Language1", null, null, "English" },
                    { "35de94a2-e80d-4b81-abc5-6332616a07dc", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8240), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "3df58921-2a58-4b17-aca6-e9694bd49a9a", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8190), false, "Hotline", null, null, "+48 500 500 500" },
                    { "3e4aee71-7482-4702-a26f-5a8bfda7b464", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8260), false, "currency2", null, null, "EUR$" },
                    { "4f76c245-82c7-48eb-a2b3-6fd27de37584", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8240), false, "Payment", null, null, "payment.png" },
                    { "5b6fc348-8aac-4548-90bd-a8bd778c0f66", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8210), false, "PhoneNumber", null, null, "+994513004484" },
                    { "7a7398c5-2d6f-4036-aa5d-4286dfd441a0", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8220), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "7f8d9b93-17fb-4418-b7bc-cd55ab64266b", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8200), false, "Logo", null, null, "logo.png" },
                    { "8ef0c11e-fe9c-4126-9c2b-69a223faccc8", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8230), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "90c926b9-e296-4f6f-9191-8b3e0f474cee", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8210), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "a80afa00-c4e1-44be-bdd7-c86eae6df2c5", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8270), false, "Flag1", null, null, "1.jpg" },
                    { "ced3e1fe-dd73-4543-b477-0a8fddb35a98", "System", new DateTime(2023, 10, 31, 20, 9, 29, 795, DateTimeKind.Local).AddTicks(8250), false, "currency1", null, null, "USD$" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "248a822b-fe31-4c88-93b8-0a94cbef753d", "37c0e899-2349-4cc2-8054-25feaa34ebf2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b07c9057-e50b-487f-8a9b-f44bbfb38fa7", "38062ec5-9ecf-44b7-b51f-9add232c608b" });
        }
    }
}
