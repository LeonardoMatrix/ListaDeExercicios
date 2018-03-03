using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Temperatura
    {

        public int[] Vet = new int[5];
        public int Med { get; set; }
        public int MM { get; set; }
        public int MN { get; set; }



        public int Media()
        {

            for (int i = 0; i <= 4; i++) {

                Med = Med + Vet[i];

            }

            Med = (Med / 5);

            return Med;

        }


        public int Maior()
        {

            MM = Vet[0];

            for (int i = 0; i <= 4; i++)
            {
                 
                if (Vet[i] > MM)
                {

                    MM = Vet[i];


                }

            }

            return MM;

        }

        public int Menor()
        {

            MN = Vet[0];

            for (int i = 0; i <= 4; i++)
            {

                if (Vet[i] < MN)
                {

                    MN = Vet[i];


                }

            }

            return MN;

        }



    }
}
