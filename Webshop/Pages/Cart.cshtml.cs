using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webshop.Pages
{
    public class CartModel : PageModel
    {
        public IEnumerable<Models.Products> ProductsList { get; set; }

        public IEnumerable<Models.Products> CartList { get; set; }

        public void OnGet(int producktId)
        {
            ProductsList = Data.ProductsManager.GetAllProducts();

            CartList = Data.CartManagar.GetCartProduckts();

            if (producktId != 0)
            {
                var produckt = ProductsList.Where(m => m.Id == producktId).FirstOrDefault();
                Data.CartManagar.AddCartProduckt(produckt);
            }
        }
    }
}
