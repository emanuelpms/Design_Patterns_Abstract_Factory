using System;
using Abstract_Method.Atributos;

namespace Abstract_Method
{
    class PokemonGrass : ICreatePokemon
    {

        public PokemonGrass()
        {
            Pokemon();
        }

        public void Pokemon()
        {
            Console.WriteLine("Pokemon tipo 'Planta' criado");

            LifeGrass lf = new LifeGrass();
            lf.HealthPoints();

            PowerGrass pf = new PowerGrass();
            pf.Power();
            Console.WriteLine();
        }


    }
}
