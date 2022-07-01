using Furion.ConfigurableOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Options
{
    public sealed class RefreshTokenSettingOptions : IConfigurableOptions
    {
        /// <summary>
        /// 令牌过期时间（分钟）
        /// </summary>
        public int ExpiredTime { get; set; } = 43200*1000;
    }
}
