using System;

namespace ArrayOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 3.90 };
            string[] artikelen = { "snoepje", "luxe broodje", "lunch menu", "toetje" };
            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Sterren = 5,
                Feedback = "Lekker eten en goede service!"
            };

            formulieren[1] = new Formulier()
            {
                Sterren = 3,
                Feedback = "Eten was prima, maar het duurde te lang."
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artikelen[i]);
            }

            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Sterren);
                Console.WriteLine(formulier.Feedback);
            }
        }
    }
    internal class Formulier()
    {
        internal int Sterren { get; set; }
        internal string Feedback { get; set; }
    }

}
