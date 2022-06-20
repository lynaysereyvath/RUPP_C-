using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show26_myproject
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        SqlDataAdapter dataAdapter;
        DataSet dataset;
        DataView dataView;

        bool isEditing = false;
        string holder = "";

        public Form1()
        {
            InitializeComponent();

            connection.ConnectionString = "Data Source=DESKTOP-ID5VONE;Initial Catalog=CSharpClassdb;Integrated Security=True";
            connection.Open();
            command.Connection = connection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
            //command.CommandText = "SELECT * FROM tbBook";

            //dataAdapter = new SqlDataAdapter(command);

            //dataset = new DataSet();
            //dataAdapter.Fill(dataset);

            //dataView = new DataView();
            //dataView = dataset.Tables[0].DefaultView;

            //dataGridView1.DataSource = dataView;

            //textBox1.DataBindings.Add(new Binding("text", dataView, "B_id"));
            //textBox2.DataBindings.Add(new Binding("text", dataView, "B_title"));
            //textBox3.DataBindings.Add(new Binding("text", dataView, "B_qty"));
            //textBox4.DataBindings.Add(new Binding("text", dataView, "B_author"));
            //textBox5.DataBindings.Add(new Binding("text", dataView, "B_date"));

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index - 1].Cells[5].Value = "Add new";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Add new"))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Delete";
                    command.CommandText = String.Format("INSERT INTO tbBook VALUES(\'{0}\', \'{1}\', {2}, \'{3}\', \'{4}\')", 
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value);

                    command.ExecuteNonQuery();
                    
                } else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Delete"))
                {
                    command.CommandText = String.Format("DELETE FROM tbBook WHERE B_id = \'{0}\'", dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    command.ExecuteNonQuery();
                } else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Update"))
                {
                    command.CommandText = String.Format("UPDATE tbBook SET B_id = \'{0}\', B_title = \'{1}\', B_qty = {2}, B_author = \'{3}\', B_date = \'{4}\' WHERE B_id = \'{5}\'",
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value,
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(isEditing)
            {
                holder = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                isEditing = true;
            }
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!holder.Equals(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) && 
                !dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Add new") && 
                isEditing)
            {
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Update";
                isEditing = false;
            }
        }
    }
}
