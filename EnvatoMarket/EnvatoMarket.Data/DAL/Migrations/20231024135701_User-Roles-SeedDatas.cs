using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvatoMarket.DAL.Migrations
{
    public partial class UserRolesSeedDatas : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11152a9b-b923-4fd5-a826-426b27386e77", "d3592aad-0134-49d9-83c4-707c1f5b171e", "Admin", "ADMIN" },
                    { "428eb54d-0e6b-47a4-92c3-b1fede867d15", "c06a97b2-ea21-490d-89d7-34191bf3325f", "SupperAdmin", "SUPPERADMIN" },
                    { "54426e5b-a207-43ad-aab6-455e4bffa45f", "2064bfdd-4691-48a8-8704-b973e9b1d8fc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c3a0857-9869-4ac3-bf3e-46a250632ea9", 0, "a293291c-0e93-4eaa-997c-93a9b58b5b7e", "rufatri@code.edu.az", true, "Rufat Azerbaijan", true, false, null, "RUFATRI@CODE.EDU.AZ", "RUFATCODE", "AQAAAAEAACcQAAAAEK0R7HQszmC5pyTlbt8zFDV8Gs07EPIjPFEjfJqEwXZMjv6KezEy61ZPyf+2dse6GA==", "+994513004484", true, null, "40f9836b-2b94-455c-869b-9a631d5bf3b2", false, "RufatCode" },
                    { "54412fe9-790b-4b48-8d02-c561afcbe23d", 0, "bf3ba913-3bf8-4df8-80d3-42071faaa066", "rft.smayilov@bk.ru", true, "Rufat Code", true, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT_2003", "AQAAAAEAACcQAAAAEH02E4DrGOFmM//RrmYu+sLD6m+6hHA0fLq6zq7AtNNV+WQqP4XjBx/rAe31V4Q2+Q==", "+994513004484", true, null, "6f76cb75-b8ee-4015-bdaa-d0bc51fcb2dd", false, "Rufat_2003" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11152a9b-b923-4fd5-a826-426b27386e77", "2c3a0857-9869-4ac3-bf3e-46a250632ea9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "428eb54d-0e6b-47a4-92c3-b1fede867d15", "54412fe9-790b-4b48-8d02-c561afcbe23d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54426e5b-a207-43ad-aab6-455e4bffa45f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11152a9b-b923-4fd5-a826-426b27386e77", "2c3a0857-9869-4ac3-bf3e-46a250632ea9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "428eb54d-0e6b-47a4-92c3-b1fede867d15", "54412fe9-790b-4b48-8d02-c561afcbe23d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11152a9b-b923-4fd5-a826-426b27386e77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "428eb54d-0e6b-47a4-92c3-b1fede867d15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c3a0857-9869-4ac3-bf3e-46a250632ea9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54412fe9-790b-4b48-8d02-c561afcbe23d");

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
