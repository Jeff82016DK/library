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

namespace Lab_ADO_1114_v1
{
    // 和上週五有差異的地方
    // => 分成 實際筆數 跟 預設筆數
    // => 每一次事件都描述三個按鈕狀態
    // => 已知 read 是讀取一次，那為什麼還要判斷+清除?
    //    Ans: 因為，計畫中，read 和 上一頁 下一頁 很像，所以先寫著放著
    // => if 如果只做一件事情，大括弧{}可以不寫，程式碼可以跟在後面
    public partial class Form1 : Form
    {
        #region 連線資料庫相關
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion
        #region 紀錄筆數
        int defaultPage;
        int realPage;
        int currIndex;
        int totalRecaord;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region 自己寫的function
        // public | private   void    名稱(參數) {要做的事情}
        //     修飾詞       回傳數值   名稱(參數) {要做的事情}
        private void GetData(int start, int page)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM DimCurrency ORDER BY CurrencyAlternateKey OFFSET @apple ROWS FETCH NEXT @bee ROWS ONLY", conn);
            da.SelectCommand.Parameters.AddWithValue("@apple", start);
            da.SelectCommand.Parameters.AddWithValue("@bee", page);
            if (ds.Tables["DimCurrency"] != null) ds.Tables["DimCurrency"].Clear();
            da.Fill(ds, "DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

            //顯示當前分頁訊息
            lbl_resould.Text = $"第{start + 1}筆 - 第{start + page}筆 ，共{totalRecaord}筆";
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化
            conn = new SqlConnection(Properties.Settings.Default.MyDB);
            da = new SqlDataAdapter();
            ds = new DataSet();

            defaultPage = 48; // 預期每一次讀取的筆數
            realPage = defaultPage; // 實際上每一次分頁筆數
            currIndex = 0; // 計算筆數的開頭
            totalRecaord = 0; // 總共的筆數

            //按鈕狀態
            btn_read.Enabled = true;
            btn_Prev.Enabled = false;
            btn_Next.Enabled = false;
        }
        private void btn_read_Click(object sender, EventArgs e)
        {
            //和上週五有差異的地方
            // => 原本顯示訊息的時候直接 +6 ，現在改成 +realPage
            // => 原本無條件打開 下一頁
            //    =>根據 計畫，要判斷，如果讀取的筆數大於總比數，那也沒有下一頁可以讀
            // => 原本沒有控制 上一頁
            //   => 根據 計畫，要判斷，如果在第一頁，就不可以打開
            //   =>要怎知道第一頁?
            //     Ans: 只要currIndex 為 0 就表示在第一頁

            // 取得總筆數:105
            da.SelectCommand = new SqlCommand("select count(*)  from DimCurrency", conn);
            if (ds.Tables["DimCurrency"] != null) ds.Tables["DimCurrency"].Clear();
            da.Fill(ds, "DimCurrency");
            totalRecaord = Convert.ToInt32(ds.Tables["DimCurrency"].Rows[0].ItemArray[0]);
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

            // 讀取第一頁回來
            realPage = defaultPage > totalRecaord ? totalRecaord : defaultPage;
            GetData(currIndex, realPage);


            //按鈕狀態
            btn_read.Enabled = false;
            btn_Prev.Enabled = currIndex != 0; // !(第一筆|第一頁)   !(currIndex == 0)
            btn_Next.Enabled = realPage < totalRecaord; // 預設的分頁數量大於總筆數

            //da.SelectCommand = new SqlCommand("select *  from DimCurrency", conn);
            //if (ds.Tables["DimCurrency"] != null) ds.Tables["DimCurrency"].Clear();
            //da.Fill(ds, "DimCurrency");
            //dataGridView1.DataSource = ds.Tables["DimCurrency"];
        }
        // 上一頁
        private void btn_Prev_Click(object sender, EventArgs e)
        {
            currIndex = currIndex - defaultPage;
            realPage = defaultPage;
            GetData(currIndex, realPage);

            btn_read.Enabled = false;
            btn_Prev.Enabled = !(currIndex == 0); // !(第一筆|第一頁)   !(currIndex == 0)
            btn_Next.Enabled = true; // 預設的分頁數量大於總筆數
        }
        // 下一頁
        private void btn_Next_Click(object sender, EventArgs e)
        {
            // currIndex realPage
            currIndex = currIndex + realPage;
            realPage = currIndex + defaultPage > totalRecaord ? totalRecaord - currIndex : defaultPage;
            GetData(currIndex, realPage);


            btn_read.Enabled = false;
            btn_Prev.Enabled = currIndex != 0; // !(第一筆|第一頁)   !(currIndex == 0)
            btn_Next.Enabled = realPage == defaultPage; // 預設的分頁數量大於總筆數
        }


    }
}
