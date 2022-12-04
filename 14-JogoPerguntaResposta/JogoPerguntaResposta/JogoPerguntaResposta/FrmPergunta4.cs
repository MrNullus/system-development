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
        public int QtdeRespostasErradas { get; set; }

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
            if (QtdeRespostasErradas == 3) {
                Pontuacao = 0;
            } else if (rdbPergunta4RespostaA.Checked)
            {
                Pontuacao = 0.0;
            }
            else if (rdbPergunta4RespostaB.Checked)
            {
                Pontuacao = 1.0;
            }
            else if (rdbPergunta4RespostaC.Checked)
            {
                Pontuacao = 0.8;
            }
            else if (rdbPergunta4RespostaD.Checked)
            {
                Pontuacao = 0.6;
            }
            else if (rdbPergunta4RespostaE.Checked)
            {
                Pontuacao = 0.4;
            }


            Hide();

            FrmPergunta5 pergunta5 = new FrmPergunta5();
            pergunta5.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta5.NomeJogador = NomeJogador;
            pergunta5.Pontuacao = Pontuacao;

            pergunta5.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }
    }
}
