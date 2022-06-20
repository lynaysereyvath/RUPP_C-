using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace semester2_midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Book[] obj_B = {new Book("b001", "A", "12/2/2002"),
            new Book("b002", "B", "12/2/2002"),
            new Book("b003", "C", "12/2/2002"),
            new Book("b004", "D", "12/2/2002"),
            new Book("b005", "E", "12/2/2002")};

            var source = from v in obj_B
                         select v;

            FileStream fs = new FileStream("myBook.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);

            foreach(var s in source)
            {
                sw.WriteLine(s.id + "\t" + s.name + "\t" + s.date);
            }


            sw.Close();
            fs.Close();

        }
    }

    class Book
    {
        public string id { set; get; }
        public string name { set; get; }
        public string date { set; get; }
        public Book(string id, string name, string date)
        {
            this.id = id; this.name = name; this.date = date;
        }
    }
}
