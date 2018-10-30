using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace UI_Api.Controllers
{
    public class UserController : ApiController
    {
        UserManager uManager = new UserManager();
       

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        public AdminInfo AdminLogin(string id, string pwd)
        {
            return uManager.AdminLogin(id, pwd);
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        public UserInfo UserLogin(string id, string pwd)
        {
            return uManager.UserLogin(id, pwd);
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public int RegisterUser(UserInfo user)
        {
            return uManager.RegisterUser(user);
        }

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public int CheckUserName(string id) 
        {
            return uManager.CheckUserName(id);
        }

       
    }
}
