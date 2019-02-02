using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha5EXE1
{
    class Operario : Funcionario {
        public string Departamento { get; set; }

        public Operario() : base() { Departamento = null; } 
        public Operario(int id, string nome, Data data, string mail, double val, string dep) : base(id, nome, data, mail, val) { Departamento = dep; } 
        public Operario(Operario o) : base(o) { Departamento = o.Departamento; }
        public override string ToString() { return base.ToString() +  "Departamento: " +Departamento+ "\n"; }
    }
}
