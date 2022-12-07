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
    public partial class FrmPergunta9 : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPergunta9()
        {
            InitializeComponent();
        }

        private void FrmPergunta9_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;   
        }
        

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (QtdeRespostasErradas == 4) {
                Pontuacao = 0;
            } else if (rdbPergunta9RespostaA.Checked)
            {
                Pontuacao += 0.6;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta9RespostaB.Checked)
            {
                Pontuacao += 0.4;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta9RespostaC.Checked)
            {
                Pontuacao += 0.0;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta9RespostaD.Checked)
            {
                Pontuacao += 1.0;
            }
            else if (rdbPergunta9RespostaE.Checked)
            {
                Pontuacao += 0.8;
                QtdeRespostasErradas += 1;
            }


            Hide();

            FrmPergunta10 pergunta10 = new FrmPergunta10();
            pergunta10.QtdeRespostasErradas = QtdeRespostasErradas;
            pergunta10.NomeJogador = NomeJogador;
            pergunta10.Pontuacao = Pontuacao;

            pergunta10.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
