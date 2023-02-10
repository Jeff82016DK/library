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
    public partial class Form4 : Form
    {
        // 1.上一頁下一頁不能點
        // 2.讀取本人不能再被選
        // 3.下一頁可以被點選
        // 4.讀取點下去的時候就要從資料庫讀出來
        // 5.當前讀取到哪裡 ex 第1筆-第6筆
        // 6.總共有幾筆
        // 7.dataGridView 一次六筆

        // 8.!!上一頁下一頁要判斷一下
        //      a.當前讀取到哪裡 要更新
        //      b.能不能被操作跟筆(頁)數有幾筆
        public Form4()
        {
            InitializeComponent();
        }
        #region 連線資料庫相關聯
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        #endregion

        #region 紀錄總筆數
        int totalcount;
        int curryindex;

        #endregion
        private void Form4_Load(object sender, EventArgs e)
        {
            // 10. 資料庫相關類別初始化
            conn = new SqlConnection(Properties.Settings.Default.MyDBAdventureWorksDW2019);
            da = new SqlDataAdapter();
            ds = new DataSet();

            // 20. 上一頁下一頁
            btn_Prev.Enabled = false;
            btn_Next.Enabled = false;

            totalcount = 0;
            curryindex = 0;

            bool flag = true;
            textBox1.Text = flag.ToString();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            // 把自己關閉，不能重複
            btn_read.Enabled = false;

            //下一頁
            //btn_Prev.Enabled = true;
            btn_Next.Enabled = true;

            //筆數 第1筆-第6筆，共105筆
            string sql = $"select count(*) as TotalRow from  DimCurrency";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.Fill(ds, "cat");

            // 推理過程 (使用 textbox 只是為了方便查看)
            //  1. DataSet 裡面有 Table → Table 裡面有 Rows → Row 裡面應該有 Column 但是找不到
            //  2. 下中斷點查看， Row 裡面到底有什麼
            //  3. 用刪去法，找到 ItemArray 
            //textBox1.Text = ds.Tables["cat"].Rows[0].ItemArray[0].ToString();
            totalcount = Convert.ToInt32(ds.Tables["cat"].Rows[0].ItemArray[0]);
            label1.Text = $"第{curryindex + 1}筆-第{curryindex + 6}筆，共{totalcount}筆";



            // 讀取資料
            sql = $"select * from DimCurrency order by CurrencyAlternateKey offset @dog rows fetch next 6 rows only;";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@dog", curryindex);

            if (ds.Tables["DimCurrency"] != null)
            {
                ds.Tables["DimCurrency"].Clear();
            }
            da.Fill(ds, "DimCurrency");

            dataGridView1.RowTemplate.Height = 51;
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

            // 後六筆

            if ((curryindex + 6) > totalcount)
            {
                //btn_Next.Enabled = false;
                curryindex = curryindex + 3;
            }
            else if (curryindex < 106)
            {
                curryindex = curryindex + 6;

            }

            //curryindex = (curryindex + 6) > totalcount ? curryindex = curryindex + 3 : curryindex = curryindex + 6;

            // 打開上一頁
            btn_Prev.Enabled = true;
            // btnNext 在甚麼情況下要設定
            if (curryindex == totalcount)
            {
                btn_Next.Enabled = false;

            }
            else
            {
                btn_Prev.Enabled = true;

            }


            // 讀取資料
            string sql = $"select * from DimCurrency order by CurrencyAlternateKey offset @dog rows fetch next 6 rows only;";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@dog", curryindex);

            if (ds.Tables["DimCurrency"] != null)
            {
                ds.Tables["DimCurrency"].Clear();
            }
            da.Fill(ds, "DimCurrency");

            dataGridView1.RowTemplate.Height = 51;
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

            label1.Text = $"第{curryindex + 1}筆-第{curryindex + (ds.Tables["DimCurrency"].Rows.Count)}筆，共{totalcount}筆";
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            curryindex -= 6;
            // 打開上一頁
            btn_Prev.Enabled = true;

            label1.Text = $"第{curryindex + 1}筆-第{curryindex + 6}筆，共{totalcount}筆";

            // 讀取資料
            string sql = $"select * from DimCurrency order by CurrencyAlternateKey offset @dog rows fetch next 6 rows only;";
            da.SelectCommand = new SqlCommand(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@dog", curryindex);

            if (ds.Tables["DimCurrency"] != null)
            {
                ds.Tables["DimCurrency"].Clear();
            }
            da.Fill(ds, "DimCurrency");

            dataGridView1.RowTemplate.Height = 51;
            dataGridView1.DataSource = ds.Tables["DimCurrency"];
        }
    }

}
