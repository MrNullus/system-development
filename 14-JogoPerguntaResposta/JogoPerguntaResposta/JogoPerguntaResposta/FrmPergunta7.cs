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
    public partial class FrmPergunta7 : Form
    {

        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta7()
        {
            InitializeComponent();
        }

        private void FrmPergunta7_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (QtdeRespostasErradas == 4) {
                Pontuacao = 0;
            } else if (rdbPergunta7RespostaA.Checked)
            {
                Pontuacao += 0.0;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta7RespostaB.Checked)
            {
                Pontuacao += 1.0;
            }
            else if (rdbPergunta7RespostaC.Checked)
            {
                Pontuacao += 0.8;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta7RespostaD.Checked)
            {
                Pontuacao += 0.6;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta7RespostaE.Checked)
            {
                Pontuacao += 0.4;
                QtdeRespostasErradas += 1;
            }


            Hide();

            FrmPergunta8 pergunta8 = new FrmPergunta8();
            pergunta8.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta8.NomeJogador = NomeJogador;
            pergunta8.Pontuacao = Pontuacao;

            pergunta8.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
