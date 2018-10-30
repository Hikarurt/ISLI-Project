using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Demo.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }


        public ActionResult Delete()
        {
            return View();
        }
    }
}
