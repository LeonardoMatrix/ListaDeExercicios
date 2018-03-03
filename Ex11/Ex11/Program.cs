using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {

            Temperatura temperatura = new Temperatura();

            for (int i = 0; i <= 4; i++)
            {

                Console.WriteLine("Informe a temperatura");

                temperatura.Vet[i] = Convert.ToInt32(Console.ReadLine());


            }


            Console.WriteLine("A maior temperatura é  " + temperatura.Maior());
            Console.WriteLine("A menor temperatura é  " + temperatura.Menor());
            Console.WriteLine("A média de temperatura é  " + temperatura.Media());
            Console.ReadKey();


        }
    }
}
