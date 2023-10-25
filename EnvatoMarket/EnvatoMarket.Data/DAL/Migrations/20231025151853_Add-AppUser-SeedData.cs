using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class AddAppUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Removed",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Removed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
