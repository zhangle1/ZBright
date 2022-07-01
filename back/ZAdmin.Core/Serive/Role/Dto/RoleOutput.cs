using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Serive.Role.Dto
{
    public class RoleOutput
    {
        /// <summary>
        /// 角色类型-集团角色_0、加盟商角色_1、门店角色_2
        /// </summary>
        public RoleTypeEnum RoleType { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }
}
