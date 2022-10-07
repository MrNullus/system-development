using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// 
    /// </summary>
    /// 

    class Professor
    {
        public string Nome { get; set; }
        public int RM { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public List<string> Cursos { get; set; }

        public List<Turma> Turmas { get; set; }
    }
}
