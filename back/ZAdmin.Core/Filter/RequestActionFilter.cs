using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAParser;
using ZAdmin.Core.Util;

namespace ZAdmin.Core.Filter
{
    /// <summary>
    /// 请求日志拦截
    /// </summary>
    public class RequestActionFilter : IAsyncActionFilter
    {

        public RequestActionFilter()
        {

        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var httpContext = context.HttpContext;
            var httpRequest = httpContext.Request;

            var sw = new Stopwatch();
            sw.Start();
            var actionContext = await next();
            sw.Stop();

            // 判断是否请求成功（没有异常就是请求成功）
            var isRequestSucceed = actionContext.Exception == null;
            var headers = httpRequest.Headers;
            var clientInfo = headers.ContainsKey("User-Agent") ? Parser.GetDefault().Parse(headers["User-Agent"]) : null;
            var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;

            var ip = httpContext.GetRequestIPv4();

            //判断是否需有禁用操作日志属性
            //foreach (var metadata in actionDescriptor.EndpointMetadata)
            //{
            //    if (metadata.GetType() == typeof(DisableOpLogAttribute))
            //    {
            //        //禁用操作日志，直接返回
            //        return;
            //    }
            //}


            await  Task.FromResult("");

        }
    }
}
