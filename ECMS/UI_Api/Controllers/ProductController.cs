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
    public class ProductController : ApiController
    {
        ProductManager pManager = new ProductManager();
        /// <summary>
        /// 查询商品类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProType> GetProType()
        {
            return pManager.GetProType();
        }
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddProduct(Product pro)
        {
            return pManager.AddProduct(pro);
        }
        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPut]
        public int UpdateProduct(Product p)
        {
            return pManager.UpdateProduct(p);
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteProduct(int id)
        {
            return pManager.DeleteProduct(id);
        }
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return pManager.GetProducts();
        }

        /// <summary>
        /// 根据id查询商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            return pManager.GetProductById(id);
        }

        /// <summary>
        /// 分页查询商品
        /// </summary>
        /// <param name="id">每页显示的条数</param>
        /// <param name="index">索引页数</param>
        /// <returns></returns>
        public PageList GetProductByPage(int id, int index)
        {
           
            return pManager.GetProductByPage(id, index);
        }
    }
}
