using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_Chords_and_Scales
{
    class Notes
    {
        public static string CollectNotes()
        {
            string Answer = "";
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

            return URL;
        }
    }
}
