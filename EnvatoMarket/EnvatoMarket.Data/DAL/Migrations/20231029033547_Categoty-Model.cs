using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class CategotyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dbef8aa-3e45-4ab9-9d63-95d54c914574");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2fb5820-ffe2-4f64-b248-d024537f5a9a", "39164a35-c093-405f-b2a7-ba45bc27d3c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a972cdc-f95e-422b-9225-412864eda6ae", "5f9456e8-be42-4703-813d-cf9c485ccb1a" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "043ef68c-a273-46d6-ab39-34ec2bc0cea3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "105e2481-4368-41da-b887-a1520a7a0b3d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "15be1877-2079-4c60-8a2c-2d1b526de8a3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "20a886db-1075-474f-8fa6-6fc62fe09722");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3ad2ffed-c014-4fdd-b6f2-7ea9243a53cb");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4d5abb53-80f9-4ac5-b115-856ee9a762df");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5d2640f8-6098-4912-aed7-ccb77c56d833");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "6f171b63-8614-4843-8272-f7af2e242b94");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "85331695-9ae4-49b0-b5bc-432dff5c5e06");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "b224073b-2d22-4c12-b682-7ab56485af12");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d13f72c2-2ecc-4e5c-9512-de9b3d3facf2");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "e96c06c9-b1dc-4109-ae89-97ee55b7e5d1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f1d5100f-546b-4f66-88c5-6d192f2deb6f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "f7cc72ef-017c-4afd-b2e7-1afd461afa4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a972cdc-f95e-422b-9225-412864eda6ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2fb5820-ffe2-4f64-b248-d024537f5a9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39164a35-c093-405f-b2a7-ba45bc27d3c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f9456e8-be42-4703-813d-cf9c485ccb1a");

            migrationBuilder.RenameColumn(
                name: "CatagoryName",
                table: "Categories",
                newName: "CategoryName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "CatagoryName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4dbef8aa-3e45-4ab9-9d63-95d54c914574", "c97f5acd-5e8b-4a43-bf5f-ef9f9b35753b", "User", "USER" },
                    { "9a972cdc-f95e-422b-9225-412864eda6ae", "bd34b627-b4f9-48c2-8347-ccf61f008990", "SupperAdmin", "SUPPERADMIN" },
                    { "c2fb5820-ffe2-4f64-b248-d024537f5a9a", "c85792a8-556c-4d56-915f-5960f3efa448", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "39164a35-c093-405f-b2a7-ba45bc27d3c4", 0, "System", "8f1335ad-342c-4d0f-9f67-78aa705c0f5c", new DateTime(2023, 10, 29, 7, 31, 17, 521, DateTimeKind.Local).AddTicks(310), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEF94ompodu9SEnMUyInrveu1LjEehx/pEc0at7o6jkyRbLjq/pR/SOc6Hlx6FmV99g==", "+994513004484", true, null, null, "fabba85d-cc87-474c-9808-5b4358794698", false, null, "RufatCode" },
                    { "5f9456e8-be42-4703-813d-cf9c485ccb1a", 0, "System", "2a47a571-8fd6-4d59-b2cb-360cc2f4583a", new DateTime(2023, 10, 29, 7, 31, 17, 521, DateTimeKind.Local).AddTicks(340), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEIWLgnuiZsTaJo+f2ty9IOz0Zv742kurfgL+gVJVwVKE7mWfs1A1lOA73D7QGRN44g==", "+994513004484", true, null, null, "c79aa197-b275-4c37-8863-e78e143bfe4e", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "043ef68c-a273-46d6-ab39-34ec2bc0cea3", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(500), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "105e2481-4368-41da-b887-a1520a7a0b3d", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(550), false, "Language2", null, null, "Franch" },
                    { "15be1877-2079-4c60-8a2c-2d1b526de8a3", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(480), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "20a886db-1075-474f-8fa6-6fc62fe09722", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(500), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "3ad2ffed-c014-4fdd-b6f2-7ea9243a53cb", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(520), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "4d5abb53-80f9-4ac5-b115-856ee9a762df", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(510), false, "Payment", null, null, "payment.png" },
                    { "5d2640f8-6098-4912-aed7-ccb77c56d833", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(470), false, "Logo", null, null, "logo.png" },
                    { "6f171b63-8614-4843-8272-f7af2e242b94", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(470), false, "Hotline", null, null, "+48 500 500 500" },
                    { "85331695-9ae4-49b0-b5bc-432dff5c5e06", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(530), false, "currency1", null, null, "USD$" },
                    { "b224073b-2d22-4c12-b682-7ab56485af12", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(540), false, "Language1", null, null, "English" },
                    { "d13f72c2-2ecc-4e5c-9512-de9b3d3facf2", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(560), false, "Flag2", null, null, "2.jpg" },
                    { "e96c06c9-b1dc-4109-ae89-97ee55b7e5d1", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(530), false, "currency2", null, null, "EUR$" },
                    { "f1d5100f-546b-4f66-88c5-6d192f2deb6f", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(490), false, "PhoneNumber", null, null, "+994513004484" },
                    { "f7cc72ef-017c-4afd-b2e7-1afd461afa4a", "System", new DateTime(2023, 10, 29, 7, 31, 17, 524, DateTimeKind.Local).AddTicks(560), false, "Flag1", null, null, "1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c2fb5820-ffe2-4f64-b248-d024537f5a9a", "39164a35-c093-405f-b2a7-ba45bc27d3c4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9a972cdc-f95e-422b-9225-412864eda6ae", "5f9456e8-be42-4703-813d-cf9c485ccb1a" });
        }
    }
}
