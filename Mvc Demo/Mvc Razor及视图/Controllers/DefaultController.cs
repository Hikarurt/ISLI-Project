using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Razor及视图.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult add()
        {
            return View();
        }

        public ActionResult personList()
        {
            return View();
        }

    }
}
