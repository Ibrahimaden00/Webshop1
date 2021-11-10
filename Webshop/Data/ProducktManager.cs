using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Data
{
    public class ProducktManager
    {
        public static List<Models.Produckt> GetProduckts()
        {
          List<Models.Produckt> produckts = new List<Models.Produckt>();

            produckts.Add(new Models.Produckt("sko1 ", 100.50, "boots-g6d767c2a7_1920.jpg"));
            produckts.Add(new Models.Produckt("sko2 ", 200.50, "shoes-gc2bd10846_1920.jpg"));
            produckts.Add(new Models.Produckt("sko3 ", 300.99, "shoes-gcb76b411f_1920.jpg"));



            return produckts;


    }



}
}
