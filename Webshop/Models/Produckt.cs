using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Products
    {
       public string Title { get; set; }
      
        public double Price { get; set; }     
        public string Info { get; set; }
        public int Id { get; set; }
      
          public string ImgFileName { get; set; }
    }

    public class Stövlar : Products
    {      
         public  bool gummi { get; set; }
        
        }

    public class Sandaler : Products
    {       
       public string Färg { get; set; }
    }

    public class Sneakers : Products
    {
        public int Storlek { get; set; }
    }
}
