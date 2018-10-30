using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilterDemo.Filter
{
    /// <summary>
    /// 动作过滤器
    /// </summary>
    public class MyActionFilter:ActionFilterAttribute,IActionFilter
    {

        /// <summary>
        /// 动作执行之前执行的过滤方法
        /// </summary>
        /// <param name="filterContext">过滤器的上下文</param>
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>方法名称：OnActionExecuting  (action 的执行之前执行该方法)</p>");

            var filePath = filterContext.HttpContext.Server.MapPath(@"~\app_data\Loginlog.txt");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("登录的时间：{0}", DateTime.Now.ToString());
                sw.WriteLine("Ip：{0}", filterContext.HttpContext.Request.UserHostAddress);
                sw.WriteLine("主机Dns名称：{0}", filterContext.HttpContext.Request.UserHostName);
                sw.WriteLine("浏览器名称：{0}", filterContext.HttpContext.Request.Browser);
            }
        }

        /// <summary>
        /// 动作执行之后执行的过滤方法
        /// </summary>
        /// <param name="filterContext">过滤器的上下文</param>
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>方法名称：OnActionExecuted  (action 的return 执行后再执行的)</p>");
        }
    }
}