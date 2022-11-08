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
    public partial class FrmCadProduto : Form
    {

        List<Produto> produtos = new List<Produto>();

        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            Produto novoProduto = new Produto();

            novoProduto.Nome = txtCategoriaProduto.Text;
            novoProduto.Quantidade = Convert.ToInt32(txtQtdeProduto.Text);
            novoProduto.Valor = Convert.ToDouble(txtValorProduto.Text);
            novoProduto.DataValidade = txtCategoriaProduto.Text;

            Random rdn = new Random();
            
            categoria.Id = rdn.Next(0, 2000);
            categoria.Nome = txtCategoriaProduto.Text;
            novoProduto.Cat = categoria;

            novoProduto.Descricao = txtDescricaoProduto.Text;
            novoProduto.Obs = txtObsProduto.Text;

            ListViewItem item = new ListViewItem();
            item.Text = "ID: " + novoProduto.ID + " | " + "Nome: " + novoProduto.Nome + " | " + "Quantidade: " + novoProduto.Quantidade + " | " + "Valor: " + novoProduto.Valor + " | " + "Data Validade: " + novoProduto.DataValidade + " | " + "Data Validade: " + novoProduto.DataValidade + " | " + "Categoria: " + novoProduto.Cat.Nome + " | " + "Descrição: " + novoProduto.Descricao + " | " + "Observação: " + novoProduto.Obs;

            listProduto.Items.Add(item);

            lblQtdeProdutos.Text = produtos.Count().ToString();
        }
    }
}
