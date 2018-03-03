using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {


            Idade idade = new Idade();

            Console.WriteLine("Informa a quantidade de dias");
            idade.Dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informa a quantidade de Meses");
            idade.Mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de Anos");
            idade.Ano = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Sua idade em dias é " + idade.SomarIdade());
            Console.ReadKey();


        }
    }
}
