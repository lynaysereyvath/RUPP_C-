using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class Person
    {
        public string id;
        public string name;
        public int age;
        public double salary;

        public Person(string id, string name, int age, double salary)
        {
            this.id = id; this.name = name; this.age = age; this.salary = salary;
        }
    }
}
