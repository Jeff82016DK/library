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

namespace Lab_ADO_1115_v1
{
    public partial class Form1 : Form
    {
        #region 連線資料庫相關
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void GetDataBySQL(string sql)
        {
            da.SelectCommand = new SqlCommand(sql, conn);
            if (ds.Tables["DimCurrency"] != null) ds.Tables["DimCurrency"].Clear();
            da.Fill(ds, "DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化
            conn = new SqlConnection(Properties.Settings.Default.My_DATA);
            da = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            GetDataBySQL("select *  from DimCurrency");
            // 
            if (txt_CurrencyKey.DataBindings.Count == 0)
            {
                txt_CurrencyKey.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyKey");
            }
        }

        private void btnPK_Click(object sender, EventArgs e)
        {
            // 取得 PK 到textBox 顯示
            DataColumn[] apple = ds.Tables["DimCurrency"].Constraints[];
            for (int i = 0; i < apple.Length; i++)
            {
                textBox4.Text = apple[i].ToString();
            }
        }
    }
}
