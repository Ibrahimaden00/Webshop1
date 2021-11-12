using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Pages
{
    public class IndexModel : PageModel
    {

        public IEnumerable<Models.Products> ProductsList { get; set; }

       

        public void OnGet()
        {
            ProductsList = Data.ProductsManager.GetAllProducts();


            

        }
    }
}
