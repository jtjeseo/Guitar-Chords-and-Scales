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
                try
                {
                    //Ask for notes they would like. Let them know it can be for chords or scales
                    Console.WriteLine(Environment.NewLine+ "Enter a single music note that you would like possible chords for then press enter (enter Q to get result)... ");
                    response = Console.ReadLine();


                    if (response.Contains("A") || response.Contains("A#") || response.Contains("Bb") || response.Contains("B") || response.Contains("C") || response.Contains("C#") || response.Contains("Db") || response.Contains("D") || response.Contains("D#") || response.Contains("Eb") || response.Contains("E") || response.Contains("F") || response.Contains("F#") || response.Contains("Gb") || response.Contains("G") || response.Contains("G#") || response.Contains("Ab") || response.Contains("Q"))
                    {

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
                    else
                    {
                        Console.WriteLine("Please enter a note like 'A' or 'C#' or 'Bb'..."+Environment.NewLine);
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Something is wrong with what you entered... please try again! Examples( A C# E )");
                }

            }
            //Paste userNotes onto url from tofret.com and store response into var
            string URL = "http://www.tofret.com/reverse-chord-finder.php?return-type=json&notes=" + Answer;

            return URL;
        }
    }
}
