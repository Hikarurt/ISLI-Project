using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
//引用命名空间
using System.Web.Mvc;

namespace MvcFilterDemo.Filter
{
    /// <summary>
    /// 异常过滤器
    /// </summary>
    public class ExceptionFilter:FilterAttribute,IExceptionFilter
    {
        /// <summary>
        /// 异常实现方法
        /// </summary>
        /// <param name="filterContext">过滤器的上下文</param>
        public void OnException(ExceptionContext filterContext)
        {
            var filePath = filterContext.HttpContext.Server.MapPath(@"~\app_data\log.txt");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("捕获异常的时间：{0}", DateTime.Now.ToString());
                sw.WriteLine("错误信息：{0}", filterContext.Exception.Message);
                sw.WriteLine("执行方法名称：{0}", filterContext.RouteData.Values["Action"]);
                sw.WriteLine("控制器名称：{0}", filterContext.RouteData.Values["Controller"]);
            }

            filterContext.HttpContext.Response.Redirect("/home/ErroInfo");
        }
    }
}