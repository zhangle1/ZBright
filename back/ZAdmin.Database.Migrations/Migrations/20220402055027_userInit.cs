using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class userInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_menu",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Pid = table.Column<long>(type: "bigint", nullable: false, comment: "父Id"),
                    Pids = table.Column<string>(type: "longtext", nullable: true, comment: "父Ids")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "编码")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "菜单类型"),
                    Icon = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "图标")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Router = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "路由地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Component = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "组件地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Permission = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "权限标识")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Application = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "应用分类")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OpenType = table.Column<int>(type: "int", nullable: false, comment: "打开方式"),
                    Visible = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true, comment: "是否可见")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Link = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "内链地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Redirect = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "重定向地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<int>(type: "int", nullable: false, comment: "权重"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    Remark = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "备注")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "创建时间"),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "更新时间"),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "创建者Id"),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "创建者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "修改者Id"),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "修改者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_menu", x => x.Id);
                },
                comment: "菜单表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_org",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Pid = table.Column<long>(type: "bigint", nullable: false, comment: "父Id"),
                    Pids = table.Column<string>(type: "longtext", nullable: true, comment: "父Ids")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "编码")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contacts = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "联系人")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "电话")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    Remark = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "备注")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态"),
                    OrgType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "创建时间"),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "更新时间"),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "创建者Id"),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "创建者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "修改者Id"),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "修改者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_org", x => x.Id);
                },
                comment: "组织机构表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_role",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "编码")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    DataScopeType = table.Column<int>(type: "int", nullable: false, comment: "数据范围类型"),
                    Remark = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "备注")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态"),
                    RoleType = table.Column<int>(type: "int", nullable: false, comment: "角色类型-集团角色_0、加盟商角色_1、门店角色_2"),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "创建时间"),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "更新时间"),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "创建者Id"),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "创建者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "修改者Id"),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "修改者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_role", x => x.Id);
                },
                comment: "角色表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_user",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Account = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "账号")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "密码")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NickName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "昵称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "姓名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Avatar = table.Column<string>(type: "longtext", nullable: true, comment: "头像")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthday = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "生日"),
                    Sex = table.Column<int>(type: "int", nullable: false, comment: "性别-男_1、女_2"),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "邮箱")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "手机")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "电话")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastLoginIp = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "最后登录IP")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastLoginTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "最后登录时间"),
                    AdminType = table.Column<int>(type: "int", nullable: false, comment: "管理员类型-超级管理员_1、管理员_2、普通账号_3"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态-正常_0、停用_1、删除_2"),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "创建时间"),
                    UpdatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "更新时间"),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "创建者Id"),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "创建者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedUserId = table.Column<long>(type: "bigint", nullable: true, comment: "修改者Id"),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "修改者名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, comment: "软删除标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_user", x => x.Id);
                },
                comment: "用户表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_role_data_scope",
                columns: table => new
                {
                    SysRoleId = table.Column<long>(type: "bigint", nullable: false, comment: "角色Id"),
                    SysOrgId = table.Column<long>(type: "bigint", nullable: false, comment: "机构Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_role_data_scope", x => new { x.SysRoleId, x.SysOrgId });
                    table.ForeignKey(
                        name: "FK_sys_role_data_scope_sys_org_SysOrgId",
                        column: x => x.SysOrgId,
                        principalTable: "sys_org",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_role_data_scope_sys_role_SysRoleId",
                        column: x => x.SysRoleId,
                        principalTable: "sys_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "角色数据范围表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_role_menu",
                columns: table => new
                {
                    SysRoleId = table.Column<long>(type: "bigint", nullable: false, comment: "角色Id"),
                    SysMenuId = table.Column<long>(type: "bigint", nullable: false, comment: "菜单Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_role_menu", x => new { x.SysRoleId, x.SysMenuId });
                    table.ForeignKey(
                        name: "FK_sys_role_menu_sys_menu_SysMenuId",
                        column: x => x.SysMenuId,
                        principalTable: "sys_menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_role_menu_sys_role_SysRoleId",
                        column: x => x.SysRoleId,
                        principalTable: "sys_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "角色菜单表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_user_data_scope",
                columns: table => new
                {
                    SysUserId = table.Column<long>(type: "bigint", nullable: false, comment: "用户Id"),
                    SysOrgId = table.Column<long>(type: "bigint", nullable: false, comment: "机构Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_user_data_scope", x => new { x.SysUserId, x.SysOrgId });
                    table.ForeignKey(
                        name: "FK_sys_user_data_scope_sys_org_SysOrgId",
                        column: x => x.SysOrgId,
                        principalTable: "sys_org",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_user_data_scope_sys_user_SysUserId",
                        column: x => x.SysUserId,
                        principalTable: "sys_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "用户数据范围表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_user_role",
                columns: table => new
                {
                    SysUserId = table.Column<long>(type: "bigint", nullable: false, comment: "用户Id"),
                    SysRoleId = table.Column<long>(type: "bigint", nullable: false, comment: "角色Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_user_role", x => new { x.SysUserId, x.SysRoleId });
                    table.ForeignKey(
                        name: "FK_sys_user_role_sys_role_SysRoleId",
                        column: x => x.SysRoleId,
                        principalTable: "sys_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_user_role_sys_user_SysUserId",
                        column: x => x.SysUserId,
                        principalTable: "sys_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "用户角色表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_sys_role_data_scope_SysOrgId",
                table: "sys_role_data_scope",
                column: "SysOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_role_menu_SysMenuId",
                table: "sys_role_menu",
                column: "SysMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_user_data_scope_SysOrgId",
                table: "sys_user_data_scope",
                column: "SysOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_user_role_SysRoleId",
                table: "sys_user_role",
                column: "SysRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_role_data_scope");

            migrationBuilder.DropTable(
                name: "sys_role_menu");

            migrationBuilder.DropTable(
                name: "sys_user_data_scope");

            migrationBuilder.DropTable(
                name: "sys_user_role");

            migrationBuilder.DropTable(
                name: "sys_menu");

            migrationBuilder.DropTable(
                name: "sys_org");

            migrationBuilder.DropTable(
                name: "sys_role");

            migrationBuilder.DropTable(
                name: "sys_user");
        }
    }
}
