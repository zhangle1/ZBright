using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive
{
    public interface ISysAppService
    {
        Task AddApp(AddAppInput input);

        Task DeleteApp(BaseId input);

        Task<SysApp> GetApp([FromQuery] QueryAppInput input);

        Task<List<SysApp>> GetAppList();

        Task<List<AppOutput>> GetLoginApps(long userId);

        Task<PageResult<SysApp>> QueryAppPageList([FromQuery] AppPageInput input);

        Task SetAsDefault(SetDefaultAppInput input);

        Task UpdateApp(UpdateAppInput input);

        Task ChangeUserAppStatus(ChangeUserAppStatusInput input);
    }
}
