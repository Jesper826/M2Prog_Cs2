using System.Diagnostics.CodeAnalysis;

namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[] {
            "What 1997 n64 video game, features James Bond and is named after the 1995 film?",
            "What arcade game was called puckman in Japan?"
        };
        static void Main(string[] args)
        {
            Program program = new Program(); // Een object van de Program-klasse maken //variabele Program met als type program
            program.Run();//program wordt uitgevoerd //De functie heet run
        }

        internal void Run()
        {
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            
        }

        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag2()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag4()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal string Vraag7()
        {
            Console.WriteLine("Wat is jouw duurste miskoop");
            string antwoord = Console.ReadLine();

            return antwoord;
            
        }


            internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
            string vraag0 = GetVraag(0);
        }
        internal string GetRandomVraag()
        {
            Random r = new Random();
            int rInt = r.Next(0, vragen.Length);
            return vragen[rInt];
        }
            

        
            
    }
}



