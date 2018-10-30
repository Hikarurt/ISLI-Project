using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfo
    {
        [Key]
        public int UId { get; set; }
        public string LoginId { get; set; }
        public string Pwd { get; set; }
    }
}
