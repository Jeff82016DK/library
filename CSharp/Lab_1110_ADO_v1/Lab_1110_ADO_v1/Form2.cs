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

namespace Lab_1110_ADO_v1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=LAPTOP-6MR6T3L5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connStr);

            string sql = "select ProductName from Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("bee", "產品單價");
            dataGridView2.Columns["bee"].DataPropertyName = "UnitPrice";

            string connStr = "Data Source=LAPTOP-6MR6T3L5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connStr);

            string sql = "select UnitPrice from Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=LAPTOP-6MR6T3L5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connStr);

            string sql = "select ProductName,UnitPrice from Products";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView3.DataSource = ds.Tables[0];
            
        }
    }
}
