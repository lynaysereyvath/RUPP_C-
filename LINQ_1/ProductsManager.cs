using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class ProductsManager
    {
        public List<Products> loadProducts()
        {
            List<Products> p = new List<Products>();

            p.Add(new Products("p001", "Coca Cola", 100, 0.5));
            p.Add(new Products("p002", "ABC", 100, 0.5));
            p.Add(new Products("p003", "Tiger", 100, 0.5));
            p.Add(new Products("p004", "Anchor", 100, 0.5));
            p.Add(new Products("p005", "Soju", 100, 0.5));
            p.Add(new Products("p006", "Gangberg", 100, 0.5));
            p.Add(new Products("p007", "Angkor", 100, 0.5));
            p.Add(new Products("p008", "Cambodia", 100, 0.5));
            p.Add(new Products("p009", "Krud", 100, 0.5));
            p.Add(new Products("p010", "Hanuman", 100, 0.5));

            return p;
        }
    }
}
