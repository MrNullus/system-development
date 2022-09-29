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
            setarLabel(lblMsgCpf, "");
            setarLabel(lblMsgTelefone, "");
            setarLabel(lblMsgEnder, "");

            // dados iniciais
            List<int> onzeDigitos = new List<int>();
            List<int> noveDigitos = new List<int>();
            string ultimos2Digitos = string.Empty;

            bool cpfNaoNumerico = false;
            string cpfDigitado = txtCpf.Text;


            // verificação primaria - (verificar quantidade de digitos informados e se estão vazios)
            int qtdeDigitosDoCpf = txtCpf.TextLength;
            int qtdeDigitosDoTel = txtTelefone.TextLength;

            if (estaVazio(txtCpf) && estaVazio(txtTelefone) && estaVazio(txtEnder)) 
            {
                setarLabel(lblMsgCpf, "Campo obrigatório!");
                setarLabel(lblMsgTelefone, "Campo obrigatório!");
                setarLabel(lblMsgEnder, "Campo obrigatório!");

                return;
            }

            if (qtdeDigitosDoCpf != 11 && qtdeDigitosDoTel != 12)
            {
               setarLabel(lblMsgCpf, "O campo CPF deve conter todos os 11 digitos!");
               setarLabel(lblMsgTelefone, "Telefone está invalido!");

               return;
            }


            // pegar os nove digitos do cpf digitado
            for (int posicao = 0; posicao < cpfDigitado.Length; posicao++)
            {
                string carac = cpfDigitado.Substring(posicao, 1);

                if (int.TryParse(carac, out int digito))
                {
                    if (posicao <= 8)
                    {
                        noveDigitos.Add(digito);
                    } 
                    else
                    {
                        ultimos2Digitos += digito.ToString();
                    }
                } 
                else
                {
                    cpfNaoNumerico = true;
                }
                
            }


            // verificações secundarias - (se possui apenas numeros e se é valido)
            if (cpfNaoNumerico)
            {
               setarLabel(lblMsgCpf, "Informe apenas os onze digitos do CPF!");
               return;
            }
            if (verificarCpf(noveDigitos, ultimos2Digitos))
            {
                MessageBox.Show("Curriculo cadastrado!");
            }
        }


        // função que irá verificar se o CPF informado é valido ou não     
        private bool verificarCpf(List<int> noveDigitos, string ultimos2Digitos)
        {
            // digito 10 e 11 calculados
            int digito10 = calcDigito10(noveDigitos);
            int digito11 = calcDigito11(noveDigitos, digito10);

            // tornando os digitos 10 e 11 (inseridos e calculados) em um unico texto 
            string ultimosDigitos = ultimos2Digitos[0].ToString() + ultimos2Digitos[1].ToString();
            string ultimosDigiCalculados = digito10.ToString() + digito11.ToString();

            // verificar se esses digitos são correspondentes
            bool cpfValido = validarDoisUltimosDigitos(ultimos2Digitos, ultimosDigiCalculados);

            // autenticação final - verificar se é ou não valido
            if (cpfValido) 
            {
                return true;
            }
            else
            {
                setarLabel(lblMsgCpf, "CPF invalido! Por favor, insira um CPF valido");
                return false;
            }
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


        // funções de calculos dos digito 10 e 11
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


        // validara se os ultimos digitos inseridos são correspondentes aos calculados 
        private bool validarDoisUltimosDigitos(string ultimos2Digitos, string ultimosDigitosCalculados)
        {
            if (ultimos2Digitos == ultimosDigitosCalculados)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // funções auxiliares
        private bool estaVazio(TextBox campo) {
            if (campo.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void setarLabel(Label lbl, string msg) {
            lbl.Text = msg;
        }
    }
}
