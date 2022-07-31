using Furion.DatabaseAccessor;
using Furion.DatabaseAccessor.Extensions;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Dict.Dto;
using ZAdmin.Core.Serive.User;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.Dict
{

    /// <summary>
    /// 字典类型服务
    /// </summary>
    [ApiDescriptionSettings(Name = "DictType", Order = 100)]
    [AllowAnonymous]
    public class SysDictTypeService : ISysDictTypeService, IDynamicApiController, ITransient
    {

        private readonly IRepository<SysDictType> _sysDictTypeRep;  // 字典类型表仓储
        private readonly ISysDictDataService _sysDictDataService;

        public SysDictTypeService(IRepository<SysDictType> sysDictTypeRep, ISysDictDataService sysDictDataService)
        {
            _sysDictTypeRep = sysDictTypeRep;
            _sysDictDataService = sysDictDataService;
        }

        /// <summary>
        /// 分页查询字典类型
        /// </summary>
        /// <returns></returns>
        [HttpGet("/sysDictType/page")]
        public async Task<PageResult<SysDictType>> QueryDictTypePageList([FromQuery] DictTypePageInput input)
        {
            bool supperAdmin = CurrentUserInfo.IsSuperAdmin;
            var code = !string.IsNullOrEmpty(input.Code?.Trim());
            var name = !string.IsNullOrEmpty(input.Name?.Trim());
            var dictTypes = await _sysDictTypeRep.DetachedEntities
                                  .Where((code, u => EF.Functions.Like(u.Code, $"%{input.Code.Trim()}%")),
                                         (name, u => EF.Functions.Like(u.Name, $"%{input.Name.Trim()}%")))
                                  .Where(u => (u.Status != CommonStatus.DELETED && !supperAdmin) || (u.Status <= CommonStatus.DELETED && supperAdmin)).OrderBy(u => u.Sort)
                                  .ToADPagedListAsync(input.PageNo, input.PageSize);
            return dictTypes;
        }

        /// <summary>
        /// 获取字典类型列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("/sysDictType/list")]
        public async Task<List<SysDictType>> GetDictTypeList()
        {
            return await _sysDictTypeRep.DetachedEntities.Where(u => u.Status != CommonStatus.DELETED).ToListAsync();
        }

        /// <summary>
        /// 获取字典类型下所有字典值
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/sysDictType/dropDown")]
        public async Task<List<SysDictData>> GetDictTypeDropDown([FromQuery] DropDownDictTypeInput input)
        {
            var dictType = await _sysDictTypeRep.FirstOrDefaultAsync(u => u.Code == input.Code, false);
            if (dictType == null) throw Oops.Oh(ErrorCode.D3000);
            return await _sysDictDataService.GetDictDataListByDictTypeId(dictType.Id);
        }

        /// <summary>
        /// 添加字典类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysDictType/add")]
        public async Task AddDictType(AddDictTypeInput input)
        {
            var isExist = await _sysDictTypeRep.AnyAsync(u => u.Name == input.Name || u.Code == input.Code, false);
            if (isExist) throw Oops.Oh(ErrorCode.D3001);

            var dictType = input.Adapt<SysDictType>();
            await _sysDictTypeRep.InsertAsync(dictType);
        }

        /// <summary>
        /// 删除字典类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysDictType/delete")]
        public async Task DeleteDictType(DeleteDictTypeInput input)
        {
            var dictType = await _sysDictTypeRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            if (dictType == null) throw Oops.Oh(ErrorCode.D3000);

            if (dictType.Status == CommonStatus.DELETED)
            {
                await dictType.DeleteAsync();
            }
            else
            {
                dictType.Status = CommonStatus.DELETED;
                dictType.IsDeleted = true;
            }
        }

        /// <summary>
        /// 更新字典类型
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysDictType/edit"),]
        public async Task UpdateDictType(UpdateDictTypeInput input)
        {
            var isExist = await _sysDictTypeRep.AnyAsync(u => u.Id == input.Id, false);
            if (!isExist) throw Oops.Oh(ErrorCode.D3000);

            // 排除自己并且判断与其他是否相同
            isExist = await _sysDictTypeRep.AnyAsync(u => (u.Name == input.Name || u.Code == input.Code) && u.Id != input.Id, false);
            if (isExist) throw Oops.Oh(ErrorCode.D3001);

            var dictType = input.Adapt<SysDictType>();
            await _sysDictTypeRep.UpdateAsync(dictType, ignoreNullValues: true);
        }

        /// <summary>
        /// 字典类型详情
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet("/sysDictType/detail")]
        public async Task<SysDictType> GetDictType([FromQuery] QueryDictTypeInfoInput input)
        {
            return await _sysDictTypeRep.FirstOrDefaultAsync(u => u.Id == input.Id, false);
        }

        /// <summary>
        /// 更新字典类型状态
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("/sysDictType/changeStatus")]
        public async Task ChangeDictTypeStatus(ChangeStateDictTypeInput input)
        {
            var dictType = await _sysDictTypeRep.FirstOrDefaultAsync(u => u.Id == input.Id);
            if (dictType == null) throw Oops.Oh(ErrorCode.D3000);

            if (!Enum.IsDefined(typeof(CommonStatus), input.Status))
                throw Oops.Oh(ErrorCode.D3005);

            dictType.Status = input.Status;
            dictType.IsDeleted = false;
        }

        /// <summary>
        /// 字典类型与字典值构造的字典树
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/sysDictType/tree")]
        public async Task<List<DictTreeOutput>> GetDictTree()
        {
            return await _sysDictTypeRep.DetachedEntities.Select(u => new DictTreeOutput
            {
                Id = u.Id,
                Code = u.Code,
                Name = u.Name,
                Children = u.SysDictDatas.Select(c => new DictTreeOutput
                {
                    Id = c.Id,
                    Pid = c.TypeId,
                    Code = c.Code,
                    Name = c.Value
                }).ToList()
            }).ToListAsync();
        }
    }
}
