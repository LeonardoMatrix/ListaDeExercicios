using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ler um valor N e imprimir todos os valores inteiros entre 1 (inclusive) e N (inclusive).
Considere que o N será sempre maior que ZERO.*/

namespace Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;

            Console.WriteLine("Digite um valor para N: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
