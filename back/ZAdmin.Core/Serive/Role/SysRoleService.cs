using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Org.Dto;
using ZAdmin.Core.Serive.Role.Dto;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.Role
{

    /// <summary>
    /// 角色服务
    /// </summary>
    [ApiDescriptionSettings(Name = "Role", Order = 149)]
    public class SysRoleService : ISysRoleService, IDynamicApiController, ITransient
    {
        private readonly IRepository<SysRole> _sysRoleRep;  // 角色表仓储
        private readonly IRepository<SysUserRole> _sysUserRoleRep;  // 用户角色表仓储
        private readonly ISysRoleDataScopeService _sysRoleDataScopeService;
        private readonly ISysOrgService _sysOrgService;

        public SysRoleService(IRepository<SysRole> sysRoleRep, IRepository<SysUserRole> sysUserRoleRep, ISysRoleDataScopeService sysRoleDataScopeService, ISysOrgService sysOrgService)
        {
            _sysRoleRep = sysRoleRep;
            _sysUserRoleRep = sysUserRoleRep;
            _sysRoleDataScopeService = sysRoleDataScopeService;
            _sysOrgService = sysOrgService;
        }

        public Task AddRole(AddRoleInput input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRole(DeleteRoleInput input)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNameByRoleId(long roleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RoleOutput>> GetRoleDropDown()
        {
            throw new NotImplementedException();
        }

        public Task<SysRole> GetRoleInfo([FromQuery] QueryRoleInput input)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> GetRoleList([FromQuery] RoleInput input)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 根据角色Id集合获取数据范围Id集合
        /// </summary>
        /// <param name="roleIdList"></param>
        /// <param name="orgId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<long>> GetUserDataScopeIdList(List<long> roleIdList, long orgId)
        {
            // 定义角色中最大数据范围的类型，目前按最大范围策略来，如果你同时拥有ALL和SELF的权限，最后按ALL返回
            int strongerDataScopeType = (int)DataScopeType.SELF;

            var customDataScopeRoleIdList = new List<long>();

            if (roleIdList != null && roleIdList.Count > 0)
            {
                var roles = await _sysRoleRep.DetachedEntities.Where(u => roleIdList.Contains(u.Id)).ToListAsync();
                roles.ForEach(u =>
                {
                    if (u.DataScopeType == DataScopeType.DEFINE)
                        customDataScopeRoleIdList.Add(u.Id);
                    else if ((int)u.DataScopeType <= strongerDataScopeType)
                        strongerDataScopeType = (int)u.DataScopeType;
                });
            }

            // 自定义数据范围的角色对应的数据范围
            var roleDataScopeIdList = await _sysRoleDataScopeService.GetRoleDataScopeIdList(customDataScopeRoleIdList);
            // 角色中拥有最大数据范围类型的数据范围
            var dataScopeIdList = await _sysOrgService.GetDataScopeListByDataScopeType(strongerDataScopeType, orgId);

            return roleDataScopeIdList.Concat(dataScopeIdList).Distinct().ToList(); //并集
        }

        public Task<List<RoleOutput>> GetUserRoleList(long userId)
        {
            throw new NotImplementedException();
        }

        public Task GrantData(GrantRoleDataInput input)
        {
            throw new NotImplementedException();
        }

        public Task GrantMenu(GrantRoleMenuInput input)
        {
            throw new NotImplementedException();
        }

        public Task<List<long>> OwnData([FromQuery] QueryRoleInput input)
        {
            throw new NotImplementedException();
        }

        public Task<List<long>> OwnMenu([FromQuery] QueryRoleInput input)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<SysRole>> QueryRolePageList([FromQuery] RolePageInput input)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRole(UpdateRoleInput input)
        {
            throw new NotImplementedException();
        }
    }
}
