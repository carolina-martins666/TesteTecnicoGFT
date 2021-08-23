using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            string matricula, nome, escola, universidade;
            int op;

            Console.WriteLine("Teste 1 - Registro Acadêmico");
            Console.WriteLine("1- Conclui o Ensino Básico");
            Console.WriteLine("2- Conclui o Ensino Superior");
            Console.WriteLine("3- Não estudou");
            Console.WriteLine("Escolha uma opção sobre o colaborador a ser registrado: ");
            op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("1- Conclui o Ensino Básico");
                    Console.WriteLine("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o número de matrícula: ");
                    matricula = Console.ReadLine();
                    Console.WriteLine("Digite o nome da escola em que estudou: ");
                    escola = Console.ReadLine();
                    Console.WriteLine("Os dados cadastrados foram: ");
                    Console.WriteLine("Nome: " + nome + " Matrícula: " + matricula + " Escola: " + escola);
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("2- Conclui o Ensino Superior");
                    Console.WriteLine("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o número de matrícula: ");
                    matricula = Console.ReadLine();
                    Console.WriteLine("Digite o nome da escola em que estudou: ");
                    escola = Console.ReadLine();
                    Console.WriteLine("Digite o nome da Universidade em que estudou: ");
                    universidade = Console.ReadLine();
                    Console.WriteLine("Os dados cadastrados foram: ");
                    Console.WriteLine("Nome: " + nome + " Matrícula: " + matricula + " Escola: " + escola + " Universidade: "+ universidade);
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("3- Não estudou");
                    Console.WriteLine("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o número de matrícula: ");
                    matricula = Console.ReadLine();
                    Console.WriteLine("Os dados cadastrados foram: ");
                    Console.WriteLine("Nome: " + nome + " Matrícula: " + matricula);
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opcão Inválida");
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
