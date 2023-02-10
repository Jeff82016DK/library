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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter();


            //day1
            SqlConnection conn = null;
            string sql = "";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            //day2
            //da2 = new SqlDataAdapter();           // 先new出來
            //da2.SelectCommand = new SqlCommand(); // 在設定 (使用"屬性"進行設定)






            //Employee emp1 = new Employee(); // 有一個職缺
            //emp1.SetEmployeeName("胖丁");
            //txtResult.Text = emp1.GetEmployeeName();




            Employee emp2 = new Employee("皮卡丘");
            emp2.SetEmployeeName("鮭魚");
            string temp = emp2.GetEmployeeName();
            txtResult.Text = temp;


        }

        // 員工類別
        public class Employee
        {
            private string EmployeeName;
            // 建構子 - 無參數
            public Employee()
            {
                Console.WriteLine("a.跑到了");
            }
            // 建構子 - 有參數
            public Employee(string EmployeeName)
            {
                //Console.WriteLine("b.跑到了" + bee);
                this.EmployeeName = EmployeeName;
            }

            /// <summary>
            /// 取得員工姓名
            /// </summary>
            /// <returns>蜜蜂</returns>
            public string GetEmployeeName()
            {
                return EmployeeName;
            }

            public void SetEmployeeName(string EmployeeName)
            {
                this.EmployeeName = EmployeeName;
            }
        }
    }
}
