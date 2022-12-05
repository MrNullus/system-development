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
    public partial class FrmPergunta2 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta2()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (rdbPergunta2RespostaA.Checked)
            {
                Pontuacao = 1.0;
            }
            else if (rdbPergunta2RespostaB.Checked)
            {
                Pontuacao = 0.8;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta2RespostaC.Checked)
            {
                Pontuacao = 0.6;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta2RespostaD.Checked)
            {
                Pontuacao = 0.4;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta2RespostaE.Checked)
            {
                Pontuacao = 0.0;
                QtdeRespostasErradas += 1;
            }

            Hide();

            FrmPergunta3 pergunta3 = new FrmPergunta3();
            pergunta3.QtdeRespostasErradas = QtdeRespostasErradas;      
            pergunta3.NomeJogador = NomeJogador;
            pergunta3.Pontuacao += Pontuacao;

            pergunta3.Show();
        }

        private void FrmPergunta2_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }
    }
}
