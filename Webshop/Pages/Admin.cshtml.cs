using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Webshop.Pages
{
    public class AdminModel : PageModel
    {
        public IEnumerable<Models.Products> ProductsList { get; set; }

        [BindProperty]
        public string title { get; set; }
        [BindProperty]
        public double price { get; set; }
        [BindProperty]
        public string info { get; set; }
        [BindProperty]
        public int id { get; set; }     
        [BindProperty]
        public string imgFileName { get; set; }
        [BindProperty]

        public String category { get; set; }
        [BindProperty]
        public int stock { get; set; }
        public void OnGet()
        {

            ProductsList = Data.ProductsManager.GetAllProducts();
            {
               
            }
        }
        public void OnPost()
        {
            Data.ProductsManager.AddProduckt(category, title, stock, imgFileName, id, info, price);
        }
    }
}
