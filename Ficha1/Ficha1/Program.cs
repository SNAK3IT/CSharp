using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// a. Crie um programa que leia o nome próprio do utilizador e imprima uma mensagem personalizada do tipo: "Olá João!" ✓
// b. Altere o programa de modo a que se o nome for "Bartolomeu", o programa imprima "Dá cá o meu!". ✓
// c. Altere o programa anterior para que a mensagem surja para todos os nomes terminados em "eu". Exemplo:> Olá Zebedeu! Dá cá o meu! ✓
// d. Altere o programa de modo a pedir o nome completo e apresentar apenas o primeiro e o último nome. ✓
// e. Crie uma função que indique qual de três strings introduzidas pelo utilizador tem um comprimento superior. ✓


namespace Ficha1

{
    class Program {
        static void Main(string[] args) {
            //Console.Write("Escreva um nome completo? ");
            //Console.WriteLine();
            //Console.Write("> ");
            //string Nome = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("> ");
            //string NomeDois = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("> ");
            //string NomeTres = Console.ReadLine();
            //int a = Nome.Length,i=0,pos=0;
            //string[] vec = new string[10];
            //string[] palavras = Nome.Split(' ');
            string[] VecStr = new string[4];
            bool flag = VectorStrings(VecStr);
            //foreach (string palavra in palavras) {
            //    vec[i] = palavra;
            //    i++; // posição do VEC
            //    pos++; // Tamanho do VEC
            //}

            if (flag == true)
            {
                Console.Write("As 4 strings são iguais");
                Console.WriteLine();
            }
            else
            {
                Console.Write("As 4 strings não são iguais");
                Console.WriteLine();
            }
            //Console.Write("Olá " + vec[0] + " " + vec[pos-1]);
            //Console.WriteLine();
            //Console.Write("A maior strings é " + MaiorString(Nome,NomeDois,NomeTres));
           

            /*if (nome.Substring(a-2,2) == "eu")
                Console.Write("Olá " + nome + " dá cá o meu!");
            else
                Console.Write("Olá " + nome);*/
            System.Threading.Thread.Sleep(4000);
        }
        public  static string MaiorString(string StrUm, string StrDois, string StrTres) {

            int maior = StrUm.Length;
            string palavra = StrUm;
            if (maior < StrDois.Length)
            {
                palavra =  StrDois;
            }
            if (maior < StrTres.Length)
            {
                palavra =  StrTres;
            }
            return palavra;
        }
        public static bool VectorStrings(string[] str) {
            int cont = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Escreve o vector de string?");
                Console.WriteLine();
                Console.Write("> ");
                str[i] = Console.ReadLine();
            }
            for (int i = 0; i < 4; i++)
            {
                if (str[i]  == str[i+1]) {
                    cont++;
                }
            }
            if(cont == 4) { return true; }
            return false;
        }
    }
}
