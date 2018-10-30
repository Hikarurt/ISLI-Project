using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class ECContext:DbContext
    {
        public ECContext() : base("ecDB") { }


        public virtual DbSet<AdminInfo> AdminInfo { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProType> ProType { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<ShoppingCar> ShoppingCar { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
    }
}
