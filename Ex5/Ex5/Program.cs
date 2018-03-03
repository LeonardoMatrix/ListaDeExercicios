using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            Peso peso = new Peso();
            int Operacao;


            Console.WriteLine("Informe seu Nome");
            peso.Nome = Console.ReadLine();

            Console.WriteLine("Informe seu altura");
            peso.Altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe 1-Masculino ou 2-Feminino");
            Operacao = Convert.ToInt32(Console.ReadLine());

            switch (Operacao)
            {
                case 1:
                    Console.WriteLine("O peso ideal é: " + peso.CalcularMasculino());
                    Console.ReadKey();


                    break;
                case 2:
                    Console.WriteLine("O peso ideal é: " + peso.CalcularFemino());
                    Console.ReadKey();

                    break;
                default:
                    Console.WriteLine("Sexo invalido!");
                    break;
            }


        

        }
    }
}
