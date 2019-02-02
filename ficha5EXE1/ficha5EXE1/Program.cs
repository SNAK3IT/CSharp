using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha5EXE1
{
    class Program
    {
        private enum Opcao { Inserir_Gerente = 1, Inserir_Operário = 2, Visualizar_Gerentes = 3, Visualizar_Operarios = 4, exit = 5 }
        private enum m2 { Calcular_Salario = 1, Calcular_Idade = 2, Recuar = 3, Sair = 4 }
        private static List<Gerente> ger = new List<Gerente>();
        private static List<Operario> oper = new List<Operario>();
        private static ArrayList func = new ArrayList();

        static void Main(string[] args) {
            int op;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        GerenteCreate();
                        break;
                    case 2:
                        OperarioCreate();
                        break;
                    case 3:
                        GerenteSearch();
                        break;
                    case 4:
                        OperarioSearch();
                        break;
                    case 5:
                        fechar();
                        break;
                    default:
                        opInvalida();
                        break;
                }
            } while (op != (int)Opcao.exit);
            System.Threading.Thread.Sleep(10000);
        }
        static int menu() {
            Console.Clear();
            Console.WriteLine("Qual a opção pretendida?");
            foreach (Opcao val in Enum.GetValues(typeof(Opcao)))
            {
                Console.WriteLine("{0} - {1}", val, (int)val);
            }
            return leitor();
        }
        static int leitor(){
            int val = 0;
            bool flag = false;
            do
            {
                try
                {
                    Console.Write("> ");
                    val = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor incorrecto, digite novamente:");
                    flag = false;
                }
            } while (!flag);
            return val;

        }

        //Operarios
        static void OperarioSearch() {
            if (ger.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há Gerentes na base de dados!!");
                System.Threading.Thread.Sleep(4000);
            }
            else
            {
                Console.Clear();
                foreach (Operario a in oper)
                {
                    Console.WriteLine("| {0} => {1} | {2}", a.ID, a.NOME, a.MAIL);
                }
                Console.WriteLine();
                Console.WriteLine("Escolha um dos Operaios!\n");
                OperarioView(leitor());
            }
        }
        static void OperarioView(int op) {
            try
            {
                Console.Clear();
                int chose = 0;
                Operario a = new Operario(oper.Find(o => o.ID == op));
                Console.WriteLine(a.ToString() + " \n");
                Console.WriteLine();
                Console.WriteLine("Qual a opção pretendida?");
                foreach (m2 val in Enum.GetValues(typeof(m2)))
                {
                    Console.WriteLine("{0} - {1}", val, (int)val);
                }
                chose = leitor();
                switch (chose) {
                    case 1:
                        Console.WriteLine(a.CalcSalario(a.ValorHora));
                        break;
                    case 2:
                        a.ValorHora = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        OperarioSearch();
                        break;
                    case 4:
                        fechar();
                        break;
                    default:
                        opInvalida();
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Operario tem algum erro ou não existe!!");
                System.Threading.Thread.Sleep(4000);
                GerenteSearch();
            }
        }
        static void OperarioCreate() {
            string data;
            Operario novoop = new Operario();
            if (ger.Count == 0)
            {
                novoop.ID = 1;
            }
            else
            {
                novoop.ID = ger[ger.Count - 1].ID + 1;
            }
            Console.Write("Nome> ");
            novoop.NOME = Console.ReadLine();
            Console.Write("E-mail> ");
            novoop.MAIL = Console.ReadLine();
            Console.Write("Data Nascimento> ");
            data = Console.ReadLine();
            DateTime a = DateTime.Parse(data);
            Data b = new Data(a.Day, a.Month, a.Year);
            novoop.DATANASC = b;
            Console.Write("Valor Hora> ");
            novoop.ValorHora = double.Parse(Console.ReadLine());
            Console.Write("Departamento> ");
            novoop.Departamento = Console.ReadLine();
            oper.Add(novoop);
            func.Add(novoop);
        }

        //Gerentes
        static void GerenteSearch() {
            if (ger.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Não há Gerentes na base de dados!!");
                System.Threading.Thread.Sleep(4000);
            }
            else
            {
                if (ger.Count > 0)
                {
                    Console.Clear();
                    foreach (Gerente a in ger)
                    {
                        Console.WriteLine("| {0} => {1} | {2}", a.ID, a.NOME, a.MAIL);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Escolha um dos Gerentes!\n");
                    GerenteView(leitor());
                }
            }
        }
        static void GerenteView(int gern) {
            try
            {
                Console.Clear();
                int chose = 0;
                Gerente a = new Gerente(ger.Find(g => g.ID == gern));
                Console.WriteLine(a.ToString() + " \n");
                Console.WriteLine();
                Console.WriteLine("Qual a opção pretendida?");
                foreach (m2 val in Enum.GetValues(typeof(m2)))
                {
                    Console.WriteLine("{0} - {1}", val, (int)val);
                }
                chose = leitor();
                switch (chose)
                {
                    case 1:
                        Console.WriteLine(a.CalcSalario(a.ValorHora));
                        System.Threading.Thread.Sleep(4000);
                        break;
                    case 2:
                        Console.WriteLine(a.CalcIDade());
                        System.Threading.Thread.Sleep(4000);
                        break;
                    case 3:
                        OperarioSearch();
                        break;
                    case 4:
                        fechar();
                        break;
                    default:
                        opInvalida();
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Gerente tem algum erro ou não existe!!");
                System.Threading.Thread.Sleep(4000);
                GerenteSearch();
            }
        }
        static void GerenteCreate() {
            try {
                string data;
                Gerente novoger = new Gerente();
                if (ger.Count == 0){
                    novoger.ID = 1;
                }
                else {
                    novoger.ID = ger[ger.Count - 1].ID + 1;
                }
                Console.Write("Nome> ");
                novoger.NOME = Console.ReadLine();
                Console.Write("E-mail> ");
                novoger.MAIL = Console.ReadLine();
                Console.Write("Data Nascimento> ");
                data = Console.ReadLine();
                DateTime a = DateTime.Parse(data);
                Data b = new Data(a.Day,a.Month,a.Year);
                novoger.DATANASC = b;
                Console.Write("Valor Hora> ");
                novoger.ValorHora = double.Parse(Console.ReadLine());
                Console.Write("Especialidade> ");
                novoger.Especialidade = Console.ReadLine();
                Console.Write("Extensão> ");
                novoger.Extensao = int.Parse(Console.ReadLine());
                ger.Add(novoger);
                func.Add(novoger);
            } catch (Exception e) { 
                Console.WriteLine(e.ToString());
            }
        }

        static void OutputFile() { }
        static void opInvalida() { Console.WriteLine("Opção errada!!"); }
        static void fechar() {
            Console.Clear();
            Console.WriteLine("Até à próxima!");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        } 
    }
}
