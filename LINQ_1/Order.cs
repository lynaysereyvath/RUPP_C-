using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class Order
    {
        public string id { set; get; }
        public string cid { set; get; }
        public DateTime dateTime { set; get; }

        public Order(string id, string cid)
        {
            this.id = id; this.cid = cid;
        }
    }
}
