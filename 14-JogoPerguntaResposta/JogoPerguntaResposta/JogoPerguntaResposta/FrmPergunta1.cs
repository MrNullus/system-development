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
    }
}
