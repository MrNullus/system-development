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
    public partial class FrmPergunta3 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta3()
        {
            InitializeComponent();
        }

        private void FrmPergunta3_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (rdbPergunta3RespostaA.Checked)
            {
                Pontuacao = 0.0;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta3RespostaB.Checked)
            {
                Pontuacao = 0.4;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta3RespostaC.Checked)
            {
                Pontuacao = 0.6;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta3RespostaD.Checked)
            {
                Pontuacao = 0.8;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta3RespostaE.Checked)
            {
                Pontuacao = 1.0;
            }


            Hide();

            FrmPergunta4 pergunta4 = new FrmPergunta4();
            pergunta4.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta4.NomeJogador = NomeJogador;
            pergunta4.Pontuacao = Pontuacao;

            pergunta4.Show();
        }

      
    }
}
