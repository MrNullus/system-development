using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPerguntaResposta
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtNomeJogador.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo nome", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // esconder o formulario ativo no momento
            Hide();

            FrmPergunta1 pergunta1 = new FrmPergunta1();
            pergunta1.NomeJogador = txtNomeJogador.Text;
            pergunta1.Show();
        }
    }
}
