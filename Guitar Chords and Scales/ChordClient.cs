using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Guitar_Chords_and_Scales.Controllers
{
    class ChordsClient
    {
        private static HttpClient _client = new HttpClient();

        public async static Task GetChords(string url)
        {
            string URL = url;

            //HttpClient
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(URL))
            using (HttpContent content = response.Content)
            {
                string JSONtext = await response.Content.ReadAsStringAsync();
                Console.WriteLine("");
                Console.WriteLine("JSON Preview:" + JSONtext.Substring(0, 50) + "........");

                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Include
                    };

                    //Convert JSON 
                    var chords = JsonConvert.DeserializeObject<Theory>(JSONtext,settings);
                    
                    Console.WriteLine(chords);
                }

                catch
                {
                    Console.WriteLine("Something went wrong...");
                }
            }
        }
    }
}