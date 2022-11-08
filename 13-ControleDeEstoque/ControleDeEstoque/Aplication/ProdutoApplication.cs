using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Aplication
{
    class ProdutoApplication
    {

        public List<Produto> CadastrarProduto(List<Produto> produtos, Produto novoProduto)
        {
            produtos.Add(novoProduto);

            return produtos;
        }

    }
}
