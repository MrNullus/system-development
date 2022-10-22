using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador
{
    public partial class frmCalculador : Form
    {
        public frmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculador calc = new Calculador();
            string resultado = string.Empty;

            // Operações
            if (rdbSoma.Checked)
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = calc.SomarValores(valor1, valor2).ToString();
            }

            if (rdbSubtracao.Checked)
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = calc.SubtrairValores(valor1, valor2).ToString();
            }

            if (rdbMultiplicacao.Checked)
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = calc.MultiplicarValores(valor1, valor2).ToString();
            }

            // Calculos das Áreas
            if (rdbDivisao.Checked)
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = calc.DividirValores(valor1, valor2).ToString();
            }

            if (rdbQuadrado.Checked)
            {
                int valor1 = int.Parse(txtValor1.Text);

                resultado = calc.CalcularAreaQuadrado(valor1).ToString();
            }

            if (rdbCirculo.Checked)
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);

                resultado = calc.CalcularAreaCirculo(valor1).ToString();
            }

            if (rdbTriangulo.Checked)
            {
                int valor1 = int.Parse(txtValor1.Text);
                int valor2 = int.Parse(txtValor2.Text);

                resultado = calc.CalcularAreaTriangulo(valor1, valor2).ToString();
            }

            if (rdbRetangulo.Checked)
            {
                int valor1 = int.Parse(txtValor1.Text);
                int valor2 = int.Parse(txtValor2.Text);

                resultado = calc.CalcularAreaRetangulo(valor1, valor2).ToString();
            }

            // Outros Calculos
            if (rdbParOuImpar.Checked)
            {
                int valor1 = int.Parse(txtValor1.Text);

                resultado = calc.ParOuImpar(valor1);
            }

            if (rdbImc.Checked)
            {
                double valor1 = Convert.ToDouble(txtValor1.Text);
                double valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = calc.CalcularImc(valor1, valor2);
            }

            lblResultado.Text = resultado;

        }

        public void SetarPadraoRdbs()
        {
            foreach (var item in this.Controls)
            {
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = string.Empty; 
            txtValor2.Text = string.Empty;
            lblResultado.Text = string.Empty;

            SetarPadraoRdbs();
        }
    }
}
 