﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        public string Provinceid { get; set; }
        public string PName { get; set; }
    }
}
