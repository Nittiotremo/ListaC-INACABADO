using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_Um_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "1";
        }

        private void bt_Dois_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "2";
        }

        private void bt_Tres_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "3";
        }

        private void bt_Quatro_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "4";
        }

        private void bt_Cinco_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "5";
        }

        private void bt_Seis_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "6";
        }

        private void bt_Sete_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "7";
        }

        private void bt_Oito_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "8";
        }

        private void bt_Nove_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "9";
        }

        private void bt_Zero_Click(object sender, EventArgs e)
        {
            txt_numero.Text = txt_numero.Text + "0";
        }

        private void bt_Corrige_Click(object sender, EventArgs e)
        {
            txt_numero.Text = ("");
        }

        private void txt_numero_Click(object sender, EventArgs e)
        {
            if (txt_numero.Text == "50")
            {
                
            }
        }
    }
}
