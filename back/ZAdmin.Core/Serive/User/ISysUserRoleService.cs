using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.User.Dto;

namespace ZAdmin.Core.Serive.User
{
    public interface ISysUserRoleService
    {
        Task DeleteUserRoleListByRoleId(long roleId);

        Task DeleteUserRoleListByUserId(long userId);

        Task<List<long>> GetUserRoleDataScopeIdList(long userId, long orgId);

        Task<List<long>> GetUserRoleIdList(long userId, bool checkRoleStatus = true);

        Task GrantRole(UpdateUserRoleDataInput input);
    }
}
