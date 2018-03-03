using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Habitantes
    {
        public decimal Salario { get; set; }
        public decimal Filhos { get; set; }
        public decimal SalarioM { get; set; }
        public decimal Mfilhos { get; set; }
        public decimal Msalario { get; set; }
        public int Percent { get; set; }


        public void CalcularMaior()
        {

            if (Salario > SalarioM)
            {

                SalarioM = Salario;

            }

        }

        public void Media()
        {

            Mfilhos = Mfilhos + Filhos;
            Msalario = Msalario + Salario;

        }

        public void Percentual()
        {

            if (Salario < 150)
            {

                Percent = Percent + 1;


            }

            

        }

    }
}
