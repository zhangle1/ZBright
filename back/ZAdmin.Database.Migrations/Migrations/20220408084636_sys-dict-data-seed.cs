using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class sysdictdataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sys_dict_type",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "名称")
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
                    table.PrimaryKey("PK_sys_dict_type", x => x.Id);
                },
                comment: "字典类型表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sys_dict_data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "Id主键"),
                    TypeId = table.Column<long>(type: "bigint", nullable: false, comment: "字典类型Id"),
                    Value = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "值")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "编码")
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
                    table.PrimaryKey("PK_sys_dict_data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sys_dict_data_sys_dict_type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "sys_dict_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "字典值表")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "sys_dict_type",
                columns: new[] { "Id", "Code", "CreatedTime", "CreatedUserId", "CreatedUserName", "IsDeleted", "Name", "Remark", "Sort", "Status", "UpdatedTime", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 142307070906483L, "common_status", null, null, null, false, "通用状态", "通用状态", 100, 0, null, null, null },
                    { 142307070906484L, "sex", null, null, null, false, "性别", "性别字典", 100, 0, null, null, null },
                    { 142307070906485L, "consts_type", null, null, null, false, "常量的分类", "常量的分类，用于区别一组配置", 100, 0, null, null, null },
                    { 142307070906486L, "yes_or_no", null, null, null, false, "是否", "是否", 100, 0, null, null, null },
                    { 142307070906487L, "vis_type", null, null, null, false, "访问类型", "访问类型", 100, 0, null, null, null },
                    { 142307070906488L, "menu_type", null, null, null, false, "菜单类型", "菜单类型", 100, 0, null, null, null },
                    { 142307070906489L, "send_type", null, null, null, false, "发送类型", "发送类型", 100, 0, null, null, null },
                    { 142307070906490L, "open_type", null, null, null, false, "打开方式", "打开方式", 100, 0, null, null, null },
                    { 142307070906491L, "menu_weight", null, null, null, false, "菜单权重", "菜单权重", 100, 0, null, null, null },
                    { 142307070906492L, "data_scope_type", null, null, null, false, "数据范围类型", "数据范围类型", 100, 0, null, null, null },
                    { 142307070906493L, "sms_send_source", null, null, null, false, "短信发送来源", "短信发送来源", 100, 0, null, null, null },
                    { 142307070906494L, "op_type", null, null, null, false, "操作类型", "操作类型", 100, 0, null, null, null },
                    { 142307070906495L, "file_storage_location", null, null, null, false, "文件存储位置", "文件存储位置", 100, 0, null, null, null },
                    { 142307070910533L, "run_status", null, null, null, false, "运行状态", "定时任务运行状态", 100, 0, null, null, null },
                    { 142307070910534L, "notice_type", null, null, null, false, "通知公告类型", "通知公告类型", 100, 0, null, null, null },
                    { 142307070910535L, "notice_status", null, null, null, false, "通知公告状态", "通知公告状态", 100, 0, null, null, null },
                    { 142307070910536L, "yes_true_false", null, null, null, false, "是否boolean", "是否boolean", 100, 0, null, null, null },
                    { 142307070910537L, "code_gen_create_type", null, null, null, false, "代码生成方式", "代码生成方式", 100, 0, null, null, null },
                    { 142307070910538L, "request_type", null, null, null, false, "请求方式", "请求方式", 100, 0, null, null, null },
                    { 142307070922827L, "code_gen_effect_type", null, null, null, false, "代码生成作用类型", "代码生成作用类型", 100, 0, null, null, null },
                    { 142307070922828L, "code_gen_query_type", null, null, null, false, "代码生成查询类型", "代码生成查询类型", 100, 0, null, null, null },
                    { 142307070922829L, "code_gen_net_type", null, null, null, false, "代码生成.NET类型", "代码生成.NET类型", 100, 0, null, null, null },
                    { 142307070926941L, "role_type", null, null, null, false, "角色类型", "角色类型", 100, 0, null, null, null },
                    { 142307070926942L, "org_type", null, null, null, false, "机构类型", "机构类型", 100, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "sys_dict_data",
                columns: new[] { "Id", "Code", "CreatedTime", "CreatedUserId", "CreatedUserName", "IsDeleted", "Remark", "Sort", "Status", "TypeId", "UpdatedTime", "UpdatedUserId", "UpdatedUserName", "Value" },
                values: new object[,]
                {
                    { 142307070902375L, "1", null, null, null, false, "男性", 100, 0, 142307070906484L, null, null, null, "男" },
                    { 142307070902376L, "2", null, null, null, false, "女性", 100, 0, 142307070906484L, null, null, null, "女" },
                    { 142307070902377L, "3", null, null, null, false, "未知性别", 100, 0, 142307070906484L, null, null, null, "未知" },
                    { 142307070902378L, "DEFAULT", null, null, null, false, "默认常量，都以XIAONUO_开头的", 100, 0, 142307070906485L, null, null, null, "默认常量" },
                    { 142307070902379L, "ALIYUN_SMS", null, null, null, false, "阿里云短信配置", 100, 0, 142307070906485L, null, null, null, "阿里云短信" },
                    { 142307070902380L, "TENCENT_SMS", null, null, null, false, "腾讯云短信", 100, 0, 142307070906485L, null, null, null, "腾讯云短信" },
                    { 142307070902381L, "EMAIL", null, null, null, false, "邮件配置", 100, 0, 142307070906485L, null, null, null, "邮件配置" },
                    { 142307070902382L, "FILE_PATH", null, null, null, false, "文件上传路径", 100, 0, 142307070906485L, null, null, null, "文件上传路径" },
                    { 142307070902383L, "OAUTH", null, null, null, false, "Oauth配置", 100, 0, 142307070906485L, null, null, null, "Oauth配置" },
                    { 142307070902384L, "0", null, null, null, false, "正常", 100, 0, 142307070906483L, null, null, null, "正常" },
                    { 142307070902385L, "1", null, null, null, false, "停用", 100, 0, 142307070906483L, null, null, null, "停用" },
                    { 142307070902386L, "2", null, null, null, false, "删除", 100, 0, 142307070906483L, null, null, null, "删除" },
                    { 142307070902387L, "N", null, null, null, false, "否", 100, 0, 142307070906486L, null, null, null, "否" },
                    { 142307070902388L, "Y", null, null, null, false, "是", 100, 0, 142307070906486L, null, null, null, "是" },
                    { 142307070902389L, "1", null, null, null, false, "登录", 100, 0, 142307070906487L, null, null, null, "登录" },
                    { 142307070902390L, "2", null, null, null, false, "登出", 100, 0, 142307070906487L, null, null, null, "登出" },
                    { 142307070902391L, "0", null, null, null, false, "目录", 100, 0, 142307070906488L, null, null, null, "目录" },
                    { 142307070902392L, "1", null, null, null, false, "菜单", 100, 0, 142307070906488L, null, null, null, "菜单" },
                    { 142307070902393L, "2", null, null, null, false, "按钮", 100, 0, 142307070906488L, null, null, null, "按钮" },
                    { 142307070902394L, "0", null, null, null, false, "未发送", 100, 0, 142307070906489L, null, null, null, "未发送" },
                    { 142307070902395L, "1", null, null, null, false, "发送成功", 100, 0, 142307070906489L, null, null, null, "发送成功" },
                    { 142307070902396L, "2", null, null, null, false, "发送失败", 100, 0, 142307070906489L, null, null, null, "发送失败" },
                    { 142307070902397L, "3", null, null, null, false, "失效", 100, 0, 142307070906489L, null, null, null, "失效" },
                    { 142307070902398L, "0", null, null, null, false, "无", 100, 0, 142307070906490L, null, null, null, "无" },
                    { 142307070902399L, "1", null, null, null, false, "组件", 100, 0, 142307070906490L, null, null, null, "组件" },
                    { 142307070906437L, "2", null, null, null, false, "内链", 100, 0, 142307070906490L, null, null, null, "内链" },
                    { 142307070906438L, "3", null, null, null, false, "外链", 100, 0, 142307070906490L, null, null, null, "外链" },
                    { 142307070906439L, "1", null, null, null, false, "系统权重", 100, 0, 142307070906491L, null, null, null, "系统权重" },
                    { 142307070906440L, "2", null, null, null, false, "业务权重", 100, 0, 142307070906491L, null, null, null, "业务权重" },
                    { 142307070906441L, "1", null, null, null, false, "全部数据", 100, 0, 142307070906492L, null, null, null, "全部数据" },
                    { 142307070906442L, "2", null, null, null, false, "本部门及以下数据", 100, 0, 142307070906492L, null, null, null, "本部门及以下数据" },
                    { 142307070906443L, "3", null, null, null, false, "本部门数据", 100, 0, 142307070906492L, null, null, null, "本部门数据" },
                    { 142307070906444L, "4", null, null, null, false, "仅本人数据", 100, 0, 142307070906492L, null, null, null, "仅本人数据" },
                    { 142307070906445L, "5", null, null, null, false, "自定义数据", 100, 0, 142307070906492L, null, null, null, "自定义数据" },
                    { 142307070906446L, "1", null, null, null, false, "app", 100, 0, 142307070906493L, null, null, null, "app" },
                    { 142307070906447L, "2", null, null, null, false, "pc", 100, 0, 142307070906493L, null, null, null, "pc" },
                    { 142307070906448L, "3", null, null, null, false, "其他", 100, 0, 142307070906493L, null, null, null, "其他" },
                    { 142307070906449L, "0", null, null, null, false, "其它", 100, 0, 142307070906494L, null, null, null, "其它" },
                    { 142307070906450L, "1", null, null, null, false, "增加", 100, 0, 142307070906494L, null, null, null, "增加" },
                    { 142307070906451L, "2", null, null, null, false, "删除", 100, 0, 142307070906494L, null, null, null, "删除" },
                    { 142307070906452L, "3", null, null, null, false, "编辑", 100, 0, 142307070906494L, null, null, null, "编辑" },
                    { 142307070906453L, "4", null, null, null, false, "更新", 100, 0, 142307070906494L, null, null, null, "更新" },
                    { 142307070906454L, "5", null, null, null, false, "查询", 100, 0, 142307070906494L, null, null, null, "查询" },
                    { 142307070906455L, "6", null, null, null, false, "详情", 100, 0, 142307070906494L, null, null, null, "详情" },
                    { 142307070906456L, "7", null, null, null, false, "树", 100, 0, 142307070906494L, null, null, null, "树" },
                    { 142307070906457L, "8", null, null, null, false, "导入", 100, 0, 142307070906494L, null, null, null, "导入" },
                    { 142307070906458L, "9", null, null, null, false, "导出", 100, 0, 142307070906494L, null, null, null, "导出" },
                    { 142307070906459L, "10", null, null, null, false, "授权", 100, 0, 142307070906494L, null, null, null, "授权" },
                    { 142307070906460L, "11", null, null, null, false, "强退", 100, 0, 142307070906494L, null, null, null, "强退" },
                    { 142307070906461L, "12", null, null, null, false, "清空", 100, 0, 142307070906494L, null, null, null, "清空" },
                    { 142307070906462L, "13", null, null, null, false, "修改状态", 100, 0, 142307070906494L, null, null, null, "修改状态" },
                    { 142307070906463L, "1", null, null, null, false, "阿里云", 100, 0, 142307070906495L, null, null, null, "阿里云" },
                    { 142307070906464L, "2", null, null, null, false, "腾讯云", 100, 0, 142307070906495L, null, null, null, "腾讯云" },
                    { 142307070906465L, "3", null, null, null, false, "minio", 100, 0, 142307070906495L, null, null, null, "minio" },
                    { 142307070906466L, "4", null, null, null, false, "本地", 100, 0, 142307070906495L, null, null, null, "本地" },
                    { 142307070906467L, "1", null, null, null, false, "运行", 100, 0, 142307070910533L, null, null, null, "运行" },
                    { 142307070906468L, "2", null, null, null, false, "停止", 100, 0, 142307070910533L, null, null, null, "停止" },
                    { 142307070906469L, "1", null, null, null, false, "通知", 100, 0, 142307070910534L, null, null, null, "通知" },
                    { 142307070906470L, "2", null, null, null, false, "公告", 100, 0, 142307070910534L, null, null, null, "公告" },
                    { 142307070906471L, "0", null, null, null, false, "草稿", 100, 0, 142307070910535L, null, null, null, "草稿" },
                    { 142307070906472L, "1", null, null, null, false, "发布", 100, 0, 142307070910535L, null, null, null, "发布" },
                    { 142307070906473L, "2", null, null, null, false, "撤回", 100, 0, 142307070910535L, null, null, null, "撤回" },
                    { 142307070906474L, "3", null, null, null, false, "删除", 100, 0, 142307070910535L, null, null, null, "删除" },
                    { 142307070906475L, "true", null, null, null, false, "是", 100, 0, 142307070910536L, null, null, null, "是" },
                    { 142307070906476L, "false", null, null, null, false, "否", 100, 0, 142307070910536L, null, null, null, "否" },
                    { 142307070906477L, "1", null, null, null, false, "下载压缩包", 100, 0, 142307070910537L, null, null, null, "下载压缩包" },
                    { 142307070906478L, "2", null, null, null, false, "生成到本项目", 100, 0, 142307070910537L, null, null, null, "生成到本项目" },
                    { 142307070906479L, "1", null, null, null, false, "GET", 100, 0, 142307070910538L, null, null, null, "GET" },
                    { 142307070906480L, "2", null, null, null, false, "POST", 100, 0, 142307070910538L, null, null, null, "POST" },
                    { 142307070906481L, "3", null, null, null, false, "PUT", 100, 0, 142307070910538L, null, null, null, "PUT" },
                    { 142307070906482L, "4", null, null, null, false, "DELETE", 100, 0, 142307070910538L, null, null, null, "DELETE" },
                    { 142307070922829L, "fk", null, null, null, false, "外键", 100, 0, 142307070922827L, null, null, null, "外键" },
                    { 142307070922830L, "input", null, null, null, false, "输入框", 100, 0, 142307070922827L, null, null, null, "输入框" },
                    { 142307070922831L, "datepicker", null, null, null, false, "时间选择", 100, 0, 142307070922827L, null, null, null, "时间选择" },
                    { 142307070922832L, "select", null, null, null, false, "下拉框", 100, 0, 142307070922827L, null, null, null, "下拉框" },
                    { 142307070922833L, "radio", null, null, null, false, "单选框", 100, 0, 142307070922827L, null, null, null, "单选框" },
                    { 142307070922834L, "switch", null, null, null, false, "开关", 100, 0, 142307070922827L, null, null, null, "开关" },
                    { 142307070922835L, "checkbox", null, null, null, false, "多选框", 100, 0, 142307070922827L, null, null, null, "多选框" },
                    { 142307070922836L, "inputnumber", null, null, null, false, "数字输入框", 100, 0, 142307070922827L, null, null, null, "数字输入框" },
                    { 142307070922837L, "textarea", null, null, null, false, "文本域", 100, 0, 142307070922827L, null, null, null, "文本域" },
                    { 142307070922838L, "==", null, null, null, false, "等于", 1, 0, 142307070922828L, null, null, null, "等于" },
                    { 142307070922839L, "like", null, null, null, false, "模糊", 2, 0, 142307070922828L, null, null, null, "模糊" },
                    { 142307070922840L, ">", null, null, null, false, "大于", 3, 0, 142307070922828L, null, null, null, "大于" },
                    { 142307070922841L, "<", null, null, null, false, "小于", 4, 0, 142307070922828L, null, null, null, "小于" },
                    { 142307070922842L, "!=", null, null, null, false, "不等于", 5, 0, 142307070922828L, null, null, null, "不等于" },
                    { 142307070922843L, ">=", null, null, null, false, "大于等于", 6, 0, 142307070922828L, null, null, null, "大于等于" },
                    { 142307070922844L, "<=", null, null, null, false, "小于等于", 7, 0, 142307070922828L, null, null, null, "小于等于" },
                    { 142307070922845L, "isNotNull", null, null, null, false, "不为空", 8, 0, 142307070922828L, null, null, null, "不为空" },
                    { 142307070922846L, "long", null, null, null, false, "long", 100, 0, 142307070922829L, null, null, null, "long" },
                    { 142307070922847L, "string", null, null, null, false, "string", 100, 0, 142307070922829L, null, null, null, "string" },
                    { 142307070922848L, "DateTime", null, null, null, false, "DateTime", 100, 0, 142307070922829L, null, null, null, "DateTime" },
                    { 142307070922850L, "bool", null, null, null, false, "bool", 100, 0, 142307070922829L, null, null, null, "bool" },
                    { 142307070922851L, "int", null, null, null, false, "int", 100, 0, 142307070922829L, null, null, null, "int" },
                    { 142307070922852L, "double", null, null, null, false, "double", 100, 0, 142307070922829L, null, null, null, "double" },
                    { 142307070922861L, "float", null, null, null, false, "float", 100, 0, 142307070922829L, null, null, null, "float" },
                    { 142307070922862L, "decimal", null, null, null, false, "decimal", 100, 0, 142307070922829L, null, null, null, "decimal" },
                    { 142307070922863L, "Guid", null, null, null, false, "Guid", 100, 0, 142307070922829L, null, null, null, "Guid" },
                    { 142307070922864L, "DateTimeOffset", null, null, null, false, "DateTimeOffset", 100, 0, 142307070922829L, null, null, null, "DateTimeOffset" },
                    { 142307070926943L, "0", null, null, null, false, "集团角色", 100, 0, 142307070926941L, null, null, null, "集团角色" },
                    { 142307070926944L, "1", null, null, null, false, "加盟商角色", 100, 0, 142307070926941L, null, null, null, "加盟商角色" },
                    { 142307070926945L, "2", null, null, null, false, "门店角色", 100, 0, 142307070926941L, null, null, null, "门店角色" },
                    { 142307070926946L, "1", null, null, null, false, "一级", 100, 0, 142307070926942L, null, null, null, "一级" },
                    { 142307070926947L, "2", null, null, null, false, "二级", 100, 0, 142307070926942L, null, null, null, "二级" },
                    { 142307070926948L, "3", null, null, null, false, "三级", 100, 0, 142307070926942L, null, null, null, "三级" },
                    { 142307070926949L, "4", null, null, null, false, "四级", 100, 0, 142307070926942L, null, null, null, "四级" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_sys_dict_data_TypeId",
                table: "sys_dict_data",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sys_dict_data");

            migrationBuilder.DropTable(
                name: "sys_dict_type");
        }
    }
}
