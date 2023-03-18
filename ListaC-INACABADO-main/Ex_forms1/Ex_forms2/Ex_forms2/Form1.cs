using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
        int oreo = 0;
        int Nal = 0;
        int Gugu = 0;
        int branco = 0;
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
            txt_Partido.Text = ("");
            txt_Nome.Text = ("");
            pic_Candidato.Visible = false;
        }

        private void txt_numero_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Confirma_Click(object sender, EventArgs e)
        {
            if(txt_numero.Text == "12")
            {
                oreo = oreo + 1;
                NumbOreo.Text = (""+oreo);
                pic_Candidato.Visible = false;
                txt_Nome.Text = ("");
                txt_Partido.Text = ("");
                txt_numero.Text = ("");
            }
           else if (txt_numero.Text == "50")
            {
                Gugu = Gugu + 1;
                NumbGugu.Text = ("" + Gugu);
                pic_Candidato.Visible = false;
                txt_Nome.Text = ("");
                txt_Partido.Text = ("");
                txt_numero.Text = ("");
            }
           else if (txt_numero.Text == "22")
            {
                Nal = Nal + 1;
                NumbNal.Text = ("" + Nal);
                pic_Candidato.Visible = false;
                txt_Nome.Text = ("");
                txt_Partido.Text = ("");
                txt_numero.Text = ("");

            }
        }

        private void pic_Candidato_Click(object sender, EventArgs e)
        {
         
            
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {
            if (txt_numero.Text == "12")
            {
                pic_Candidato.ImageLocation = @"C:\Users\User\source\repos\ListaC-INACABADO-main\ListaC-INACABADO-main\Ex_forms1\Midia\Oreo.jpg";
                pic_Candidato.Visible = true;
                txt_Nome.Text = ("Homem Oreo");
                txt_Partido.Text = ("PDT");

            }

            if (txt_numero.Text == "50")
            {
                pic_Candidato.ImageLocation = @"C:\Users\User\source\repos\ListaC-INACABADO-main\ListaC-INACABADO-main\Ex_forms1\Midia\Gugu.jpg";
                pic_Candidato.Visible = true;
                txt_Nome.Text = ("Gugu Negro");
                txt_Partido.Text = ("PSOL");
            }

            if (txt_numero.Text == "22")
            {
                pic_Candidato.ImageLocation = @"C:\Users\User\source\repos\ListaC-INACABADO-main\ListaC-INACABADO-main\Ex_forms1\Midia\Nal.jpg";
                pic_Candidato.Visible = true;
                txt_Nome.Text = ("Nal Do Canal");
                txt_Partido.Text = ("PL");
            }
        }

        private void bt_Branco_Click(object sender, EventArgs e)
        {
            branco = branco + 1;
            NumbBranco.Text = ("" + branco);
            pic_Candidato.Visible = false;
            txt_Nome.Text = ("");
            txt_Partido.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nal > Gugu && Nal > oreo)
            {
                MessageBox.Show("Nal do Canal é o novo Presidente do Brasil");
            }
           else if (Gugu > Nal && Gugu > oreo)
            {
                MessageBox.Show("Gugu é o novo Presidente do brasil");
            }
           else if (oreo > Gugu && oreo > Nal)
            {
                MessageBox.Show("Oreo é o novo Presidente do Brasil");
            }
        }
    }
}
