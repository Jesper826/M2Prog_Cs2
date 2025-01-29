using System;
using System.IO;
using System.Text.Json;

public class FavoriteGame
{
    public string Name { get; set; }
    public string Platform { get; set; }
}

class Program
{
    static void Main()
    {
        
        string filePath = "mijntekst.txt";
        string tekst = "Dit is een voorbeeldtekst die wordt opgeslagen in mijntekst.txt.";
        File.WriteAllText(filePath, tekst);
        Console.WriteLine($"De tekst is succesvol geschreven naar: {filePath}");

        string filePath2 = "mijnregels.txt";
        string[] regels = {
            "stille kano's",
            "Wind fluistert",
            "Rust"
        };
        File.WriteAllLines(filePath2, regels);

        if (File.Exists(filePath2))
        {
            Console.WriteLine($"De regels zijn succesvol geschreven naar: {filePath2}");
            Console.WriteLine("Inhoud van mijnregels.txt:");
            Console.WriteLine(File.ReadAllText(filePath2));
        }
        else
        {
            Console.WriteLine($"Er is een probleem opgetreden bij het schrijven naar {filePath2}.");
        }

        FavoriteGame[] favoriteGames = new FavoriteGame[]
        {
            new FavoriteGame { Name = "Mario kart", Platform = "Nintendo Switch" },
            new FavoriteGame { Name = "Red Dead", Platform = "PlayStation 5" },
            new FavoriteGame { Name = "Minecraft", Platform = "PC" }
        };

        string gamesFilePath = "games.json";
        string gamesJson = JsonSerializer.Serialize<FavoriteGame[]>(favoriteGames);

        File.WriteAllText(gamesFilePath, gamesJson);
        Console.WriteLine($"De games zijn succesvol geschreven naar: {gamesFilePath}");

        if (File.Exists(gamesFilePath))
        {
            string loadedJson = File.ReadAllText(gamesFilePath);
            FavoriteGame[] loadedGames = JsonSerializer.Deserialize<FavoriteGame[]>(loadedJson);

            Console.WriteLine("\nIngeladen games:");
            foreach (var game in loadedGames)
            {
                Console.WriteLine($"Name: {game.Name}, Platform: {game.Platform}");
            }
        }
       
    }
}
