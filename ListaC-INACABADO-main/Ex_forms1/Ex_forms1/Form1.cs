using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_forms1
{
    public partial class Form1 : Form
    {



        



        public Form1()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = (float.Parse(Text1.Text) + float.Parse(Text2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = (float.Parse(Text1.Text) / float.Parse(Text2.Text)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = (float.Parse(Text1.Text) - float.Parse(Text2.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = (float.Parse(Text1.Text) * float.Parse(Text2.Text)).ToString();

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            Text1.Text = ("");
            Text2.Text = ("");
            txt_resultado.Text = ("");
        }
    }
}
