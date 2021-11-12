using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Data
{
    public class ProductsManager
    {
        public static List<Models.Products> Products { get; set; } = new List<Models.Products>();

        public static List<Models.Products> GetAllProducts()
        {
            Products = new List<Models.Products>
            {
                new Models.Sandaler()
                {
                    Id=1,
                    Title = "Basic Sandaler",
                    ImgFileName = "sandal1.jpg",                   
                    Färg = "Grön",
                    Price = 500,

                },
                new Models.Sandaler()
                {
                    Id=2,
                    Title = "Gucci Sandaler",
                    ImgFileName = "Sandal2.jpg",
                    Färg = "Röd",
                    Price = 999.99,

                },
                new Models.Sandaler()
                {
                    Id=3,
                    Title = "Limited edition Sandaler",
                    ImgFileName = "Sandal3.jpg",
                    Färg = "Svar",
                    Price = 499.99,

                },
                new Models.Sandaler()
                {
                    Id=4,
                    Title = "Saras Sandaler",
                    ImgFileName = "Sandal4.jpg",
                    Färg = "Blå",
                    Price = 99.99,

                },
                new Models.Sandaler()
                {
                    Id=5,
                    Title = "Ibbes Sandaler",
                    ImgFileName = "sandal5.jpg",
                    Färg = "Ljusblå",
                    Price = 60.50,

                },
                new Models.Sneakers()
                {
                    Id=1,
                    Title = "Air force",
                    ImgFileName = "Sneakers1.jpg",
                    Storlek = 44,
                    Price = 1999.99,
                },
              
                    new Models.Sneakers()
                {
                    Id=2,
                    Title = "Converse ",
                    ImgFileName = "Sneakers2.png",
                    Storlek = 43,
                    Price = 999.99,
                },
                        new Models.Sneakers()
                {
                    Id=3,
                    Title = "Black Airforce ",
                    ImgFileName = "Sneakers4.jpg",
                    Storlek = 39,
                    Price = 800.00,
                },
                            new Models.Sneakers()
                {
                    Id=4,
                    Title = "Converse light ",
                    ImgFileName = "Sneakers5.jpg",
                    Storlek = 38,
                    Price = 899.99,
                },
                                new Models.Stövlar()
                {
                    Id=2,
                    Title = "Air Jordan 1 ",
                    ImgFileName = "Sneakers5.jpg",
                    gummi = false,
                    Price = 9999.99,
                },
                     new Models.Stövlar()
                {
                    Id=1,
                    Title = "Grenson ",
                    ImgFileName = "Boots1.jpg",
                  gummi = true,
                    Price = 99.99,
                },
                  new Models.Stövlar()
                {
                    Id=2,
                    Title = "Dr. Martens ",
                    ImgFileName = "Boots2.jpg",
                      gummi = false,
                    Price = 459.99,
                },
                new Models.Stövlar()
                {
                    Id=3,
                    Title = "Timberland ",
                    ImgFileName = "Boots3.jpg",
                   gummi = false,
                    Price = 239.99,
                },
                new Models.Stövlar()
               {
                    Id=4,
                    Title = "Tricker’s ",
                    ImgFileName = "Boots4.jpg",
                   gummi = false,
                    Price = 889.99,

                },
             new Models.Stövlar()
                {
                    Id=5,
                    Title = "Clarks ",
                    ImgFileName = "Boots5.jpg",
                    gummi = true,
                    Price = 99.99,
                },


            };
            return Products;
        }
    }
}
