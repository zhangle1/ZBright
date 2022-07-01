using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Role.Dto;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.Role
{
    public interface ISysRoleService
    {
        Task AddRole(AddRoleInput input);

        Task DeleteRole(DeleteRoleInput input);

        Task<string> GetNameByRoleId(long roleId);

        Task<List<RoleOutput>> GetRoleDropDown();

        Task<SysRole> GetRoleInfo([FromQuery] QueryRoleInput input);

        Task<dynamic> GetRoleList([FromQuery] RoleInput input);

        Task<List<long>> GetUserDataScopeIdList(List<long> roleIdList, long orgId);

        Task<List<RoleOutput>> GetUserRoleList(long userId);

        Task GrantData(GrantRoleDataInput input);

        Task GrantMenu(GrantRoleMenuInput input);

        Task<List<long>> OwnData([FromQuery] QueryRoleInput input);

        Task<List<long>> OwnMenu([FromQuery] QueryRoleInput input);

        Task<PageResult<SysRole>> QueryRolePageList([FromQuery] RolePageInput input);

        Task UpdateRole(UpdateRoleInput input);
    }
}
