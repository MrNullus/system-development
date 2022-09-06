using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modularizacao
{
    public partial class frmModularizacao : Form
    {
        public frmModularizacao()
        {
            InitializeComponent();
        }

        /* 
        # Funções de Calculos #
        */
        // -> soma
        public string SomarNumeros(string v1, string v2)
        {
            int valor1 = Convert.ToInt32(v1);
            int valor2 = Convert.ToInt32(v2);

            return (valor1 + valor2).ToString();
        }
        // -> subtração
        public void SubtrairNumeros(string v1, string v2)
        {

        }
        // -> multiplicação
        public void MultiplicarNumeros(string v1, string v2)
        {

        }
        // -> divisão
        public void DividirNumeros(string v1, string v2)
        {

        }

        /*
        # Procedimentos de Limpeza #
        */
        // -> limpar todos os txts de entrada
        public void LimparTxtsDeEntrada()
        {
            txtValor1.Text = string.Empty;
            txtValor2.Text = string.Empty;
        }

        // -> limpar todos os controles
        public void LimparControles()
        {
            LimparTxtsDeEntrada();

            lblMensagem.Text = string.Empty;

            foreach (var item in this.Controls)
            {
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
        }

        public void ManipularClick()
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;

            if (rdbSomar.Checked)
            {
                SomarNumeros(valor1, valor2);
            } 
            else if (rdbSubtrair.Checked)
            {
                SubtrairNumeros(valor1, valor2);
            } 
            else if (rdbMultiplicar.Checked)
            {
                MultiplicarNumeros(valor1, valor2);
            } 
            else if(rdbDividir.Checked)
            {
                DividirNumeros(valor1, valor2);
            } 
            else
            {
                MessageBox.Show("Selecione uma das opções de calculos.");
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            string resultado = SomarNumeros(txtValor1.Text, txtValor2.Text);

            lblMensagem.Text = resultado;
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmModularizacao_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            

            if (rdbSomar.Checked == true)
            {
                lblMensagem.Text = SomarNumeros(valor1, valor2);
            }

            LimparTxtsDeEntrada();

        }
    }
}
