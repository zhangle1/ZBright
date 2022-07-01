using Furion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Const;
namespace ZAdmin.Core.Serive.User
{
    /// <summary>
    /// 当前用户
    /// </summary>
    public static class CurrentUserInfo
    {

        public static long UserId => long.Parse(App.User.FindFirst(ClaimConst.CLAINM_USERID)?.Value);

        /// <summary>
        /// 账号
        /// </summary>
        public static string Account => App.User.FindFirst(ClaimConst.CLAINM_ACCOUNT)?.Value;

        /// <summary>
        /// 昵称
        /// </summary>
        public static string Name => App.User.FindFirst(ClaimConst.CLAINM_NAME)?.Value;

        /// <summary>
        /// 是否超级管理员
        /// </summary>
        public static bool IsSuperAdmin => App.User.FindFirst(ClaimConst.CLAINM_SUPERADMIN)?.Value == ((int)AdminType.SuperAdmin).ToString();

    }
}
