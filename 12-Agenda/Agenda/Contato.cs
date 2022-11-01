using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contato
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string Observacao { get; set; }
        public bool   Ativo { get; set; }

        public string GetDadosFormatados()
        {
            string dadosFormatados = "Nome: " + Nome + " | " + "Celular: " + Celular + " | " + "Fixo: " + " | " + "Email: " + Email + " | " + "Observação: " + Observacao + " | ";

            return dadosFormatados;
        }

    }
}
