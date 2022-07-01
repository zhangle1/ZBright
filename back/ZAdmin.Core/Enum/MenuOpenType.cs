using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core
{
    /// <summary>
    /// 系统菜单类型
    /// </summary>
    public enum MenuOpenType
    {
        /// <summary>
        /// 无
        /// </summary>
        [Description("无")]
        NONE = 0,

        /// <summary>
        /// 组件
        /// </summary>
        [Description("组件")]
        COMPONENT = 1,

        /// <summary>
        /// 内链
        /// </summary>
        [Description("内链")]
        INNER = 2,

        /// <summary>
        /// 外链
        /// </summary>
        [Description("外链")]
        OUTER = 3
    }
}
