using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class log : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_log_audit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "表名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColumnName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "列名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NewValue = table.Column<string>(type: "longtext", nullable: true, comment: "新值")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OldValue = table.Column<string>(type: "longtext", nullable: true, comment: "旧值")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "操作时间"),
                    UserId = table.Column<long>(type: "bigint", nullable: false, comment: "操作人Id"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "操作人名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Operate = table.Column<int>(type: "int", nullable: false, comment: "操作方式"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_log_audit", x => x.Id);
                },
                comment: "审计日志表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_log_ex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Account = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "操作人")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "类名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MethodName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "方法名")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExceptionName = table.Column<string>(type: "longtext", nullable: true, comment: "异常名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExceptionMsg = table.Column<string>(type: "longtext", nullable: true, comment: "异常信息")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExceptionSource = table.Column<string>(type: "longtext", nullable: true, comment: "异常源")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StackTrace = table.Column<string>(type: "longtext", nullable: true, comment: "堆栈信息")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParamsObj = table.Column<string>(type: "longtext", nullable: true, comment: "参数对象")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExceptionTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "异常时间"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_log_ex", x => x.Id);
                },
                comment: "异常日志表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_log_op",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Success = table.Column<int>(type: "int", nullable: false, comment: "是否执行成功"),
                    Message = table.Column<string>(type: "longtext", nullable: true, comment: "具体消息")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ip = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "IP")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true, comment: "地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Browser = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "浏览器")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Os = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "操作系统")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "请求地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "类名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MethodName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "方法名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReqMethod = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, comment: "请求方式")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Param = table.Column<string>(type: "longtext", nullable: true, comment: "请求参数")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Result = table.Column<string>(type: "longtext", nullable: true, comment: "返回结果")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ElapsedTime = table.Column<long>(type: "bigint", nullable: false, comment: "耗时"),
                    OpTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "操作时间"),
                    Account = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "操作人")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_log_op", x => x.Id);
                },
                comment: "操作日志表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_log_vis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Success = table.Column<int>(type: "int", nullable: false, comment: "是否执行成功"),
                    Message = table.Column<string>(type: "longtext", nullable: true, comment: "具体消息")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ip = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, comment: "IP")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true, comment: "地址")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Browser = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "浏览器")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Os = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "操作系统")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VisType = table.Column<int>(type: "int", nullable: false, comment: "访问类型"),
                    VisTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true, comment: "访问时间"),
                    Account = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "访问人")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sys_log_vis", x => x.Id);
                },
                comment: "访问日志表")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_log_audit");

            migrationBuilder.DropTable(
                name: "sys_log_ex");

            migrationBuilder.DropTable(
                name: "sys_log_op");

            migrationBuilder.DropTable(
                name: "sys_log_vis");
        }
    }
}
