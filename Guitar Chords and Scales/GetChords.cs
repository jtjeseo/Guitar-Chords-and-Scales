using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_Chords_and_Scales.Controllers
{
    class Chords
    {
        private static HttpClient _client = new HttpClient();

        public async Task<RecipeResponse> GetRecipe(ICollection<string> ingredients, string foodType, int count)
        {
            var builder = new StringBuilder();
            builder.Append("http://www.recipepuppy.com/api/");

            var formattedIngredients = string.Join(",", ingredients);
            builder.Append($"?i={formattedIngredients}");

            //var formattedFoods = string.Join(",", foodType);
            builder.Append($"&q={foodType}");

            builder.Append($"&p={count}");

            HttpResponseMessage response = null;
            response = await _client.GetAsync(builder.ToString());

            var responseString = await response.Content.ReadAsStringAsync();
            var responseJson = JsonConvert.DeserializeObject<RecipeResponse>(responseString);

            return await Task.FromResult(responseJson);
        }
    }
}