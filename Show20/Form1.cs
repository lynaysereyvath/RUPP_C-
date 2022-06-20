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

namespace Show20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FileStream fs = new FileStream("show20.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbName.Equals("") && tbQty.Equals("") && tbPrice.Equals(""))
            {
                MessageBox.Show("Enter all info");
            } 
            else
            {
                FileStream fs;
                //if (!File.Exists("Products.txt"))
                //{
                //    fs = new FileStream("Products.txt", FileMode.);
                //} 
                //else
                //{
                    fs = new FileStream("Products.txt", FileMode.Open);
                //}
                
                StreamWriter write = new StreamWriter(fs);

                write.WriteLine(tbName.Text.ToString() + "\t" + 
                    tbQty.Text.ToString() + "\t" + 
                    tbPrice.Text.ToString());

                write.Close();
                fs.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Products.txt"))
            {
                MessageBox.Show("File does not exist");
            }
            else
            {
                String result = "";
                FileStream fs = new FileStream("Products.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fs);
                while (!reader.EndOfStream)
                {
                    result += reader.ReadLine() + "\n";
                }
                MessageBox.Show(result);
                fs.Close();
                reader.Close();
            }
        }
    }
}
