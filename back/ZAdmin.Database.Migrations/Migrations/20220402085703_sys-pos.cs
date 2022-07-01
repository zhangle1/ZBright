using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class syspos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_emp",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "用户Id"),
                    JobNum = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, comment: "工号")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrgId = table.Column<long>(type: "bigint", nullable: false, comment: "机构Id"),
                    OrgName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "机构名称")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_emp", x => x.Id);
                },
                comment: "员工表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_pos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "编码")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    Remark = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "备注")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态"),
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
                    table.PrimaryKey("PK_sys_pos", x => x.Id);
                },
                comment: "职位表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_emp_ext_org_pos",
                columns: table => new
                {
                    SysEmpId = table.Column<long>(type: "bigint", nullable: false, comment: "员工Id"),
                    SysOrgId = table.Column<long>(type: "bigint", nullable: false, comment: "机构Id"),
                    SysPosId = table.Column<long>(type: "bigint", nullable: false, comment: "职位Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_emp_ext_org_pos", x => new { x.SysEmpId, x.SysOrgId, x.SysPosId });
                    table.ForeignKey(
                        name: "FK_sys_emp_ext_org_pos_sys_emp_SysEmpId",
                        column: x => x.SysEmpId,
                        principalTable: "sys_emp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_emp_ext_org_pos_sys_org_SysOrgId",
                        column: x => x.SysOrgId,
                        principalTable: "sys_org",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_emp_ext_org_pos_sys_pos_SysPosId",
                        column: x => x.SysPosId,
                        principalTable: "sys_pos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "员工附属机构职位表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_emp_pos",
                columns: table => new
                {
                    SysEmpId = table.Column<long>(type: "bigint", nullable: false, comment: "员工Id"),
                    SysPosId = table.Column<long>(type: "bigint", nullable: false, comment: "职位Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_emp_pos", x => new { x.SysEmpId, x.SysPosId });
                    table.ForeignKey(
                        name: "FK_sys_emp_pos_sys_emp_SysEmpId",
                        column: x => x.SysEmpId,
                        principalTable: "sys_emp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sys_emp_pos_sys_pos_SysPosId",
                        column: x => x.SysPosId,
                        principalTable: "sys_pos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "员工职位表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_sys_emp_ext_org_pos_SysOrgId",
                table: "sys_emp_ext_org_pos",
                column: "SysOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_emp_ext_org_pos_SysPosId",
                table: "sys_emp_ext_org_pos",
                column: "SysPosId");

            migrationBuilder.CreateIndex(
                name: "IX_sys_emp_pos_SysPosId",
                table: "sys_emp_pos",
                column: "SysPosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_emp_ext_org_pos");

            migrationBuilder.DropTable(
                name: "sys_emp_pos");

            migrationBuilder.DropTable(
                name: "sys_emp");

            migrationBuilder.DropTable(
                name: "sys_pos");
        }
    }
}
