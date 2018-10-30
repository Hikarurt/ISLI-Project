using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly.DAL
{
    public class Product
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int GetProductIDMax(int i)
        {
            return i * 10;
        }

        public decimal Price = 123.456m;

        public int ID { get; set; }
    }
}
