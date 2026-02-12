using Newtonsoft.Json;

namespace JsonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INITIATE

            // declare json lists
            string serializedPeople;
            List<Person> deserializedPeople;

            // Create people list
            List<Person> people = new List<Person>
            {
                new("John Doe", 67, "johndoe@email.com", true),
                new("Jane Smith", 21, "janesmith@email.com", false),
                new("John Lennon", 60, "johnlennon@email.com", false)
            };

            // Serialize people and print result
            serializedPeople = JsonConvert.SerializeObject(people);
            Console.WriteLine("Serialized JSON: " + serializedPeople);

            // Deserialize people and print individual person
            deserializedPeople = JsonConvert.DeserializeObject<List<Person>>(serializedPeople);
            deserializedPeople.PrettyPrintAll();

            //EXTRA LOGIC

            Console.WriteLine("\nExtra non-required logic:\n");

            Console.WriteLine("People saying hello");

            people.SayHiToAll();

            people.GreetAll();
            
        }
    }
}
