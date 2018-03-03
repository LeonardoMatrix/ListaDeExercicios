using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Idade
    {

        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int Sua_Idade { get; set; }

        public int SomarIdade()
        {

            Sua_Idade = Ano * 365;
            Sua_Idade = Sua_Idade + (Mes * 30);
            Sua_Idade = Sua_Idade + Dia;

            return Sua_Idade;

        }

    }
}
