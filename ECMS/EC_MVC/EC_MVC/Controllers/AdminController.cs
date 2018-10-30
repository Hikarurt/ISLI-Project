using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EC_MVC.Models;
using Newtonsoft.Json;
using System.IO;

namespace EC_MVC.Controllers
{
    public class AdminController : Controller
    {
       
       

        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加商品视图
        /// </summary>
        /// <returns></returns>
        public ActionResult AddProduct()
        {
            GetProType();
            return View();
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="PImg"></param>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddProduct(HttpPostedFileBase PImg, Product pro)
        {
            if (PImg != null)
            {
                string path = Path.Combine(Request.MapPath("/Content/images/"), PImg.FileName);
                PImg.SaveAs(path);
            }
            pro.AId = ((AdminInfo)Session["user"]).AId;
            string json = WebApiHelper.GetApiResult("post", "product", "AddProduct", pro);
            return int.Parse(json);

        }

        /// <summary>
        ///分页显示商品列表
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductList(int id = 1)
        {
            int size = 3;//每页显示3条商品

            //通过webApi实现分页查询，size每页显示的条数，index当前页索引
            string json = WebApiHelper.GetApiResult("get", "product", "GetProductByPage/" + size + "?index=" + id);

            //将得到的json反序列化成page对象
            PageList page = JsonConvert.DeserializeObject<PageList>(json);

            //将当前页保存到ViewBag中，传到视图，用于上一页或者下一页加减
            ViewBag.index = id;


            return PartialView("ProductList", page);
        }


        /// <summary>
        /// 获取商品类型下拉列表
        /// </summary>
        private void GetProType()
        {
            string json = WebApiHelper.GetApiResult("get", "product", "GetProType");
            List<ProType> pros = JsonConvert.DeserializeObject<List<ProType>>(json);

            var linq = from s in pros
                       select new SelectListItem
                       {
                           Text = s.TName,
                           Value = s.TId.ToString()
                       };

            ViewBag.types = linq.ToList();
        }
    }
}