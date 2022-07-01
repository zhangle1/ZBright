﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Const
{
    public class CommonConst
    {
        /// <summary>
        /// 默认密码
        /// </summary>
        public const string DEFAULT_PASSWORD = "123456";

        /// <summary>
        /// 用户缓存
        /// </summary>
        public const string CACHE_KEY_USER = "user_";

        /// <summary>
        /// 菜单缓存
        /// </summary>
        public const string CACHE_KEY_MENU = "menu_";

        /// <summary>
        /// 权限缓存
        /// </summary>
        public const string CACHE_KEY_PERMISSION = "permission_";

        /// <summary>
        /// 数据范围缓存
        /// </summary>
        public const string CACHE_KEY_DATASCOPE = "datascope_";

        /// <summary>
        /// 验证码缓存
        /// </summary>
        public const string CACHE_KEY_CODE = "vercode_";

        /// <summary>
        /// 所有缓存关键字集合
        /// </summary>
        public const string CACHE_KEY_ALL = "allkey";

        /// <summary>
        /// 定时任务缓存
        /// </summary>
        public const string CACHE_KEY_TIMER_JOB = "timerjob";

        /// <summary>
        /// 在线用户缓存
        /// </summary>
        public const string CACHE_KEY_ONLINE_USER = "onlineuser";

        /// <summary>
        /// 系统管理员角色编码
        /// </summary>
        public const string SYS_MANAGER_ROLE_CODE = "sys_manager_role";
    }
}