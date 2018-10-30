using MvcFilterDemo.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilterDemo.Controllers
{
    public class HomeController : Controller
    {

        [AuthorizationAttribute]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizationAttribute]
        public ActionResult Add()
        {
            return View();
        }

        [ExceptionFilter]
        public ActionResult Login(string name)
        {
           // name.ToString();
            Session["UserInfo"] = null;
            return View();
        }

        /// <summary>
        /// 所有页面发生错误，跳转到该页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ErroInfo()
        {
            return View();
        }

        //动作过滤器
        [MyActionFilter]
        //结果过滤器
        [MyResultFilter]
        public ActionResult UserList()
        {
            ViewBag.User = "zhangsan";
            return View();
        }

    }
}
