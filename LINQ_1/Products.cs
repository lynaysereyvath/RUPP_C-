using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class Products
    {
        public string id { set; get; }
        public string name { set; get; }
        public int qty { set; get; }
        public double price { set; get; }

        public Products(string id, string name, int qty, double price)
        {
            this.id = id; this.name = name;
            this.qty = qty; this.price = price;
        }
    }
}
