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
using System.Runtime.Serialization.Formatters.Binary;
namespace show21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Save Data into file Serialize data
            BinaryFormatter Bf = new BinaryFormatter();
            FileStream Fs = new FileStream("A1file.txt", FileMode.Append);
            Book obj = new Book("B002", "NetWork", 5);
            Bf.Serialize(Fs, obj);
            Fs.Close();
            //Open data from file Serialize 
            Fs = new FileStream("A1file.txt", FileMode.Open);
            while (Fs.Position != Fs.Length)
            {
                obj = (Book)Bf.Deserialize(Fs);
                MessageBox.Show(obj.Bid + "\t" + obj.Btitle + "\t" + obj.Qty);
            }
            Fs.Close();
        }
    }
    [Serializable] class Book {
        public string Bid { set; get; }
        public string Btitle { set; get; }
        public int Qty { set; get; }
        public Book(string id, string title, int Q) {
            Bid = id; Btitle = title; Qty = Q;
        }
    }
}
