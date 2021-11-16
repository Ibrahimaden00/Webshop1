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

        public double price { get; set; }
        public string info { get; set; }
        public int id { get; set; }

        public string ImgFileName { get; set; }
        public void OnGet()
        {


        }
    }
}
