using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 商品类型
    /// </summary>
    public class ProType
    {
        [Key]
        public int TId { get; set; }
        public string TName { get; set; }
    }
}
