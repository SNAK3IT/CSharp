using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhas
{
    class Program
    {
        static void Main(string[] args) {

            string[] perg = new string[8];

            Random rnd = new Random();
            int nperg = rnd.Next(1, 9), total = 0;

            perg = Pergunta(nperg);
            int erra = 0, corr=0, resp;

            for (int i = 0; i< 7; i++)
            {
                resp = int.Parse(perg[5]);
                if (total < 10)
                {
                    Console.Write(perg[1]);
                    Console.WriteLine();
                    Console.Write(perg[2]);
                    Console.WriteLine();
                    Console.Write(perg[3]);
                    Console.WriteLine();
                    Console.Write(perg[4]);
                    Console.WriteLine();
                    Console.Write("Escreva um nº de 1-3 ");
                    Console.WriteLine();
                    perg[6] = Console.ReadLine();
                    if (int.Parse(perg[6]) == resp)
                    {
                        corr++;
                        Console.Write("Acertou!!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        erra++;
                        Console.Write("Errou!!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    total++;
                    nperg = rnd.Next(1, 9);
                }
            }
            Console.WriteLine();
            Console.Write("Acertou " + corr + " e errou " + erra);
            System.Threading.Thread.Sleep(3000);

        }
        static string[] Pergunta(int perg)
        {
            string[,] perguntas = new string[8,7];
            string[] pergun = new string[7];
            //Pergunta 1
            perguntas[0, 0] = "1";
            perguntas[0, 1] = "O que é o que é que dá muitas voltas e não sai do lugar?";
            perguntas[0, 2] = "1- Roda!";
            perguntas[0, 3] = "2- Anel";
            perguntas[0, 4] = "3- Relógio";
            perguntas[0, 5] = "4";
            perguntas[0, 6] = "";
            //Pergunta 2
            perguntas[1, 0] = "2";
            perguntas[1, 1] = "O que a formiga falou para a barata ?";
            perguntas[1, 2] = "1- A barata Baratou!";
            perguntas[1, 3] = "2- O Teu marido é maior barato.";
            perguntas[1, 4] = "3- Procuro a barata";
            perguntas[1, 5] = "3";
            perguntas[1, 6] = "";
            //Pergunta 3
            perguntas[2, 0] = "3";
            perguntas[2, 1] = "O que é, o que é. Uma casinha branca, sem porta, sem tranca?";
            perguntas[2, 2] = "1- O ovo.";
            perguntas[2, 3] = "2- O barraco do Zé cigano.";
            perguntas[2, 4] = "3- Uma casa";
            perguntas[2, 5] = "2";
            perguntas[2, 6] = "";
            //Pergunta 4
            perguntas[3, 0] = "4";
            perguntas[3, 1] = "Você sabe qual é a piada do fotógrafo?";
            perguntas[3, 2] = "1- Não tem um olho!";
            perguntas[3, 3] = "2- Ninguém sabe, pois ela ainda não foi revelada.";
            perguntas[3, 4] = "3- Olha a pombinha.";
            perguntas[3, 5] = "3";
            perguntas[3, 6] = "";
            //Pergunta 5
            perguntas[4, 0] = "5";
            perguntas[4, 1] = "O que tem uma perna longa e a outra perna curta, mas anda sem parar o dia todo?";
            perguntas[4, 2] = "1- Um perneta;";
            perguntas[4, 3] = "2- Os dedos";
            perguntas[4, 4] = "3- O relógio.";
            perguntas[4, 5] = "4";
            perguntas[4, 6] = "";
            //Pergunta 6
            perguntas[5, 0] = "6";
            perguntas[5, 1] = "O Rio Amazonas está em qual estado?";
            perguntas[5, 2] = "1- Gás";
            perguntas[5, 3] = "2- Líquido.";
            perguntas[5, 4] = "3- Sólido";
            perguntas[5, 5] = "3";
            perguntas[5, 6] = "";
            //Pergunta 7
            perguntas[6, 0] = "7";
            perguntas[6, 1] = "Qual é a diferença do dente de leite e o Palmeiras?";
            perguntas[6, 2] = "1- O dente de leite só cai uma vez!";
            perguntas[6, 3] = "2- O dente é maior";
            perguntas[6, 4] = "3- Ainda tamos a espera que o palmeiras cresça";
            perguntas[6, 5] = "2";
            perguntas[6, 6] = "";
            //Pergunta 8
            perguntas[7, 0] = "8";
            perguntas[7, 1] = "Qual a única pedra que fica em cima da água?";
            perguntas[7, 2] = "1- A pedra de gelo.";
            perguntas[7, 3] = "2- Um calhau";
            perguntas[7, 4] = "3- Pedra";
            perguntas[7, 5] = "2";
            perguntas[7, 6] = "";
            //Pergunta 9
            perguntas[8, 0] = "9";
            perguntas[8, 1] = "O que é, o que é. Todo mês tem, menos abril?";
            perguntas[8, 2] = "1- A pedra de gelo.";
            perguntas[8, 3] = "2- A letra O.";
            perguntas[8, 4] = "3- Pedra";
            perguntas[8, 5] = "3";
            perguntas[8, 6] = "";
            for (int i = 0; i < 8;i++) {
                for (int f = 0; f < 7; f++) {
                    if (perg == int.Parse(perguntas[i, 0]))
                    {
                        pergun[f] = perguntas[perg, f];
                    }
                }
            }
            return pergun;
        }
    }
}
