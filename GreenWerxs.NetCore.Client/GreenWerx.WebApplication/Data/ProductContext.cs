using GreenWerx.NetCore.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenWerx.WebApplication.Data
{
    public class ProductContext
    {
        public static List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>();

            lst.Add(new Product()
            {
                Name = "alpha",
                UUID = "1a"

            }) ;
            lst.Add( new Product()
            {
                Name = "beta",
                UUID = "1b"
            });
            lst.Add(new Product()
            {
                Name = "charlie",
                UUID = "1c"
            });
            return lst;
        }
    }
}
