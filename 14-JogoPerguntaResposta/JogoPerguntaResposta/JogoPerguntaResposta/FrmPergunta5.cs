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
    public partial class FrmPergunta5 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta5()
        {
            InitializeComponent();
        }

        private void FrmPergunta5_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (QtdeRespostasErradas == 4)
            {
                Pontuacao = 0;
                QtdeRespostasErradas += 1;
            } else if (rdbPergunta5RespostaA.Checked)
            {
                Pontuacao += 0.4;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta5RespostaB.Checked)
            {
                Pontuacao += 0.0;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta5RespostaC.Checked)
            {
                Pontuacao += 1.0;
            }
            else if (rdbPergunta5RespostaD.Checked)
            {
                Pontuacao += 0.8;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta5RespostaE.Checked)
            {
                Pontuacao += 0.6;
                QtdeRespostasErradas += 1;
            }


            Hide();

            FrmPergunta6 pergunta6 = new FrmPergunta6();
            pergunta6.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta6.NomeJogador = NomeJogador;
            pergunta6.Pontuacao = Pontuacao;

            pergunta6.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
