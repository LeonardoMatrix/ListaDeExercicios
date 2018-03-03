using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {

            Maior maior = new Maior();
            maior.Max = 0;


            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Informe o " + i + " número");
                maior.Aux = Convert.ToInt32(Console.ReadLine());

             if (i == 1) {

              maior.Max = maior.Aux;

             }

                maior.CalcularMaior();

            }

            Console.WriteLine("O maior valor é:" + maior.Max);
            Console.ReadKey();

        }
    }
}
