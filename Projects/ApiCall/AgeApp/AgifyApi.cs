using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Text.Json;

namespace AgifyApi
{
    public class Name
    {
        public string name { get; set; }
        public int count { get; set; }
        public int age { get; set; }
        public string country_id { get; set; }
    }

    internal class Agify
    {
        static async Task<Name> Age(string name, string country = "US") // Use US as a default localization
        {
            try
            {
                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"https://api.agify.io?name={name}&country_id={country}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<Name>(json);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return null;
            }
        }
    }
}
