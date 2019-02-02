using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha5EXE1
{
    class Data
    {
        //Atributos 
        private int _Dia;
        private int _Mes;
        private int _Ano;


        //Contrutores
        public Data() { _Dia = 1; _Mes = 1; _Ano = 2000; }
        public Data(int dia, int mes, int ano) { _Ano = 2000; ANO = ano; _Mes = 1; MES = mes; _Dia = 1; DIA = dia; }
        public Data(Data d) { _Ano = d.ANO; _Mes = d.MES; _Dia = d.DIA; }
        public override string ToString() { return _Dia + "/" + _Mes + "/" + _Ano + "\n"; }


        //Propriedades
        public int ANO { get { return _Ano; } set { DateTime saveNow = DateTime.Now; if (value > 1900 && value <= saveNow.Year) { _Ano = value; } } }
        public int MES { get { return _Mes; } set { if (value > 0 && value < 12) { _Mes = value; } } }
        public int DIA
        {
            get { return _Dia; }
            set
            {
                if (MES == 1 || MES == 3 || MES == 5 || MES == 7 || MES == 8 || MES == 10 || MES == 12)
                {
                    if (value > 0 && value <= 31)
                    {
                        _Dia = value;
                    }
                }
                else
                {
                    if (MES == 2 || MES == 4 || MES == 6 || MES == 7 || MES == 9 || MES == 11)
                    {
                        if (MES != 2 && value > 0 && value <= 30)
                        {
                            _Dia = value;
                        }
                        else
                        {
                            if (ANO % 100 != 0 && ANO % 400 == 0 || ANO % 4 == 0)
                            {
                                if (MES == 2 && value > 0 && value < 30)
                                {
                                    _Dia = value;
                                }
                            }
                            else
                            {
                                if (MES == 2 && value > 0 && value < 29)
                                {
                                    _Dia = value;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
