using System;
using System.IO;
using System.Threading.Tasks;

namespace NotesToChords.Controllers
{
    public class Program
    {
        public static void Main()
        {
            //ASCII FUN
            Console.WriteLine(@".__   __.   ______   .___________. _______     _______.   .___________.  ______   ");
            Console.WriteLine(@"|  \ |  |  /  __  \  |           ||   ____|   /       |   |           | /  __  \  ");
            Console.WriteLine(@"|   \|  | |  |  |  | `---|  |----`|  |__     |   (----`   `---|  |----`|  |  |  | ");
            Console.WriteLine(@"|  . `  | |  |  |  |     |  |     |   __|     \   \           |  |     |  |  |  | ");
            Console.WriteLine(@"|  |\   | |  `--'  |     |  |     |  |____.----)   |          |  |     |  `--'  | ");
            Console.WriteLine(@"|__| \__|  \______/      |__|     |_______|_______/           |__|      \______/  ");
            Console.WriteLine(@"                                                                                  ");
            Console.WriteLine(@"  ______  __    __    ______   .______       _______       _______.");
            Console.WriteLine(@" /      ||  |  |  |  /  __  \  |   _  \     |       \     /       |");
            Console.WriteLine(@"|  ,----'|  |__|  | |  |  |  | |  |_)  |    |  .--.  |   |   (----`");
            Console.WriteLine(@"|  |     |   __   | |  |  |  | |      /     |  |  |  |    \   \    ");
            Console.WriteLine(@"|  `----.|  |  |  | |  `--'  | |  |\  \----.|  '--'  |.----)   |   ");
            Console.WriteLine(@" \______||__|  |__|  \______/  | _| `._____||_______/ |_______/    ");
            Console.WriteLine(@"                                                                   ");

            Console.WriteLine(@"+---------------------------------------------------------------------+");
            Console.WriteLine(@"|                       Possible Notes to enter                       |");
            Console.WriteLine(@"|                                                                     |");
            Console.WriteLine(@"|             A A# Bb B C C# Db D D# Eb F F# Gb G G# Ab               |");
            Console.WriteLine(@"|                                                                     |");
            Console.WriteLine(@"+---------------------------------------------------------------------+");

            var URL = Notes.CollectNotes();

            ChordsClient.GetChords(URL);

            var result = Task.Run(async () => { return await ChordsClient.GetChords(URL); }).Result;

            //Check if result has contents. If not then no chords.
            if (result.Chords != null)
            {
                Console.WriteLine(Environment.NewLine + "These are the possible chords your notes could make:");
                Console.WriteLine(result.Chords.ToString());
            }
            else
            {
                Console.WriteLine(Environment.NewLine+"There were no chords found with your notes. Press enter to exit");
                Console.ReadLine();
                Environment.Exit(1);
            }

            //Store results into a file specified by user
            try
            {
                Console.WriteLine("Would you like this stored in a text file? (Y or N)");
                var answer = Console.ReadLine();
                if (answer.Contains("Y"))
                {
                    Console.WriteLine("Please enter the file path you would like the chords store in. Please leave the end of the path open without a \\... (Example C:\\Users\\YourName\\Desktop"+Environment.NewLine);
                    var userPath = Console.ReadLine() + "\\Chords.txt";
                    File.WriteAllText(userPath, result.Chords.ToString());
                    Console.WriteLine("Check " + userPath + " for your file");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Program will exit now.");
                }
            }
            //In case there is unauthorized access to the specified file path
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized access to file path when creating file.");
                Console.ReadLine();
            }
        }
    }
}