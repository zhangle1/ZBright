using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core
{
    public enum MenuType
    {
        /// <summary>
        /// 目录
        /// </summary>
        [Description("目录")]
        DIR = 0,

        /// <summary>
        /// 菜单
        /// </summary>
        [Description("菜单")]
        MENU = 1,

        /// <summary>
        /// 按钮
        /// </summary>
        [Description("按钮")]
        BTN = 2
    }
}
