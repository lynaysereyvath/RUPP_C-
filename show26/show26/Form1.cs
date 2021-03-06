using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace show26
{
    public partial class Form1 : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataView dv = new DataView();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=DESKTOP-25NCC32;Initial catalog=Library;Integrated Security=true";
            cnn.Open();
            cmm.Connection = cnn;
            cmm.CommandText = "Select * from TblBook";
            da = new SqlDataAdapter(cmm);
            ds = new DataSet();
            da.Fill(ds);
            dv = ds.Tables[0].DefaultView;

            dataGridView1.DataSource = dv;

            txtId.DataBindings.Add(new Binding("text", dv, "Book_id"));
            txttitle.DataBindings.Add(new Binding("text", dv, "B_title"));
            txtQty.DataBindings.Add(new Binding("text", dv, "Qty"));
            txtAuthor.DataBindings.Add(new Binding("text", dv, "author"));
            txtDates.DataBindings.Add(new Binding("text", dv, "dates"));
        }
    }
}
