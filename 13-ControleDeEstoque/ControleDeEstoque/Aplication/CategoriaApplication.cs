using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Aplication
{
    class CategoriaApplication
    {
        // -> Cadastar nova categoria
        public List<Categoria> CadastrarCategoria(List<Categoria> categorias, Categoria novaCategoria)
        {
            categorias.Add(novaCategoria);

            return categorias;
        }
    }
}
