using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Turma
{
    class Program
    {
        static void Main(string[] args) {
            string[,] mat = new string[10,10];
            int contl = 0, contc = 0, l = 0, c = 0; ;
            FileReader(ref c,ref l,ref contc,ref contl,ref mat);
            Reprovados(contc, contl, mat);
            Aprovados(contc, contl, mat);
        }
        private static void FileReader(ref int c, ref int l, ref int contc,ref int contl,ref string[,] arg)
        {
            Console.WriteLine("Escreva o caminho do ficheiro que vai importar!");
            Console.Write("> ");
            string file = Console.ReadLine();
            StreamReader rd = new StreamReader(@""+file);
            string[,] mat = new string[10, 10];
            while (!rd.EndOfStream) {
                string linha = rd.ReadLine();
                string[] palavras = linha.Split();
                contc = 0;
                c = 0;
                foreach (string palavra in palavras)
                {
                    mat[l, c] = palavra;
                    c++;
                    contc++;
                }
                l++;
                contl++;
            }
            rd.Close();
        }
        private static void Reprovados(int contc,int contl,string[,] mat) {
            StreamWriter wr = new StreamWriter(@"C:\Users\Pedro Moreira\source\repos\Turma\Turma\TxtFiles\Reprovados.txt");
            int cont = 0;
             for (int i = 0;i< contl;i++) {
                 for(int f=0;f< contl; f++) {
                     if (double.Parse(mat[i, 2]) < 9.5) {
                         wr.Write(mat[i,f] + " | ");
                         contc++;
                     }
                 }
                 Console.WriteLine();
             }
             if (cont == 0) {
                 Console.WriteLine("Não contém registos.");
             }
             wr.Close();
        }
        private static void Aprovados(int contc, int contl, string[,] mat) {
            StreamWriter wr = new StreamWriter(@"C:\Users\Pedro Moreira\source\repos\Turma\Turma\TxtFiles\Aprovados.txt");
            int cont = 0;
            for (int i = 0; i < contl; i++)
            {
                for (int f = 0; f < contl; f++)
                {
                    if (double.Parse(mat[i, 2]) <  9.5)
                    {
                        wr.Write(mat[i, f] + " | ");
                        contc++;
                    }
                }
                Console.WriteLine();
            }
            if (cont == 0)
            {
                Console.WriteLine("Não contém registos.");
            }
            wr.Close();
        }
    }
}
