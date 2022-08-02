using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Atributos
{
    class LifeWater : ILife
    {

        public void HealthPoints()
        {
            Console.WriteLine("Você possui 100% de vida");
        }
    }
}
