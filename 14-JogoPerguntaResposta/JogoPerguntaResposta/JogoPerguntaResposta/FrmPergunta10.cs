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
    public partial class FrmPergunta10 : Form
    {
        public sting NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta10()
        {
            InitializeComponent();
        }

        private void FrmPergunta10_Load(object sender, EventArgs e) {
            lblNomeJogador.Text = NomeJogador;
        }


        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (QtdeRespostasErradas == 3) {
                Pontuacao = 0;
            } else if (rdbPergunta10RespostaA.Checked)
            {
                Pontuacao = 0.6;
            }
            else if (rdbPergunta10RespostaB.Checked)
            {
                Pontuacao = 0.4;
            }
            else if (rdbPergunta10RespostaC.Checked)
            {
                Pontuacao = 0.0;
            }
            else if (rdbPergunta10RespostaD.Checked)
            {
                Pontuacao = 1.0;
            }
            else if (rdbPergunta10RespostaE.Checked)
            {
                Pontuacao = 0.8;
            }


            Hide();

            FrmPlacarFinal placarFinal = new FrmPlacarFinal();
            placarFinal.NomeJogador = NomeJogador;
            placarFinal.Pontuacao = Pontuacao;

            placarFinal.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
