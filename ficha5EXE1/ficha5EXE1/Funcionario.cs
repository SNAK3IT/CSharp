using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ficha5EXE1
{
    abstract class Funcionario {
        protected int _id;
        protected String _Nome;
        public Data DATANASC { get; set; }
        protected string _eMail;
        public double ValorHora { get; set; }

        public Funcionario() { _id = 0; _Nome = null; DATANASC = new Data(); _eMail = null; ValorHora = 0.0; }
        public Funcionario(int id,string nome,Data data, string mail, double val) { ID = id; NOME = nome; DATANASC = data; MAIL = mail; ; Math.Abs(ValorHora = val); }
        public Funcionario(Funcionario f) { ID = f.ID; NOME = f.NOME; DATANASC = f.DATANASC; MAIL = f.MAIL; ValorHora = f.ValorHora; }
        public override string ToString() { return "ID: " + ID + "\nNome: "+ NOME + "\nData nascimento: "+ DATANASC.ToString()+ "\nE-mail: " +MAIL+"\nValor Hora: "+ValorHora+"\n"; }
        public double CalcSalario(double he) { return Math.Abs(he * ValorHora); }
        public int CalcIDade() { DateTime saveNow = DateTime.Now; return Math.Abs(saveNow.Year - DATANASC.ANO); }


        public int ID { get { return _id; } set { if (value > 0) { _id = value; } else throw new Exception("Id tem de ser maior que 0!"); } }
        public string NOME { get { return _Nome; } set { if (value.Length > 0 && value.Length < 50) { _Nome = value; } else throw new Exception("Introduza um nome entre 0 a 50 caracteres!"); } }
        public string MAIL { get { return _eMail; }
            set {
                Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                bool isValid = regex.IsMatch(value);
                if (isValid == true) {
                    _eMail = value;
                }
                else
                throw new FormatException("O Email "+ value +" não é válido!");
            }
        }
    }
}
