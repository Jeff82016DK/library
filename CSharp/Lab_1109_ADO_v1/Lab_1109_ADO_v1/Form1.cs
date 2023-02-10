using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1109_ADO_v1
{
    public partial class Form1 : Form
    {

        //1. 建構子： public 、 沒有回傳值 、 與class 同名
        //2. 事件命名：建立 【事件當下的控制項名稱_事件名稱】
        //3. 事件建立後改變控制項名稱，事件命名不會跟著改變
        //4. 增加控制項的方式： 從工具箱拖曳
        //5. 複製控制項的方式： ctrl+c ctrl+v   |   點選 ctrl 的情況下拖曳控制項

        //6.         唯一 內容
        //    HTML id<> </>
        //    C#     name      text
        //7. 如果採取複製畫面上的控制項，事件會跟著過來
        //8. 要讓控制項有自己的事件
        //    =>檢查閃電
        //    =>刪除閃電事件後面的文字
        //    =>重新建立
        //9. 刪除有綁定事件的控制項: (O)，不過要自己刪除 cs 裡面的程式碼
        //10. 刪除有綁定事件的程式碼: (X)，需要到設計工具裡面去刪除掉對應程式碼
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("皮卡丘");
        }
        //事件 | 方法 點擊事件
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("卡比");
            Console.WriteLine("胖丁");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("卡比2");

        }
    }
}
