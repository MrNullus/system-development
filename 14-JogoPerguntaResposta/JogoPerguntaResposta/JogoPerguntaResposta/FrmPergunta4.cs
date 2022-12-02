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
    public partial class FrmPergunta4 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }

        public FrmPergunta4()
        {
            InitializeComponent();
        }

        private void FrmPergunta4_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }
        
        private void btnResponder_Click(object sender, EventArgs e)
        {
            Hide();

            FrmPergunta5 pergunta5 = new FrmPergunta5();

            pergunta5.NomeJogador = NomeJogador;
            pergunta5.Pontuacao = Pontuacao;
            pergunta5.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }
    }
}
