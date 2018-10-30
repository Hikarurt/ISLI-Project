using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class AdminInfo
    {
        [Key]
        public int AId { get; set; }
        public string LoginId { get; set; }
        public string Pwd { get; set; }
    }
}
