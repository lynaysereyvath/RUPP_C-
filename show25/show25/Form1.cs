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

namespace show25
{
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader sqlDataReader;
        public Form1()
        {
            InitializeComponent();

            sqlConnection.ConnectionString = "Data Source=DESKTOP-ID5VONE;Initial Catalog=CSharpClassdb;Integrated Security=True";
            sqlConnection.Open();

            sqlCommand.Connection = sqlConnection;
            //insertCommand.CommandText = "INSERT into tbBook values('b004', 'Statistics', 30, 'Yaya Tore', '2022/01/15')";
            //insertCommand.ExecuteNonQuery(); 
            //sqqlCommand.CommandText = "SELECT * FROM tbBook";
            //sqlDataReader = sqqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    MessageBox.Show(sqlDataReader[0].ToString() + "\t" + sqlDataReader[1].ToString() + "\t" + sqlDataReader[2].ToString() + "\t" + sqlDataReader[3].ToString() + "\t" + sqlDataReader[4].ToString());

            //}
            button4.Enabled = false;
            button2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = String.Format("INSERT INTO tbBook values('{0}', '{1}', {2}, '{3}', '{4}')",
                tb_id.Text,
                tb_title.Text,
                tb_qty.Text,
                tb_author.Text,
                tb_date.Text);
            sqlCommand.ExecuteNonQuery();
            tb_id.Clear(); tb_title.Clear(); tb_qty.Clear(); tb_author.Clear(); tb_date.Clear();
            tb_id.Focus();
            button4.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = String.Format("SELECT * FROM tbBook WHERE b_id = '{0}'", tb_id.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                tb_title.Text = sqlDataReader[1].ToString();
                tb_qty.Text = sqlDataReader[2].ToString();
                tb_author.Text = sqlDataReader[3].ToString();
                tb_date.Text = sqlDataReader[4].ToString();
                button4.Enabled = true;
                button2.Enabled = true;
            } else
            {
                MessageBox.Show("Book not found");
                button4.Enabled = false;
                button2.Enabled = false;
            }
            sqlDataReader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = String.Format("DELETE FROM tbBook WHERE b_id = '{0}'", tb_id.Text);
            sqlCommand.ExecuteNonQuery();
            button4.Enabled = false;
            button2.Enabled = false;
            tb_id.Clear(); tb_title.Clear(); tb_qty.Clear(); tb_author.Clear(); tb_date.Clear();
            tb_id.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = String.Format("UPDATE tbBook SET B_title = '{0}', B_qty = {1}, B_author = '{2}', B_date = '{3}' WHERE B_id = '{4}'",
                tb_title.Text,
                tb_qty.Text,
                tb_author.Text, 
                tb_date.Text,
                tb_id.Text);
            sqlCommand.ExecuteNonQuery();
            button4.Enabled = false;
            button2.Enabled = false;
            tb_id.Clear(); tb_title.Clear(); tb_qty.Clear(); tb_author.Clear(); tb_date.Clear();
            tb_id.Focus();
        }
    }
}
