using Furion.DatabaseAccessor;
using Furion.DatabaseAccessor.Extensions;
using Furion.DataEncryption;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAdmin.Core.Const;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Cache;
using ZAdmin.Core.Serive.Emp;
using ZAdmin.Core.Serive.Org.Dto;
using ZAdmin.Core.Serive.User.Dto;
using ZAdmin.Core.Util;


namespace ZAdmin.Core.Serive.User
{

    /// <summary>
    /// 用户服务
    /// </summary>
    [ApiDescriptionSettings(Name = "User", Order = 150)]
    public class SysUserService : ISysUserService, IDynamicApiController, ITransient
    {
        private readonly IRepository<SysUser> _sysUserRep;  // 用户表仓储
        private readonly ISysCacheService _sysCacheService;
        private readonly ISysEmpService _sysEmpService;
        private readonly ISysUserDataScopeService _sysUserDataScopeService;
        private readonly ISysUserRoleService _sysUserRoleService;
        private readonly ISysOrgService _sysOrgService;

        public SysUserService(ISysCacheService sysCacheService, ISysEmpService sysEmpService, ISysUserDataScopeService sysUserDataScopeService, ISysUserRoleService sysUserRoleService, ISysOrgService sysOrgService, IRepository<SysUser> sysUserRep)
        {
            _sysCacheService = sysCacheService;
            _sysEmpService = sysEmpService;
            _sysUserDataScopeService = sysUserDataScopeService;
            _sysUserRoleService = sysUserRoleService;
            _sysOrgService = sysOrgService;
            _sysUserRep = sysUserRep;
        }


        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysUser/changeStatus")]
        public async Task ChangeUserStatus(UpdateUserStatusInput input)
        {
            var user = await _sysUserRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            if (user.AdminType == AdminType.SuperAdmin)
                throw Oops.Oh(ErrorCode.D1015);
           
            if (!System.Enum.IsDefined(typeof(CommonStatus), input.Status))
                throw Oops.Oh(ErrorCode.D3005);
            user.Status = input.Status;
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysUser/delete")]
        public async Task DeleteUser(DeleteUserInput input)
        {
            // 数据范围检查
            CheckDataScope(input.SysEmpParam.OrgId);

            var user = await _sysUserRep.FirstOrDefaultAsync(u => u.Id == input.Id, false);
            if (user == null)
                throw Oops.Oh(ErrorCode.D1002);
            if (user.AdminType == AdminType.SuperAdmin)
                throw Oops.Oh(ErrorCode.D1014);
            if (user.AdminType == AdminType.Admin)
                throw Oops.Oh(ErrorCode.D1018);

            if (user.Id == CurrentUserInfo.UserId)
                throw Oops.Oh(ErrorCode.D1001);

            // 直接删除用户
            await user.DeleteAsync();

            await _sysEmpService.DeleteEmpInfoByUserId(input.Id);//empId与userId相同

            //删除该用户对应的用户-角色表关联信息
            await _sysUserRoleService.DeleteUserRoleListByUserId(input.Id);

            //删除该用户对应的用户-数据范围表关联信息
            await _sysUserDataScopeService.DeleteUserDataScopeListByUserId(input.Id);
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysUser/add")]
        public async Task AddUser(AddUserInput input)
        {
            // 数据范围检查
            CheckDataScope(input.SysEmpParam.OrgId);

            var isExist = await _sysUserRep.AnyAsync(u => u.Account == input.Account && !u.IsDeleted, false, true);
            if (isExist) throw Oops.Oh(ErrorCode.D1003);

            var user = input.Adapt<SysUser>();
            user.Password = MD5Encryption.Encrypt(input.Password);
            if (string.IsNullOrEmpty(user.Name))
                user.Name = user.Account;
            if (string.IsNullOrEmpty(user.NickName))
                user.NickName = user.Account;
            var newUser = await _sysUserRep.InsertNowAsync(user);
            input.SysEmpParam.Id = newUser.Entity.Id.ToString();
            // 增加员工信息
            await _sysEmpService.AddOrUpdate(input.SysEmpParam);
        }






        /// 更新用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysUser/edit")]
        public async Task UpdateUser(UpdateUserInput input)
        {
            // 数据范围检查
            CheckDataScope(input.SysEmpParam.OrgId);

            // 排除自己并且判断与其他是否相同
            var isExist = await _sysUserRep.AnyAsync(u => u.Account == input.Account && u.Id != input.Id, false);
            if (isExist) throw Oops.Oh(ErrorCode.D1003);

            var user = input.Adapt<SysUser>();
            await user.UpdateExcludeAsync(new[] { nameof(SysUser.Password), nameof(SysUser.Status), nameof(SysUser.AdminType) }, true);
            input.SysEmpParam.Id = user.Id.ToString();

            // 更新员工及附属机构职位信息
            await _sysEmpService.AddOrUpdate(input.SysEmpParam);
        }


        /// <summary>
        /// 获取用户数据范围（机构Id集合）并缓存
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<long>> GetUserDataScopeIdList()
        {
            var userId = CurrentUserInfo.UserId;
            var dataScopes = await GetUserDataScopeIdList(userId);
            return dataScopes;
        }


        /// <summary>
        /// 获取用户数据范围（机构Id集合）并缓存
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<long>> GetUserDataScopeIdList(long userId)
        {
            //var dataScopes = await _sysCacheService.GetDataScope(userId); // 先从缓存里面读取
            var dataScopes = new List<long>(); // 先从缓存里面读取
            if (dataScopes == null || dataScopes.Count < 1)
            {
                if (!CurrentUserInfo.IsSuperAdmin)
                {
                    var orgId = await _sysEmpService.GetEmpOrgId(userId);
                    // 获取该用户对应的数据范围集合
                    var userDataScopeIdListForUser = await _sysUserDataScopeService.GetUserDataScopeIdList(userId);
                    // 获取该用户的角色对应的数据范围集合
                    var userDataScopeIdListForRole = await _sysUserRoleService.GetUserRoleDataScopeIdList(userId, orgId);
                    dataScopes = userDataScopeIdListForUser.Concat(userDataScopeIdListForRole).Distinct().ToList(); // 并集
                }
                else
                {
                    dataScopes = await _sysOrgService.GetAllDataScopeIdList();
                }
                await _sysCacheService.SetDataScope(userId, dataScopes); // 缓存结果
            }
            return dataScopes;
        }

        /// <summary>
        /// 分页查询用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("/sysUser/page")]
        public async Task<PageResult<UserOutput>> QueryUserPageList([FromQuery] UserPageInput input)
        {
            var searchValue = input.SearchValue;
            var pid = input.SysEmpParam.OrgId;

            var sysEmpRep = Db.GetRepository<SysEmp>();
            var sysOrgRep = Db.GetRepository<SysOrg>();

            var dataScopes = await GetUserDataScopeIdList(CurrentUserInfo.UserId);
            var users = await _sysUserRep.DetachedEntities
                             .Join(sysEmpRep.DetachedEntities, u => u.Id, e => e.Id, (u, e) => new { u, e })
                             .Join(sysOrgRep.DetachedEntities, n => n.e.OrgId, o => o.Id, (n, o) => new { n, o })
                             .Where(!string.IsNullOrEmpty(input.Account),x=> (x.n.u.Account.Contains(input.Account)))
                             .Where(!string.IsNullOrEmpty(input.Name),x=> (x.n.u.Name.Contains(input.Name)))
                             .Where(!string.IsNullOrEmpty(input.Phone),x=> (x.n.u.Phone.Contains(input.Phone)))
                             .Where(!string.IsNullOrEmpty(pid), x => (x.n.e.OrgId == long.Parse(pid) ||
                             x.o.Pids.Contains($"[{pid.Trim()}]")))
                             .Where(input.Status >= 0, x => x.n.u.Status == input.Status)
                             .Where(x => x.n.u.AdminType != AdminType.SuperAdmin)//排除超级管理员
                             .Where(!CurrentUserInfo.IsSuperAdmin && dataScopes.Count > 0, x => dataScopes.Contains(x.n.e.OrgId))
                             .Select(u => u.n.u.Adapt<UserOutput>())
                             .ToADPagedListAsync(input.PageNo, input.PageSize);
            foreach (var user in users.Rows)
            {
                user.SysEmpInfo = await _sysEmpService.GetEmpInfo(long.Parse(user.Id));
            }
            return users;
        }

        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysUser/resetPwd")]
        public async Task ResetUserPwd(QueryUserInput input)
        {
            var user = await _sysUserRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            user.Password = MD5Encryption.Encrypt(CommonConst.DEFAULT_PASSWORD);
        }



        /// <summary>
        /// 检查普通用户数据范围
        /// 当有用户有多个组织时，在登录时选择一个组织，所以组织id（orgId）从前端传过来
        /// </summary>
        /// <param name="orgId"></param>
        /// <returns></returns>
        private async void CheckDataScope(string orgId) {
            if (!CurrentUserInfo.IsSuperAdmin) {
                var dataScopes = await GetUserDataScopeIdList(CurrentUserInfo.UserId);
                if (dataScopes == null || (orgId != null && !dataScopes.Any(u => u == long.Parse(orgId))))
                    throw Oops.Oh(ErrorCode.D1013);
            }
        }
    }
}
