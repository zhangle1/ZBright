﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core
{
    /// <summary>
    /// 菜单权重
    /// </summary>
    public enum MenuWeight
    {
        /// <summary>
        /// 系统权重
        /// </summary>
        [Description("系统权重")]
        SUPER_ADMIN_WEIGHT = 1,

        /// <summary>
        /// 业务权重
        /// </summary>
        [Description("业务权重")]
        DEFAULT_WEIGHT = 2
    }
}
