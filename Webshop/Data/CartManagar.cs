using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Data
{
    public class CartManagar
    {
        public static List<Models.Products> CartProduckts { get; set; } = new List<Models.Products>();

        public static List<Models.Products> GetCartProduckts()
        {
            return CartProduckts;
        }
        public static List<Models.Products> AddCartProduckt(Models.Products addProduckt)
        {
            CartProduckts.Add(addProduckt);
            return CartProduckts;
        }
    }
}
