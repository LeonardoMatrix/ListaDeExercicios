using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Comissao
    {

        public decimal Salario { get; set; }
        public decimal VendaTotal { get; set; }
        public decimal Aux { get; set; }


        public Decimal CacularMenos()
        {

            VendaTotal = Salario  + (VendaTotal * 0.03m);


            return VendaTotal;

        }

        public Decimal CacularMais()
        {

            Aux = VendaTotal;
            Aux = (Aux * 0.05m);

            VendaTotal = (1500 * 0.03m);

            VendaTotal = Salario  + Aux + VendaTotal;


            return VendaTotal;

        }
    }
}
