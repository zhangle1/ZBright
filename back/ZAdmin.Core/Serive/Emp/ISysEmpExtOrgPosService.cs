using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.Emp.Dto;

namespace ZAdmin.Core.Serive.Emp
{

    public interface ISysEmpExtOrgPosService
    {
        Task AddOrUpdate(long empId, List<EmpExtOrgPosOutput> extIdList);

        Task DeleteEmpExtInfoByUserId(long empId);

        Task<List<EmpExtOrgPosOutput>> GetEmpExtOrgPosList(long empId);

        Task<bool> HasExtOrgEmp(long orgId);

        Task<bool> HasExtPosEmp(long posId);
    }
}
