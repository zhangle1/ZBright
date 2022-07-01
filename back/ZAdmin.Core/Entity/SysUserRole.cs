using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Entity
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    [Table("sys_user_role")]
    [Comment("用户角色表")]
    public class SysUserRole: IEntity
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        [Comment("用户Id")]
        public long SysUserId { get; set; }

        /// <summary>
        /// 一对一引用（系统用户）
        /// </summary>
        public SysUser SysUser { get; set; }

        /// <summary>
        /// 系统角色Id
        /// </summary>
        [Comment("角色Id")]
        public long SysRoleId { get; set; }



        /// <summary>
        /// 一对一引用（系统角色）
        /// </summary>
        public SysRole SysRole { get; set; }



    }
}
