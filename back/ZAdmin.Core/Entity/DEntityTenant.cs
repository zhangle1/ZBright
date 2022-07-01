using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Entity
{
    public abstract class DEntityTenant: DEntityBase
    {
        /// <summary>
        /// 租户id
        /// </summary>
        [Comment("租户id")]
        public virtual long? TenantId { get; set; }
    }
}
