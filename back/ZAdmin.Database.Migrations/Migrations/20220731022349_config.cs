using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_config",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "名称")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "编码")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true, comment: "属性值")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SysFlag = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true, comment: "是否是系统参数")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Remark = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "备注")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态"),
                    GroupCode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "常量所属分类的编码")
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
                    table.PrimaryKey("PK_sys_config", x => x.Id);
                },
                comment: "参数配置表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "sys_config",
                columns: new[] { "Id", "Code", "CreatedTime", "CreatedUserId", "CreatedUserName", "GroupCode", "IsDeleted", "Name", "Remark", "Status", "SysFlag", "UpdatedTime", "UpdatedUserId", "UpdatedUserName", "Value" },
                values: new object[,]
                {
                    { 142307070902342L, "DILON_JWT_SECRET", null, null, null, "DEFAULT", false, "jwt密钥", "（重要）jwt密钥，默认为空，自行设置", 0, "Y", null, null, null, "xiaonuo" },
                    { 142307070902343L, "DILON_DEFAULT_PASSWORD", null, null, null, "DEFAULT", false, "默认密码", "默认密码", 0, "Y", null, null, null, "123456" },
                    { 142307070902344L, "DILON_TOKEN_EXPIRE", null, null, null, "DEFAULT", false, "token过期时间", "token过期时间（单位：秒）", 0, "Y", null, null, null, "86400" },
                    { 142307070902345L, "DILON_SESSION_EXPIRE", null, null, null, "DEFAULT", false, "session会话过期时间", "session会话过期时间（单位：秒）", 0, "Y", null, null, null, "7200" },
                    { 142307070902346L, "DILON_ALIYUN_SMS_ACCESSKEY_ID", null, null, null, "ALIYUN_SMS", false, "阿里云短信keyId", "阿里云短信keyId", 0, "Y", null, null, null, "你的keyId" },
                    { 142307070902347L, "DILON_ALIYUN_SMS_ACCESSKEY_SECRET", null, null, null, "ALIYUN_SMS", false, "阿里云短信secret", "阿里云短信secret", 0, "Y", null, null, null, "你的secret" },
                    { 142307070902348L, "DILON_ALIYUN_SMS_SIGN_NAME", null, null, null, "ALIYUN_SMS", false, "阿里云短信签名", "阿里云短信签名", 0, "Y", null, null, null, "你的签名" },
                    { 142307070902349L, "DILON_ALIYUN_SMS_LOGIN_TEMPLATE_CODE", null, null, null, "ALIYUN_SMS", false, "阿里云短信-登录模板号", "阿里云短信-登录模板号", 0, "Y", null, null, null, "SMS_1877123456" },
                    { 142307070902350L, "DILON_ALIYUN_SMS_INVALIDATE_MINUTES", null, null, null, "ALIYUN_SMS", false, "阿里云短信默认失效时间", "阿里云短信默认失效时间（单位：分钟）", 0, "Y", null, null, null, "5" },
                    { 142307070902351L, "DILON_TENCENT_SMS_SECRET_ID", null, null, null, "TENCENT_SMS", false, "腾讯云短信secretId", "腾讯云短信secretId", 0, "Y", null, null, null, "你的secretId" },
                    { 142307070902352L, "DILON_TENCENT_SMS_SECRET_KEY", null, null, null, "TENCENT_SMS", false, "腾讯云短信secretKey", "腾讯云短信secretKey", 0, "Y", null, null, null, "你的secretkey" },
                    { 142307070902353L, "DILON_TENCENT_SMS_SDK_APP_ID", null, null, null, "TENCENT_SMS", false, "腾讯云短信sdkAppId", "腾讯云短信sdkAppId", 0, "Y", null, null, null, "1400375123" },
                    { 142307070902354L, "DILON_TENCENT_SMS_SIGN", null, null, null, "TENCENT_SMS", false, "腾讯云短信签名", "腾讯云短信签名", 0, "Y", null, null, null, "你的签名" },
                    { 142307070902355L, "DILON_EMAIL_HOST", null, null, null, "EMAIL", false, "邮箱host", "邮箱host", 0, "Y", null, null, null, "smtp.126.com" },
                    { 142307070902356L, "DILON_EMAIL_USERNAME", null, null, null, "EMAIL", false, "邮箱用户名", "邮箱用户名", 0, "Y", null, null, null, "test@126.com" },
                    { 142307070902357L, "DILON_EMAIL_PASSWORD", null, null, null, "EMAIL", false, "邮箱密码", "邮箱密码", 0, "Y", null, null, null, "你的邮箱密码" },
                    { 142307070902358L, "DILON_EMAIL_PORT", null, null, null, "EMAIL", false, "邮箱端口", "邮箱端口", 0, "Y", null, null, null, "465" },
                    { 142307070902359L, "DILON_EMAIL_SSL", null, null, null, "EMAIL", false, "邮箱是否开启ssl", "邮箱是否开启ssl", 0, "Y", null, null, null, "true" },
                    { 142307070902360L, "DILON_EMAIL_FROM", null, null, null, "EMAIL", false, "邮箱发件人", "邮箱发件人", 0, "Y", null, null, null, "test@126.com" },
                    { 142307070902361L, "DILON_FILE_UPLOAD_PATH_FOR_WINDOWS", null, null, null, "FILE_PATH", false, "Win本地上传文件路径", "Win本地上传文件路径", 0, "Y", null, null, null, "D:/tmp" },
                    { 142307070902362L, "DILON_FILE_UPLOAD_PATH_FOR_LINUX", null, null, null, "FILE_PATH", false, "Linux/Mac本地上传文件路径", "Linux/Mac本地上传文件路径", 0, "Y", null, null, null, "/tmp" },
                    { 142307070902363L, "DILON_UN_XSS_FILTER_URL", null, null, null, "DEFAULT", false, "放开XSS过滤的接口", "多个url可以用英文逗号隔开", 0, "Y", null, null, null, "/demo/xssfilter,/demo/unxss" },
                    { 142307070902364L, "DILON_ENABLE_SINGLE_LOGIN", null, null, null, "DEFAULT", false, "单用户登陆的开关", "true-打开，false-关闭，如果一个人登录两次，就会将上一次登陆挤下去", 0, "Y", null, null, null, "false" },
                    { 142307070902365L, "DILON_CAPTCHA_OPEN", null, null, null, "DEFAULT", false, "登录验证码的开关", "true-打开，false-关闭", 0, "Y", null, null, null, "true" },
                    { 142307070902366L, "DILON_DRUID_USERNAME", null, null, null, "DEFAULT", false, "Druid监控登录账号", "Druid监控登录账号", 0, "Y", null, null, null, "superAdmin" },
                    { 142307070902367L, "DILON_DRUID_PASSWORD", null, null, null, "DEFAULT", false, "Druid监控界面登录密码", "Druid监控界面登录密码", 0, "Y", null, null, null, "123456" },
                    { 142307070902368L, "DILON_IP_GEO_API", null, null, null, "DEFAULT", false, "阿里云定位api接口地址", "阿里云定位api接口地址", 0, "Y", null, null, null, "http://api01.aliyun.venuscn.com/ip?ip=%s" },
                    { 142307070902369L, "DILON_IP_GEO_APP_CODE", null, null, null, "DEFAULT", false, "阿里云定位appCode", "阿里云定位appCode", 0, "Y", null, null, null, "461535aabeae4f34861884d392f5d452" },
                    { 142307070902370L, "DILON_ENABLE_OAUTH_LOGIN", null, null, null, "OAUTH", false, "Oauth用户登录的开关", "Oauth用户登录的开关", 0, "Y", null, null, null, "true" },
                    { 142307070902371L, "DILON_OAUTH_GITEE_CLIENT_ID", null, null, null, "OAUTH", false, "Oauth码云登录ClientId", "Oauth码云登录ClientId", 0, "Y", null, null, null, "你的clientId" },
                    { 142307070902372L, "DILON_OAUTH_GITEE_CLIENT_SECRET", null, null, null, "OAUTH", false, "Oauth码云登录ClientSecret", "Oauth码云登录ClientSecret", 0, "Y", null, null, null, "你的clientSecret" },
                    { 142307070902373L, "DILON_OAUTH_GITEE_REDIRECT_URI", null, null, null, "OAUTH", false, "Oauth码云登录回调地址", "Oauth码云登录回调地址", 0, "Y", null, null, null, "http://127.0.0.1:5566/oauth/callback/gitee" },
                    { 142307070902374L, "DILON_DEMO_ENV_FLAG", null, null, null, "DEFAULT", false, "演示环境", "演示环境的开关,true-打开，false-关闭，如果演示环境开启，则只能读数据不能写数据", 0, "Y", null, null, null, "false" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_config");
        }
    }
}
