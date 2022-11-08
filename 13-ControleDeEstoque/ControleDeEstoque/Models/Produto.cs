using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    class Produto
    {
        public Guid ID { get; set; }

        public string Nome { get; set; }
        public int  Quantidade { get; set; }
        public double Valor { get; set; }

        public string DataValidade { get; set; }
        public Categoria Cat { get; set; }

        public string Descricao { get; set; }
        public string Obs { get; set; }
    }
}
