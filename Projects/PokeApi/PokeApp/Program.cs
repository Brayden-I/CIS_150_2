using PokeApi;

namespace PokeApp
{
    internal class Program
    {
        private static string? input;
        private static Pokemon pokemon;

        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon Pokedex.");

            while (input != "leave")
            {
                // Prompt
                Console.WriteLine("Please enter the name or id of your requested Pokemon");
                Console.Write(">> ");

                input = Console.ReadLine();

                switch (input)
                {
                    case "leave":
                        continue;

                    default:
                        pokemon = await Pokedex.Search(input);

                        if (pokemon != null)
                        {
                            pokemon.Print();
                        }
                        else
                        {
                            Console.WriteLine("Pokemon not found. Did you misspell?");
                        }
                        
                        break;
                }

            }
        }
    }
}
