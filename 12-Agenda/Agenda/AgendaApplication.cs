using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class AgendaApplication
    {

        public List<Contato> CadastrarNovoContato(List<Contato> listaContatos, Contato novoContato)
        {
            listaContatos.Add(novoContato);

            return listaContatos;
        }

        public List<Contato> DeletarContato(List<Contato> listaContatos, Contato contato)
        {
            listaContatos.Remove(contato);

            return listaContatos;
        }

    }
}
