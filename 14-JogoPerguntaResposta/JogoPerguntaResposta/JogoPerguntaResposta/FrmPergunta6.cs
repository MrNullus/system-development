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
    public partial class FrmPergunta6 : Form
    {
        public string NomeJogador { get; set; }
        
        public FrmPergunta6()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            Hide();

            FrmPergunta7 pergunta7 = new FrmPergunta7();

            pergunta7.NomeJogador = NomeJogador;
            pergunta7.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Se sair agora, a pontuação será perdida!");
            
            Close();
        }
    }
}
