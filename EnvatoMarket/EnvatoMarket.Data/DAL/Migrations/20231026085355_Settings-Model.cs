using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class SettingsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4ace3f9-34a6-4acb-aa58-a32c940062c2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b641bc20-8276-4cfd-97ca-243ca0e87851", "964ce9dd-5320-42b4-8b74-5a4337b21f89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1fbddfc1-5f33-4fa8-9372-592db298fd61", "ca5c7e1d-4248-4537-b0d5-bce7a6ca901e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fbddfc1-5f33-4fa8-9372-592db298fd61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b641bc20-8276-4cfd-97ca-243ca0e87851");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "964ce9dd-5320-42b4-8b74-5a4337b21f89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca5c7e1d-4248-4537-b0d5-bce7a6ca901e");

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Removed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46e482b2-cf21-414d-9003-cc18ee4d225a", "f4638bd2-53f9-43bd-abb6-3c8074942ad3", "SupperAdmin", "SUPPERADMIN" },
                    { "5a3f90b3-f45f-42aa-b533-69159a70cfc6", "c508d51a-02dd-418f-89b3-5d305aab0d27", "Admin", "ADMIN" },
                    { "e5fb6f7b-7859-47c9-a8b2-575da33a53dc", "5f432bb6-61c2-45ae-bf29-d7b465190662", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "40a2ad00-eb30-4bf1-8714-c7aadd809ecf", 0, "System", "2296f78f-7592-476d-961c-07d92f4801ce", new DateTime(2023, 10, 26, 12, 53, 55, 269, DateTimeKind.Local).AddTicks(9510), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEOWEvqLaZF29pTph1p1Aa9bRbVOaLTS8BlRCnIiDHKp4XUE5rgkpn2SbYNuNQCaHzA==", "+994513004484", true, null, null, "935b9700-5914-4a79-983c-6a01e604ee52", false, null, "Rufat_2003" },
                    { "f45774a2-6135-4920-8368-60683c496bf6", 0, "System", "93a9405c-9046-469f-803e-dd776a707e63", new DateTime(2023, 10, 26, 12, 53, 55, 269, DateTimeKind.Local).AddTicks(9470), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEHBxR6eya2YvBeHLdEPwDbGhKY0cMhNLlOOZ7Ses2YgHtEVjf0IQ8+GKU/P6xDDOGA==", "+994513004484", true, null, null, "bee73742-0189-419d-b6cd-4b4778317c57", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46e482b2-cf21-414d-9003-cc18ee4d225a", "40a2ad00-eb30-4bf1-8714-c7aadd809ecf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a3f90b3-f45f-42aa-b533-69159a70cfc6", "f45774a2-6135-4920-8368-60683c496bf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5fb6f7b-7859-47c9-a8b2-575da33a53dc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46e482b2-cf21-414d-9003-cc18ee4d225a", "40a2ad00-eb30-4bf1-8714-c7aadd809ecf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a3f90b3-f45f-42aa-b533-69159a70cfc6", "f45774a2-6135-4920-8368-60683c496bf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46e482b2-cf21-414d-9003-cc18ee4d225a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a3f90b3-f45f-42aa-b533-69159a70cfc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40a2ad00-eb30-4bf1-8714-c7aadd809ecf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f45774a2-6135-4920-8368-60683c496bf6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fbddfc1-5f33-4fa8-9372-592db298fd61", "cdace586-b704-41f0-93a3-d59b2ac2d2df", "Admin", "ADMIN" },
                    { "b641bc20-8276-4cfd-97ca-243ca0e87851", "384ef174-dfc7-4ccc-bb63-a476676bb6b6", "SupperAdmin", "SUPPERADMIN" },
                    { "f4ace3f9-34a6-4acb-aa58-a32c940062c2", "819a0534-70b3-4876-a157-f37e205e3d7d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddedBy", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Removed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { "964ce9dd-5320-42b4-8b74-5a4337b21f89", 0, "System", "4a183837-5d6b-483a-a3e8-64be4a05c8e5", new DateTime(2023, 10, 25, 19, 18, 53, 706, DateTimeKind.Local).AddTicks(6400), "rft.smayilov@bk.ru", true, "Rufat Code", true, false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEOzr2IH6/2NewlSQVUXlD3Li/0R+5AdFd1APNyp1DOP9IQOUj0DVCYUQ927t/szz0A==", "+994513004484", true, null, null, "a1b8ac5f-d05c-405d-8ab8-a20863f45b98", false, null, "Rufat_2003" },
                    { "ca5c7e1d-4248-4537-b0d5-bce7a6ca901e", 0, "System", "cede1c50-852d-418a-bc6d-509beb4b6aae", new DateTime(2023, 10, 25, 19, 18, 53, 706, DateTimeKind.Local).AddTicks(6370), "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEBg8CfdSfjgtgdhPGCms8RD56YseNJR2qgnLCuedrGHPoYDgMGZhOEmpRuW14UIDqw==", "+994513004484", true, null, null, "0e042ac4-f80c-4843-995d-6e0230622d81", false, null, "RufatCode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b641bc20-8276-4cfd-97ca-243ca0e87851", "964ce9dd-5320-42b4-8b74-5a4337b21f89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1fbddfc1-5f33-4fa8-9372-592db298fd61", "ca5c7e1d-4248-4537-b0d5-bce7a6ca901e" });
        }
    }
}
