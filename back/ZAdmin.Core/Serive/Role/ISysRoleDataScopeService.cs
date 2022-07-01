using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.Role.Dto;

namespace ZAdmin.Core.Serive.Role
{
    public interface ISysRoleDataScopeService
    {
        Task DeleteRoleDataScopeListByOrgIdList(List<long> orgIdList);

        Task DeleteRoleDataScopeListByRoleId(long roleId);

        Task<List<long>> GetRoleDataScopeIdList(List<long> roleIdList);

        Task GrantDataScope(GrantRoleDataInput input);
    }
}
