using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.Emp.Dto;

namespace ZAdmin.Core.Serive.Emp
{
    public interface ISysEmpPosService
    {
        Task AddOrUpdate(long empId, List<long> posIdList);

        Task DeleteEmpPosInfoByUserId(long empId);

        Task<List<EmpPosOutput>> GetEmpPosList(long empId);

        Task<bool> HasPosEmp(long posId);
    }
}
