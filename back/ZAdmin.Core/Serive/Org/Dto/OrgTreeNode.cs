using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.Org.Dto
{
    /// <summary>
    /// 组织机构树
    /// </summary>
    public class OrgTreeNode : ITreeNode
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 父Id
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// 排序，越小优先级越高
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<OrgTreeNode> Children { get; set; } = new List<OrgTreeNode>();

        /// <summary>
        /// 上一级Id
        /// </summary>
        public long Pid { get; set; }

        public long GetId()
        {
            return Id;
        }

        public long GetPid()
        {
            return ParentId;
        }

        public void SetChildren(IList children)
        {
            Children = (List<OrgTreeNode>)children;
        }
    }
}
