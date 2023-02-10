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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCombo_Click(object sender, EventArgs e)
        {
            // 固定增加小狗字串
            this.comboBox1.Items.Add("小狗");

            this.checkedListBox1.Items.Add("雞蛋");
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                Console.WriteLine(item);
                //this.listBox1.Items.Add(item.Name);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
