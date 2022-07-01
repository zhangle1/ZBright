using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Entity;
using ZAdmin.Core.Serive.Org.Dto;

namespace ZAdmin.Core.Mapper
{
    public class CustomMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<SysOrg, OrgTreeNode>()
                .Map(dest => dest.ParentId, src => src.Pid)
                .Map(dest => dest.Title, src => src.Name)
                .Map(dest => dest.Value, src => src.Id)
                .Map(dest => dest.Weight, src => src.Sort);
        }
    }
}
