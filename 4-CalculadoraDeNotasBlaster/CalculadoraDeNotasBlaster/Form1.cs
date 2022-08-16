using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeNotasBlaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // setar imagens
            imgAprovado.Visible = false;
            imgRecuperacao.Visible = false;
            imgReprovado.Visible = false;

            // calculo 
            float nota1 = float.Parse(txtNota1.Text);
            float nota2 = float.Parse(txtNota2.Text);
            float nota3 = float.Parse(txtNota3.Text);

            float media = (nota1 + nota2 + nota3) / 3;

            // Vericar notas
            if (media > 6)
            {

                imgAprovado.Visible = true;

            } else if (media == 6) 
            {

                imgRecuperacao.Visible = true;

            } else
            {

                imgReprovado.Visible = true;

            }

        }
    }
}
