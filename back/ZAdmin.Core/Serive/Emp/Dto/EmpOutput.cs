using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Serive.Emp.Dto
{
    /// <summary>
    /// 员工信息参数
    /// </summary>
    public class EmpOutput
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNum { get; set; }

        /// <summary>
        /// 机构id
        /// </summary>
        public string OrgId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 机构与职位信息
        /// </summary>
        public List<EmpExtOrgPosOutput> ExtOrgPos { get; set; } = new List<EmpExtOrgPosOutput>();

        /// <summary>
        /// 职位信息
        /// </summary>
        public List<EmpPosOutput> Positions { get; set; } = new List<EmpPosOutput>();
    }
}
