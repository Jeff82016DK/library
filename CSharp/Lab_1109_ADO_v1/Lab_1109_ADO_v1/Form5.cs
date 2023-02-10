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

namespace Lab_1109_ADO_v1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_sql_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=LAPTOP-6MR6T3L5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlCommand Sqldata = new SqlCommand();

            string sql = "select * from Products";
            SqlDataAdapter apple = new SqlDataAdapter(sql,conStr);

            DataSet bee = new DataSet();
            apple.Fill(bee);

            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.DataSource = bee.Tables[0];


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].HeaderText = "胖丁";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
