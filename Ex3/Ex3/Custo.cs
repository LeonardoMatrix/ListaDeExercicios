using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Custo
    {

        public decimal CustoFabrica { get; set; }
        public decimal Auxiliar { get; set; }
        public decimal CustoTotal { get; set; }


        public decimal Calculo()
        {

            CustoTotal = CustoFabrica * 0.28m;
            CustoTotal = CustoTotal + (CustoFabrica * 0.45m);
            CustoTotal = CustoTotal + CustoFabrica;


            return CustoTotal;

        }


    }
}
