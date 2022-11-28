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
    public partial class FrmPergunta7 : Form
    {

        public string NomeJogador { get; set; }

        public FrmPergunta7()
        {
            InitializeComponent();
        }

        private void FrmPergunta7_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            Hide();

            FrmPergunta8 pergunta8 = new FrmPergunta8();

            pergunta8.NomeJogador = NomeJogador;
            pergunta8.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
