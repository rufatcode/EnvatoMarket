using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AddCatagoryNameColumnCategotyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "CatagoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CatagoryName",
                table: "Categories");

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
        }
    }
}
