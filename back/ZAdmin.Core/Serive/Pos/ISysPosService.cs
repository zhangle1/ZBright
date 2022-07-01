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
    public interface ISysPosService
    {
        Task AddPos(AddPosInput input);

        Task DeletePos(DeletePosInput input);

        Task<SysPos> GetPos([FromQuery] QueryPosInput input);

        Task<List<SysPos>> GetPosList([FromQuery] PosInput input);

        Task<PageResult<SysPos>> QueryPosPageList([FromQuery] PosInput input);

        Task UpdatePos(UpdatePosInput input);
    }
}
