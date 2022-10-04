using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Turma
    {
        public string Nome { get; set; }
        public Periodo periodo { get; set; }
        public List<ComponenteCurricular> Componentes { get; set; }
    }

}
