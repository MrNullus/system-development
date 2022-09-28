using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurriculoVitae
{
    public partial class frmCurriculo : Form
    {
        public frmCurriculo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // dados iniciais
            int[] digitos = new int[];

            // pegar os nove digitos do cpf digitado
            foreach(char digito in txtCpf)
            {

            }
        }
    }
}