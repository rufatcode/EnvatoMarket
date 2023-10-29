using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class CategotyModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cad7c1-3ff8-4085-b22c-faf7f48d82c3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82", "4f18dd5b-3242-4700-9c18-55053e21f8d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ff757ef-cb02-4336-b7af-6c551ff8d660", "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "076519ce-da54-460d-8b10-5f3f48f86cbb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "18bb6124-0b68-401c-890d-cf2eda9c4915");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1bba2a6a-6bf4-446a-babe-c0fd180aab92");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "33d0af2b-16a5-4b14-a555-74a9c9e2356d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "59576887-0af9-4d94-89f1-02e0fdea56b3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7d4459f1-5031-4b3c-9b92-835191af0cbf");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "99b2c592-50db-4abb-8f43-c4fa872d10b4");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9f574046-1192-4dca-80b4-6b2686fdb8d7");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "be41e6cb-a420-4fd2-a86d-6af5b5af9ee2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d31a3e27-f745-4e7e-b1b6-db0c4c3ece95");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e504fc56-3647-4fd2-af11-1904473cf338");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f67b03df-f705-4276-a74d-f87e9b81492e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f8a8c633-dd3a-4ea9-a780-13396de6d903");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f962c4c4-f466-4e35-b5de-ba6aaf456923");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ff757ef-cb02-4336-b7af-6c551ff8d660");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f18dd5b-3242-4700-9c18-55053e21f8d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Sliders",
                newName: "SubTitle");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "Sliders");

            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "Sliders",
                newName: "Title");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13cad7c1-3ff8-4085-b22c-faf7f48d82c3", "f3acb702-b6f3-4da1-9576-01005768fa99", "User", "USER" },
                    { "8ff757ef-cb02-4336-b7af-6c551ff8d660", "3673f12f-8ee9-49f3-88b9-66651a787eee", "SupperAdmin", "SUPPERADMIN" },
                    { "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82", "cb108a99-12c9-450c-a147-d78325e6f193", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "4f18dd5b-3242-4700-9c18-55053e21f8d0", 0, "System", "1211e6dc-c4d2-4556-bdc9-f26032cce955", new DateTime(2023, 10, 27, 15, 17, 8, 822, DateTimeKind.Local).AddTicks(9830), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEIne1aeXlMmyo4MsL4QQ6x7pLEpPKc434xIGRWaYgTY0n0BB1CkKwzjstHigvZGk1A==", "+994513004484", true, null, null, "08d77937-4ec5-4490-8d16-081dbc9fc9dd", false, null, "RufatCode" },
                    { "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6", 0, "System", "3bc81311-e283-4b12-a4a5-f3e60d38b999", new DateTime(2023, 10, 27, 15, 17, 8, 822, DateTimeKind.Local).AddTicks(9870), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAELuqdvcvHGI6h+v/fR1y628aGSZTuOe+8/PbWAXIofqvwt1vqDwDu+n3BidzRcVjsg==", "+994513004484", true, null, null, "02563ed5-fbfe-4a50-b671-ae2b5485f68f", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "076519ce-da54-460d-8b10-5f3f48f86cbb", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(860), false, "Payment", null, null, "payment.png" },
                    { "18bb6124-0b68-401c-890d-cf2eda9c4915", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(890), false, "Language1", null, null, "English" },
                    { "1bba2a6a-6bf4-446a-babe-c0fd180aab92", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(830), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "33d0af2b-16a5-4b14-a555-74a9c9e2356d", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(850), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "59576887-0af9-4d94-89f1-02e0fdea56b3", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(910), false, "Flag2", null, null, "2.jpg" },
                    { "7d4459f1-5031-4b3c-9b92-835191af0cbf", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(820), false, "Hotline", null, null, "+48 500 500 500" },
                    { "99b2c592-50db-4abb-8f43-c4fa872d10b4", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(900), false, "Flag1", null, null, "1.jpg" },
                    { "9f574046-1192-4dca-80b4-6b2686fdb8d7", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(870), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "be41e6cb-a420-4fd2-a86d-6af5b5af9ee2", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(890), false, "Language2", null, null, "Franch" },
                    { "d31a3e27-f745-4e7e-b1b6-db0c4c3ece95", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(830), false, "Logo", null, null, "logo.png" },
                    { "e504fc56-3647-4fd2-af11-1904473cf338", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(870), false, "currency1", null, null, "USD$" },
                    { "f67b03df-f705-4276-a74d-f87e9b81492e", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(850), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "f8a8c633-dd3a-4ea9-a780-13396de6d903", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(880), false, "currency2", null, null, "EUR$" },
                    { "f962c4c4-f466-4e35-b5de-ba6aaf456923", "System", new DateTime(2023, 10, 27, 15, 17, 8, 826, DateTimeKind.Local).AddTicks(840), false, "PhoneNumber", null, null, "+994513004484" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af1f61f1-d86b-4249-be2f-4f7a5b6c1c82", "4f18dd5b-3242-4700-9c18-55053e21f8d0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8ff757ef-cb02-4336-b7af-6c551ff8d660", "964ae7f1-53a3-44d6-ba73-8fcc7d09dca6" });
        }
    }
}
