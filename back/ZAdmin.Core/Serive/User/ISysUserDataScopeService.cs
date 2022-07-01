using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.User.Dto;

namespace ZAdmin.Core.Serive.User
{
    public interface ISysUserDataScopeService
    {
        Task DeleteUserDataScopeListByOrgIdList(List<long> orgIdList);

        Task DeleteUserDataScopeListByUserId(long userId);

        Task<List<long>> GetUserDataScopeIdList(long userId);

        Task GrantData(UpdateUserRoleDataInput input);
    }
}
