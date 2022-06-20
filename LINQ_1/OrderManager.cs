using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class OrderManager
    {
        public List<Order> loadOrder()
        {
            List<Order> o = new List<Order>();

            o.Add(new Order("001", "001"));
            o.Add(new Order("002", "002"));
            o.Add(new Order("003", "004"));
            o.Add(new Order("004", "002"));
            o.Add(new Order("005", "003"));
            o.Add(new Order("006", "005"));
            o.Add(new Order("007", "006"));
            o.Add(new Order("008", "007"));
            o.Add(new Order("009", "008"));
            o.Add(new Order("010", "002"));
            o.Add(new Order("011", "003"));
            o.Add(new Order("012", "005"));

            return o;
        }
    }
}
