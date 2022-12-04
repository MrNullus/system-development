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
    public partial class FrmPergunta6 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }
        
        public FrmPergunta6()
        {
            InitializeComponent();
        }

        private void FrmPergunta6_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (QtdeRespostasErradas == 3) {
                Pontuacao = 0;
            } else if (rdbPergunta6RespostaA.Checked)
            {
                Pontuacao = 0.6;
            }
            else if (rdbPergunta6RespostaB.Checked)
            {
                Pontuacao = 0.4;
            }
            else if (rdbPergunta6RespostaC.Checked)
            {
                Pontuacao = 0.0;
            }
            else if (rdbPergunta6RespostaD.Checked)
            {
                Pontuacao = 1.0;
            }
            else if (rdbPergunta6RespostaE.Checked)
            {
                Pontuacao = 0.8;
            }


            Hide();

            FrmPergunta7 pergunta7 = new FrmPergunta7();
            pergunta7.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta7.NomeJogador = NomeJogador;
            pergunta7.Pontuacao = Pontuacao;

            pergunta7.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
