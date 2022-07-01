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
    public class SysRoleSeedData : IEntitySeedData<SysRole>
    {
        public IEnumerable<SysRole> HasData(DbContext dbContext, Type dbContextLocator)
        {
            return new[]
{
                new SysRole{TenantId=142307070918780, Id=142307070910554, Name="系统管理员", Code="sys_manager_role", Sort=100, DataScopeType=DataScopeType.ALL, Remark="系统管理员", Status=0 },
                new SysRole{TenantId=142307070918780, Id=142307070910555, Name="普通用户", Code="common_role", Sort=101, DataScopeType=DataScopeType.DEFINE, Remark="普通用户", Status=0 },

                new SysRole{TenantId=142307070918781, Id=142307070910556, Name="系统管理员", Code="sys_manager_role", Sort=100, DataScopeType=DataScopeType.DEFINE, Remark="系统管理员", Status=0 },
                new SysRole{TenantId=142307070918781, Id=142307070910557, Name="普通用户", Code="common_role", Sort=101, DataScopeType=DataScopeType.DEFINE, Remark="普通用户", Status=0 },
            };
        }
    }
}
