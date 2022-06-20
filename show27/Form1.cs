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
using System.IO;

namespace show27
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DataSet dataSet;
        DataTable dataTable;
        SqlDataReader dataReader;
        DataRow dataRow;
        SqlDataAdapter dataAdapter;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=CSharpClassdb;Integrated Security=True";
            command = new SqlCommand();
            command.Connection = connection;
        }

        private void btnBrowse_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtId.Text!= null && txtName.Text != null && txtPhone.Text!=null && txtSex.Text!= null && pictureBox1.Image != null)
            {
                command.CommandText = "SELECT * FROM tbStudent";
                dataAdapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataRow = dataTable.NewRow();
                dataRow[0] = txtId.Text.ToString();
                dataRow[1] = txtName.Text.ToString();
                dataRow[2] = txtSex.Text.ToString();
                dataRow[3] = txtPhone.Text.ToString();

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                dataRow[4] = ms.GetBuffer();
                dataTable.Rows.Add(dataRow);

                SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataTable);

                txtId.Clear(); txtName.Clear(); txtSex.Clear(); txtPhone.Clear();
                pictureBox1.Image = null;
                txtId.Focus();
            }
        }

        
    }
}
