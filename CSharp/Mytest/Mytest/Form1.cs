using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mytest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 連線資料相關
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion

        #region 紀錄總筆數
        int totlecount;
        int currnumb;
        string totle;
        string sql;
        string find;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(Properties.Settings.Default.MyAdventureWorksDW2019);
            da = new SqlDataAdapter();
            ds = new DataSet();

            // 按鈕狀態
            btn_read.Enabled = true;
            btn_Prev.Enabled = false;
            btn_Next.Enabled = false;
        }

        // 要匯入資料
        private void Sqlapp()
        {
            totle = "select count(*)as total  from DimCurrency";
            da.SelectCommand = new SqlCommand(totle, conn);
            da.Fill(ds, "totle");
            // 更改筆數
            totlecount = Convert.ToInt32(ds.Tables["totle"].Rows[0].ItemArray[0].ToString());

            //讀取資料
            sql = "SELECT*  from DimCurrency ORDER BY CurrencyAlternateKey OFFSET @dog ROWS FETCH FIRST 6 ROWS ONLY";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@dog", currnumb);

            if (ds.Tables["DimCurrency"] != null)
            {
                ds.Tables["DimCurrency"].Clear();
            }
            da.Fill(ds, "DimCurrency");

            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

            lab_txt.Text = $"第{currnumb + 1}筆 - 第{currnumb + ds.Tables["DimCurrency"].Rows.Count}筆 ，總共{totlecount}筆";
        }
        //讀取資料
        private void btn_read_Click(object sender, EventArgs e)
        {
            // 打開下一頁
            btn_Next.Enabled = true;
            // 讀取完後要關閉
            btn_read.Enabled = false;

            //textBox1.Text = ds.Tables["totle"].Rows[0].ItemArray[0].ToString();

            Sqlapp();

        }

        //下一頁
        private void btn_Next_Click(object sender, EventArgs e)
        {
            currnumb = currnumb + 6;

            btn_Prev.Enabled = true;
            Sqlapp();
            //下一頁筆數
            if (currnumb + ds.Tables["DimCurrency"].Rows.Count >= totlecount)
            {
                btn_Next.Enabled = false;
            }

        }
        //上一頁
        private void btn_Prev_Click(object sender, EventArgs e)
        {
            currnumb = currnumb - 6;

            //btn_Prev.Enabled = true;
            Sqlapp();
            //上一頁筆數
            if (currnumb + 1 == 1)
            {
                btn_Prev.Enabled = false;
            }
            else if (currnumb + ds.Tables["DimCurrency"].Rows.Count <= totlecount)
            {
                btn_Next.Enabled = true;
            }

        }

        //模糊查詢
        private void btn_select_Click(object sender, EventArgs e)
        {
            btn_Next.Enabled = true;
            btn_Prev.Enabled = false;
            btn_read.Enabled = true;

            //CurrencyName
            //find = "select *  from DimCurrency where CurrencyName like @cat+'%' ORDER BY CurrencyAlternateKey OFFSET 0 ROWS FETCH FIRST 40 ROWS ONLY";
            find = "select *  from @name ";
            da.SelectCommand = new SqlCommand(find, conn);
            //da.SelectCommand.Parameters.AddWithValue("@cat", textBox1.Text);
            //textBox3.Text = find;
            da.SelectCommand.Parameters.AddWithValue("@name", textBox2.Text);


            if (ds.Tables["apple"] != null)
            {
                ds.Tables["apple"].Clear();
            }
            else if (ds.Tables["DimCurrency"] != null)
            {
                ds.Tables["DimCurrency"].Clear();
            }

            da.Fill(ds, "apple");

            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = ds.Tables["apple"];



        }
    }
}
