using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Maior
    {

        public int Max { get; set; }
        public int Aux { get; set; }



        public void CalcularMaior()
        {

            if (Aux > Max)
            {

                Max = Aux;

            }

        }
    }
}
