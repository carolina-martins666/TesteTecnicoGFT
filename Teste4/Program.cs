using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double compra = 200, desconto = 0, valorFinal;
            Console.WriteLine("Teste 4 - Tabela descontos");
            for (i = 0; i < 20; i++)
            {
                desconto++;
                compra = compra + 100;
                valorFinal = compra - (compra  * (desconto / 100));
                Console.WriteLine("Valor da Compra: R$" + compra + " Porcentagem de desconto: " + desconto + "%" + " Valor Final: R$" + valorFinal);
                
            }
            Console.WriteLine("A execução do programa acabou, aperte enter para sair");
            Console.ReadLine();
        }
    }
}

