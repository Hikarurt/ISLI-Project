using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class UserManager
    {
        UserService service = new UserService();
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public AdminInfo AdminLogin(string name, string pwd)
        {
            return service.AdminLogin(name,pwd);
        }

        /// <summary>
        /// 买家登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public UserInfo UserLogin(string name, string pwd)
        {
            return service.UserLogin(name,pwd);
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int RegisterUser(UserInfo user)
        {
            return service.RegisterUser(user);
        }
        /// <summary>
        /// 检查用户名是否存在，返回大于0则存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int CheckUserName(string name)
        {
            return service.CheckUserName(name);
        }
    }
}
