using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class seedsysAppData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "sys_app",
                columns: new[] { "Id", "Active", "Code", "CreatedTime", "CreatedUserId", "CreatedUserName", "IsDeleted", "Name", "Sort", "Status", "UpdatedTime", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 142307070898245L, "Y", "system", null, null, null, false, "平台管理", 100, 0, null, null, null },
                    { 142307070902341L, "N", "manage", null, null, null, false, "系统管理", 300, 0, null, null, null },
                    { 142307070922826L, "N", "platform", null, null, null, false, "运营管理", 200, 0, null, null, null },
                    { 142307070922869L, "N", "busiapp", null, null, null, false, "业务应用", 400, 0, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sys_app",
                keyColumn: "Id",
                keyValue: 142307070898245L);

            migrationBuilder.DeleteData(
                table: "sys_app",
                keyColumn: "Id",
                keyValue: 142307070902341L);

            migrationBuilder.DeleteData(
                table: "sys_app",
                keyColumn: "Id",
                keyValue: 142307070922826L);

            migrationBuilder.DeleteData(
                table: "sys_app",
                keyColumn: "Id",
                keyValue: 142307070922869L);
        }
    }
}
