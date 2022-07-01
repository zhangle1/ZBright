using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Entity
{
    /// <summary>
    /// 数据权限接口，实现数据权限必须继承本接口
    /// </summary>
    public interface IDataPermissions
    {
        /// <summary>
        /// 创建用户部门id
        /// </summary>
        long? CreatedUserOrgId { get; set; }

        /// <summary>
        /// 创建用户部门名称
        /// </summary>
        string CreatedUserOrgName { get; set; }

        /// <summary>
        /// 创建者Id
        /// </summary>
        long? CreatedUserId { get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        string CreatedUserName { get; set; }
    }
}
