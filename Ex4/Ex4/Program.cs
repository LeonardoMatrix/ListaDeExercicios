using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            Salario salario = new Salario();

            Console.WriteLine("Informe o salário fixo");
            salario.SalarioInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a comissão por carro");
            salario.ComissãoCarro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quandidade de carros vendidos");
            salario.QtdCarro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor total de venda");
            salario.TotalVendas = Convert.ToInt32(Console.ReadLine());


            salario.ComissãoCarros();
            salario.ComissãoVendas();
            

            Console.WriteLine("O salário total é: " + salario.Total());
            Console.ReadKey();


        }
    }
}
