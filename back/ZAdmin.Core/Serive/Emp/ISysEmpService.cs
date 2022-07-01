﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Emp.Dto;

namespace ZAdmin.Core.Serive.Emp
{


    public interface ISysEmpService
    {
        Task AddOrUpdate(EmpOutput2 sysEmpParam);

        Task DeleteEmpInfoByUserId(long empId);

        Task<EmpOutput> GetEmpInfo(long empId);

        Task<long> GetEmpOrgId(long empId);

        Task<bool> HasOrgEmp(long orgId);

        Task UpdateEmpOrgInfo(long orgId, string orgName);

        Task<List<SysEmp>> HasOrgEmp(List<long> orgIds);
    }
}
