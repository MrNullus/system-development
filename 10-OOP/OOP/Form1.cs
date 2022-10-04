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
            Aluno alunoCadastrar = new Aluno();
            alunoCadastrar.Nome = txtNome.Text;
            alunoCadastrar.Rm = int.Parse(txtRm.Text);
            alunoCadastrar.Cpf = txtCpf.Text;
            alunoCadastrar.Endereco = txtEndereco.Text;

            lblResultado.Text = alunoCadastrar.ExibirDadosAluno();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
