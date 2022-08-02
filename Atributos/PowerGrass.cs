using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Atributos
{
    class PowerGrass : IPower
    {
        public void Power()
        {
            Console.WriteLine("Rajadas de folhagem");
        }
    }
}
