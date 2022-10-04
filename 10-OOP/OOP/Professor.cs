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

    class ComponenteCurricular
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public bool ComponenteObrigatorio { get; set; }
    }

    class Turma
    {
        public string Nome { get; set; }
        public Periodo periodo { get; set; }
        public List<ComponenteCurricular> Componentes { get; set; }
    }

    class Periodo
    {
        public string Nome { get; set; }
        public string Turno { get; set; }
    }
}
