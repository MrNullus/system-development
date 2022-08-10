using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introducaonet
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double valorDigitadoUm = Convert.ToDouble(txtNumb1.Text);
            double valorDigitadoDois = Convert.ToDouble(txtNumb2.Text);

            double resultado = valorDigitadoUm + valorDigitadoDois;

            txtResult.Text = resultado.ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            double valorDigitadoUm = Convert.ToDouble(txtNumb1.Text);
            double valorDigitadoDois = Convert.ToDouble(txtNumb2.Text);

            double resultado = valorDigitadoUm - valorDigitadoDois;

            txtResult.Text = resultado.ToString();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {

            double valorDigitadoUm = Convert.ToDouble(txtNumb1.Text);
            double valorDigitadoDois = Convert.ToDouble(txtNumb2.Text);

            double resultado = valorDigitadoUm * valorDigitadoDois;

            txtResult.Text = resultado.ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double valorDigitadoUm = Convert.ToDouble(txtNumb1.Text);
            double valorDigitadoDois = Convert.ToDouble(txtNumb2.Text);

            double resultado = valorDigitadoUm / valorDigitadoDois;

            txtResult.Text = resultado.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
