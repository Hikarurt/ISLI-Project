using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilterDemo.Filter
{
    /// <summary>
    /// 结果过滤器
    /// </summary>
    public class MyResultFilter : ActionFilterAttribute,IResultFilter
    {

        /// <summary>
        /// 结果执行前实现的方法
        /// </summary>
        /// <param name="filterContext">结果过滤器的上下文</param>
        public new void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>方法名称：OnResultExecuting   (Html页面渲染之前执行的方法)</p>");
        }

        /// <summary>
        /// 结果执行后实现的方法
        /// </summary>
        /// <param name="filterContext">结果过滤器的上下文</param>
        public new void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>方法名称：OnResultExecuted   (Html页面渲染之后执行的方法) </p>");
        }
    }
}