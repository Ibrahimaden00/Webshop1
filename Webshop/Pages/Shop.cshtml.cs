using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webshop.Pages
{
    public class ShopModel : PageModel
    {
       
      
        public IEnumerable<Models.Products> ProductsList { get; set; }
        public void OnGet()
        {
          
            ProductsList = Data.ProductsManager.GetAllProducts();
        }
    }
}
