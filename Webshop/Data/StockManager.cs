using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;

namespace Webshop.Data
{
    public static class StockManager
    {
        

        public static List<Models.Products> StockBalances { get; set; } = new List<Models.Products>();
        public static List<Products> InStock { get; private set; }

        public static List<Models.Products> GetStockBalance()
        {
            return StockBalances;
        }

        public static List<Models.Products> RemoveStockBalance(Models.Products inStock)
        {
            if( inStock.Stock>0)
            { 
            inStock.Stock--;
            StockBalances.Remove(inStock);
           
            }
            return StockBalances;

        }

    }
}
