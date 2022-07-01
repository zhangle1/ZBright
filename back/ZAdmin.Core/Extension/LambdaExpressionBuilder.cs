using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Extension
{
    /// <summary>
    /// 动态生成查询表达式
    /// </summary>
    public class LambdaExpressionBuilder
    {
    }



    [Serializable]
    public class Condition
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// 操作符
        /// </summary>
        public QueryTypeEnum Op { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        public string OrGroup { get; set; }
    }
}
