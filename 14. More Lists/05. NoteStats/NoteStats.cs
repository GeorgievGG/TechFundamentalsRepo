using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NoteStats
{
    class NoteStats
    {
        static void Main()
        {
            var frequencies = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var notesList = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            decimal natSum = 0;
            decimal sharpsSum = 0;
            for (int i = 0; i < frequencies.Count; i++)
            {
                switch (frequencies[i].ToString())
                {
                    case "261.63":
                        notesList.Add("C");
                        break;
                    case "277.18":
                        notesList.Add("C#");
                        break;
                    case "293.66":
                        notesList.Add("D");
                        break;
                    case "311.13":
                        notesList.Add("D#");
                        break;
                    case "329.63":
                        notesList.Add("E");
                        break;
                    case "349.23":
                        notesList.Add("F");
                        break;
                    case "369.99":
                        notesList.Add("F#");
                        break;
                    case "392.0":
                        notesList.Add("G");
                        break;
                    case "415.3":
                        notesList.Add("G#");
                        break;
                    case "440.0":
                        notesList.Add("A");
                        break;
                    case "466.16":
                        notesList.Add("A#");
                        break;
                    case "493.88":
                        notesList.Add("B");
                        break;
                }
            }
            for (int j = 0; j < notesList.Count; j++)
            {
                if (notesList[j].Contains("#"))
                {
                    sharps.Add(notesList[j]);
                    sharpsSum += frequencies[j];
                }
                else
                {
                    naturals.Add(notesList[j]);
                    natSum += frequencies[j];
                }
            }
            Console.WriteLine("Notes: " + string.Join(" ", notesList));
            Console.WriteLine("Naturals: " + string.Join(", ", naturals));
            Console.WriteLine("Sharps: " + string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: " + natSum);
            Console.WriteLine("Sharps sum: " + sharpsSum);
        }
    }
}
