using System;

namespace Abstract_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreatePokemon pokemon;

            bool adicionarPokemon = true;

            do
            {
                Console.WriteLine("Escolha um tipo de Pokemon | 1 - Planta | 2 - Fogo | 3 - Àgua ........");

                switch (Console.ReadLine())
                {
                    case "1":
                        pokemon = new PokemonGrass();
                        break;
                    case "2":
                        pokemon = new PokemonFire();
                        break;
                    case "3":
                        pokemon = new PokemonWater();
                        break;
                }

                Console.WriteLine("_________________________________#________________________________");

                Console.WriteLine("Deseja adicionar um novo Pokemon? {S} ou {N}");
                string continuar = Console.ReadLine().ToUpper();

                adicionarPokemon = (continuar == "S") ? true : false;

            } while (adicionarPokemon);
        }
    }
}
