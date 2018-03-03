using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Eleitor
    {
        public decimal Branco { get; set; }
        public decimal Nulo { get; set; }
        public decimal Valido { get; set; }
        public decimal Eleitores { get; set; }

        public decimal Percentual{ get; set; }
       

        public decimal PercentNulo()
        {

            Percentual = (Nulo / Eleitores) * 100;

            return Percentual;

        }

        public decimal PercentValido()
        {

            Percentual = (Valido / Eleitores) * 100;

            return Percentual;

        }

        public decimal PercentBranco()
        {

            Percentual = (Branco / Eleitores) * 100;

            return Percentual;

        }


    }
}
