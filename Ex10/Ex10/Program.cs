using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {

            Habitantes habitantes = new Habitantes();

            for (int i=1;i<=4 ;i++)
            {

                Console.WriteLine("Informe o Salário");
                habitantes.Salario = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de filhos");
                habitantes.Filhos = Convert.ToDecimal(Console.ReadLine());

                if (i == 1)
                {
                    habitantes.SalarioM = habitantes.Salario;
                    habitantes.Mfilhos = 0;
                    habitantes.Msalario = 0;
                    habitantes.Percent = 0;

                }

                habitantes.CalcularMaior();
                habitantes.Media();
                habitantes.Percentual();



            }


            Console.WriteLine("O maior salário é " + habitantes.SalarioM);
            Console.WriteLine("A média de filhos é " + habitantes.Mfilhos/4);
            Console.WriteLine("A média de Salário é " + habitantes.Msalario/4);
            Console.WriteLine("O percentual de quem ganha menos que 150,00 é %" + (habitantes.Percent / 4) * 100);
            Console.ReadKey();


        }
    }
}
