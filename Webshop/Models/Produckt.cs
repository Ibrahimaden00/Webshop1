﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Produckt
    {
        public  string Name { get; set; }
        public  double  Price { get; set; }

        public string ImageFileName { get; set; }
        public string Info { get; set; }
        public Produckt(string name, double price, string imageFileName, string info)
        {
            Name = name ;
            Price = price;
            ImageFileName = imageFileName;
            Info = info;
        }
    }
}
