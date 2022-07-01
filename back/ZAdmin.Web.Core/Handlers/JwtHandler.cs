using Furion;
using Furion.Authorization;
using Furion.DataEncryption;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core;
using ZAdmin.Core.Const;
using ZAdmin.Core.Options;

namespace ZAdmin.Web.Core.Handlers
{
    public class JwtHandler : AppAuthorizeHandler
    {
        /// <summary>
        /// 重写 Handler 添加自动刷新
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task HandleAsync(AuthorizationHandlerContext context)
        {
            // 自动刷新Token
            if (JWTEncryption.AutoRefreshToken(context, context.GetCurrentHttpContext(),
                App.GetOptions<JWTSettingsOptions>().ExpiredTime,
                App.GetOptions<RefreshTokenSettingOptions>().ExpiredTime))
            {
                await AuthorizeHandleAsync(context);
            }
            else
            {
                context.Fail(); // 授权失败
                DefaultHttpContext currentHttpContext = context.GetCurrentHttpContext();
                if (currentHttpContext == null)
                    return;
                currentHttpContext.SignoutToSwagger();
            }
        }

        /// <summary>
        /// 授权判断逻辑，授权通过返回 true，否则返回 false
        /// </summary>
        /// <param name="context"></param>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public override async Task<bool> PipelineAsync(AuthorizationHandlerContext context, DefaultHttpContext httpContext)
        {
            // 此处已经自动验证 Jwt Token的有效性了，无需手动验证
            return await CheckAuthorzieAsync(httpContext);
        }

        /// <summary>
        /// 检查权限
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        private static async Task<bool> CheckAuthorzieAsync(DefaultHttpContext httpContext)
        {
            // 管理员跳过判断
            if (App.User.FindFirst(ClaimConst.CLAINM_SUPERADMIN)?.Value == ((int)AdminType.SuperAdmin).ToString()) return true;

            // 路由名称
            var routeName = httpContext.Request.Path.Value[1..].Replace("/", ":");

            // 默认路由(获取登录用户信息)
            var defalutRoute = new List<string>()
            {
                "getLoginUser",     //登录
                "sysMenu:change"    //切换顶部菜单
            };

            if (defalutRoute.Contains(routeName)) return true;

            // 获取用户权限集合（按钮或API接口）
            //var allPermissionList = await App.GetService<ISysMenuService>().GetAllPermissionList();
            var currUserId = Convert.ToInt64(App.User.FindFirst(ClaimConst.CLAINM_USERID)?.Value);
            //var permissionList = await App.GetService<ISysMenuService>().GetLoginPermissionList(currUserId);

            // 检查授权
            // 菜单中没有配置按钮权限，则不限制
            return true;
            //return allPermissionList.All(u => u != routeName) || permissionList.Contains(routeName);
        }
    }
}
