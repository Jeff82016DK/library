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
    public partial class Form4_自己從資料庫取得資料 : Form
    {
        public Form4_自己從資料庫取得資料()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // 資料位置
            string ConnStr = "Data Source=LAPTOP-6MR6T3L5\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection apple = new SqlConnection(ConnStr);

            // 走路工到那邊抓取甚麼樣的資料回來至DateSet
            string sql = "select * from Products";
            SqlDataAdapter bee = new SqlDataAdapter(sql, ConnStr);

            // 把拿回來的資料顯示出來
            DataSet cat = new DataSet();
            bee.Fill(cat);

            //this.dgvDataTable.RowTemplate.Height = 70;

            this.dgvDataTable.DataSource = cat.Tables[0];


        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.dgvDataTable.Columns[0].HeaderText = "胖丁";
            this.dgvDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
