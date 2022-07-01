using Furion;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ZAdmin.EntityFramework.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
  

        services.AddDatabaseAccessor(options =>
        {
            options.CustomizeMultiTenants(); // 自定义租户

            options.AddDbPool<DefaultDbContext>(providerName: default, optionBuilder: opt =>
            {
                opt.UseBatchEF_MySQLPomelo(); // EF批量组件
            });
        }, "ZAdmin.Database.Migrations");
    }
}
