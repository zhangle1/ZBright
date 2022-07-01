using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Util
{
    public class PageResult<T>
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int TotalRows { get; set; }
        public ICollection<T> Rows { get; set; }
    }
}
