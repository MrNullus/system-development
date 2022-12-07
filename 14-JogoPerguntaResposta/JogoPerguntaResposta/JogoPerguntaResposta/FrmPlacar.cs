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
    public partial class FrmPlacar : Form
    {
        public string NomeJogador { get; set; }
        public double Pontuacao { get; set; }
        public int QtdeRespostasErradas { get; set; }

        public FrmPlacar()
        {
            InitializeComponent();
        }

        private void FrmPlacar_Load(object sender, EventArgs e) {   
            lblNomeJogador.Text = NomeJogador;
            lblAcertos.Text = Convert.ToString(Pontuacao);
            lblErros.Text = Convert.ToString(QtdeRespostasErradas);
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O jogo será reiniciado...");
            Hide();

            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            Close();
        }

       
    }
}
