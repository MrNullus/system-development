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
            Hide();

            FrmPergunta4 pergunta4 = new FrmPergunta4();

            pergunta4.NomeJogador = NomeJogador;
            pergunta4.Show();
        }

      
    }
}
