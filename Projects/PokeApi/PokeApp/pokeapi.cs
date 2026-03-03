using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokeApi
{
    public class Pokemon
    {
        // FIELDS
        public int id { get; set; }
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        // METHODS

        // print
        public void Print()
        {
            Console.WriteLine($"Pokemon entry for {name}\n-------\nid: {id}\nname: {name}\nheight: {height}\nweight: {weight}\n");
        }
    }

    public class Pokedex
    {
        // METHODS
        public static async Task<Pokemon> Search(string name, int id = -1)
        {
            try
            {
                string url = "https://pokeapi.co/api/v2/pokemon/";

                if (id != -1) // If the user has entered an id, use that input, otherwise use name
                {
                    url += $"{id}/";
                }
                else
                {
                    url += $"{name}/";
                }

                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode) // Check if the api call was successful, if so proceed
                {
                    string json = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<Pokemon>(json);
                }

                return null; // Failed to get pokemon
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null; // Unexpected failure to get pokemon
            }
        }

    }
}
