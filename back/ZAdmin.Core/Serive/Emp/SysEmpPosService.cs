using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Emp.Dto;

namespace ZAdmin.Core.Serive.Emp
{

    /// <summary>
    /// 员工职位服务
    /// </summary>
    public class SysEmpPosService : ISysEmpPosService, ITransient
    {
        private readonly IRepository<SysEmpPos> _sysEmpPosRep;  // 员工职位表仓储

        public SysEmpPosService(IRepository<SysEmpPos> sysEmpPosRep)
        {
            _sysEmpPosRep = sysEmpPosRep;
        }



        public async Task AddOrUpdate(long empId, List<long> posIdList)
        {
            // 先删除
            await DeleteEmpPosInfoByUserId(empId);

            var empPos = posIdList.Select(u => new SysEmpPos
            {
                SysEmpId = empId,
                SysPosId = u
            }).ToList();
            await _sysEmpPosRep.InsertAsync(empPos);
        }


        public async Task<List<EmpPosOutput>> GetEmpPosList(long empId)
        {
            return await _sysEmpPosRep.DetachedEntities
                                      .Where(u => u.SysEmpId == empId)
                                      .Select(u => new EmpPosOutput
                                      {
                                          PosId = u.SysPos.Id,
                                          PosCode = u.SysPos.Code,
                                          PosName = u.SysPos.Name
                                      }).ToListAsync();
        }



        public async Task DeleteEmpPosInfoByUserId(long empId)
        {
            var sepList = await _sysEmpPosRep.AsQueryable(u => u.SysEmpId == empId, false).ToListAsync();
            await _sysEmpPosRep.DeleteAsync(sepList);
        }


        public async Task<bool> HasPosEmp(long posId)
        {
            return await _sysEmpPosRep.DetachedEntities.AnyAsync(u => u.SysPosId == posId);
        }
    }
}
