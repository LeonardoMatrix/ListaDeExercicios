using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            String Aux;

            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Informe o tamanho do lado A do triangulo!");
            triangulo.A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do lado B do triangulo!");
            triangulo.B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do lado C do triangulo!");
            triangulo.C = Convert.ToInt32(Console.ReadLine());

            Aux = triangulo.CalcularTriangulo();


            if(Aux == "T") {

                Console.WriteLine("É um Triangulo");
 
                Console.ReadKey();

            }
            else{

                Console.WriteLine("Não é um Triangulo");
                Console.ReadKey();

            }


        }
    }
    }

