using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Peso
    {

        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public decimal Ideal { get; set; }


        public Decimal CalcularMasculino()
        {

            Ideal = (72.7m * Altura) - 58;

            return Ideal;

        }
        public Decimal CalcularFemino()
        {

            Ideal = (62.1m * Altura) -44.7m;

            return Ideal;

        }

    }


}


