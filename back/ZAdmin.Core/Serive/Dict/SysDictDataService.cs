using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    /// 字典值服务
    /// </summary>
    [ApiDescriptionSettings(Name = "DictData", Order = 100)]
    [AllowAnonymous]
    public class SysDictDataService : ISysDictDataService, IDynamicApiController, ITransient
    {

        private readonly IRepository<SysDictData> _sysDictDataRep;  // 字典类型表仓储

        public SysDictDataService(IRepository<SysDictData> sysDictDataRep)
        {
            _sysDictDataRep = sysDictDataRep;
        }

        public Task AddDictData(AddDictDataInput input)
        {
            throw new NotImplementedException();
        }

        public Task ChangeDictDataStatus(ChageStateDictDataInput input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByTypeId(long dictTypeId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDictData(DeleteDictDataInput input)
        {
            throw new NotImplementedException();
        }

        public Task<SysDictData> GetDictData([FromQuery] QueryDictDataInput input)
        {
            throw new NotImplementedException();
        }

        public Task<List<SysDictData>> GetDictDataList([FromQuery] QueryDictDataListInput input)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 根据字典类型Id获取字典值集合
        /// </summary>
        /// <param name="dictTypeId"></param>
        /// <returns></returns>
        [NonAction]
        public async Task<List<SysDictData>> GetDictDataListByDictTypeId(long dictTypeId)
        {
            return await _sysDictDataRep.DetachedEntities.Where(u => u.SysDictType.Id == dictTypeId)
                                                         .Where(u => u.Status == CommonStatus.ENABLE).OrderBy(u => u.Sort)
                                                         .ToListAsync();
        }

        public Task<PageResult<DictDataOutput>> QueryDictDataPageList([FromQuery] DictDataPageInput input)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDictData(UpdateDictDataInput input)
        {
            throw new NotImplementedException();
        }
    }
}
