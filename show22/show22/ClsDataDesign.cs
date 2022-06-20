using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show22
{
    class ClsDataDesign
    {
        public string Pid { set; get; }
        public string Pname { set; get; }
        public int Qty { set; get; }
        public double Price { set; get; }
        public ClsDataDesign(string id, string name, int q, double p) {
            Pid = id; Pname = name; Qty = q; Price = p;
        }
    }
}
