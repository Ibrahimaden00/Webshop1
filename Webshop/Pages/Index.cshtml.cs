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

        public IEnumerable<Models.Products>  CartList{ get; set; }

        public void OnGet(int producktId)
        {
            ProductsList = Data.ProductsManager.GetAllProducts();
            ProductsList = Data.ProductsManager.GetAllProducts();
            ProductsList = from p in ProductsList
                           where (p is Models.Products)
                           select (p);

            ProductsList = ProductsList.Where(p => p.Title.Contains("Black"));

            CartList = Data.CartManagar.GetCartProduckts();

            if (producktId != 0)
            {
                var produckt = ProductsList.Where(m => m.Id == producktId).FirstOrDefault();
                Data.CartManagar.AddCartProduckt(produckt);
            }
        }
    }
}
