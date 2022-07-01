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
    public interface ISysDictTypeService
    {
        Task AddDictType(AddDictTypeInput input);

        Task ChangeDictTypeStatus(ChangeStateDictTypeInput input);

        Task DeleteDictType(DeleteDictTypeInput input);

        Task<List<DictTreeOutput>> GetDictTree();

        Task<SysDictType> GetDictType([FromQuery] QueryDictTypeInfoInput input);

        Task<List<SysDictData>> GetDictTypeDropDown([FromQuery] DropDownDictTypeInput input);

        Task<List<SysDictType>> GetDictTypeList();

        Task<PageResult<SysDictType>> QueryDictTypePageList([FromQuery] DictTypePageInput input);

        Task UpdateDictType(UpdateDictTypeInput input);
    }
}
