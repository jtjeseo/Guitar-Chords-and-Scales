﻿using System;
using System.Threading.Tasks;

namespace Guitar_Chords_and_Scales.Controllers
{
    public class Program
    {
        public static void Main()
        {
            var URL = Notes.CollectNotes();

            ChordsClient.GetChords(URL);

            var result = Task.Run(async () => { return await ChordsClient.GetChords(URL); }).Result;

            Console.WriteLine(Environment.NewLine+"These are the possible chords your notes could make:");

            Console.WriteLine(result.Chords.ToString());

            Console.ReadLine();

        }
    }
}