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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region 資料庫連線所需要的類別
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Properties.Settings.Default.MyAdventureWorksDW2019);
            da = new SqlDataAdapter();
            ds = new DataSet();
        }




        private void btn_select_Click(object sender, EventArgs e)
        {
            string sql = "select *from DimCurrency";
            da.SelectCommand = new SqlCommand(sql, conn);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = Properties.Settings.Default.MyAdventureWorksDW2019;

            // 20. 想把要看的字串放在textbox
            //textBox1.Text = Properties.Settings.Default.MyAdventureWorksDW2019;

            //// 10. 確認textbox 可以被控制
            //textBox1.Text = "皮卡丘";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
