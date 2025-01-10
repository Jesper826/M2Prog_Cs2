using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characters = {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
            };

            Console.WriteLine("Gamepersonages:");
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i]);
            }

            List<string> characterList = new List<string>();
            characterList.Add("Toad");

            Console.WriteLine("\nCharacters in characterList:");
            foreach (string character in characterList)
            {
                Console.WriteLine(character);
            }

            List<double> reviews = new List<double> { 342.97, 128.50, 98.76, 210.45, 156.89 };

            Console.WriteLine("\nReviews:");
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }

            Console.WriteLine("\nNa Remove (hoogste waarde):");
            reviews.Remove(342.97);
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }

            Console.WriteLine("\nNa RemoveAt (eerste waarde):");
            reviews.RemoveAt(0);
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }

            Console.WriteLine("\nEindresultaat:");
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }
        }
    }
}
