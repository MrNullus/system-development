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
        # Função Validar Entrada do Usuario #
        */
        public bool ValorTxtValido() 
        {
            bool valorVazio, valorNumerico;
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            
            valorNumerico = Int.TryParse(valor1, out value)  &&  Int.TryParse(valor2, out value);
            valorVazio =  valor1 == '' || valor2 == '';
            
            if (valorVazio) 
            {
                valorVazio = true;
                MessageBox.Show("Os campos não podem estar vazios, por favor, preencha os");
            } else 
            {
                valorVazio = false;
            }
            
            if (valorNumerico) 
            {
                valorNumerico = true;
            } else 
            {
                valorNumerico = false;
                MessageBox.Show("Informe apenas números inteiros.");
            }
            
            if (!valorVazio && valorNumerico) 
            {
                return true;
            } else 
            {
                return false;
            }
        }
    

        /* 
        # Funções Auxiliares #
        */
        public int ConvertParaInt(string valor) 
        {
            return Convert.ToInt32(valor);
        }
        public string PegarValorDaTxt(TextBox txt) 
        {
            return ConvertParaInt(txt.Text);
        }


        /* 
        # Funções Para Realizar os Calculos #
        */
        // -> soma
        public string SomarNumeros(string val1, string val2)
        {
            return (val1 + val2).ToString();
        }
        // -> subtração
        public string SubtrairNumeros(string val1, string val2)
        {
            return (val1 - val2).ToString();
        }
        // -> multiplicação
        public string MultiplicarNumeros(string val1, string val2)
        {
            return (val1 * val2).ToString();
        }
        // -> divisão
        public string DividirNumeros(string val1, string val2)
        {
            return (val1 / val2).ToString();
        }
        
        
        /* 
        # Função Que Irá Manipular o Calculo a Ser Feito #
        */
        public string Calcular(string op)
        {
            int valor1 = PegarValorDaTxt(txtValor1);
            int valor2 = PegarValorDaTxt(txtValor2);
            string calculo = string.Empty;

            if (op == "+") 
            {
                calculo = SomarNumeros(valor1, valor2);
            } 
            else if (op == "-")
            {
                calculo = SubtrairNumeros(valor1, valor2);
            } 
            else if (op == "*") 
            {
                calculo = MultiplicarNumeros(valor1, valor2);
            }
            else
            {
                calculo = DividirNumeros(valor1, valor2);
            }
         
            return calculo;
        }


        /*
        # Procedimentos de Limpeza #
        */
        // -> setar o estado dos radio buttons como false
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
        // -> limpar todos os controles especificados em uma lista passada
        public void LimparControle(string[] controls)
        {
            foreach (var item in controls)
            {
                item.Text = string.Empty;
            }
        }
        // -> limpar todos os controles (as textbox de entrada, a label de saída e os radio buttons)
        public void LimparControles()
        {
            string[] controles = { txtValor1.Text, txtValor2.Text, lblMensagem.Text };
        
            LimparControle(controles);
            SetarPadraoRdbs();
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
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
            string[] controles = { txtValor1.Text, txtValor2.Text };
            string resultado = string.Empty;
         
            if (ValorTxtValido())
            {
                if (rdbSomar.Checked)
                {
                    resultado = Calcular("+");
                } 
                else if (rdbSubtrair.Checked)
                {
                    resultado = Calcular("-");
                } 
                else if (rdbMultiplicar.Checked)
                {
                    resultado = Calcular("*");
                }   
                else if(rdbDividir.Checked)
                {
                    resultado = Calcular("/");
                } 
                else
                {
                    MessageBox.Show("Selecione uma das opções de calculos.");
                }
            
                lblMensagem.Text = resultado;
                LimparControle(controles);       
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparControles();
        }
    }
}
