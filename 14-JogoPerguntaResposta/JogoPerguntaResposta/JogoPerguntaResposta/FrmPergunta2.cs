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
    public partial class FrmPergunta2 : Form
    {
       public string NomeJogador { get; set; }

        public FrmPergunta2()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            Hide();

            FrmPergunta3 pergunta3 = new FrmPergunta3();

            pergunta3.NomeJogador = NomeJogador;
            pergunta3.Show();
        }

        private void FrmPergunta2_Load(object sender, EventArgs e)
        {
            lblNomeJogador.Text = NomeJogador;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");

            Close();
        }
    }
}
