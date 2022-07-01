using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Serive.Dict.Dto
{
    /// <summary>
    /// 字典类型参数
    /// </summary>
    public class DictTypePageInput : PageInputBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
    }

    public class AddDictTypeInput
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "字典类型名称不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "字典类型编码不能为空")]
        public string Code { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 状态（字典 0正常 1停用 2删除）
        /// </summary>
        public CommonStatus Status { get; set; }
    }

    public class DeleteDictTypeInput : BaseId
    {
    }

    public class UpdateDictTypeInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "字典类型Id不能为空")]
        public long Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "字典类型名称不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "字典类型编码不能为空")]
        public string Code { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 状态（字典 0正常 1停用 2删除）
        /// </summary>
        public CommonStatus Status { get; set; }
    }

    public class ChangeStateDictTypeInput
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required(ErrorMessage = "字典类型Id不能为空")]
        public long Id { get; set; }

        /// <summary>
        /// 状态（字典 0正常 1停用 2删除）
        /// </summary>
        public CommonStatus Status { get; set; }
    }

    public class DropDownDictTypeInput
    {
        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "字典类型编码不能为空")]
        public string Code { get; set; }
    }

    public class QueryDictTypeInfoInput : BaseId
    {
    }
}
