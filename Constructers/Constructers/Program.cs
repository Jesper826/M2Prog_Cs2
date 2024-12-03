using System.Runtime.CompilerServices;

namespace Constructers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.Run();
        }
        internal void Run()
        {
            QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
            
        }
    }
}
