using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_MVC.Models
{
    public class City
    {
        
        public int Id { get; set; }
        public string Cityid { get; set; }
        public string CName { get; set; }
        public string Provinceid { get; set; }
    }
}
