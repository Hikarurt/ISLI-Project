using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_MVC.Models
{
   public class Area
    {
       
        public int Id { get; set; }
        public string Areaid { get; set; }
        public string AName { get; set; }
        public string Cityid { get; set; }
    }
}
