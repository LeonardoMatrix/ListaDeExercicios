using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            Comissao comissao = new Comissao();


            Console.WriteLine("Informe o salário fixo");
            comissao.Salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor das vendas");
            comissao.VendaTotal = Convert.ToDecimal(Console.ReadLine());

            if (comissao.VendaTotal > 1500)
            {

                Console.WriteLine("O salário Total é: " + comissao.CacularMais());
                Console.ReadKey();

            }
            else
            {

                Console.WriteLine("O salário Total é: " + comissao.CacularMenos());
                Console.ReadKey();

            }
        }
    }
}
