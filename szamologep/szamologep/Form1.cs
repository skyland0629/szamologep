using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gomb_nyomas(object sender, EventArgs e)//az összes szám-gomb lenyomására vonatkozik
        {
            Button Gomb = (Button)sender;
            textBox1.Text = textBox1.Text + Gomb.Text;
        }

        private void elojel_valtoztatas(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Substring(1);
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
                textBox1.Text = "-" + textBox1.Text;
        }

        private void C_gomb(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void CE_gomb(object sender, EventArgs e)
        {
            textBox1.Text = "0";
           
        }
    }
}
