using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurriculoVitae
{
    public partial class frmCurriculo : Form
    {
        public frmCurriculo()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // dados iniciais
            List<int> onzeDigitos = new List<int>();
            List<int> noveDigitos = new List<int>();
            string ultimos2Digitos = string.Empty;

            bool cpfNaoNumerico = false;
            string cpfDigitado = txtCpf.Text;

            int qtdeDigitosDoCpf = txtCpf.TextLength;
            if (qtdeDigitosDoCpf != 11)
            {
                MessageBox.Show("O campo CPF deve conter todos os 11 digitos!");
                return;
            }

            // pegar os nove digitos do cpf digitado
            for (int posicao = 0; posicao < cpfDigitado.Length; posicao++)
            {
                string carac = cpfDigitado.Substring(posicao, 1);
                if (int.TryParse(carac, out int digito))
                {
                    lblMensagem.Text += " " + digito;

                    if (posicao <= 8)
                    {
                        noveDigitos.Add(digito);
                    } else
                    {
                        ultimos2Digitos += digito.ToString();
                    }
                } else
                {
                    cpfNaoNumerico = true;
                }
                
            }
            if (cpfNaoNumerico)
            {
                MessageBox.Show("Informe apenas os onze digitos do CPF!");
                return;
            }

            if (verificarCpf(noveDigitos, ultimos2Digitos))
            {
                MessageBox.Show("Curriculo cadastrado!");
            }


        }

        private bool verificarCpf(List<int> noveDigitos, string ultimos2Digitos)
        {
            // digito 10 e 11
            int digito10 = calcDigito10(noveDigitos);
            int digito11 = calcDigito11(noveDigitos, digito10);
            string ultimos2Digitos = string.Empty;
            string ultimosDigiCalculados = string.Empty;

            // verificar se esses digitos são correspondentes
            bool cpfValido = validarDoisUltimosDigitos(ultimos2Digitos, ultimosDigiCalculados);

            return true;
        }


        // funções de calculos auxiliares
        private int calcNoveDigitos(List<int> noveDigitos, int digInicio)
        {
            int soma = 0, mult = 0;

            for (int i = digInicio, d = 0; i >= 2; i--, d++)
            {
                int digito = noveDigitos[d];

                mult = digito * i;
                soma += mult;
            }

            return (soma % 11);
        }

        private int obterDigito(int resto)
        {
            if (resto < 2)
            {
                return 0;
            }
            else
            {
                return (resto - 11);
            }
        }


        // funcções de calculos dos digito 10 e 11
        private int calcDigito10(List<int> noveDigitos)
        {
            int digito10 = 0, resto = 0;

            resto = calcNoveDigitos(noveDigitos, 10);
            digito10 = Math.Abs(obterDigito(resto));

            return (digito10);
        }

        public int calcDigito11(List<int> noveDigitos, int digito10)
        {
            int digito11 = 0, resto = 0;
            noveDigitos.Add(digito10);

            resto = calcNoveDigitos(noveDigitos, 11);
            digito11 = Math.Abs(obterDigito(resto));

            return (digito11);
        }


        // verificar 
        private bool ValidarDoisUltimosDigitos(string ultimos2Digitos, string ultimosDigiCalculados)
        {
            

            return true; 
        }
    }
}
