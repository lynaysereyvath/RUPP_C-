using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class OrderDetail
    {
        public string id { set; get; }
        public string pid { set; get; }
        public int qty { set; get; }
        public OrderDetail(string id, string pid, int qty)
        {
            this.id = id; this.pid = pid; this.qty = qty;
        }
    }
}
