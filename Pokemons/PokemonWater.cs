using Abstract_Method.Atributos;
using System;

namespace Abstract_Method
{
    class PokemonWater : ICreatePokemon
    {

        public PokemonWater()
        {
            Pokemon();
        }

        public void Pokemon()
        {
            Console.WriteLine("Pokemon do Tipo 'Água' foi criado");

            LifeWater lw = new LifeWater();
            lw.HealthPoints();

            PowerWater pw = new PowerWater();
            pw.Power();

            Console.WriteLine();

        }
    }

}
