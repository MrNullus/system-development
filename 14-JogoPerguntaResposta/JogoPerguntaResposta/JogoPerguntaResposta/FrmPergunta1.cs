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
            double pontuacao;

            if (rdbPergunta1RespostaA.Checked)
            {
                pontuacao = 0.8;
            }
            else if (rdbPergunta1RespostaB.Checked)
            {
                pontuacao = 1.0;
            }
            else if (rdbPergunta1RespostaC.Checked)
            {
                pontuacao = 0.6;
            }
            else if (rdbPergunta1RespostaD.Checked)
            {
                pontuacao = 0.4;
            }
            else if (rdbPergunta1RespostaE.Checked)
            {
                pontuacao = 0.0;
            }
        }
    }
}
