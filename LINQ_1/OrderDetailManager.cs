using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class OrderDetailManager
    {
        public List<OrderDetail> loadOrderDetail()
        {
            List<OrderDetail> o = new List<OrderDetail>();

            o.Add(new OrderDetail("001", "p001", 100));
            o.Add(new OrderDetail("001", "p002", 200));
            o.Add(new OrderDetail("001", "p003", 300));
            o.Add(new OrderDetail("002", "p001", 200));
            o.Add(new OrderDetail("002", "p002", 400));
            o.Add(new OrderDetail("003", "p005", 300));
            o.Add(new OrderDetail("003", "p006", 600));
            o.Add(new OrderDetail("004", "p006", 300));
            o.Add(new OrderDetail("005", "p006", 500));
            o.Add(new OrderDetail("006", "p007", 400));
            o.Add(new OrderDetail("007", "p008", 200));
            o.Add(new OrderDetail("008", "p004", 100));
            o.Add(new OrderDetail("009", "p003", 50));
            o.Add(new OrderDetail("010", "p002", 500));
            o.Add(new OrderDetail("011", "p001", 120));
            o.Add(new OrderDetail("011", "p004", 210));
            o.Add(new OrderDetail("004", "p003", 100));
            o.Add(new OrderDetail("004", "p005", 100));
            o.Add(new OrderDetail("005", "p002", 100));

            return o;
        }


    }
}
