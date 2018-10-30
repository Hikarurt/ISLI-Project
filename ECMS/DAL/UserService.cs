using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserService
    {
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public AdminInfo AdminLogin(string name, string pwd)
        {
            using (ECContext ctx = new ECContext())
            {
                return ctx.AdminInfo.Where(m => m.LoginId == name && m.Pwd == pwd).FirstOrDefault();
            }
        }

        /// <summary>
        /// 买家登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public UserInfo UserLogin(string name, string pwd)
        {
            using (ECContext ctx = new ECContext())
            {
                return ctx.UserInfo.Where(m => m.LoginId == name && m.Pwd == pwd).FirstOrDefault();
            }
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int RegisterUser(UserInfo user)
        {
            using (ECContext ctx = new ECContext())
            {
                ctx.UserInfo.Add(user);
                return ctx.SaveChanges();
            }
        }
        /// <summary>
        /// 检查用户名是否存在，返回大于0则存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int CheckUserName(string name)
        {
            using (ECContext ctx = new ECContext())
            {
                return ctx.UserInfo.Where(m => m.LoginId == name).Count();
            }
        }

       
    }
}
