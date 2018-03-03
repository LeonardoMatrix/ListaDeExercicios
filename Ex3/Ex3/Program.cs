using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Custo custo = new Custo();

            Console.WriteLine("Informe o valor de fabrica!");
            custo.CustoFabrica = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("O custo final é: " + custo.Calculo());
            Console.ReadKey();
        }
    }
}
