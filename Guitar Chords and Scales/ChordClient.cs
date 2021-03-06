﻿using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NotesToChords.Controllers
{
    class ChordsClient
    {
        private static HttpClient _client = new HttpClient();

        public async static Task<Theory> GetChords(string url)
        {
            string URL = url;

            Theory chords = new Theory();

            //HttpClient
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(URL))
            using (HttpContent content = response.Content)
            {
                string JSONtext = await response.Content.ReadAsStringAsync();

                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Include
                    };

                    //Convert JSON into object chords
                    chords = JsonConvert.DeserializeObject<Theory>(JSONtext, settings);
                }

                catch
                {
                    Console.WriteLine(Environment.NewLine+"Couldn't convert the results into text.");
                }
            }
            return chords;
        }
    }
}