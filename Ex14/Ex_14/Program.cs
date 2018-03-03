using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Faça um algoritmo que calcule e escreva a média aritmética dos números inteiros entre 15
(inclusive) e 100 (inclusive).*/
namespace Ex_14
{
   class Program
   {
       static void Main(string[] args)
       {

            int media = 0, total =0;

                for (int i =15; i<=100; i++)
            {
                total = total + i;
            }

            media = total / (100 - 15);

            Console.WriteLine("Media dos numeros eh: " + media);

            Console.ReadKey();
       }
   }
}
