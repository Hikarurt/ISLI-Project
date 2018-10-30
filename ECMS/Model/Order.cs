using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Order
    {
        [Key]
        public int OId { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int PId { get; set; }
        public int UId { get; set; }
        public int Num { get; set; }
        public decimal TotalMoney { get; set; }
        public DateTime AddTime { get; set; }
        public string Address { get; set; }
        public string UName { get; set; }
        public string Phone { get; set; }

        [ForeignKey("UId")]
        public virtual UserInfo UserInfo { get; set; }

        [ForeignKey("PId")]
        public virtual Product Product { get; set; }
    }
}
