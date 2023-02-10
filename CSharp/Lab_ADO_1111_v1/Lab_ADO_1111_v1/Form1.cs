using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_ADO_1111_v1
{
    public partial class Form1 : Form
    {
        Lab apple = new Lab();
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("1.建構子");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("2.Load載入");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string v1 = Properties.Settings.Default.test_v1;
            string v2 = Properties.Settings.Default.test_v2;

            textBox1.Text = v1;
            textBox1.Text += "\r\n";
            textBox1.Text += v2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }

    public class Lab
    {
        public Lab()
        {
            Console.WriteLine("3.建構中");
        }
    }
}
