using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_ADO_1114_v1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lebal 顯示的文字 由textbox 決定
            label1.DataBindings.Add("Text", textBox1, "Text");
            //                     lebal的Text的內容 是由  textbox 輸入的內容text 決定
        }
    }
}
