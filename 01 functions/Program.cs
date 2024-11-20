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
            Console.WriteLine("");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord); 
        }
        internal void Vraag2()
        {
            Console.WriteLine("");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag4()
        {
            Console.WriteLine("");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void Vraag5()
        {
            Console.WriteLine("");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
    }
}



