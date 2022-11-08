using ControleDeEstoque.Aplication;
using ControleDeEstoque.Models;
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
    public partial class FrmCadCategoriaProduto : Form
    {
        List<Categoria> categorias = new List<Categoria>();
        CategoriaApplication categoriaApplication = new CategoriaApplication();

        public FrmCadCategoriaProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoria novaCategoria = new Categoria();

            novaCategoria.Id = Convert.ToInt32(txtIdCategoria.Text);
            novaCategoria.Nome = txtNome.Text;

            categorias = categoriaApplication.CadastrarCategoria(categorias, novaCategoria);

            ListViewItem item = new ListViewItem();
            item.Text = "ID: " + novaCategoria.Id + " | " + "Nome: " + novaCategoria.Nome;

            listCategoria.Items.Add(item);

            lblQtdeCategorias.Text = categorias.Count().ToString(); 
        }

    }
}
