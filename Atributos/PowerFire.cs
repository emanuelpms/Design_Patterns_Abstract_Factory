using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Method
{
    class PowerFire : IPower
    {

        public void Power()
        {
            Console.WriteLine("Pode lançar-chamas");
        }
    }
}
