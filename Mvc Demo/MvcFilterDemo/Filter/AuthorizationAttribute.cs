using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//引用命名空间
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace MvcFilterDemo.Filter
{
    /// <summary>
    /// 授权过滤器
    /// </summary>
    public class AuthorizationAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 授权过滤方法
        /// </summary>
        /// <param name="filterContext">授权上下文</param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserInfo"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/home/login");
            }

            //if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            //{
            //    var strUserData = ((FormsIdentity)User.Identity).Ticket.UserData;
            //    _loginInfo = new JavaScriptSerializer().Deserialize<UserData>(strUserData);

            //    _loginInfo = RedisHelper.Get<UserData>(_loginInfo.Id.ToString());


            //    var action = filterContext.RouteData.Values["Action"];
            //    var controller = filterContext.RouteData.Values["Controller"];
            //    var tmpVal = (controller + "/" + action).ToLower();

            //    _loginInfo.RoleList
               
            //        _loginInfo.PermissionList  


            //}
        }
    }
}