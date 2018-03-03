using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Triangulo
    {

        public Int32 A { get; set; }
        public Int32 B { get; set; }
        public Int32 C { get; set; }


        public String CalcularTriangulo()
        {

            if (A < (B + C))
            {

                if  (B < (A + C))
                    {

                        if  (C < (A + A))
                            {

                                return "T";

                            }
                    }
            }

            return "";
        }

    }
}
