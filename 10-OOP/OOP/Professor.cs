using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Professor
    {
        // # Atributos
        public int    Rm { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int    Idade { get; set; }
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Especializacao { get; set; }

        public List<string> Cursos { get; set; }
        public List<Turma> Turmas { get; set; }

        public string Salario { get; set;}

    }

}
