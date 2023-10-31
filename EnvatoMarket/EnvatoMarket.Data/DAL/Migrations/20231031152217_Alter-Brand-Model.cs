using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AlterBrandModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "116ab76a-bb74-4f31-9d99-94176af16d6d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1551afba-409f-4b30-8f61-26b38f6dffad", "46533fbf-1ef4-4099-b994-a0e25ad08ecf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9be348e2-acde-4039-9901-cf2c0b88a217", "5ae80f56-a257-4c98-916d-1aaf19fa0460" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1031104a-0f0a-4cc6-82bc-41636e2ad297");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2f25cf98-d0f2-46fe-9c98-1cfa88d83c68");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3befebbe-3000-4ea1-a0fb-2f65b5d3126d");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3d6838c2-fd3f-4953-8285-8898dd0f5ab3");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "7f10c907-2f63-4c40-a936-8be3429f5f4f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8fcc6f59-bc0f-4fe2-81af-c3176a34c4db");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "96842835-83e3-490b-bdbd-a8e578dd55b9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a502301f-1ab4-41ed-a6ac-a0a20db922e9");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c5664d71-a22c-419a-a5c2-bef61d4b2b49");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d3f46e9b-4f90-478c-a01f-f3a4066e5a40");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d87992bf-0b98-4f1d-9361-8bdc944183e8");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "db67af74-dae3-4ece-a603-453b7d632c43");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "debeb58e-6f51-40b5-81b4-d21570dd2999");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "edef1f93-4ab2-438d-b47b-65e643ba8fb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1551afba-409f-4b30-8f61-26b38f6dffad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be348e2-acde-4039-9901-cf2c0b88a217");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46533fbf-1ef4-4099-b994-a0e25ad08ecf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ae80f56-a257-4c98-916d-1aaf19fa0460");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "223cfc5c-99a2-4c69-ae6d-e056a8b5919c", "edb100b4-93e3-4db0-844e-7fb9d18ab597", "User", "USER" },
                    { "56806c2e-c095-4fd1-abb3-c60938af8884", "000a237d-e7a8-4296-8ead-3c2430391cb4", "Admin", "ADMIN" },
                    { "dec07f4c-b59e-47ec-a105-a6183a2b24f0", "66103e9d-ae3c-46b9-ba69-2e5368a43520", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca", 0, "System", "5cf09031-dbbd-46fe-986c-255a2568b675", new DateTime(2023, 10, 31, 19, 22, 17, 68, DateTimeKind.Local).AddTicks(1540), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEJnF9q6x7AlSoaAc2zA+HgLK2vNjuSwMZEJuJEhrLzxBF1rSuGP9jk6yuB4k7v+V5Q==", "+994513004484", true, null, null, "565d88c6-bb10-4a4e-a3be-79bb31ee11e1", false, null, "RufatCode" },
                    { "c2a19149-d453-412c-b753-50be308a9e08", 0, "System", "09456434-25b8-4933-a518-3c778b708b64", new DateTime(2023, 10, 31, 19, 22, 17, 68, DateTimeKind.Local).AddTicks(1580), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEAC9Z7eMzY3GpHa8oBQn6cBTf6yNgPtQsk6U45BdpTvNEtKwjZVIvmJLQIUByBRvKA==", "+994513004484", true, null, null, "49401c03-f530-4343-8936-407103412a50", false, null, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "02864753-8021-42f1-be4d-5cb160e44fb1", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1050), false, "Hotline", null, null, "+48 500 500 500" },
                    { "033573fd-ab60-4aa1-b9a0-6132dc536c1f", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1130), false, "Flag1", null, null, "1.jpg" },
                    { "3157f4eb-a11b-4d37-b51b-ba2c12354f2b", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1070), false, "PhoneNumber", null, null, "+994513004484" },
                    { "348e7387-0ad8-4b8b-855a-5797cc0cbac1", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1090), false, "Payment", null, null, "payment.png" },
                    { "4560aaa6-386b-468d-b1a3-c7ecff23e22b", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1100), false, "currency1", null, null, "USD$" },
                    { "462795e8-b68a-4559-9c43-5e6566e65304", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1090), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "4b960752-c99a-4f98-b931-e0cf0585feb5", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1120), false, "Language2", null, null, "Franch" },
                    { "5ecc1c44-7c58-407b-aad6-34fbb297330e", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1130), false, "Flag2", null, null, "2.jpg" },
                    { "8e68ac2f-1201-4a5a-a727-8db131b86d12", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1070), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "9a22248f-ad7b-401c-9f56-0ea1060dc970", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1110), false, "currency2", null, null, "EUR$" },
                    { "a61fac6b-344a-4c19-ad7b-e8198c3d694a", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1060), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "c41787c5-429f-432f-b1e9-276655d6d1ae", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1050), false, "Logo", null, null, "logo.png" },
                    { "d1928f56-77e8-4421-ad50-8728edf658ed", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1080), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "d93963f5-051c-40e1-aabe-6853e65d87ec", "System", new DateTime(2023, 10, 31, 19, 22, 17, 71, DateTimeKind.Local).AddTicks(1110), false, "Language1", null, null, "English" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "56806c2e-c095-4fd1-abb3-c60938af8884", "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dec07f4c-b59e-47ec-a105-a6183a2b24f0", "c2a19149-d453-412c-b753-50be308a9e08" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "223cfc5c-99a2-4c69-ae6d-e056a8b5919c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "56806c2e-c095-4fd1-abb3-c60938af8884", "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dec07f4c-b59e-47ec-a105-a6183a2b24f0", "c2a19149-d453-412c-b753-50be308a9e08" });

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "02864753-8021-42f1-be4d-5cb160e44fb1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "033573fd-ab60-4aa1-b9a0-6132dc536c1f");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "3157f4eb-a11b-4d37-b51b-ba2c12354f2b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "348e7387-0ad8-4b8b-855a-5797cc0cbac1");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4560aaa6-386b-468d-b1a3-c7ecff23e22b");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "462795e8-b68a-4559-9c43-5e6566e65304");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "4b960752-c99a-4f98-b931-e0cf0585feb5");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "5ecc1c44-7c58-407b-aad6-34fbb297330e");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "8e68ac2f-1201-4a5a-a727-8db131b86d12");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "9a22248f-ad7b-401c-9f56-0ea1060dc970");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "a61fac6b-344a-4c19-ad7b-e8198c3d694a");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "c41787c5-429f-432f-b1e9-276655d6d1ae");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d1928f56-77e8-4421-ad50-8728edf658ed");

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "d93963f5-051c-40e1-aabe-6853e65d87ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56806c2e-c095-4fd1-abb3-c60938af8884");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dec07f4c-b59e-47ec-a105-a6183a2b24f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37cfbb75-ded6-4899-b2d2-03d4ba48a1ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2a19149-d453-412c-b753-50be308a9e08");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Brands");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "116ab76a-bb74-4f31-9d99-94176af16d6d", "bb6e6f16-731e-4ece-a444-43c85506f574", "User", "USER" },
                    { "1551afba-409f-4b30-8f61-26b38f6dffad", "e5b9af61-6cdf-4db4-a281-33d02a63fa11", "SupperAdmin", "SUPPERADMIN" },
                    { "9be348e2-acde-4039-9901-cf2c0b88a217", "e447bdf5-e982-499c-b3e0-1533066ddb41", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "46533fbf-1ef4-4099-b994-a0e25ad08ecf", 0, "System", "374f7136-00e1-438d-9e96-fb8d5f8cf723", new DateTime(2023, 10, 31, 17, 59, 27, 692, DateTimeKind.Local).AddTicks(3960), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEMQ/okfJmMO8hZVard7/KCYqiza4I+h5f0QQgcsdo/38PTyfhZxH5R7bCAmRG6wh7Q==", "+994513004484", true, null, null, "d7c397f3-1848-4db1-8464-eacea95d5dcc", false, null, "Rufat_2003" },
                    { "5ae80f56-a257-4c98-916d-1aaf19fa0460", 0, "System", "2212af32-903d-43c2-beb9-ba5c4cd39f5a", new DateTime(2023, 10, 31, 17, 59, 27, 692, DateTimeKind.Local).AddTicks(3920), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEDIi8Qd7ct40JO/CMYe9LfoLHy8P4pjQd6kMqbAp+1A2LLptHLndcdLPnXFyh9nalQ==", "+994513004484", true, null, null, "fcf90c4f-3cdc-4650-baec-044142fce72c", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "AddedBy", "Created", "IsDeleted", "Key", "Removed", "Updated", "Value" },
                values: new object[,]
                {
                    { "1031104a-0f0a-4cc6-82bc-41636e2ad297", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4250), false, "PhoneNumber", null, null, "+994513004484" },
                    { "2f25cf98-d0f2-46fe-9c98-1cfa88d83c68", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4260), false, "Email", null, null, "rufatri@code.edu.az" },
                    { "3befebbe-3000-4ea1-a0fb-2f65b5d3126d", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4290), false, "currency2", null, null, "EUR$" },
                    { "3d6838c2-fd3f-4953-8285-8898dd0f5ab3", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4320), false, "Flag2", null, null, "2.jpg" },
                    { "7f10c907-2f63-4c40-a936-8be3429f5f4f", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4300), false, "Language1", null, null, "English" },
                    { "8fcc6f59-bc0f-4fe2-81af-c3176a34c4db", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4300), false, "Language2", null, null, "Franch" },
                    { "96842835-83e3-490b-bdbd-a8e578dd55b9", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4240), false, "Location", null, null, "45 Grand Central Terminal New York,NY 1017 United State USA" },
                    { "a502301f-1ab4-41ed-a6ac-a0a20db922e9", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4230), false, "Hotline", null, null, "+48 500 500 500" },
                    { "c5664d71-a22c-419a-a5c2-bef61d4b2b49", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4310), false, "Flag1", null, null, "1.jpg" },
                    { "d3f46e9b-4f90-478c-a01f-f3a4066e5a40", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4280), false, "CompanyEmail", null, null, "rft.smayilov@bk.ru" },
                    { "d87992bf-0b98-4f1d-9361-8bdc944183e8", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4260), false, "Work Time", null, null, "Mon-Sat 9:00pm - 5:00pm Sun:Closed" },
                    { "db67af74-dae3-4ece-a603-453b7d632c43", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4280), false, "currency1", null, null, "USD$" },
                    { "debeb58e-6f51-40b5-81b4-d21570dd2999", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4270), false, "Payment", null, null, "payment.png" },
                    { "edef1f93-4ab2-438d-b47b-65e643ba8fb2", "System", new DateTime(2023, 10, 31, 17, 59, 27, 695, DateTimeKind.Local).AddTicks(4240), false, "Logo", null, null, "logo.png" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1551afba-409f-4b30-8f61-26b38f6dffad", "46533fbf-1ef4-4099-b994-a0e25ad08ecf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9be348e2-acde-4039-9901-cf2c0b88a217", "5ae80f56-a257-4c98-916d-1aaf19fa0460" });
        }
    }
}
