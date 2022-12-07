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
    public partial class FrmPergunta8 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta8()
        {
            InitializeComponent();
        }

        private void FrmPergunta8_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (QtdeRespostasErradas == 4) {
                Pontuacao = 0;
            } else if (rdbPergunta8RespostaA.Checked)
            {
                Pontuacao += 0.4;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta8RespostaB.Checked)
            {
                Pontuacao += 0.0;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta8RespostaC.Checked)
            {
                Pontuacao += 1.0;
            }
            else if (rdbPergunta8RespostaD.Checked)
            {
                Pontuacao += 0.8;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta8RespostaE.Checked)
            {
                Pontuacao += 0.6;
                QtdeRespostasErradas += 1;
            }


            Hide();

            FrmPergunta9 pergunta9 = new FrmPergunta9();
            pergunta9.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta9.NomeJogador = NomeJogador;
            pergunta9.Pontuacao = Pontuacao;

            pergunta9.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
