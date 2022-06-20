using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PersonManager personManager = new PersonManager();
            OrderDetailManager orderDetailManager = new OrderDetailManager();
            OrderManager orderManager = new OrderManager();
            ProductsManager productsManager = new ProductsManager();

            List<Person> persons = personManager.loadPerson();
            List<OrderDetail> orderDetails = orderDetailManager.loadOrderDetail();
            List<Order> orders = orderManager.loadOrder();
            List<Products> products = productsManager.loadProducts();


            var source = from od in orderDetails
                         orderby od.id
                         join p in products
                         on od.id equals p.id into nv
                         select new { orderId = od.id, order = from mv in nv
                                                               select mv};

            //var source = from v in orderDetails
            //             select v.id;

            //var source2 = from v in products
            //              select v.id;

            string result = "";
            foreach(var s in source)
            {
                result += s.orderId + "\n";
                foreach(var n in s.order)
                {
                    result += n.name + "\t";
                }
                result += "\n";
            }

            MessageBox.Show(result);


            //var source = from v in persons 
            //             where v.salary > 1000 
            //             orderby v.salary descending
            //             select new Person(v.id, v.name, v.age, v.salary);

            /*var source = from v in orderDetails
                         group v by v.pid into nv
                         orderby nv.Key
                         select nv;


            string result = "";
            foreach(var p in source)
            {
                result += p.Key + "\n";
                foreach(OrderDetail o in p)
                {
                    result += "\t" + o.id + " " + o.qty + "\n";
                }
            }
            MessageBox.Show(result);*/
        }

        class Loader
        {
            public string oid { set; get; }
            public string pid { set; get; }
            public string pname { set; get; }
            public Loader(string oid, string pid, string pname)
            {
                this.oid = oid; this.pid = pid; this.pname = pname;
            }
        }
    }
}
