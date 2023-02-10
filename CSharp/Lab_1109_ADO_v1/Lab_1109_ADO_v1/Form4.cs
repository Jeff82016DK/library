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
    public partial class Form4 : Form
    {
        //    enum
        //1. 宣告有限定 => 在 calss 底下OK 、 函式底下不行
        //2. 當程式碼有 神秘數字|神秘字串 判斷出現的時候，可以考慮將對照使用 enum 來做設定
        //    範例：1 => 星期一 第一名  一月份

        //    before:  userInput == "1"
        //        string userInput = Console.ReadLine();
        //        if(userInput == "1"){
        //            Console.WriteLine("好棒棒!");
        //        }

        //after:  userInput == 星期.星期一
        //        enum 星期 { 星期一, 星期二, 星期三...}
        //string userInput = Console.ReadLine();
        //        if(userInput == 星期.星期一){
        //            Console.WriteLine("好棒棒!");
        //        }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_enum_Click(object sender, EventArgs e)
        {
            Console.WriteLine((int)Season.Spring);
        }
    }
}
