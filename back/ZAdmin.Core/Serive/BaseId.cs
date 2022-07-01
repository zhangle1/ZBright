using Furion.DataValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Serive
{

    /// <summary>
    /// 主键Id映射DTO
    /// </summary>
    public class BaseId
    {

        [Required(ErrorMessage ="Id不能为空")]
        [DataValidation(ValidationTypes.Numeric)]
        public long Id { get; set; }
        
    }
}
