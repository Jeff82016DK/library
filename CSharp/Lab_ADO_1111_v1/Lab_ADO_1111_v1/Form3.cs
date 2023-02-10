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

namespace Lab_ADO_1111_v1
{
    public partial class Form3 : Form
    {
        #region 連線資料庫相關
        SqlConnection conn;
        SqlConnection conn2;
        SqlDataAdapter da;
        SqlDataAdapter da2;
        DataSet ds;
        #endregion
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //初始化
            conn = new SqlConnection(Properties.Settings.Default.MyDBAdventureWorksDW2019);
            conn2 = new SqlConnection(Properties.Settings.Default.MyDBNorthwind);
            da = new SqlDataAdapter();
            da2 = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void bntSelect_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            string sql2 = "select ProductName from Products";
            da.SelectCommand = new SqlCommand(sql, conn);
            da2.SelectCommand = new SqlCommand(sql2, conn2);
            da.Fill(ds, "DimCurrency");
            da2.Fill(ds, "Products");

            dataGridView1.DataSource = ds.Tables["DimCurrency"];
            dataGridView1.DataSource = ds.Tables["Products"];
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            // 20. 串字串的方式 => 會有隱碼攻擊的問題
            //string sql = $"select * from DimCurrency where CurrencyAlternateKey = 'JPY'";
            //string sql = $"select * from DimCurrency where CurrencyAlternateKey = '{textBox1.Text}'"; // 會被攻擊 

            // 30. 透過 Parmaeters處理 才不會被隱碼攻擊資料庫
            string sql = "select * from DimCurrency where CurrencyAlternateKey = @apple";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@apple", textBox1.Text);

            // 資料集.clean()
            // 判斷 "如果apple有東西" 才能清除

            // && ds.Tables["Apple"].Rows.Count > 0
            // ↑ 這一行只是想討論 &&
            if (ds.Tables["apple"] != null && ds.Tables["Apple"].Rows.Count > 0)
            {
                ds.Tables["apple"].Clear();
            };
            da.Fill(ds, "apple");

            dataGridView1.DataSource = ds.Tables["apple"];
        }
    }
}
