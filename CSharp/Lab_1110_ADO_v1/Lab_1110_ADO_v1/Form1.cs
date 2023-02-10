using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1110_ADO_v1
{
    public enum Pokemon { Pikachu = 25, Duck = 54, Eevee = 133 };
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 30. 討論class 中的enum
            MyPokemon p1 = new MyPokemon();
            p1.PokemonID_v1 = 25;
            p1.PokemonID_v2 = "25";
            p1.PokemonID_v3 = Pokemon.Pikachu;

            //// 23. 判斷 - enum
            //switch (Convert.ToUInt32(textBox1.Text))
            //{
            //    case (int)Pokemon.Pikachu:
            //        MessageBox.Show("皮卡丘v2");
            //        break;
            //    default:
            //        break;
            //}

            //// 20. 判斷-字串
            //switch (textBox1.Text)
            //{
            //    case "25":
            //        MessageBox.Show("皮卡丘");
            //        break;
            //    default:
            //        break;
            //}
            // 10. 抓取 textbox 的文字
            //MessageBox.Show(textBox1.Text);
        }
    }

    public class MyPokemon
    {
        // 目標: 寶可夢ID ==> PokemonID
        public int PokemonID_v1;
        public string PokemonID_v2;
        public Pokemon PokemonID_v3;

    }
}
