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

            //FrmPergunta5 pergunta5 = new FrmPergunta5();

            //pergunta5.NomeJogador = NomeJogador;
            //pergunta5.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
