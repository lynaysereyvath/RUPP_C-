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

namespace show20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (!File.Exists("A1file.txt"))
            //{
            //    FileStream Fs = new FileStream("A1file.txt", FileMode.CreateNew);
            //}
            //else { 
            //FileStream Fs = new FileStream("A1file.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(Fs);
            //sw.WriteLine("Bora@male@012909090");
            //sw.Close();
            //Fs.Close();
            //}
            //FileStream Fs = new FileStream("A1file.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(Fs);
            //while (!sr.EndOfStream)
            //{
            //    MessageBox.Show(sr.ReadLine());
            //}
            //Fs.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //FileStream Fs = new FileStream("Profile.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(Fs);
            //sw.WriteLine(txtpname.Text + "@" + txtQty.Text + "@" + txtPrice.Text);
            //sw.Close();
            //Fs.Close();
            ListViewItem t = listView1.Items.Add(txtpname.Text);
            t.SubItems.Add(txtQty.Text);
            t.SubItems.Add(txtPrice.Text);
            txtpname.Clear(); txtQty.Clear(); txtPrice.Clear(); txtpname.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            //FileStream Fs = new FileStream("Profile.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(Fs);
            //string st = "";
            //while (!sr.EndOfStream)
            //{
            //    st += sr.ReadLine() + "\n";
            //}
            //MessageBox.Show(st);
            //Fs.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream Fs = new FileStream(saveFileDialog1.FileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(Fs);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sw.WriteLine(listView1.Items[i].Text + "@" + listView1.Items[i].SubItems[1].Text 
                            + "@" + listView1.Items[i].SubItems[2].Text);
            }
            listView1.Items.Clear();
            sw.Close();
            Fs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream Fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(Fs);
            string[] st;
            listView1.Items.Clear();
            while (!sr.EndOfStream)
            {
               // st += sr.ReadLine() + "\n";
               st = sr.ReadLine().Split('@');
               ListViewItem t =  listView1.Items.Add(st[0]);
               t.SubItems.Add(st[1]);
               t.SubItems.Add(st[2]);

            }            
            Fs.Close();
        }
    }
}
