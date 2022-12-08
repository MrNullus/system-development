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
        public string NomeJogador { get; set; }
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
            if (QtdeRespostasErradas == 4)
            {
                Pontuacao = 0;
            }
            
            if (rdbPergunta10RespostaA.Checked)
            {
                Pontuacao += 0.6;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta10RespostaB.Checked)
            {
                Pontuacao += 0.4;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta10RespostaC.Checked)
            {
                Pontuacao += 0.0;
                QtdeRespostasErradas += 1;
            }
            else if (rdbPergunta10RespostaD.Checked)
            {
                Pontuacao += 1.0;
            }
            else if (rdbPergunta10RespostaE.Checked)
            {
                Pontuacao += 0.8;
                QtdeRespostasErradas += 1;
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Hide();

            FrmPlacar placarFinal = new FrmPlacar();
            placarFinal.QtdeRespostasErradas = QtdeRespostasErradas;
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
