using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAdmin.Core.Serive.Org.Dto
{
    public interface ISysOrgService
    {

        Task<List<long>> GetDataScopeListByDataScopeType(int dataScopeType, long orgId);


        Task<dynamic> GetOrgTree();

        Task<List<long>> GetUserDataScopeIdList();


        Task<List<long>> GetAllDataScopeIdList();


    }
}
