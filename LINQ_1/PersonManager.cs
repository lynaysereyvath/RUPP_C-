using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class PersonManager
    {
        public List<Person> loadPerson()
        {
            List<Person> p = new List<Person>();

            p.Add(new Person("001", "Dara", 20, 2000));
            p.Add(new Person("002", "Jack", 30, 1200));
            p.Add(new Person("003", "John", 25, 1000));
            p.Add(new Person("004", "Josh", 21, 2300));
            p.Add(new Person("005", "James", 31, 400));
            p.Add(new Person("006", "Jole", 29, 700));
            p.Add(new Person("007", "Janny", 25, 900));
            p.Add(new Person("008", "Jane", 27, 1230));

            return p;
        }

       
    }

    
    
}
