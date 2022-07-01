using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.User.Dto;
using Microsoft.EntityFrameworkCore;
using ZAdmin.Core.Serive.Role;

namespace ZAdmin.Core.Serive.User
{
    /// <summary>
    /// 用户角色服务
    /// </summary>
    public class SysUserRoleService : ISysUserRoleService, ITransient
    {

        private readonly IRepository<SysUserRole> _sysUserRoleRep;  // 用户权限表仓储

        private readonly ISysRoleService _sysRoleService;


        public SysUserRoleService(IRepository<SysUserRole> sysUserRoleRep, ISysRoleService sysRoleService)
        {
            _sysUserRoleRep = sysUserRoleRep;
            _sysRoleService = sysRoleService;
        }

        public Task DeleteUserRoleListByRoleId(long roleId)
        {
            throw new NotImplementedException();
        }

        public  async Task DeleteUserRoleListByUserId(long userId)
        {
            var surList = await _sysUserRoleRep.AsQueryable(m => m.SysUserId == userId, false).ToListAsync();
            await _sysUserRoleRep.DeleteAsync(surList);
        }

        public async Task<List<long>> GetUserRoleDataScopeIdList(long userId, long orgId)
        {
            var roleIdList = await GetUserRoleIdList(userId);

            // 获取这些角色对应的数据范围
            if (roleIdList.Count > 0)
                return await _sysRoleService.GetUserDataScopeIdList(roleIdList, orgId);
            return roleIdList;
        }

        /// <summary>
        /// 获取用户的角色Id集合
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="checkRoleStatus"></param>
        /// <returns></returns>
        public async Task<List<long>> GetUserRoleIdList(long userId, bool checkRoleStatus = true)
        {
            return await _sysUserRoleRep
                  // 检查role状态，跳过全局tenantId&delete过滤器，超级管理员使用
                  .Where(!checkRoleStatus, u => u.SysRole.Status == CommonStatus.ENABLE && !u.SysRole.IsDeleted, ignoreQueryFilters: true)
                  // 当不是超级管理员的时候检查role状态和全局tenantId&delete过滤器
                  .Where(checkRoleStatus, u => u.SysRole.Status == CommonStatus.ENABLE)
                  .Where(u => u.SysUserId == userId)
                  .Select(u => u.SysRoleId)
                  .ToListAsync();
        }

        public Task GrantRole(UpdateUserRoleDataInput input)
        {
            throw new NotImplementedException();
        }
    }
}
