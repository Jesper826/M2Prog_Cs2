namespace Dictionaries
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
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
            personeelOpNummer.Add(382942, "Jijm");
            personeelOpNummer.Add(456789, "Tijm");
            

            foreach (KeyValuePair<int, string> item in personeelOpNummer) {

                Console.WriteLine(item.Value + ": " + item.Key);
            }

            foreach (int key in personeelOpNummer.Keys) {
                Console.WriteLine(key);
            }


            foreach (string value in personeelOpNummer.Values) {
                Console.WriteLine(value);
            }
        }        
    }
}
