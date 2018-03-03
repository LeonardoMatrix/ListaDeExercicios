using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {

         
        Preco preco = new Preco();
        

            for (int i = 1; i <= 15; i++)
            {

                Console.WriteLine("Informe o código do produto " + i);
                preco.Codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor do produto " + i);
                preco.Valores = Convert.ToDecimal(Console.ReadLine());

                if (i == 1){

                    preco.Maior = preco.Valores;
                    preco.Soma = 0;

                }

                preco.Soma = preco.Soma + preco.Valores;


            }

            Console.WriteLine("O maior valor é " + preco.Maior);
            Console.WriteLine("A média é "  +  preco.Soma/15);
            Console.ReadKey();
        }
    }
}
