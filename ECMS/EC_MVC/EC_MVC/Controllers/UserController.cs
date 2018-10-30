using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using EC_MVC.Models;

namespace EC_MVC.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Login()
        {
            return View();
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult Login(string userName, string pwd, string type)
        {
            //1是管理员，2是用户
            if (type == "1")
            {
                string json = WebApiHelper.GetApiResult("get","user", "AdminLogin/" + userName + "?pwd=" + pwd);
                if (json != "null")
                {
                    Session["user"] = JsonConvert.DeserializeObject<AdminInfo>(json);
                    return Redirect("/admin/index");
                }
            }
            else
            {
                string json = WebApiHelper.GetApiResult("get", "user", "UserLogin/" + userName + "?pwd=" + pwd);
                if (json != "null")
                {
                    Session["user"] = JsonConvert.DeserializeObject<UserInfo>(json);
                    return Redirect("/user/index");
                }
            }


            Response.Write("<script>alert('登录失败')</script>");

            return View();

        }


        public ActionResult Register()
        {
            return View();
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult Register(UserInfo user)
        {
            string json = WebApiHelper.GetApiResult("post", "user", "RegisterUser", user);

            if (int.Parse(json)>0)
            {
                Response.Write("<script>alert('注册成功');location.href='/user/login'</script>");
            }
            return View();
        }




    }
}