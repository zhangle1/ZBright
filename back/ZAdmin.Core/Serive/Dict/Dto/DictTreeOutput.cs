using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Serive.Dict.Dto
{
    /// <summary>
    /// 字典类型与字典值构造的树
    /// </summary>
    public class DictTreeOutput
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 父Id
        /// </summary>
        public long Pid { get; set; }

        /// <summary>
        /// 编码-对应字典值的编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称-对应字典值的value
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 子节点集合
        /// </summary>
        public List<DictTreeOutput> Children { get; set; } = new List<DictTreeOutput>();
    }
}
