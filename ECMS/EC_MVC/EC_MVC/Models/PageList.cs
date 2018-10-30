using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC_MVC.Models
{
    /// <summary>
    /// 封装分页的相关数据
    /// </summary>
    public class PageList
    {
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage { get; set; }
        /// <summary>
        /// 分页查询的结果
        /// </summary>
        public List<Product> ProductList { get; set; }
    }
}