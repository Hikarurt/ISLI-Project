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
    /// 购物车表
    /// </summary>
    public class ShoppingCar
    {
        [Key]
        public int CId { get; set; }
        public int PId { get; set; }
        public int UId { get; set; }
        public int Num { get; set; }

        [ForeignKey("UId")]
        public virtual UserInfo UserInfo { get; set; }

        [ForeignKey("PId")]
        public virtual Product Product { get; set; }
    }
}
