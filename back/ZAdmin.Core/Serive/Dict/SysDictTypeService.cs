using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Dict.Dto;
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

        public Task AddDictType(AddDictTypeInput input)
        {
            throw new NotImplementedException();
        }

        public Task ChangeDictTypeStatus(ChangeStateDictTypeInput input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDictType(DeleteDictTypeInput input)
        {
            throw new NotImplementedException();
        }

        public Task<List<DictTreeOutput>> GetDictTree()
        {
            throw new NotImplementedException();
        }

        public Task<SysDictType> GetDictType([FromQuery] QueryDictTypeInfoInput input)
        {
            throw new NotImplementedException();
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

        public Task<List<SysDictType>> GetDictTypeList()
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<SysDictType>> QueryDictTypePageList([FromQuery] DictTypePageInput input)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDictType(UpdateDictTypeInput input)
        {
            throw new NotImplementedException();
        }
    }
}
