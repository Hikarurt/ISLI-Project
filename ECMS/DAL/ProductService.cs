using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;

namespace DAL
{
    public class ProductService
    {
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            using (ECContext ctx = new ECContext())
            {
                return ctx.Product.Include("ProType").Include(m => m.AdminInfo).ToList();
            }
        }
        /// <summary>
        /// 新增商品
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public int AddProduct(Product pro)
        {
            using (ECContext ctx = new ECContext())
            {
                ctx.Product.Add(pro);
                return ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        public int UpdateProduct(Product pro)
        {
            using (ECContext ctx = new ECContext())
            {
                ctx.Product.Attach(pro);
                ctx.Entry(pro).State = EntityState.Modified;
                return ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteProduct(int id)
        {
            using (ECContext ctx = new ECContext())
            {
                Product pro = ctx.Product.First(m => m.PId == id);
                ctx.Product.Remove(pro);
                return ctx.SaveChanges();
            }
        }

        /// <summary>
        /// 查询所有商品类型
        /// </summary>
        /// <returns></returns>
        public List<ProType> GetProType()
        {
            using (ECContext ctx = new ECContext())
            {
                return ctx.ProType.ToList();
            }
        }

        /// <summary>
        /// 根据id查询商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            using (ECContext ctx = new ECContext())
            {
                return ctx.Product.First(m => m.PId == id);
            }
        }

        /// <summary>
        /// 分页查询商品
        /// </summary>
        /// <param name="size">每页显示的条数</param>
        /// <param name="index">索引页数</param>
        /// <returns></returns>
        public PageList GetProductByPage(int size, int index)
        {
            PageList page = new PageList();
            //通过配置文件获取连接字符串
            string connStr = ConfigurationManager.ConnectionStrings["ecDB"].ConnectionString;

            //创建连接对象
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "select count(*) from products";
                SqlCommand command = new SqlCommand(sql, conn);
                //查询总条数
                page.TotalCount = (int)command.ExecuteScalar();

                //查询总页数
                page.TotalPage = page.TotalCount / size;
                if (page.TotalCount % size > 0)
                {
                    page.TotalPage += 1;
                }

            }
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                //不使用参数的方式,后面则不需要指定SqlParameter
                //string sql = "select top "+size+" * from products where pid not in (select top (("+index+"-1) * ("+size+")) pid from products)";

                string sql = "select top (@size) * from products where pid not in (select top ((@index-1) * (@size)) pid from products)";
                //sql参数化查询：------定义sql参数
                SqlParameter[] paras = new SqlParameter[] { new SqlParameter("@size", size), new SqlParameter("@index", index) };

                SqlCommand command = new SqlCommand(sql, conn);

                //将参数赋值给command对象
                command.Parameters.AddRange(paras);

                //数据适配器
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //创建数据集对象
                DataSet ds = new DataSet();
                //填充数据集
                adapter.Fill(ds);

                //将数据集里的数据表序列化成json
                string json = JsonConvert.SerializeObject(ds.Tables[0]);

                //分页查询的结果，反序列化成泛型集合
                page.ProductList = JsonConvert.DeserializeObject<List<Product>>(json);

            }
            return page;

        }

    }
}
