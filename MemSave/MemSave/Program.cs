using System;
using System.IO;

namespace MemSave
{
    internal class Program
    {
        string saveFile = "welkomState.txt";

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            string welkomsTekst = "Hello bbbbborld";

            bool bestaatDeFile = File.Exists(saveFile);
            if (bestaatDeFile)
            {
               
                welkomsTekst = File.ReadAllText(saveFile);
                Console.WriteLine("nieuwe text:" + welkomsTekst);
            }
            
            while (true)
            {
                Console.WriteLine(welkomsTekst);
                Console.WriteLine("Enter a text, then press enter:");
                welkomsTekst = Console.ReadLine();
                File.WriteAllText(saveFile, welkomsTekst);
            }
        }
    }
}
