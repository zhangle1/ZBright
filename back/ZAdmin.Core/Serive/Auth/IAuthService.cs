using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAdmin.Core.Serive.Auth.Dto;

namespace ZAdmin.Core.Serive
{
    public interface IAuthService
    {
        string LoginAsync([FromBody] LoginInput input);


    }
}
