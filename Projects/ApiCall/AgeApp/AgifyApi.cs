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

    public class Agify
    {
        public static async Task<Name> Age(string name, string country = null) // Use US as a default localization
        {
            try
            {
                string url = $"https://api.agify.io?name={name}";

                if (country != null)
                {
                    url += $"&country_id={country}";
                }

                using HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);

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
