using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriaDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            FrmCadCategoriaProduto frmCadCategoria = new FrmCadCategoriaProduto();

            frmCadCategoria.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // -> fecha todas as dependencias, fechando o form principal o que fecha tudo
            Close();
            // -> fecha todos os forms
            // Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProduto frmCadProduto = new FrmCadProduto();

            frmCadProduto.Show();
        }
    }
}
