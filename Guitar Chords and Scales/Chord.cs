using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace Guitar_Chords_and_Scales.Controllers
{
    class Chords
    {
        private static HttpClient _client = new HttpClient();

        public async static void GetChords(string url)
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

                //try
                //{
                JArray JSONarray = JArray.Parse(JSONtext);

                    foreach (var item in JSONarray)
                    {
                        Console.WriteLine(item.ToString());
                    }
                //}

                //catch
                //{
                    //Console.WriteLine("Something went wrong...");
                //}
                
                //foreach (var File in articles)
                //{
                //    Console.WriteLine("{0}\t{1}\t{2}\t{3}", File.Chord, File.Root, File.Quality, File.Notes);
                //}
            }

        }
    }
}