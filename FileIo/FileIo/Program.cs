namespace FileIo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();            
        }

        internal void Run()
        {
            Console.WriteLine(Environment.CurrentDirectory);
            string[] lines = File.ReadAllLines("quiz.txt");
            for (int i = 0; i < lines.Length; i++) 
            { 
                Console.WriteLine($"{i} {lines[i]}");
            }

            Console.WriteLine(Environment.CurrentDirectory);
            string[] lines2 = File.ReadAllLines("Nos.txt");
            for (int i = 0; i < lines2.Length; i++)
            {
                Console.WriteLine($"{i} {lines2[i]}");
            }
        }
        

    }
}
