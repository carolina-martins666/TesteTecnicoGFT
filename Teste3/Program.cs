using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3
{
    class Program : Moradores
    {
        static void Main(string[] args)
        {
            string cachorro;
            int contador = 0,contador2 =0,i;
            string numTelefone = new Telefone();
            int casa = new numeroCasa();
            Console.WriteLine("Teste 3 - Entregas");
            Console.WriteLine("Insira o número da residência: ");
            Console.WriteLine("A residência possui cachorro(S/N): ");
            cachorro = Console.ReadLine();
            for (i = 0; i < 20; i++)
            {
                if (cachorro == "S")
                {
                    Console.WriteLine("Não entrega a correspondência");
                }
                else
                {
                    Console.WriteLine("Entrega a correspondência");
                    if (casa % 2 == 0)
                    {
                        contador++;
                    }
                    else
                    {
                        contador2++;
                        Console.WriteLine("Número de entregas em casas com númeração ímpar: " + contador2);
                    }
                }
                Console.WriteLine("A execução do programa acabou, aperte enter para sair");
                Console.ReadLine();
            }

        }
    }
}
