using AgifyApi;

namespace AgeApp
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            string nameInput;
            Name result;

            Console.WriteLine("Welcome to Agify console interface");

            Console.WriteLine("Enter the name of the person you'd like to find the age of");

            do
            {
                nameInput = Console.ReadLine();

                try
                {
                    result = await Agify.Age()
                }
                catch
                {

                }
            }
            while (true);
        }
    }
}
