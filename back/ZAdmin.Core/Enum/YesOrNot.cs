using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core
{
    /// <summary>
    /// 是否
    /// </summary>
    public enum YesOrNot
    {
        /// <summary>
        /// 是
        /// </summary>
        [Description("是")]
        Y = 1,

        /// <summary>
        /// 否
        /// </summary>
        [Description("否")]
        N = 0
    }
}
