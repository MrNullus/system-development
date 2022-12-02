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
    public partial class FrmPergunta1 : Form
    {

        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }


        public FrmPergunta1()
        {
            InitializeComponent();
        }

        private void FrmPergunta1_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (rdbPergunta1RespostaA.Checked)
            {
                Pontuacao = 0.8;
            }
            else if (rdbPergunta1RespostaB.Checked)
            {
                Pontuacao = 1.0;
            }
            else if (rdbPergunta1RespostaC.Checked)
            {
                Pontuacao = 0.6;
            }
            else if (rdbPergunta1RespostaD.Checked)
            {
                Pontuacao = 0.4;
            }
            else if (rdbPergunta1RespostaE.Checked)
            {
                Pontuacao = 0.0;
            }

            Hide();

            FrmPergunta2 pergunta2 = new FrmPergunta2();

            pergunta2.NomeJogador = NomeJogador;
            pergunta2.Pontuacao = Pontuacao;
            pergunta2.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }
    }
}
