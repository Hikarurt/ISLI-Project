using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc参数传递方法.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 传参方式1
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonList()
        {
            var id = Request["id"];
            ViewBag.id = id;
            return View();
        }

        /// <summary>
        /// 传参方式2
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult PersonList2(int id)
        {
            ViewBag.id = id;
            return View();
        }

    }
}
