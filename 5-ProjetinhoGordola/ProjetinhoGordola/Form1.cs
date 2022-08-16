using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetinhoGordola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imgAbaixoPeso.Visible = false;
            imgPesoNormal.Visible = false;
            imgSobrepeso.Visible = false;
            imgObesidade1.Visible = false;
            imgObesidade2.Visible = false;

            // pegar textbox
            float altura = float.Parse(txtAltura.Text);
            float peso = float.Parse(txtPeso.Text);

            //calculo 
            float imc = peso / (altura * altura);

            // verificação
            if (imc <= 18.5)
            {

               imgAbaixoPeso.Visible = true;

            } else if ((imc > 18.5) && (imc < 25))
            {

                imgPesoNormal.Visible = true;

            } else if ((imc >= 25) && (imc < 30))
            {

                imgSobrepeso.Visible = true;

            } else if ((imc >= 30) && (imc < 40))
            {

                imgObesidade1.Visible = true;

            } else if (imc >= 40)
            {

                imgObesidade2.Visible = true;

            }

        }
    }
}
