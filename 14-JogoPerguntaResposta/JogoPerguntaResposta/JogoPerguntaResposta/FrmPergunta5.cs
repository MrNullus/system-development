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
            Hide();

            FrmPergunta6 pergunta6 = new FrmPergunta6();

            pergunta6.NomeJogador = NomeJogador;
            pergunta6.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
