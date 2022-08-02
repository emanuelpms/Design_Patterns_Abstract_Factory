using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method.Atributos
{
    class LifeGrass : ILife
    {

        public void HealthPoints()
        {
            Console.WriteLine("Você possui 80% de vida");
        }
    }
}
