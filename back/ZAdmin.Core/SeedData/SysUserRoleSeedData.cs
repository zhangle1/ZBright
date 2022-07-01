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
    public class SysUserRoleSeedData : IEntitySeedData<SysUserRole>
    {
        public IEnumerable<SysUserRole> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new[]
            {
                // 租户管理员默认管理员角色
                new SysUserRole {SysUserId = 142307070910552, SysRoleId = 142307070910554},
                new SysUserRole {SysUserId = 142307070910554, SysRoleId = 142307070910556}
            };
        }
    }
}
