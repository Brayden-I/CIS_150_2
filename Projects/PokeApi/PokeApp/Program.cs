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
                        input = Console.ReadLine();
                        pokemon = await Pokedex.Search(input);

                        pokemon.Print();
                        break;
                }

            }
        }
    }
}
