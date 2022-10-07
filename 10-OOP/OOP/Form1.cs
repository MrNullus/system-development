using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Criação do objeto Validacao
            Validacao validaCampos = new Validacao();

            // Validações primarias necessarias
            if (!validaCampos.IsVazio(txtNome.Text))
            {
                lblResultado.Text = "Campo nome é de preenchimento obrigatorio";
                return;
            }
            if (!validaCampos.IsVazio(txtEndereco.Text))
            {
                lblResultado.Text = "Campo Endereço é de preenchimento obrigatorio";
                return;
            }
            if (!validaCampos.IsVazio(txtCpf.Text))
            {
                lblResultado.Text = "Campo Cpf preenchimento obrigatório";
                return;
            }
            if (!validaCampos.IsValorNumerico(txtRm.Text))
            {
                lblResultado.Text = "Campo RM é de preenchimento obrigatorio e somente números";
                return;
            }
            
            // Validação do CPF
            if (!validaCampos.ValidarCpf(txtCpf.Text))
            {
                lblResultado.Text = "Campo Cpf inválido";
                return;
            }


            // Criação do objeto Aluno
            Aluno alunoCadastrar = new Aluno();

            // Cadastro dos dados recebidos dentro das textboxs
            alunoCadastrar.Nome = txtNome.Text;
            alunoCadastrar.Rm = int.Parse(txtRm.Text);
            alunoCadastrar.Cpf = txtCpf.Text;
            alunoCadastrar.Endereco = txtEndereco.Text;
            
            // Exibição dos dados cadastrados
            lblResultado.Text = alunoCadastrar.ExibirDadosAluno();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            resetarLabels(new List<TextBox>() { 
                txtNome,
                txtRm,
                txtCpf,
                txtEndereco
            });
        }


        /// <summary>
        /// Procedimento para resetar todas as textboxes
        /// </summary>
        /// <param name="textBoxes">TextBoxes que serão resetadas</param>
        private void resetarLabels(List<TextBox> textBoxes)
        {
            foreach (TextBox txt in textBoxes)
            {
                txt.Text = string.Empty;
            }
        }

    }
}
