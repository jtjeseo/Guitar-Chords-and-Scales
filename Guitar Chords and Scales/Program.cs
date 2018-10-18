using System;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_Chords_and_Scales.Controllers
{
    public class Program
    {
        public static void Main()
        {


            var URL = Notes.CollectNotes();

            Console.WriteLine("");
            Console.WriteLine("Your URL is: " + URL);
            Console.ReadKey();


            Chords.GetChords(URL);

            //Task T = new Task(Chords.GetChords(URL));
            //T.Start();
            //Console.WriteLine("Json data........");
            //Console.ReadLine();

            Console.ReadLine();
        }

    }
}
