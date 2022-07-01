using Furion.DatabaseAccessor;
using Furion.DatabaseAccessor.Extensions;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.User;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive
{
    /// <summary>
    /// 系统应用服务
    /// </summary>
    [ApiDescriptionSettings(Name = "App", Order = 100)]
    public class SysAppService : ISysAppService, IDynamicApiController, ITransient
    {
        private readonly IRepository<SysApp> _sysAppRep;    // 应用表仓储
        private readonly ISysMenuService _sysMenuService;

        public SysAppService(IRepository<SysApp> sysAppRep,
                     ISysMenuService sysMenuService)
        {
            _sysAppRep = sysAppRep;
            _sysMenuService = sysMenuService;
        }

        /// <summary>
        /// 获取用户应用相关信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<AppOutput>> GetLoginApps(long userId)
        {
            var apps = _sysAppRep.DetachedEntities.Where(u => u.Status == CommonStatus.ENABLE);
            if (!CurrentUserInfo.IsSuperAdmin) {
                var appCodeList = await _sysMenuService.GetUserMenuAppCodeList(userId);
                apps = apps.Where(u => appCodeList.Contains(u.Code));
            }

            var appList = await apps.OrderBy(u => u.Sort).Select(u => new AppOutput
            {
                Code = u.Code,
                Name = u.Name,
                Active = u.Active
            }).ToListAsync(); // .OrderByDescending(u => u.Active) // 将激活的放到第一个
            return appList;
        }

        /// <summary>
        /// 分页查询系统应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("/sysApp/page")]
        public async Task<PageResult<SysApp>> QueryAppPageList([FromQuery] AppPageInput input)
        {
            var name = !string.IsNullOrEmpty(input.Name?.Trim());
            var code = !string.IsNullOrEmpty(input.Code?.Trim());
            var apps = await _sysAppRep.DetachedEntities
                                       .Where((name, u => EF.Functions.Like(u.Name, $"%{input.Name.Trim()}%")),
                                              (code, u => EF.Functions.Like(u.Code, $"%{input.Code.Trim()}%")))
                                       //.Where(u => u.Status == CommonStatus.ENABLE)
                                       .OrderBy(u => u.Sort)
                                       .ToADPagedListAsync(input.PageNo, input.PageSize);
            return apps;
        }

        /// <summary>
        /// 增加系统应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysApp/add")]
        public async Task AddApp(AddAppInput input)
        {
            var isExist = await _sysAppRep.DetachedEntities.AnyAsync(u => u.Name == input.Name || u.Code == input.Code);
            if (isExist)
                throw Oops.Oh(ErrorCode.D5000);

            if (input.Active == YesOrNot.Y.ToString())
            {
                isExist = await _sysAppRep.DetachedEntities.AnyAsync(u => u.Active == input.Active);
                if (isExist)
                    throw Oops.Oh(ErrorCode.D5001);
            }

            var app = input.Adapt<SysApp>();
            await app.InsertAsync();
        }

        /// <summary>
        /// 删除系统应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysApp/delete")]
        public async Task DeleteApp(BaseId input)
        {
            var app = await _sysAppRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            // 该应用下是否有状态为正常的菜单
            var hasMenu = await _sysMenuService.HasMenu(app.Code);
            if (hasMenu)
                throw Oops.Oh(ErrorCode.D5002);

            await app.DeleteAsync();
        }

        /// <summary>
        /// 更新系统应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysApp/edit")]
        public async Task UpdateApp(UpdateAppInput input)
        {
            var isExist = await _sysAppRep.DetachedEntities.AnyAsync(u => (u.Name == input.Name || u.Code == input.Code) && u.Id != input.Id);
            if (isExist)
                throw Oops.Oh(ErrorCode.D5000);

            if (input.Active == YesOrNot.Y.ToString())
            {
                isExist = await _sysAppRep.DetachedEntities.AnyAsync(u => u.Active == input.Active && u.Id != input.Id);
                if (isExist)
                    throw Oops.Oh(ErrorCode.D5001);
            }

            var app = input.Adapt<SysApp>();
            await app.UpdateExcludeAsync(new[] { nameof(SysApp.Status) }, true);
        }

        /// <summary>
        /// 获取系统应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("/sysApp/detail")]
        public async Task<SysApp> GetApp([FromQuery] QueryAppInput input)
        {
            return await _sysAppRep.DetachedEntities.FirstOrDefaultAsync(u => u.Id == input.Id);
        }

        /// <summary>
        /// 获取系统应用列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("/sysApp/list")]
        public async Task<List<SysApp>> GetAppList()
        {
            return await _sysAppRep.DetachedEntities.Where(u => u.Status == CommonStatus.ENABLE).OrderBy(u => u.Sort).ToListAsync();
        }

        /// <summary>
        /// 设为默认应用
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysApp/setAsDefault")]
        public async Task SetAsDefault(SetDefaultAppInput input)
        {
            var apps = await _sysAppRep.Where(u => u.Status == CommonStatus.ENABLE).ToListAsync();
            apps.ForEach(u =>
            {
                u.Active = YesOrNot.N.ToString();
            });

            var app = await _sysAppRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            app.Active = YesOrNot.Y.ToString();
        }

        /// <summary>
        /// 修改用户状态
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysApp/changeStatus")]
        public async Task ChangeUserAppStatus(ChangeUserAppStatusInput input)
        {
            if (!Enum.IsDefined(typeof(CommonStatus), input.Status))
                throw Oops.Oh(ErrorCode.D3005);

            var app = await _sysAppRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            app.Status = input.Status;
        }

    }
}
