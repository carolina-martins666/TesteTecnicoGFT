using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    class Progra
    {
        static void Main(string[] args)
        {
            int op,idade,anoNascimento,anoAtual;
            double peso, altura,imc;
            Console.WriteLine("Teste 2 - Cálculo IMC");
            Console.WriteLine("1- Idade");
            Console.WriteLine("2- IMC");
            Console.WriteLine("3- Sair");
            Console.WriteLine("Escolha uma opção: ");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("1- Idade");
                    Console.WriteLine("Digite o ano de nascimento: ");
                    anoNascimento = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o ano atual: ");
                    anoAtual = int.Parse(Console.ReadLine());
                    idade = anoAtual - anoNascimento;
                    Console.WriteLine("A idade é: " + idade);
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("2- IMC");
                    Console.WriteLine("Insira a altura: ");
                    altura = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o peso: ");
                    peso = Double.Parse(Console.ReadLine());
                    imc = peso / (altura * altura);
                    Console.WriteLine("O IMC é: "+imc);
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
