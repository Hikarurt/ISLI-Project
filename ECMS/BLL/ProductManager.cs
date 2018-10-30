
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class ProductManager
    {
        ProductService service = new ProductService();
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return service.GetProducts();
        }
        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public int AddProduct(Product pro)
        {
            return service.AddProduct(pro);
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public int UpdateProduct(Product pro)
        {
            return service.UpdateProduct(pro);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteProduct(int id)
        {
            return service.DeleteProduct(id);
        }

        /// <summary>
        /// 查询所有商品类型
        /// </summary>
        /// <returns></returns>
        public List<ProType> GetProType()
        {
            return service.GetProType();
        }

        /// <summary>
        /// 根据id查询商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            return service.GetProductById(id);
        }

        /// <summary>
        /// 分页查询商品
        /// </summary>
        /// <param name="size">每页显示的条数</param>
        /// <param name="index">索引页数</param>
        /// <returns></returns>
        public PageList GetProductByPage(int size, int index)
        {

            return service.GetProductByPage(size, index);
        }
    }
}
