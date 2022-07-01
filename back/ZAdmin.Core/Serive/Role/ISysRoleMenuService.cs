using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.Role.Dto;

namespace ZAdmin.Core.Serive
{
    public interface ISysRoleMenuService
    {
        Task DeleteRoleMenuListByMenuIdList(List<long> menuIdList);

        Task DeleteRoleMenuListByRoleId(long roleId);

        Task<List<long>> GetRoleMenuIdList(List<long> roleIdList);

        Task GrantMenu(GrantRoleMenuInput input);
    }
}
