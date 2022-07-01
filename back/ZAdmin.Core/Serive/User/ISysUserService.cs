using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.User.Dto;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.User
{
    public interface ISysUserService
    {


        Task<List<long>> GetUserDataScopeIdList();
        Task<List<long>> GetUserDataScopeIdList(long userId);

        Task<PageResult<UserOutput>> QueryUserPageList([FromQuery] UserPageInput input);
        Task DeleteUser(DeleteUserInput input);

        Task ChangeUserStatus(UpdateUserStatusInput input);


        Task ResetUserPwd(QueryUserInput input);

    }
}
