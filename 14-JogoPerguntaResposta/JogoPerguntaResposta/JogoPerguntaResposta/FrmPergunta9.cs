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
    public partial class FrmPergunta9 : Form
    {
        public FrmPergunta9()
        {
            InitializeComponent();
        }

        private void FrmPergunta9_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;   
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            Hide();

            FrmPergunta9 pergunta9 = new FrmPergunta9();

            pergunta9.NomeJogador = NomeJogador;
            pergunta9.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
