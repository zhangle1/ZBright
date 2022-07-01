using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;

namespace ZAdmin.Core.SeedData
{
    public class SysEmpExtOrgPosData : IEntitySeedData<SysEmpExtOrgPos>
    {
        public IEnumerable<SysEmpExtOrgPos> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new[]
            {
                new SysEmpExtOrgPos { SysEmpId = 142307070910551, SysOrgId = 142307070910539, SysPosId = 142307070910547 },
                new SysEmpExtOrgPos { SysEmpId = 142307070910551, SysOrgId = 142307070910540, SysPosId = 142307070910548 },
                new SysEmpExtOrgPos { SysEmpId = 142307070910551, SysOrgId = 142307070910541, SysPosId = 142307070910549 },
                new SysEmpExtOrgPos { SysEmpId = 142307070910551, SysOrgId = 142307070910542, SysPosId = 142307070910550 },
                new SysEmpExtOrgPos { SysEmpId = 142307070910553, SysOrgId = 142307070910542, SysPosId = 142307070910547 }
            };
        }
    }
}
