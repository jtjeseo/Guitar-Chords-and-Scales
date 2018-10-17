using System;
using System.Text;
using System.Net;

namespace Guitar_Chords_and_Scales.Controllers
{
    public class Program
    {

        //Declare variable(s) for notes to be inputted.
        public static string Answer = "";

        public static void Main()
        {
            string i = "";
            string response = "";
            while (i != "Q")
            {
                //Ask for notes they would like. Let them know it can be for chords or scales
                Console.WriteLine("Enter a single note that you would like a chord or scale for then press enter (enter Q to to get result)... ");
                response = Console.ReadLine();
                response = response.ToUpper();

                //Get out of loop if they enter "Q"
                if (response == "Q")
                {
                    break;
                }
                // Replaces a # sign with the correct encoded %23 character for the URL API
                if (response.Contains("#"))
                {
                    StringBuilder sb = new StringBuilder(response);
                    sb.Replace("#", "%23");
                    response = sb.ToString();
                }
                Answer = Answer + response + "+";
            }
            //Paste userNotes onto url from tofret.com and store response into var
            string URL = "http://www.tofret.com/reverse-chord-finder.php?return-type=json&notes=" + Answer;

            Console.WriteLine(URL);
            Console.ReadKey();

            Chords.PrintChords(URL);
            GetScales.PrintScales(URL);

        }

    }
}

//namespace CoinMarketCap.Controllers
//{
//    public class HomeController : Controller
//    {
//        public static HttpClient HttpClient;

//        [HttpGet]
//        public async Task<ActionResult> Index()
//        {
//            if (HttpClient == null)
//                HttpClient = new HttpClient();

//            var httpResponseMessage = await HttpClient.GetAsync("https://api.coinmarketcap.com/v1/ticker");

//            if (!httpResponseMessage.IsSuccessStatusCode)
//                throw new Exception("Unable to connect to CoinMarketCap.");

//            var responseString = await httpResponseMessage.Content.ReadAsStringAsync();

//            var coins = JsonConvert.DeserializeObject<List<Coin>>(responseString);

//            var coinListViewModel = new CoinListViewModel
//            {
//                Coins = coins,
//                SecondsToReload = 60
//            };

//            return View(coinListViewModel);
//        }
//    }
//}