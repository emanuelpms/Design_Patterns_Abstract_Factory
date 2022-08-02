using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Atributos
{
    class LifeFire : ILife
    {

        public void HealthPoints()
        {
            Console.WriteLine("Você possui 90% de vida");
        }
    }
}
