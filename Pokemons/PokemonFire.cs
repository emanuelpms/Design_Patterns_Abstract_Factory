using System;
using Abstract_Method.Atributos;

namespace Abstract_Method
{
    class PokemonFire : ICreatePokemon
    {

        public PokemonFire()
        {
            Pokemon();
        }

        public void Pokemon()
        {
            Console.WriteLine("Pokemon tipo 'Fogo' criado");

            LifeFire lf = new LifeFire();
            lf.HealthPoints();

            PowerFire pf = new PowerFire();
            pf.Power();

            Console.WriteLine();
        }

    }
}
