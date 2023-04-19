using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Grocery_Shop
{
    internal class AddProducts
    {
        public string productname;
        public string id;
        public int price;
        public string unit;

        public string Combine()
        {
            return productname + "?" + id + "?" + price + "?" + unit + "?";
        }
    }
}
