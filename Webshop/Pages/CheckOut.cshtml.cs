using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webshop.Pages
{
    public class CheckOutModel : PageModel
    {
        public IEnumerable<Models.Products> CartList { get; set; }

        [BindProperty]
        public int tal { get; set; }
        public void OnGet()
        {
            CartList = Data.CartManagar.GetCartProduckts();
        }

        public void OnPost()
        {
          
            {

                CartList = Data.CartManagar.ClearCart();
            }
        }
       
    }
}
