﻿using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Emp;
using ZAdmin.Core.Util;
using Microsoft.EntityFrameworkCore;
using Furion.FriendlyException;
using Mapster;
using Furion.DatabaseAccessor.Extensions;

namespace ZAdmin.Core.Serive
{
    /// <summary>
    /// 职位服务
    /// </summary>
    [ApiDescriptionSettings(Name = "Pos", Order = 147)]
    public class SysPosService : ISysPosService, IDynamicApiController, ITransient
    {
        private readonly IRepository<SysPos> _sysPosRep;  // 职位表仓储

        private readonly ISysEmpPosService _sysEmpPosService;
        private readonly ISysEmpExtOrgPosService _sysEmpExtOrgPosService;

        public SysPosService(IRepository<SysPos> sysPosRep, ISysEmpPosService sysEmpPosService, ISysEmpExtOrgPosService sysEmpExtOrgPosService)
        {
            _sysPosRep = sysPosRep;
            _sysEmpPosService = sysEmpPosService;
            _sysEmpExtOrgPosService = sysEmpExtOrgPosService;
        }

        /// <summary>
        /// 分页获取职位
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("/sysPos/page")]
        public async Task<PageResult<SysPos>> QueryPosPageList([FromQuery] PosInput input)
        {
            var name = !string.IsNullOrEmpty(input.Name?.Trim());
            var code = !string.IsNullOrEmpty(input.Code?.Trim());
            var pos = await _sysPosRep.DetachedEntities
                          .Where((name, u => EF.Functions.Like(u.Name, $"%{input.Name.Trim()}%")),
                                 (code, u => EF.Functions.Like(u.Code, $"%{input.Code.Trim()}%")))
                          .Where(u => u.Status == CommonStatus.ENABLE)
                          .OrderBy(u => u.Sort)
                          .ToADPagedListAsync(input.PageNo, input.PageSize);
            return pos;
        }

        /// <summary>
        /// 获取职位列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("/sysPos/list")]
        public async Task<List<SysPos>> GetPosList([FromQuery] PosInput input)
        {
            var code = !string.IsNullOrEmpty(input.Code?.Trim());
            return await _sysPosRep.DetachedEntities.Where(code, u => EF.Functions.Like(u.Code, $"%{input.Code.Trim()}%"))
                                        .Where(u => u.Status != CommonStatus.DELETED)
                                        .OrderBy(u => u.Sort).ToListAsync();
        }

        /// <summary>
        /// 增加职位
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysPos/add")]
        public async Task AddPos(AddPosInput input)
        {
            var isExist = await _sysPosRep.DetachedEntities.AnyAsync(u => u.Name == input.Name || u.Code == input.Code);
            if (isExist)
                throw Oops.Oh(ErrorCode.D6000);
            var pos = input.Adapt<SysPos>();
            await pos.InsertAsync();
        }

        /// <summary>
        /// 删除职位
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysPos/delete")]
        public async Task DeletePos(DeletePosInput input)
        {
            // 该职位下是否有员工
            var hasPosEmp = await _sysEmpPosService.HasPosEmp(input.Id);
            if (hasPosEmp)
                throw Oops.Oh(ErrorCode.D6001);

            // 该附属职位下是否有员工
            var hasExtPosEmp = await _sysEmpExtOrgPosService.HasExtPosEmp(input.Id);
            if (hasExtPosEmp)
                throw Oops.Oh(ErrorCode.D6001);

            var pos = await _sysPosRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            await pos.DeleteAsync();
        }

        /// <summary>
        /// 获取职位
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("/sysPos/detail")]
        public async Task<SysPos> GetPos([FromQuery] QueryPosInput input)
        {
            return await _sysPosRep.DetachedEntities.FirstOrDefaultAsync(u => u.Id == input.Id);
        }

        /// <summary>
        /// 更新职位
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysPos/edit")]
        public async Task UpdatePos(UpdatePosInput input)
        {
            var isExist = await _sysPosRep.DetachedEntities.AnyAsync(u => (u.Name == input.Name || u.Code == input.Code) && u.Id != input.Id);
            if (isExist)
                throw Oops.Oh(ErrorCode.D6000);

            var pos = input.Adapt<SysPos>();
            await pos.UpdateAsync(ignoreNullValues: true);
        }
    }
}
