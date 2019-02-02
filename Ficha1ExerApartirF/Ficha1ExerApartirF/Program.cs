using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1ExerApartirF
{
    class Program
    {
        // f. Crie uma função que receba um vector de strings como argumento e retorne um valor booleano indicando se todas as strings têm o mesmo comprimento.
        // g.Crie uma função que receba um vector de strings como argumento e retorne um valor inteiro correspondendo à soma de todos os comprimentos das strings.
        // h.Crie uma função que, numa string substitua todas as letras “v” por “b” e todas as ocorrências de “ão” por “om”.
        // i.Crie uma função para verificar se uma string é constituída apenas por algarismos.A função deverá retornar um valor booleano true neste caso.
        // Crie uma função que receba uma string como argumento e retorne true se a string não contiver algarismos.
        // k. Crie uma função que leia 2 strings do utilizador e indique qual das strings está primeiro na ordem alfabética.

        static void Main(string[] args) {
            int n = 3;
            string[] vec = new string[n];
            for (int i = 0; i<3; i++) {
                Console.Write("Escreve uma STRING na posição " + i+1 + "|3");
                Console.WriteLine();
                vec[i] = Console.ReadLine();
            }
            Console.Write("Texto1");
            string text = Console.ReadLine();
            Console.Write("Texto2");
            string text2= Console.ReadLine();
            bool f = VectorString(vec, n);
            if (f == true)
                Console.Write("As strings são todas iguais!");
            else
                Console.Write("As strings não são iguais!");
            Console.WriteLine();
            Console.Write("O tamanho de total das string do vector é " + VectorStringSom(vec,n));
            Console.WriteLine();
            bool a = Alg(text);
            if (a == true)
                Console.Write("Tem Algarismos");
            else
                Console.Write("Não tem Algarismos");
            Console.WriteLine();
            //VectorWordSub(text);
            FirstInAlf(text, text2);
            System.Threading.Thread.Sleep(5000);
        }

        public static bool VectorString(string [] vec , int n) {
            int cont = 0;
            string pal = vec[0];
            foreach (string palavra in vec){
                if (pal == palavra)
                    cont++;
            }
            if (cont == 3)
                return true;
            else
                return false;
        }
        public static int VectorStringSom(string [] vec, int n) {
            int sum = vec[0].Length;
            for(int i = 1; i<n; i++)
            {
                sum += vec[i].Length;
            }
            return sum;
        }
        public static void VectorWordSub(string texto) {
            // texto = texto.Replace(“A”,”B”);
            string strreplacer = texto.Replace('v','b'),strreplacer2 = texto.Replace("ão", "om");           
            Console.Write(strreplacer2);
        }
        public static bool Alg(string texto) {
            int len = texto.Length, cont = 0 ;

            for (int i = 0; i < len; i++) {
                if (char.IsDigit(texto[i])) {
                    cont++;
                }
            }
            if (cont == len)
                return true;
            else
                return false;
        }
        public static bool NotAlg(string texto) {
            int len = texto.Length, cont = 0;
            for (int i = 0; i < len; i++) {
                if (char.IsDigit(texto[i]))
                {
                    cont++;
                }
            }
            if (cont == 0)
                return true;
            else
                return false;
        }
        public static void FirstInAlf(string a, string b) {
            if (string.Compare(a.Substring(1, 1), b.Substring(1, 1)) < 0)
                Console.Write(b);
            else 
                if(string.Compare(a.Substring(1,1),b.Substring(1,1)) > 0)
                    Console.Write(a);
        }

    }
}
