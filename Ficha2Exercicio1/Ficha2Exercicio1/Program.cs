using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Ficha2Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader(@"C:\Users\T0114410\source\repos\Ficha2Exercicio1\Ficha2Exercicio1\obj\Debug\VENC.txt");
            StreamWriter wr = new StreamWriter(@"C:\Users\T0114410\source\repos\Ficha2Exercicio1\Ficha2Exercicio1\obj\Debug\SUPMIL.txt", false);
            string[,] mat = new string[6, 3];
            int l = 0, c = 0, posl = 0, posc = 0, cont = 0; ;
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] contspli = linha.Split(',');
                posc = 0;
                c = 0;
                foreach (string palavra in contspli) {
                    mat[l, c] = palavra;
                    c++;
                    posc++;
                }
                l++;
                posl++;
            }
            rd.Close();
            for (int j = 0; j < 6; j++) {
                for(int k = 0;k <3;k++) {
                    if (int.Parse(mat[j,2]) > 1000) {
                        wr.Write(" | " + mat[j, k] + " |");
                        wr.Write(" ");
                        cont++;
                    }
                }
                if (cont != 0) {
                    wr.WriteLine();
                }
            }
            if (cont == 0) {
                wr.WriteLine("não contém registos");
            }
            wr.Close();
            System.Threading.Thread.Sleep(1000);

        }
    }
}
