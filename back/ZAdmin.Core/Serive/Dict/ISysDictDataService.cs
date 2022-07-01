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
    public interface ISysDictDataService
    {
        Task AddDictData(AddDictDataInput input);

        Task ChangeDictDataStatus(ChageStateDictDataInput input);

        Task DeleteByTypeId(long dictTypeId);

        Task DeleteDictData(DeleteDictDataInput input);

        Task<SysDictData> GetDictData([FromQuery] QueryDictDataInput input);

        Task<List<SysDictData>> GetDictDataList([FromQuery] QueryDictDataListInput input);

        Task<List<SysDictData>> GetDictDataListByDictTypeId(long dictTypeId);

        Task<PageResult<DictDataOutput>> QueryDictDataPageList([FromQuery] DictDataPageInput input);

        Task UpdateDictData(UpdateDictDataInput input);
    }
}
