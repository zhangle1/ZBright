using Furion;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ZAdmin.Core.Filter;
using ZAdmin.Core.Options;
using ZAdmin.Core.Util;
using ZAdmin.Web.Core.Handlers;

namespace ZAdmin.Web.Core;

public class Startup : AppStartup
{
    public void ConfigureServices(IServiceCollection services)
    {


        services.AddConfigurableOptions<RefreshTokenSettingOptions>();
        services.AddJwt<JwtHandler>(enableGlobalAuthorize: true);
        services.AddCorsAccessor();
        //services.AddSpecificationDocuments();
        services.AddRemoteRequest();

        services.AddControllersWithViews().
        AddMvcFilter<RequestActionFilter>().AddNewtonsoftJson(options =>
        {
            // 首字母小写(驼峰样式)
            options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            // 时间格式化
            options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            // 忽略循环引用
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            // 忽略空值
            // options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }).AddInjectWithUnifyResult<XnRestfulResultProvider>();
        //services.AddDynamicApiControllers();
        services.AddViewEngine();


    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }


        // 添加状态码拦截中间件
        app.UseUnifyResultStatusCodes();

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseCorsAccessor();


        app.UseAuthentication();
        app.UseAuthorization();
        //app.UseInjectBase();
        app.UseInject(string.Empty);

        
        app.UseEndpoints(endpoints =>
        {
            //endpoints.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            //endpoints.MapControllers();

            //endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
