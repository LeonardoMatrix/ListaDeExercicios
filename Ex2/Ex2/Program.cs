using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Eleitor eleitor = new Eleitor();
             decimal total;
           



            Console.WriteLine("Informe os votos branco!");
            eleitor.Branco = Convert.ToInt32(Console.ReadLine());
       

            Console.WriteLine("Informe os votos nulos!");
            eleitor.Nulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os votos validos!");
            eleitor.Valido = Convert.ToInt32(Console.ReadLine());

            total = eleitor.Branco + eleitor.Nulo + eleitor.Valido;

                    Console.WriteLine("Informe o número total de eleitores!");
                    eleitor.Eleitores = Convert.ToInt32(Console.ReadLine());

           

            if (total > eleitor.Eleitores)
            {

                Console.WriteLine("Quantidade de votos superou a quantidade total de eleitores!");
                Console.ReadKey();
                Environment.Exit(0);

            }

            Console.WriteLine("O percentual Branco é: " + eleitor.PercentBranco() + "\nO percentual Nulo é: " + eleitor.PercentNulo() + "\nO percentual Valido é: " + eleitor.PercentValido());
            Console.ReadKey();


        }
    }
}
