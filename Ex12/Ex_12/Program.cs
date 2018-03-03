using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*12. Escreva um algoritmo para ler 10 números e ao final da leitura escrever a soma total dos 10
números lidos/*/
namespace Ex_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0, numero =0 ;

            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                total = total + numero;
            }

            Console.WriteLine("Soma total dos numeros digitados: " + total);

            Console.ReadKey();
        }
    }
}
