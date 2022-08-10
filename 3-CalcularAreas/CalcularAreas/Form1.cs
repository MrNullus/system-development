using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularAreas
{
    public partial class frmCalcularAreas : Form
    {
        private object txtAltura;

        public frmCalcularAreas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtBase.Text = "";
            txtAlt.Text = "";
            txtResultado.Text = "";

        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {

            double lado = Convert.ToDouble(txtBase.Text);
            double resultado = lado * lado;

            txtResultado.Text = resultado.ToString();

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {

            double largura = Convert.ToDouble(txtBase.Text);
            double altura = Convert.ToDouble(txtAlt.Text);

            double resultado = (largura * altura) / 2;

            txtResultado.Text = resultado.ToString();

        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {

            double largura = Convert.ToDouble(txtBase.Text);
            double altura = Convert.ToDouble(txtAlt.Text);

            double resultado = largura * altura;

            txtResultado.Text = resultado.ToString();

        }
    }
}
