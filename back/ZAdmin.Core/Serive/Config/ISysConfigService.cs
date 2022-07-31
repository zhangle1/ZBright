using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Config.Dto;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.Config
{

    public interface ISysConfigService
    {
        Task AddConfig(AddConfigInput input);

        Task DeleteConfig(DeleteConfigInput input);

        Task<SysConfig> GetConfig([FromQuery] QueryConfigInput input);

        Task<List<SysConfig>> GetConfigList();

        Task<PageResult<SysConfig>> QueryConfigPageList([FromQuery] ConfigPageInput input);

        Task UpdateConfig(UpdateConfigInput input);

        Task<bool> GetDemoEnvFlag();

        Task<bool> GetCaptchaOpenFlag();

        Task UpdateConfigCache(string code, string value);
    }
}
