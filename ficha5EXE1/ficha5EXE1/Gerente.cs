using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha5EXE1
{
    class Gerente : Funcionario {
        public string Especialidade { get; set; }
        public int Extensao { get; set; }

        public Gerente() : base() { Especialidade = null; Extensao = 0; }
        public Gerente(int id, string nome, Data data, string mail, double val, string esp, int ext) : base(id, nome, data, mail, val) { Especialidade = esp; Extensao = ext; }
        public Gerente(Gerente g) : base(g) { Especialidade = g.Especialidade; Extensao = g.Extensao; }
        public override string ToString(){ return base.ToString() + "\nEscpecialidade: " + Especialidade + "\nExtensão: "+ Extensao + "\n"; }
    }
}
