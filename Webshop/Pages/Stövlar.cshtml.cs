using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webshop.Pages
{
    public class StövlarModel : PageModel
    {
        public IEnumerable<Models.Products> ProductsList { get; set; }

        public IEnumerable<Models.Products> CartList { get; set; }
        public IEnumerable<Models.Products> StockList { get; set; }

        public void OnGet(int producktId, int stockID)
        {
            ProductsList = Data.ProductsManager.GetAllProducts();

            CartList = Data.CartManagar.GetCartProduckts();
            StockList = Data.StockManager.GetStockBalance();
           
            if (producktId != 0)
            {
                var produckt = ProductsList.Where(m => m.Id == producktId).FirstOrDefault();
                Data.CartManagar.AddCartProduckt(produckt);
                
            }
            if (stockID != 0)
            {
                var produck = ProductsList.Where(m => m.Id == stockID).FirstOrDefault();
                Data.StockManager.RemoveStockBalance(produck);
            }

        }
        public void onPost(int producktId, int stockID)
        {
            ProductsList = Data.ProductsManager.GetAllProducts();

            CartList = Data.CartManagar.GetCartProduckts();
            StockList = Data.StockManager.GetStockBalance();

            if (producktId != 0)
            {
                var produckt = ProductsList.Where(m => m.Id == producktId).FirstOrDefault();
                Data.CartManagar.AddCartProduckt(produckt);

            }
            if (stockID != 0)
            {
                var produck = ProductsList.Where(m => m.Id == stockID).FirstOrDefault();
                Data.StockManager.RemoveStockBalance(produck);
            }
        }
    }
    
}
