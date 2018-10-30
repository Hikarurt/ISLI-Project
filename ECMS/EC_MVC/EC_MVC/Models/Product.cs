using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_MVC.Models
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class Product
    {
        
        public int PId { get; set; }
        public string PName { get; set; }
        public decimal Price { get; set; }
        public string PImg { get; set; }
        public string Content { get; set; }
        /// <summary>
        /// 管理员ID
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 商品类型ID
        /// </summary>
        public int TId { get; set; }

     
        public virtual AdminInfo AdminInfo { get; set; }

       
        public virtual ProType ProType { get; set; }
    }
}
