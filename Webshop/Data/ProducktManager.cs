using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Data
{
    public class ProductsManager
    {
        public static List<Models.Products> Products { get; set; } = new List<Models.Products>();

        public static List<Models.Products> GetAllProducts()
        {
            if (!Products.Any())
            {
                Products = new List<Models.Products>
            {
                new Models.Sandaler()
                {
                    Id=1,
                    Title = "Basic Sandaler",
                    ImgFileName = "sandal1.jpg",
                    Färg = "Grön",
                     Stock = 5,
                    Info = "Basic sandlar som pasar bra till stranden",
                    Price = 500,


                },
                new Models.Sandaler()
                {
                    Id=2,
                    Title = "Gucci Sandaler",
                    ImgFileName = "Sandal2.jpg",
                    Färg = "Röd",
                    Price = 999.99,
                    Stock = 5,
                    Info = "Gucci egna exclusiv sandaler",



                },
                new Models.Sandaler()
                {
                    Id=3,
                    Title = " Black Limited edition Sandaler",
                    ImgFileName = "Sandal3.jpg",
                    Färg = "Svart",
                    Price = 499.99,
                    Info = "Sandaler som är tilvarkade av Nba",
                    Stock = 5,



                },
                new Models.Sandaler()
                {
                    Id=4,
                    Title = "Saras Sandaler",
                    ImgFileName = "Sandal4.jpg",
                    Färg = "Blå",
                    Price = 99.99,
                    Stock = 5,
                    Info = "Sandalar tillverkade av Sara"


                },
                new Models.Sandaler()
                {
                    Id=5,
                    Title = "Ibbes Sandaler",
                    ImgFileName = "sandal5.jpg",
                    Färg = "Ljusblå",
                    Stock = 5,
                    Price = 60.50,
                     Info = "Sandalar tillverkade av Ibbe"

                },
                new Models.Sneakers()
                {
                    Id=6,
                    Title = "Air force",
                    ImgFileName = "Sneakers1.jpg",
                    Storlek = 44,
                    Stock = 5,
                    Price = 1999.99,
                    Info = "Nike egna Air force"
                },

                    new Models.Sneakers()
                {
                    Id=7,
                    Title = "Converse ",
                    ImgFileName = "Sneakers2.png",
                    Storlek = 43,
                    Stock = 5,
                    Price = 999.99,
                    Info = "Originella Converse"
                },
                        new Models.Sneakers()
                {
                    Id=8,
                    Title = "Black Airforce ",
                    ImgFileName = "Sneakers3.jpg",
                    Storlek = 39,
                    Stock = 5,
                    Price = 800.00,
                      Info = "Bland de första Black Airforce"
                },
                            new Models.Sneakers()
                {
                    Id=9,
                    Title = "Converse light ",
                    ImgFileName = "Sneakers4.jpg",
                    Storlek = 38,
                    Price = 899.99,
                    Stock = 5,
                      Info = "Designer Converse"
                },
                    new Models.Sneakers()
                {
                    Id=10,
                    Title = "Air Jordan 1 ",
                    ImgFileName = "Sneakers5.jpg",
                    Storlek = 48,
                    Price = 9999.99,
                    Stock = 5,
                    Info= ""
                },
                     new Models.Stövlar()
                {
                    Id=11,
                    Title = "Grenson ",
                    ImgFileName = "Boots1.jpg",
                     gummi = "Dessa är inte gummi ",
                     Stock = 5,
                     Price = 99.99,
                     Info= ""
                },
                  new Models.Stövlar()
                {
                    Id=12,
                    Title = "Dr. Martens ",
                    ImgFileName = "Boots2.jpg",
                      gummi = "Dessa är gummi ",
                    Price = 459.99,
                    Stock = 5,
                    Info= ""
                },
                new Models.Stövlar()
                {
                    Id=13,
                    Title = "Timberland ",
                    ImgFileName = "Boots3.jpg",
                   gummi = "Dessa är gummi ",
                    Price = 239.99,
                    Stock = 5,
                    Info= ""
                },
                new Models.Stövlar()
               {
                    Id=14,
                    Title = "Tricker’s ",
                    ImgFileName = "Boots4.jpg",
                   gummi = "Dessa är gummi ",
                    Price = 889.99,
                    Stock = 5,
                    Info= ""

                },
             new Models.Stövlar()
                {
                    Id=15,
                    Title = " Black Clarks ",
                    ImgFileName = "Boots5.jpg",
                    gummi = "Dessa är inte gummi ",
                    Price = 99.99,
                    Stock = 5,
                    Info= ""
                },


            };
            }
          
            return Products;
        }

        public static string AddProduckt(string category, string title, int stock, string imgFileName, int id, string info, double price)
        {
            var producktAdd = new Models.Products();
            if (category=="sandal")
            { producktAdd = new Models.Sandaler(); }

            if (category == "Sneakers")
            { producktAdd = new Models.Sneakers(); }
            if (category == "Stövlar")
            { producktAdd = new Models.Stövlar(); }

            producktAdd.Title = title;
            producktAdd.Stock = stock;
            producktAdd.Price = price;
            producktAdd.ImgFileName = imgFileName;
            producktAdd.Id = id;
            producktAdd.Info = info;
            Products.Add(producktAdd);           
               return "Denna produckt har lagts till";
        }
        public static string EditProduckt(string title, int stock, int id, double price)
        {
   
           
           
            Products[id - 1].Title = title; 
            Products[id - 1].Price = price;
            Products[id - 1].Stock =stock;
            
          

            return "Denna produckt har lagts till";
        }


    }
}
