using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc控制器往试图传值.Controllers
{
    public class PersonController : Controller
    {
        /// <summary>
        /// viewBag传值
        /// </summary>
        /// <returns></returns>
        public ActionResult ViewBagDemo()
        {
            //viewbag传值的时候，名称是随便定义的，但要见名识意
            ViewBag.Name = "xiaoqiang";


            Mvc控制器往试图传值.PersonModel personModel = new PersonModel { id = 1, name = "周星驰" };
            ViewBag.PersonObject = personModel;

            ViewData["PersonObject"] = personModel;

            TempData["PersonObject"] = personModel;

            return View();
        }

        /// <summary>
        /// viewdata传值
        /// </summary>
        /// <returns></returns>
        public ActionResult ViewDataDemo()
        {
            ViewData["Name"] = "zhonguo";
            return View();
        }

        /// <summary>
        /// TempData传值
        /// </summary>
        /// <returns></returns>
        public ActionResult TempDataDemo()
        {
            TempData["Name"] = "打豆豆";
            return View();
        }

    }
}
