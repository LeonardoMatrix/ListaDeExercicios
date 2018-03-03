using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Salario
    {

        public decimal SalarioInicial { get; set; }
        public decimal ComissãoCarro { get; set; }
        public decimal QtdCarro { get; set; }
        public decimal TotalVendas { get; set; }

        public decimal SalarioTotal { get; set; }

        public Decimal ComissãoCarros()
        {

            SalarioTotal = ComissãoCarro * QtdCarro;

            return SalarioTotal;

        }

        public Decimal ComissãoVendas()
        {

            SalarioTotal = SalarioTotal + (TotalVendas * 0.05m);

            return SalarioTotal;

        }

        public Decimal Total()
        {
            SalarioTotal = SalarioTotal + SalarioInicial;

            return SalarioTotal;

        }

    }
}
