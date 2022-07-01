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
    public class SysUserDataScopeSeedData : IEntitySeedData<SysUserDataScope>
    {
        public IEnumerable<SysUserDataScope> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new[]
            {
                new SysUserDataScope{SysUserId=142307070910554, SysOrgId=142307070910547 }
            };
        }
    }
}
