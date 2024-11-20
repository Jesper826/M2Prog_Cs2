namespace Functions
{
    internal class Program
    {
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
    }
}



