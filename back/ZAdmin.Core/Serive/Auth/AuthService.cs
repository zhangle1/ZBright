using Furion;
using Furion.DatabaseAccessor;
using Furion.DataEncryption;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Const;
using ZAdmin.Core.Entity;

using ZAdmin.Core.Options;
using ZAdmin.Core.Serive.Auth.Dto;
using ZAdmin.Core.Serive.Emp;

namespace ZAdmin.Core.Serive
{
    /// <summary>
    /// 登录授权相关服务
    /// </summary>
    [ApiDescriptionSettings( GroupName = "Default",  Name = "Auth", Order = 160)]
    public class AuthService : IAuthService, IDynamicApiController, ITransient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IRepository<SysUser> _sysUserRep;
        private readonly ISysEmpService _sysEmpService; // 系统员工服务

        public AuthService(IHttpContextAccessor httpContextAccessor, IRepository<SysUser> sysUserRep, ISysEmpService sysEmpService)
        {
            _httpContextAccessor = httpContextAccessor;
            _sysUserRep = sysUserRep;
            _sysEmpService = sysEmpService;
        }



        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="input"></param>
        /// <remarks>默认用户名/密码：admin/admin</remarks>
        /// <returns></returns>
        [HttpPost("/login")]
        [AllowAnonymous]
        public string LoginAsync([FromBody] LoginInput input)
        {
            var encryptPasswod = MD5Encryption.Encrypt(input.Password);

            var user = _sysUserRep
                .Where(u => u.Account.Equals(input.Account) && u.Password.Equals(encryptPasswod) && !u.IsDeleted, false, true)
                .FirstOrDefault();

            _ = user ?? throw Oops.Oh(ErrorCode.D1000);

            if (user.Status == CommonStatus.DISABLE) {
                throw Oops.Oh(ErrorCode.D1017);
            }

            // 员工信息
            var empInfo = _sysEmpService.GetEmpInfo(user.Id).Result;
            
            //生成Token令牌
            var accessToken = JWTEncryption.Encrypt(new Dictionary<string, object>
            {
                {ClaimConst.CLAINM_USERID, user.Id},
                {ClaimConst.TENANT_ID, user.TenantId},
                {ClaimConst.CLAINM_ACCOUNT, user.Account},
                {ClaimConst.CLAINM_NAME, user.Name},
                {ClaimConst.CLAINM_SUPERADMIN, user.AdminType},
                {ClaimConst.CLAINM_ORGID, empInfo.OrgId},
                {ClaimConst.CLAINM_ORGNAME, empInfo.OrgName},
            });

            // 设置Swagger自动登录
            _httpContextAccessor.HttpContext.SigninToSwagger(accessToken);

            // 生成刷新Token令牌
            var refreshToken =
                JWTEncryption.GenerateRefreshToken(accessToken, App.GetOptions<RefreshTokenSettingOptions>().ExpiredTime);

            // 设置刷新Token令牌
            _httpContextAccessor.HttpContext.Response.Headers["x-access-token"] = refreshToken;

            return accessToken;
        }
    }
}
