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
    public partial class Form3 : Form
    {
        #region 連線資料庫相關
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        #endregion

        public Form3()
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
        private void Form3_Load(object sender, EventArgs e)
        {
            // 初始化
            conn = new SqlConnection(Properties.Settings.Default.MyDB);
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
                txt_CurrencyAlternateKey.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyAlternateKey");
                txt_CurrencyName.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyName");

            }
        }

        private void btn_Rowstats_Click(object sender, EventArgs e)
        {

            //textBox4.Text = "";
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    if (item.RowState == DataRowState.Modified)
            //    {
            //        textBox4.Text += String.Join("#", item.ItemArray) + "," + item.RowState + "\r\n";

            //        MessageBox.Show("資料尚未存檔 \r\n" +
            //            $"{String.Join("", item.ItemArray)}", "關閉視窗", MessageBoxButtons.YesNoCancel);
            //    }
            //}
        }

        private void btn_Updata_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cat = new SqlCommandBuilder(da);
            //textBox4.Text = cat.GetUpdateCommand().CommandText;
            da.UpdateCommand = cat.GetUpdateCommand();
            int i = da.Update(ds, "DimCurrency");
            MessageBox.Show($"異動資料{i}筆");
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ds.Tables["DimCurrency"] != null)
            {

                string temp = "";
                foreach (DataRow item in ds.Tables["DimCurrency"].Rows)
                {
                    if (item.RowState == DataRowState.Modified)
                    {
                        temp += String.Join("", item.ItemArray) + "\r\n";
                    }

                }
                //如果有異動中的資料 => 才要跳 MessageBox
                if (string.IsNullOrEmpty(temp) == false)
                {
                    if (MessageBox.Show($"資料異動{temp}", "異動的資料",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) == DialogResult.Cancel
                        )
                    {
                        e.Cancel = true;
                    }


                }

            }
        }

        // 討論 SqlCommandBuilder @p1~@p5
        private void btn_Demo_v1_Click(object sender, EventArgs e)
        {
            // UPDATE[DimCurrency] 
            //     SET[CurrencyAlternateKey] = @p1, 
            //     [CurrencyName] = @p2
            // WHERE(([CurrencyKey] = @p3) AND
            //       ([CurrencyAlternateKey] = @p4) AND
            //       ([CurrencyName] = @p5))
            SqlCommandBuilder cat = new SqlCommandBuilder(da);
            //textBox4.Text = cat.GetUpdateCommand().CommandText;
            da.UpdateCommand = cat.GetUpdateCommand();


            DataRow row = ds.Tables["DimCurrency"].Rows[0];
            //da.UpdateCommand.Parameters.AddWithValue("@p1", txtCurrencyAlternateKey.Text);
            //da.UpdateCommand.Parameters.AddWithValue("@p2", txtCurrencyName.Text);
            //da.UpdateCommand.Parameters.AddWithValue("@p3", txtCurrencyKey.Text);
            da.UpdateCommand.Parameters["@p1"].Value = txt_CurrencyAlternateKey.Text;
            da.UpdateCommand.Parameters["@p2"].Value = txt_CurrencyName.Text;
            da.UpdateCommand.Parameters["@p3"].Value = txt_CurrencyKey.Text;
            da.UpdateCommand.Parameters["@p4"].Value = row["CurrencyAlternateKey", DataRowVersion.Original];
            da.UpdateCommand.Parameters["@p5"].Value = row["CurrencyName", DataRowVersion.Original];

            conn.Open();
            int i = da.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"作業筆數:{i}");

        }

        private void btn_Demo_v2_Click(object sender, EventArgs e)
        {
            //=> cat.ConflictOption = ConflictOption.OverwriteChanges;
            //(請建築工的where條件只針對pk去打造)
            //只能去記
            SqlCommandBuilder cat = new SqlCommandBuilder(da);
            cat.ConflictOption = ConflictOption.OverwriteChanges;
            textBox4.Text = cat.GetUpdateCommand().CommandText;
        }

        private void SQL_Click(object sender, EventArgs e)
        {
            //=> 底下的 update 只有針對 幣別縮寫 CurrencyAlternateKey 欄位
            //=> 沒有針對 幣別名稱 CurrencyName 欄位
            string sql = "UPDATE DimCurrency SET CurrencyAlternateKey = @CurrencyAlternateKey , CurrencyName = @CurrencyName WHERE CurrencyKey = @CurrencyKey";
            da.UpdateCommand = new SqlCommand(sql, conn);
            da.UpdateCommand.Parameters.AddWithValue("@CurrencyAlternateKey", txt_CurrencyAlternateKey.Text);
            da.UpdateCommand.Parameters.AddWithValue("@CurrencyKey", txt_CurrencyKey.Text);
            da.UpdateCommand.Parameters.AddWithValue("@CurrencyName", txt_CurrencyName.Text);
            conn.Open();
            int i = da.UpdateCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(i.ToString());
        }
    }

}
