using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Aluno
    {
        public int Rm { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        public string ExibirDadosAluno()
        {
            string nomeRmEndereco = string.Empty;
            nomeRmEndereco += " Nome: " + Nome;
            nomeRmEndereco += " Rm: " + Rm;
            nomeRmEndereco += " Endereço: " + Endereco;
            nomeRmEndereco += " cpf: " + Cpf;

            return nomeRmEndereco;
        }

  
    }
}
