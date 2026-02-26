using AgifyApi;

namespace AgeApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Agify console interface");
            Console.WriteLine("Enter a name to find the predicted age, or 'quit' to exit.");

            while (true)
            {
                Console.Write("\nEnter name: ");
                string nameInput = Console.ReadLine();

                Console.Write("\nEnter Country code: ");
                string countryInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameInput) || nameInput.Equals("quit"))
                    break;

                try
                {
                    Name result = await Agify.Age(nameInput);
                    Console.WriteLine($"Name: {result.name}, Predicted Age: {result.age}, Count: {result.count}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching age: {ex.Message}");
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
