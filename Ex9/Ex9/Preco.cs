using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Preco
    {

        public Decimal Valores { get; set; }
        public Decimal Maior { get; set; }
        public Decimal Soma { get; set; }
        public int Codigo { get; set; }

        

        public void Calcular()
        {


            if (Valores > Maior){

                Maior = Valores;

            }
 
        }
    }
}
