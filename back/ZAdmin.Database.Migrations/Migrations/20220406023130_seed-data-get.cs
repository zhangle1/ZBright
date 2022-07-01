using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAdmin.Database.Migrations.Migrations
{
    public partial class seeddataget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "sys_emp",
                columns: new[] { "Id", "JobNum", "OrgId", "OrgName" },
                values: new object[,]
                {
                    { 142307070910551L, "D1001", 142307070910539L, "华夏集团" },
                    { 142307070910552L, "D1002", 142307070910539L, "华夏集团" },
                    { 142307070910553L, "D1003", 142307070910539L, "华夏集团" },
                    { 142307070910554L, "D1001", 142307070910547L, "租户1公司" },
                    { 142307070910555L, "D1002", 142307070910547L, "租户1公司" },
                    { 142307070910556L, "D1003", 142307070910547L, "租户1公司" },
                    { 142307070910557L, "D1001", 142307070910548L, "租户2公司" },
                    { 142307070910558L, "D1002", 142307070910548L, "租户2公司" },
                    { 142307070910559L, "D1003", 142307070910548L, "租户2公司" }
                });

            migrationBuilder.InsertData(
                table: "sys_menu",
                columns: new[] { "Id", "Application", "Code", "Component", "CreatedTime", "CreatedUserId", "CreatedUserName", "Icon", "IsDeleted", "Link", "Name", "OpenType", "Permission", "Pid", "Pids", "Redirect", "Remark", "Router", "Sort", "Status", "Type", "UpdatedTime", "UpdatedUserId", "UpdatedUserName", "Visible", "Weight" },
                values: new object[,]
                {
                    { 142307000914633L, "manage", "sys_mgr", "PageView", null, null, null, "team", false, null, "组织架构", 0, null, 0L, "[0],", null, null, "/sys", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070910560L, "busiapp", "system_index", "RouteView", null, null, null, "home", false, null, "主控面板", 0, null, 0L, "[0],", "/analysis", null, "/", 1, 0, 0, null, null, null, "Y", 2 },
                    { 142307070910561L, "busiapp", "system_index_dashboard", "system/dashboard/Analysis", null, null, null, null, false, null, "分析页", 0, null, 142307070910560L, "[0],[142307070910560],", null, null, "analysis", 100, 0, 1, null, null, null, "Y", 2 },
                    { 142307070910562L, "busiapp", "system_index_workplace", "system/dashboard/Workplace", null, null, null, null, false, null, "工作台", 0, null, 142307070910560L, "[0],[142307070910560],", null, null, "workplace", 100, 0, 1, null, null, null, "Y", 2 },
                    { 142307070910563L, "manage", "auth_manager", "PageView", null, null, null, "safety-certificate", false, null, "权限管理", 0, null, 0L, "[0],", null, null, "/auth", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070910564L, "manage", "sys_user_mgr", "system/user/index", null, null, null, null, false, null, "用户管理", 1, null, 142307070910563L, "[0],[142307070910563],", null, null, "/mgr_user", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070910565L, "manage", "sys_user_mgr_page", null, null, null, null, null, false, null, "用户查询", 0, "sysUser:page", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910566L, "manage", "sys_user_mgr_edit", null, null, null, null, null, false, null, "用户编辑", 0, "sysUser:edit", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910567L, "manage", "sys_user_mgr_add", null, null, null, null, null, false, null, "用户增加", 0, "sysUser:add", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910568L, "manage", "sys_user_mgr_delete", null, null, null, null, null, false, null, "用户删除", 0, "sysUser:delete", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910569L, "manage", "sys_user_mgr_detail", null, null, null, null, null, false, null, "用户详情", 0, "sysUser:detail", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910570L, "manage", "sys_user_mgr_export", null, null, null, null, null, false, null, "用户导出", 0, "sysUser:export", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910571L, "manage", "sys_user_mgr_selector", null, null, null, null, null, false, null, "用户选择器", 0, "sysUser:selector", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910572L, "manage", "sys_user_mgr_grant_role", null, null, null, null, null, false, null, "用户授权角色", 0, "sysUser:grantRole", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910573L, "manage", "sys_user_mgr_own_role", null, null, null, null, null, false, null, "用户拥有角色", 0, "sysUser:ownRole", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910574L, "manage", "sys_user_mgr_grant_data", null, null, null, null, null, false, null, "用户授权数据", 0, "sysUser:grantData", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910575L, "manage", "sys_user_mgr_own_data", null, null, null, null, null, false, null, "用户拥有数据", 0, "sysUser:ownData", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910576L, "manage", "sys_user_mgr_update_info", null, null, null, null, null, false, null, "用户更新信息", 0, "sysUser:updateInfo", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910577L, "manage", "sys_user_mgr_update_pwd", null, null, null, null, null, false, null, "用户修改密码", 0, "sysUser:updatePwd", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910578L, "manage", "sys_user_mgr_change_status", null, null, null, null, null, false, null, "用户修改状态", 0, "sysUser:changeStatus", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910579L, "manage", "sys_user_mgr_update_avatar", null, null, null, null, null, false, null, "用户修改头像", 0, "sysUser:updateAvatar", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910580L, "manage", "sys_user_mgr_reset_pwd", null, null, null, null, null, false, null, "用户重置密码", 0, "sysUser:resetPwd", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910581L, "manage", "sys_org_mgr", "system/org/index", null, null, null, null, false, null, "机构管理", 1, null, 142307000914633L, "[0],[142307000914633],", null, null, "/org", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070910582L, "manage", "sys_org_mgr_page", null, null, null, null, null, false, null, "机构查询", 0, "sysOrg:page", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910583L, "manage", "sys_org_mgr_list", null, null, null, null, null, false, null, "机构列表", 0, "sysOrg:list", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910584L, "manage", "sys_org_mgr_add", null, null, null, null, null, false, null, "机构增加", 0, "sysOrg:add", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910585L, "manage", "sys_org_mgr_edit", null, null, null, null, null, false, null, "机构编辑", 0, "sysOrg:edit", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910586L, "manage", "sys_org_mgr_delete", null, null, null, null, null, false, null, "机构删除", 0, "sysOrg:delete", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910587L, "manage", "sys_org_mgr_detail", null, null, null, null, null, false, null, "机构详情", 0, "sysOrg:detail", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910588L, "manage", "sys_org_mgr_tree", null, null, null, null, null, false, null, "机构树", 0, "sysOrg:tree", 142307070910581L, "[0],[142307000914633],[142307070910581],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910589L, "manage", "sys_pos_mgr", "system/pos/index", null, null, null, null, false, null, "职位管理", 1, null, 142307000914633L, "[0],[142307000914633],", null, null, "/pos", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070910590L, "manage", "sys_pos_mgr_page", null, null, null, null, null, false, null, "职位查询", 0, "sysPos:page", 142307070910589L, "[0],[142307000914633],[142307070910589],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070910591L, "manage", "sys_pos_mgr_list", null, null, null, null, null, false, null, "职位列表", 0, "sysPos:list", 142307070910589L, "[0],[142307000914633],[142307070910589],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070911739L, "manage", "sys_log_mgr_ex_log", "system/log/exlog/index", null, null, null, null, false, null, "异常日志", 1, null, 142307070918732L, "[0],[142307070918732],", null, null, "/exlog", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070911740L, "manage", "sys_log_mgr_ex_log_page", null, null, null, null, null, false, null, "异常日志查询", 0, "sysExLog:page", 142307070911739L, "[0],[142307070918732],[142307070911739],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070911741L, "manage", "sys_log_mgr_ex_log_delete", null, null, null, null, null, false, null, "异常日志清空", 0, "sysExLog:delete", 142307070911739L, "[0],[142307070918732],[142307070911739],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914629L, "manage", "sys_pos_mgr_add", null, null, null, null, null, false, null, "职位增加", 0, "sysPos:add", 142307070910589L, "[0],[142307000914633],[142307070910589],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914630L, "manage", "sys_pos_mgr_edit", null, null, null, null, null, false, null, "职位编辑", 0, "sysPos:edit", 142307070910589L, "[0],[142307000914633],[142307070910589],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914631L, "manage", "sys_pos_mgr_delete", null, null, null, null, null, false, null, "职位删除", 0, "sysPos:delete", 142307070910589L, "[0],[142307000914633],[142307070910589],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914632L, "manage", "sys_pos_mgr_detail", null, null, null, null, null, false, null, "职位详情", 0, "sysPos:detail", 142307070910589L, "[0],[142307000914633],[142307070910589],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914633L, "system", "sys_platform", "PageView", null, null, null, "safety-certificate", false, null, "平台管理", 0, null, 0L, "[0],", null, null, "/platform", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070914634L, "system", "sys_app_mgr", "system/app/index", null, null, null, null, false, null, "应用管理", 1, null, 142307070914633L, "[0],[142307070914633],", null, null, "/app", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914635L, "system", "sys_app_mgr_page", null, null, null, null, null, false, null, "应用查询", 0, "sysApp:page", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914636L, "system", "sys_app_mgr_list", null, null, null, null, null, false, null, "应用列表", 0, "sysApp:list", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914637L, "system", "sys_app_mgr_add", null, null, null, null, null, false, null, "应用增加", 0, "sysApp:add", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914638L, "system", "sys_app_mgr_edit", null, null, null, null, null, false, null, "应用编辑", 0, "sysApp:edit", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914639L, "system", "sys_app_mgr_delete", null, null, null, null, null, false, null, "应用删除", 0, "sysApp:delete", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914640L, "system", "sys_app_mgr_detail", null, null, null, null, null, false, null, "应用详情", 0, "sysApp:detail", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914641L, "system", "sys_app_mgr_set_as_default", null, null, null, null, null, false, null, "设为默认应用", 0, "sysApp:setAsDefault", 142307070914634L, "[0],[142307070914633],[142307070914634],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914642L, "system", "sys_menu_mgr", "system/menu/index", null, null, null, null, false, null, "菜单管理", 1, null, 142307070914633L, "[0],[142307070914633],", null, null, "/menu", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914643L, "system", "sys_menu_mgr_list", null, null, null, null, null, false, null, "菜单列表", 0, "sysMenu:list", 142307070914642L, "[0],[142307070914633],[142307070914642],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914644L, "system", "sys_menu_mgr_add", null, null, null, null, null, false, null, "菜单增加", 0, "sysMenu:add", 142307070914642L, "[0],[142307070914633],[142307070914642],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914645L, "system", "sys_menu_mgr_edit", null, null, null, null, null, false, null, "菜单编辑", 0, "sysMenu:edit", 142307070914642L, "[0],[142307070914633],[142307070914642],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914646L, "system", "sys_menu_mgr_delete", null, null, null, null, null, false, null, "菜单删除", 0, "sysMenu:delete", 142307070914642L, "[0],[142307070914633],[142307070914642],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914647L, "system", "sys_menu_mgr_detail", null, null, null, null, null, false, null, "菜单详情", 0, "sysMenu:detail", 142307070914642L, "[0],[142307070914633],[142307070914642],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914648L, "manage", "sys_menu_mgr_grant_tree", null, null, null, null, null, false, null, "菜单授权树", 0, "sysMenu:treeForGrant", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914649L, "manage", "sys_menu_mgr_tree", null, null, null, null, null, false, null, "菜单树", 0, "sysMenu:tree", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914650L, "system", "sys_menu_mgr_change", null, null, null, null, null, false, null, "菜单切换", 0, "sysMenu:change", 142307070914642L, "[0],[142307070914633],[142307070914642],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914651L, "manage", "sys_role_mgr", "system/role/index", null, null, null, null, false, null, "角色管理", 1, null, 142307070910563L, "[0],[142307070910563],", null, null, "/role", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914652L, "manage", "sys_role_mgr_page", null, null, null, null, null, false, null, "角色查询", 0, "sysRole:page", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914653L, "manage", "sys_role_mgr_add", null, null, null, null, null, false, null, "角色增加", 0, "sysRole:add", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914654L, "manage", "sys_role_mgr_edit", null, null, null, null, null, false, null, "角色编辑", 0, "sysRole:edit", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914655L, "manage", "sys_role_mgr_delete", null, null, null, null, null, false, null, "角色删除", 0, "sysRole:delete", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914656L, "manage", "sys_role_mgr_detail", null, null, null, null, null, false, null, "角色详情", 0, "sysRole:detail", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914657L, "manage", "sys_role_mgr_drop_down", null, null, null, null, null, false, null, "角色下拉", 0, "sysRole:dropDown", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914658L, "manage", "sys_role_mgr_grant_menu", null, null, null, null, null, false, null, "角色授权菜单", 0, "sysRole:grantMenu", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914659L, "manage", "sys_role_mgr_own_menu", null, null, null, null, null, false, null, "角色拥有菜单", 0, "sysRole:ownMenu", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914660L, "manage", "sys_role_mgr_grant_data", null, null, null, null, null, false, null, "角色授权数据", 0, "sysRole:grantData", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914661L, "manage", "sys_role_mgr_own_data", null, null, null, null, null, false, null, "角色拥有数据", 0, "sysRole:ownData", 142307070914651L, "[0],[142307070910563],[142307070914651],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914662L, "system", "system_tools", "PageView", null, null, null, "euro", false, null, "开发管理", 0, null, 0L, "[0],", null, null, "/tools", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070914663L, "system", "system_tools_config", "system/config/index", null, null, null, null, false, null, "系统配置", 1, null, 142307070914662L, "[0],[142307070914662],", null, null, "/config", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914664L, "system", "system_tools_config_page", null, null, null, null, null, false, null, "配置查询", 0, "sysConfig:page", 142307070914663L, "[0],[142307070914662],[142307070914663],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914665L, "system", "system_tools_config_list", null, null, null, null, null, false, null, "配置列表", 0, "sysConfig:list", 142307070914663L, "[0],[142307070914662],[142307070914663],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914666L, "system", "system_tools_config_add", null, null, null, null, null, false, null, "配置增加", 0, "sysConfig:add", 142307070914663L, "[0],[142307070914662],[142307070914663],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914667L, "system", "system_tools_config_edit", null, null, null, null, null, false, null, "配置编辑", 0, "sysConfig:edit", 142307070914663L, "[0],[142307070914662],[142307070914663],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914668L, "system", "system_tools_config_delete", null, null, null, null, null, false, null, "配置删除", 0, "sysConfig:delete", 142307070914663L, "[0],[142307070914662],[142307070914663],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914669L, "system", "system_tools_config_detail", null, null, null, null, null, false, null, "配置详情", 0, "sysConfig:detail", 142307070914663L, "[0],[142307070914662],[142307070914663],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914671L, "system", "sys_email_mgr", "system/email/index", null, null, null, null, false, null, "邮件发送", 1, null, 142307070914662L, "[0],[142307070914662],", null, null, "/email", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914672L, "system", "sys_email_mgr_send_email", null, null, null, null, null, false, null, "发送文本邮件", 0, "email:sendEmail", 142307070914671L, "[0],[142307070914662],[142307070914671],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 }
                });

            migrationBuilder.InsertData(
                table: "sys_menu",
                columns: new[] { "Id", "Application", "Code", "Component", "CreatedTime", "CreatedUserId", "CreatedUserName", "Icon", "IsDeleted", "Link", "Name", "OpenType", "Permission", "Pid", "Pids", "Redirect", "Remark", "Router", "Sort", "Status", "Type", "UpdatedTime", "UpdatedUserId", "UpdatedUserName", "Visible", "Weight" },
                values: new object[,]
                {
                    { 142307070914673L, "system", "sys_email_mgr_send_email_html", null, null, null, null, null, false, null, "发送html邮件", 0, "email:sendEmailHtml", 142307070914671L, "[0],[142307070914662],[142307070914671],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914674L, "system", "sys_sms_mgr", "system/sms/index", null, null, null, null, false, null, "短信管理", 1, null, 142307070914662L, "[0],[142307070914662],", null, null, "/sms", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914675L, "system", "sys_sms_mgr_page", null, null, null, null, null, false, null, "短信发送查询", 0, "sms:page", 142307070914674L, "[0],[142307070914662],[142307070914674],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914676L, "system", "sys_sms_mgr_send_login_message", null, null, null, null, null, false, null, "发送验证码短信", 0, "sms:sendLoginMessage", 142307070914674L, "[0],[142307070914662],[142307070914674],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914677L, "system", "sys_sms_mgr_validate_message", null, null, null, null, null, false, null, "验证短信验证码", 0, "sms:validateMessage", 142307070914674L, "[0],[142307070914662],[142307070914674],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914678L, "system", "sys_dict_mgr", "system/dict/index", null, null, null, null, false, null, "字典管理", 1, null, 142307070914662L, "[0],[142307070914662],", null, null, "/dict", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070914679L, "system", "sys_dict_mgr_dict_type_page", null, null, null, null, null, false, null, "字典类型查询", 0, "sysDictType:page", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914680L, "system", "sys_dict_mgr_dict_type_list", null, null, null, null, null, false, null, "字典类型列表", 0, "sysDictType:list", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914681L, "system", "sys_dict_mgr_dict_type_add", null, null, null, null, null, false, null, "字典类型增加", 0, "sysDictType:add", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914682L, "system", "sys_dict_mgr_dict_type_delete", null, null, null, null, null, false, null, "字典类型删除", 0, "sysDictType:delete", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914683L, "system", "sys_dict_mgr_dict_type_edit", null, null, null, null, null, false, null, "字典类型编辑", 0, "sysDictType:edit", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914684L, "system", "sys_dict_mgr_dict_type_detail", null, null, null, null, null, false, null, "字典类型详情", 0, "sysDictType:detail", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914685L, "system", "sys_dict_mgr_dict_type_drop_down", null, null, null, null, null, false, null, "字典类型下拉", 0, "sysDictType:dropDown", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914686L, "system", "sys_dict_mgr_dict_type_change_status", null, null, null, null, null, false, null, "字典类型修改状态", 0, "sysDictType:changeStatus", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070914687L, "system", "sys_dict_mgr_dict_page", null, null, null, null, null, false, null, "字典值查询", 0, "sysDictData:page", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918725L, "system", "sys_dict_mgr_dict_list", null, null, null, null, null, false, null, "字典值列表", 0, "sysDictData:list", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918726L, "system", "sys_dict_mgr_dict_add", null, null, null, null, null, false, null, "字典值增加", 0, "sysDictData:add", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918727L, "system", "sys_dict_mgr_dict_delete", null, null, null, null, null, false, null, "字典值删除", 0, "sysDictData:delete", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918728L, "system", "sys_dict_mgr_dict_edit", null, null, null, null, null, false, null, "字典值编辑", 0, "sysDictData:edit", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918729L, "system", "sys_dict_mgr_dict_detail", null, null, null, null, null, false, null, "字典值详情", 0, "sysDictData:detail", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918730L, "system", "sys_dict_mgr_dict_change_status", null, null, null, null, null, false, null, "字典值修改状态", 0, "sysDictData:changeStatus", 142307070914678L, "[0],[142307070914662],[142307070914678],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918731L, "system", "sys_swagger_mgr", "Iframe", null, null, null, null, false, "http://localhost:5566/", "接口文档", 2, null, 142307070914662L, "[0],[142307070914662],", null, null, "/swagger", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918732L, "manage", "sys_log_mgr", "PageView", null, null, null, "read", false, null, "日志管理", 0, null, 0L, "[0],", null, null, "/log", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070918733L, "manage", "sys_log_mgr_vis_log", "system/log/vislog/index", null, null, null, null, false, null, "访问日志", 1, null, 142307070918732L, "[0],[142307070918732],", null, null, "/vislog", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918734L, "manage", "sys_log_mgr_vis_log_page", null, null, null, null, null, false, null, "访问日志查询", 0, "sysVisLog:page", 142307070918733L, "[0],[142307070918732],[142307070918733],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918735L, "manage", "sys_log_mgr_vis_log_delete", null, null, null, null, null, false, null, "访问日志清空", 0, "sysVisLog:delete", 142307070918733L, "[0],[142307070918732],[142307070918733],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918736L, "manage", "sys_log_mgr_op_log", "system/log/oplog/index", null, null, null, null, false, null, "操作日志", 1, null, 142307070918732L, "[0],[142307070918732],", null, null, "/oplog", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918737L, "manage", "sys_log_mgr_op_log_page", null, null, null, null, null, false, null, "操作日志查询", 0, "sysOpLog:page", 142307070918736L, "[0],[142307070918732],[142307070918736],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918738L, "manage", "sys_log_mgr_op_log_delete", null, null, null, null, null, false, null, "操作日志清空", 0, "sysOpLog:delete", 142307070918736L, "[0],[142307070918732],[142307070918736],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918739L, "system", "sys_monitor_mgr", "PageView", null, null, null, "deployment-unit", false, null, "系统监控", 0, null, 0L, "[0],", null, null, "/monitor", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070918740L, "system", "sys_monitor_mgr_machine_monitor", "system/machine/index", null, null, null, null, false, null, "服务监控", 1, null, 142307070918739L, "[0],[142307070918739],", null, null, "/machine", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918741L, "system", "sys_monitor_mgr_machine_monitor_query", null, null, null, null, null, false, null, "服务监控查询", 0, "sysMachine:query", 142307070918740L, "[0],[142307070918739],[142307070918740],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918742L, "system", "sys_monitor_mgr_online_user", "system/onlineUser/index", null, null, null, null, false, null, "在线用户", 1, null, 142307070918739L, "[0],[142307070918739],", null, null, "/onlineUser", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918743L, "system", "sys_monitor_mgr_online_user_page", null, null, null, null, null, false, null, "在线用户查询", 0, "sysOnlineUser:page", 142307070918742L, "[0],[142307070918739],[142307070918742],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918744L, "system", "sys_monitor_mgr_online_user_force_exist", null, null, null, null, null, false, null, "在线用户强退", 0, "sysOnlineUser:forceExist", 142307070918742L, "[0],[142307070918739],[142307070918742],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918745L, "system", "sys_monitor_mgr_druid", "Iframe", null, null, null, null, false, "http://localhost:82/druid/login.html", "数据监控", 2, null, 142307070918739L, "[0],[142307070918739],", null, null, "/druid", 100, 0, 1, null, null, null, "N", 1 },
                    { 142307070918746L, "manage", "sys_notice", "PageView", null, null, null, "sound", false, null, "通知公告", 0, null, 0L, "[0],", null, null, "/notice", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070918747L, "manage", "sys_notice_mgr", "system/notice/index", null, null, null, null, false, null, "公告管理", 1, null, 142307070918746L, "[0],[142307070918746],", null, null, "/notice", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918748L, "manage", "sys_notice_mgr_page", null, null, null, null, null, false, null, "公告查询", 0, "sysNotice:page", 142307070918747L, "[0],[142307070918746],[142307070918747],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918749L, "manage", "sys_notice_mgr_add", null, null, null, null, null, false, null, "公告增加", 0, "sysNotice:add", 142307070918747L, "[0],[142307070918746],[142307070918747],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918750L, "manage", "sys_notice_mgr_edit", null, null, null, null, null, false, null, "公告编辑", 0, "sysNotice:edit", 142307070918747L, "[0],[142307070918746],[142307070918747],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918751L, "manage", "sys_notice_mgr_delete", null, null, null, null, null, false, null, "公告删除", 0, "sysNotice:delete", 142307070918747L, "[0],[142307070918746],[142307070918747],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918752L, "manage", "sys_notice_mgr_detail", null, null, null, null, null, false, null, "公告查看", 0, "sysNotice:detail", 142307070918747L, "[0],[142307070918746],[142307070918747],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918753L, "manage", "sys_notice_mgr_changeStatus", null, null, null, null, null, false, null, "公告修改状态", 0, "sysNotice:changeStatus", 142307070918747L, "[0],[142307070918746],[142307070918747],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918754L, "manage", "sys_notice_mgr_received", "system/noticeReceived/index", null, null, null, null, false, null, "已收公告", 1, null, 142307070918746L, "[0],[142307070918746],", null, null, "/noticeReceived", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918755L, "manage", "sys_notice_mgr_received_page", null, null, null, null, null, false, null, "已收公告查询", 0, "sysNotice:received", 142307070918754L, "[0],[142307070918746],[142307070918754],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918756L, "manage", "sys_file_mgr", "PageView", null, null, null, "file", false, null, "文件管理", 0, null, 0L, "[0],", null, null, "/file", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070918757L, "manage", "sys_file_mgr_sys_file", "system/file/index", null, null, null, null, false, null, "系统文件", 1, null, 142307070918756L, "[0],[142307070918756],", null, null, "/file", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918758L, "manage", "sys_file_mgr_sys_file_page", null, null, null, null, null, false, null, "文件查询", 0, "sysFileInfo:page", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918759L, "manage", "sys_file_mgr_sys_file_list", null, null, null, null, null, false, null, "文件列表", 0, "sysFileInfo:list", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918760L, "manage", "sys_file_mgr_sys_file_delete", null, null, null, null, null, false, null, "文件删除", 0, "sysFileInfo:delete", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918761L, "manage", "sys_file_mgr_sys_file_detail", null, null, null, null, null, false, null, "文件详情", 0, "sysFileInfo:detail", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918762L, "manage", "sys_file_mgr_sys_file_upload", null, null, null, null, null, false, null, "文件上传", 0, "sysFileInfo:upload", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918763L, "manage", "sys_file_mgr_sys_file_download", null, null, null, null, null, false, null, "文件下载", 0, "sysFileInfo:download", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918764L, "manage", "sys_file_mgr_sys_file_preview", null, null, null, null, null, false, null, "图片预览", 0, "sysFileInfo:preview", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918765L, "system", "sys_timers", "PageView", null, null, null, "dashboard", false, null, "任务调度", 0, null, 0L, "[0],", null, null, "/timers", 100, 0, 0, null, null, null, "Y", 1 },
                    { 142307070918766L, "system", "sys_timers_mgr", "system/timers/index", null, null, null, null, false, null, "任务管理", 1, null, 142307070918765L, "[0],[142307070918765],", null, null, "/timers", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918767L, "system", "sys_timers_mgr_page", null, null, null, null, null, false, null, "定时任务查询", 0, "sysTimers:page", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918768L, "system", "sys_timers_mgr_list", null, null, null, null, null, false, null, "定时任务列表", 0, "sysTimers:list", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918769L, "system", "sys_timers_mgr_detail", null, null, null, null, null, false, null, "定时任务详情", 0, "sysTimers:detail", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918770L, "system", "sys_timers_mgr_add", null, null, null, null, null, false, null, "定时任务增加", 0, "sysTimers:add", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918771L, "system", "sys_timers_mgr_delete", null, null, null, null, null, false, null, "定时任务删除", 0, "sysTimers:delete", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918772L, "system", "sys_timers_mgr_edit", null, null, null, null, null, false, null, "定时任务编辑", 0, "sysTimers:edit", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918773L, "system", "sys_timers_mgr_get_action_classes", null, null, null, null, null, false, null, "定时任务可执行列表", 0, "sysTimers:getActionClasses", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918774L, "system", "sys_timers_mgr_start", null, null, null, null, null, false, null, "定时任务启动", 0, "sysTimers:start", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918775L, "system", "sys_timers_mgr_stop", null, null, null, null, null, false, null, "定时任务关闭", 0, "sysTimers:stop", 142307070918766L, "[0],[142307070918765],[142307070918766],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070918776L, "system", "code_gen", "gen/codeGenerate/index", null, null, null, "thunderbolt", false, null, "代码生成", 0, null, 0L, "[0],", null, null, "/codeGenerate/index", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918777L, "manage", "sys_user_mgr_login", null, null, null, null, null, false, null, "用户登录信息", 0, "getLoginUser", 142307070910564L, "[0],[142307070910563],[142307070910564],", null, null, null, 100, 1, 2, null, null, null, "N", 1 },
                    { 142307070918782L, "platform", "sys_tenant", "PageView", null, null, null, "switcher", false, null, "SaaS租户", 0, null, 0L, "[0],", null, null, "/tenant", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070918783L, "platform", "sys_tenant_mgr", "system/tenant/index", null, null, null, null, false, null, "租户管理", 1, null, 142307070918782L, "[0],[142307070918782],", null, null, "/tenant", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070922821L, "platform", "sys_tenant_mgr_page", null, null, null, null, null, false, null, "租户查询", 0, "sysTenant:page", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922822L, "platform", "sys_tenant_mgr_detail", null, null, null, null, null, false, null, "租户详情", 0, "sysTenant:detail", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922823L, "platform", "sys_tenant_mgr_add", null, null, null, null, null, false, null, "租户增加", 0, "sysTenant:add", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922824L, "platform", "sys_tenant_mgr_delete", null, null, null, null, null, false, null, "租户删除", 0, "sysTenant:delete", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922825L, "platform", "sys_tenant_mgr_edit", null, null, null, null, null, false, null, "租户编辑", 0, "sysTenant:edit", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922826L, "platform", "sys_tenant_mgr_grant_menu", null, null, null, null, null, false, null, "授权租户菜单", 0, "sysTenant:grantMenu", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922827L, "platform", "sys_tenant_mgr_reset_pwd", null, null, null, null, null, false, null, "重置租户密码", 0, "sysTenant:resetPwd", 142307070918783L, "[0],[142307070918782],[142307070918783],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922870L, "system", "form_design", "system/formDesign/index", null, null, null, "robot", false, null, "表单设计", 0, null, 0L, "[0],", null, null, "/formDesign/index", 100, 0, 1, null, null, null, "Y", 1 },
                    { 142307070922874L, "manage", "sys_file_mgr_sys_file_upload_avatar", null, null, null, null, null, false, null, "头像上传", 0, "sysFileInfo:uploadAvatar", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922875L, "manage", "sys_file_mgr_sys_file_upload_document", null, null, null, null, null, false, null, "文档上传", 0, "sysFileInfo:uploadDocument", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 }
                });

            migrationBuilder.InsertData(
                table: "sys_menu",
                columns: new[] { "Id", "Application", "Code", "Component", "CreatedTime", "CreatedUserId", "CreatedUserName", "Icon", "IsDeleted", "Link", "Name", "OpenType", "Permission", "Pid", "Pids", "Redirect", "Remark", "Router", "Sort", "Status", "Type", "UpdatedTime", "UpdatedUserId", "UpdatedUserName", "Visible", "Weight" },
                values: new object[,]
                {
                    { 142307070922876L, "manage", "sys_file_mgr_sys_file_upload_shop", null, null, null, null, null, false, null, "商城上传", 0, "sysFileInfo:uploadShop", 142307070918757L, "[0],[142307070918756],[142307070918757],", null, null, null, 100, 0, 2, null, null, null, "Y", 1 },
                    { 142307070922877L, "busiapp", "main_screen_monitor", "main/screenMonitor/index", null, null, null, "desktop", false, null, "大屏监控", 0, null, 0L, "[0],", null, null, "/monitor", 100, 0, 1, null, null, null, "Y", 2 },
                    { 142307070922878L, "busiapp", "main_map", "main/map/index", null, null, null, "global", false, null, "地理信息", 0, null, 0L, "[0],", null, null, "/map", 100, 0, 1, null, null, null, "Y", 2 }
                });

            migrationBuilder.InsertData(
                table: "sys_org",
                columns: new[] { "Id", "Code", "Contacts", "CreatedTime", "CreatedUserId", "CreatedUserName", "IsDeleted", "Name", "OrgType", "Pid", "Pids", "Remark", "Sort", "Status", "Tel", "UpdatedTime", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 142307070910539L, "hxjt", null, null, null, null, false, "华夏集团", null, 0L, "[0],", "华夏集团", 100, 0, null, null, null, null },
                    { 142307070910540L, "hxjt_bj", null, null, null, null, false, "华夏集团北京分公司", null, 142307070910539L, "[0],[142307070910539],", "华夏集团北京分公司", 100, 0, null, null, null, null },
                    { 142307070910541L, "hxjt_cd", null, null, null, null, false, "华夏集团成都分公司", null, 142307070910539L, "[0],[142307070910539],", "华夏集团成都分公司", 100, 0, null, null, null, null },
                    { 142307070910542L, "hxjt_bj_yfb", null, null, null, null, false, "研发部", null, 142307070910540L, "[0],[142307070910539],[142307070910540],", "华夏集团北京分公司研发部", 100, 0, null, null, null, null },
                    { 142307070910543L, "hxjt_bj_qhb", null, null, null, null, false, "企划部", null, 142307070910540L, "[0],[142307070910539],[142307070910540],", "华夏集团北京分公司企划部", 100, 0, null, null, null, null },
                    { 142307070910544L, "hxjt_cd_scb", null, null, null, null, false, "市场部", null, 142307070910541L, "[0],[142307070910539],[142307070910541],", "华夏集团成都分公司市场部", 100, 0, null, null, null, null },
                    { 142307070910545L, "hxjt_cd_cwb", null, null, null, null, false, "财务部", null, 142307070910541L, "[0],[142307070910539],[142307070910541],", "华夏集团成都分公司财务部", 100, 0, null, null, null, null },
                    { 142307070910546L, "hxjt_cd_scb_2b", null, null, null, null, false, "市场部二部", null, 142307070910544L, "[0],[142307070910539],[142307070910541],[142307070910544],", "华夏集团成都分公司市场部二部", 100, 0, null, null, null, null },
                    { 142307070910547L, "gsmc", null, null, null, null, false, "租户1公司", null, 0L, "[0],", "公司名称", 100, 0, null, null, null, null },
                    { 142307070910548L, "gsmc", null, null, null, null, false, "租户2公司", null, 0L, "[0],", "公司名称", 100, 0, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "sys_pos",
                columns: new[] { "Id", "Code", "CreatedTime", "CreatedUserId", "CreatedUserName", "IsDeleted", "Name", "Remark", "Sort", "Status", "UpdatedTime", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 142307070910547L, "zjl", null, null, null, false, "总经理", "总经理", 100, 0, null, null, null },
                    { 142307070910548L, "fzjl", null, null, null, false, "副总经理", "副总经理", 101, 0, null, null, null },
                    { 142307070910549L, "bmjl", null, null, null, false, "部门经理", "部门经理", 102, 0, null, null, null },
                    { 142307070910550L, "gzry", null, null, null, false, "工作人员", "工作人员", 103, 0, null, null, null },
                    { 142307070910551L, "zjl", null, null, null, false, "总经理", "总经理", 100, 0, null, null, null },
                    { 142307070910552L, "fzjl", null, null, null, false, "副总经理", "副总经理", 101, 0, null, null, null },
                    { 142307070910553L, "bmjl", null, null, null, false, "部门经理", "部门经理", 102, 0, null, null, null },
                    { 142307070910554L, "gzry", null, null, null, false, "工作人员", "工作人员", 103, 0, null, null, null },
                    { 142307070910555L, "zjl", null, null, null, false, "总经理", "总经理", 100, 0, null, null, null },
                    { 142307070910556L, "fzjl", null, null, null, false, "副总经理", "副总经理", 101, 0, null, null, null },
                    { 142307070910557L, "bmjl", null, null, null, false, "部门经理", "部门经理", 102, 0, null, null, null },
                    { 142307070910558L, "gzry", null, null, null, false, "工作人员", "工作人员", 103, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "sys_role",
                columns: new[] { "Id", "Code", "CreatedTime", "CreatedUserId", "CreatedUserName", "DataScopeType", "IsDeleted", "Name", "Remark", "RoleType", "Sort", "Status", "UpdatedTime", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 142307070910554L, "sys_manager_role", null, null, null, 1, false, "系统管理员", "系统管理员", 0, 100, 0, null, null, null },
                    { 142307070910555L, "common_role", null, null, null, 5, false, "普通用户", "普通用户", 0, 101, 0, null, null, null },
                    { 142307070910556L, "sys_manager_role", null, null, null, 5, false, "系统管理员", "系统管理员", 0, 100, 0, null, null, null },
                    { 142307070910557L, "common_role", null, null, null, 5, false, "普通用户", "普通用户", 0, 101, 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "sys_user",
                columns: new[] { "Id", "Account", "AdminType", "Avatar", "Birthday", "CreatedTime", "CreatedUserId", "CreatedUserName", "Email", "IsDeleted", "LastLoginIp", "LastLoginTime", "Name", "NickName", "Password", "Phone", "Sex", "Status", "Tel", "UpdatedTime", "UpdatedUserId", "UpdatedUserName" },
                values: new object[,]
                {
                    { 142307070910551L, "superAdmin", 1, null, new DateTimeOffset(new DateTime(1986, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), null, null, null, null, false, null, null, "超级管理员", "superAdmin", "e10adc3949ba59abbe56e057f20f883e", "18020030720", 1, 0, null, null, null, null },
                    { 142307070910552L, "admin", 2, null, new DateTimeOffset(new DateTime(1986, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), null, null, null, null, false, null, null, "系统管理员", "admin", "e10adc3949ba59abbe56e057f20f883e", "18020030720", 1, 0, null, null, null, null },
                    { 142307070910553L, "zuohuaijun", 3, null, new DateTimeOffset(new DateTime(1986, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), null, null, null, null, false, null, null, "普通用户", "zuohuaijun", "e10adc3949ba59abbe56e057f20f883e", "18020030720", 1, 0, null, null, null, null },
                    { 142307070910554L, "zuohuaijun@163.com", 2, null, new DateTimeOffset(new DateTime(1986, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), null, null, null, null, false, null, null, "系统管理员", "admin", "e10adc3949ba59abbe56e057f20f883e", "18020030720", 1, 0, null, null, null, null },
                    { 142307070910556L, "dilon@163.com", 3, null, new DateTimeOffset(new DateTime(1986, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), null, null, null, null, false, null, null, "普通用户", "dilon", "e10adc3949ba59abbe56e057f20f883e", "18020030720", 1, 0, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "sys_emp_ext_org_pos",
                columns: new[] { "SysEmpId", "SysOrgId", "SysPosId" },
                values: new object[,]
                {
                    { 142307070910551L, 142307070910539L, 142307070910547L },
                    { 142307070910551L, 142307070910540L, 142307070910548L },
                    { 142307070910551L, 142307070910541L, 142307070910549L },
                    { 142307070910551L, 142307070910542L, 142307070910550L },
                    { 142307070910553L, 142307070910542L, 142307070910547L }
                });

            migrationBuilder.InsertData(
                table: "sys_emp_pos",
                columns: new[] { "SysEmpId", "SysPosId" },
                values: new object[,]
                {
                    { 142307070910551L, 142307070910547L },
                    { 142307070910551L, 142307070910548L },
                    { 142307070910552L, 142307070910549L },
                    { 142307070910553L, 142307070910547L },
                    { 142307070910554L, 142307070910551L },
                    { 142307070910554L, 142307070910552L },
                    { 142307070910555L, 142307070910551L },
                    { 142307070910555L, 142307070910553L },
                    { 142307070910557L, 142307070910555L },
                    { 142307070910557L, 142307070910556L },
                    { 142307070910558L, 142307070910557L },
                    { 142307070910559L, 142307070910555L }
                });

            migrationBuilder.InsertData(
                table: "sys_role_menu",
                columns: new[] { "SysMenuId", "SysRoleId" },
                values: new object[,]
                {
                    { 142307000914633L, 142307070910556L },
                    { 142307070910560L, 142307070910556L },
                    { 142307070910561L, 142307070910556L },
                    { 142307070910562L, 142307070910556L },
                    { 142307070910563L, 142307070910556L },
                    { 142307070910564L, 142307070910556L },
                    { 142307070910565L, 142307070910556L },
                    { 142307070910566L, 142307070910556L },
                    { 142307070910567L, 142307070910556L },
                    { 142307070910568L, 142307070910556L },
                    { 142307070910569L, 142307070910556L },
                    { 142307070910570L, 142307070910556L },
                    { 142307070910571L, 142307070910556L },
                    { 142307070910572L, 142307070910556L },
                    { 142307070910573L, 142307070910556L },
                    { 142307070910574L, 142307070910556L },
                    { 142307070910575L, 142307070910556L },
                    { 142307070910576L, 142307070910556L },
                    { 142307070910577L, 142307070910556L },
                    { 142307070910578L, 142307070910556L },
                    { 142307070910579L, 142307070910556L },
                    { 142307070910580L, 142307070910556L },
                    { 142307070910581L, 142307070910556L },
                    { 142307070910582L, 142307070910556L },
                    { 142307070910583L, 142307070910556L },
                    { 142307070910584L, 142307070910556L },
                    { 142307070910585L, 142307070910556L },
                    { 142307070910586L, 142307070910556L },
                    { 142307070910587L, 142307070910556L },
                    { 142307070910588L, 142307070910556L },
                    { 142307070910589L, 142307070910556L },
                    { 142307070910590L, 142307070910556L },
                    { 142307070910591L, 142307070910556L },
                    { 142307070914629L, 142307070910556L },
                    { 142307070914630L, 142307070910556L },
                    { 142307070914631L, 142307070910556L },
                    { 142307070914632L, 142307070910556L },
                    { 142307070914648L, 142307070910556L },
                    { 142307070914651L, 142307070910556L },
                    { 142307070914652L, 142307070910556L },
                    { 142307070914653L, 142307070910556L },
                    { 142307070914654L, 142307070910556L },
                    { 142307070914655L, 142307070910556L },
                    { 142307070914656L, 142307070910556L },
                    { 142307070914657L, 142307070910556L },
                    { 142307070914658L, 142307070910556L },
                    { 142307070914659L, 142307070910556L },
                    { 142307070914660L, 142307070910556L },
                    { 142307070914661L, 142307070910556L },
                    { 142307070918777L, 142307070910556L },
                    { 142307070922874L, 142307070910556L }
                });

            migrationBuilder.InsertData(
                table: "sys_user_data_scope",
                columns: new[] { "SysOrgId", "SysUserId" },
                values: new object[] { 142307070910547L, 142307070910554L });

            migrationBuilder.InsertData(
                table: "sys_user_role",
                columns: new[] { "SysRoleId", "SysUserId" },
                values: new object[,]
                {
                    { 142307070910554L, 142307070910552L },
                    { 142307070910556L, 142307070910554L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910556L);

            migrationBuilder.DeleteData(
                table: "sys_emp_ext_org_pos",
                keyColumns: new[] { "SysEmpId", "SysOrgId", "SysPosId" },
                keyValues: new object[] { 142307070910551L, 142307070910539L, 142307070910547L });

            migrationBuilder.DeleteData(
                table: "sys_emp_ext_org_pos",
                keyColumns: new[] { "SysEmpId", "SysOrgId", "SysPosId" },
                keyValues: new object[] { 142307070910551L, 142307070910540L, 142307070910548L });

            migrationBuilder.DeleteData(
                table: "sys_emp_ext_org_pos",
                keyColumns: new[] { "SysEmpId", "SysOrgId", "SysPosId" },
                keyValues: new object[] { 142307070910551L, 142307070910541L, 142307070910549L });

            migrationBuilder.DeleteData(
                table: "sys_emp_ext_org_pos",
                keyColumns: new[] { "SysEmpId", "SysOrgId", "SysPosId" },
                keyValues: new object[] { 142307070910551L, 142307070910542L, 142307070910550L });

            migrationBuilder.DeleteData(
                table: "sys_emp_ext_org_pos",
                keyColumns: new[] { "SysEmpId", "SysOrgId", "SysPosId" },
                keyValues: new object[] { 142307070910553L, 142307070910542L, 142307070910547L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910551L, 142307070910547L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910551L, 142307070910548L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910552L, 142307070910549L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910553L, 142307070910547L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910554L, 142307070910551L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910554L, 142307070910552L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910555L, 142307070910551L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910555L, 142307070910553L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910557L, 142307070910555L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910557L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910558L, 142307070910557L });

            migrationBuilder.DeleteData(
                table: "sys_emp_pos",
                keyColumns: new[] { "SysEmpId", "SysPosId" },
                keyValues: new object[] { 142307070910559L, 142307070910555L });

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070911739L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070911740L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070911741L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914633L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914634L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914635L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914636L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914637L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914638L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914639L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914640L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914641L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914642L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914643L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914644L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914645L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914646L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914647L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914649L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914650L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914662L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914663L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914664L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914665L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914666L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914667L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914668L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914669L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914671L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914672L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914673L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914674L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914675L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914676L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914677L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914678L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914679L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914680L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914681L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914682L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914683L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914684L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914685L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914686L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914687L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918725L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918726L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918727L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918728L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918729L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918730L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918731L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918732L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918733L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918734L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918735L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918736L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918737L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918738L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918739L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918740L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918741L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918742L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918743L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918744L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918745L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918746L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918747L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918748L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918749L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918750L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918751L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918752L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918753L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918754L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918755L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918756L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918757L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918758L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918759L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918760L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918761L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918762L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918763L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918764L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918765L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918766L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918767L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918768L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918769L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918770L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918771L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918772L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918773L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918774L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918775L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918776L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918782L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918783L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922821L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922822L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922823L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922824L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922825L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922826L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922827L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922870L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922875L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922876L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922877L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922878L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910543L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910544L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910545L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910546L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910548L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910554L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910558L);

            migrationBuilder.DeleteData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 142307070910555L);

            migrationBuilder.DeleteData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 142307070910557L);

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307000914633L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910560L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910561L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910562L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910563L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910564L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910565L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910566L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910567L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910568L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910569L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910570L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910571L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910572L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910573L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910574L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910575L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910576L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910577L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910578L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910579L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910580L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910581L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910582L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910583L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910584L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910585L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910586L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910587L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910588L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910589L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910590L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070910591L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914629L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914630L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914631L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914632L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914648L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914651L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914652L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914653L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914654L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914655L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914656L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914657L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914658L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914659L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914660L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070914661L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070918777L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_role_menu",
                keyColumns: new[] { "SysMenuId", "SysRoleId" },
                keyValues: new object[] { 142307070922874L, 142307070910556L });

            migrationBuilder.DeleteData(
                table: "sys_user",
                keyColumn: "Id",
                keyValue: 142307070910551L);

            migrationBuilder.DeleteData(
                table: "sys_user",
                keyColumn: "Id",
                keyValue: 142307070910553L);

            migrationBuilder.DeleteData(
                table: "sys_user",
                keyColumn: "Id",
                keyValue: 142307070910556L);

            migrationBuilder.DeleteData(
                table: "sys_user_data_scope",
                keyColumns: new[] { "SysOrgId", "SysUserId" },
                keyValues: new object[] { 142307070910547L, 142307070910554L });

            migrationBuilder.DeleteData(
                table: "sys_user_role",
                keyColumns: new[] { "SysRoleId", "SysUserId" },
                keyValues: new object[] { 142307070910554L, 142307070910552L });

            migrationBuilder.DeleteData(
                table: "sys_user_role",
                keyColumns: new[] { "SysRoleId", "SysUserId" },
                keyValues: new object[] { 142307070910556L, 142307070910554L });

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910551L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910552L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910553L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910554L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910555L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910557L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910558L);

            migrationBuilder.DeleteData(
                table: "sys_emp",
                keyColumn: "Id",
                keyValue: 142307070910559L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307000914633L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910560L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910561L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910562L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910563L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910564L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910565L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910566L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910567L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910568L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910569L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910570L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910571L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910572L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910573L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910574L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910575L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910576L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910577L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910578L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910579L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910580L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910581L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910582L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910583L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910584L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910585L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910586L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910587L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910588L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910589L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910590L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070910591L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914629L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914630L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914631L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914632L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914648L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914651L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914652L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914653L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914654L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914655L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914656L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914657L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914658L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914659L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914660L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070914661L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070918777L);

            migrationBuilder.DeleteData(
                table: "sys_menu",
                keyColumn: "Id",
                keyValue: 142307070922874L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910539L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910540L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910541L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910542L);

            migrationBuilder.DeleteData(
                table: "sys_org",
                keyColumn: "Id",
                keyValue: 142307070910547L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910547L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910548L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910549L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910550L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910551L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910552L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910553L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910555L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910556L);

            migrationBuilder.DeleteData(
                table: "sys_pos",
                keyColumn: "Id",
                keyValue: 142307070910557L);

            migrationBuilder.DeleteData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 142307070910554L);

            migrationBuilder.DeleteData(
                table: "sys_role",
                keyColumn: "Id",
                keyValue: 142307070910556L);

            migrationBuilder.DeleteData(
                table: "sys_user",
                keyColumn: "Id",
                keyValue: 142307070910552L);

            migrationBuilder.DeleteData(
                table: "sys_user",
                keyColumn: "Id",
                keyValue: 142307070910554L);
        }
    }
}
