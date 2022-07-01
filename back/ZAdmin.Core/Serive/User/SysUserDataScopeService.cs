using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.User.Dto;

namespace ZAdmin.Core.Serive.User
{
    public class SysUserDataScopeService : ISysUserDataScopeService, ITransient
    {
        private readonly IRepository<SysUserDataScope> _sysUserDataScopeRep;  // 用户数据范围表仓储

        public SysUserDataScopeService(IRepository<SysUserDataScope> sysUserDataScopeRep)
        {
            _sysUserDataScopeRep = sysUserDataScopeRep;
        }

        public Task DeleteUserDataScopeListByOrgIdList(List<long> orgIdList)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserDataScopeListByUserId(long userId)
        {
            var sudsList = await _sysUserDataScopeRep.AsQueryable(m => m.SysUserId == userId, false).ToListAsync();
            await _sysUserDataScopeRep.DeleteAsync(sudsList);
        }

        /// <summary>
        /// 获取用户的数据范围Id集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<long>> GetUserDataScopeIdList(long userId)
        {
            return await _sysUserDataScopeRep.DetachedEntities
                                             .Where(u => u.SysUserId == userId)
                                             .Select(u => u.SysOrgId).ToListAsync();
        }

        public Task GrantData(UpdateUserRoleDataInput input)
        {
            throw new NotImplementedException();
        }
    }
}
