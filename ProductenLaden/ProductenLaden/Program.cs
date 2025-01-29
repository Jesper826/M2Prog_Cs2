using System.Text.Json;

namespace ProductenLaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            program.RunProducten();
            program.koekies();
        }

        internal void koekies()
        {
            string text = File.ReadAllText("koek.json");
            Koek[] koek = JsonSerializer.Deserialize<Koek[]>(text);



            for (int i = 0; i < koek.Length; i++)
            {
                Console.WriteLine(koek[i].name);
                Console.WriteLine(koek[i].description);
                Console.WriteLine(koek[i].stars);
            }
        }   

        internal void RunProducten() 
        {
            string text = File.ReadAllText("Producten.json");
            Product[] product = JsonSerializer.Deserialize<Product[]>(text);

            

            for (int i = 0; i < product.Length; i++) 
            {
                Console.WriteLine(product[i].Name);
                Console.WriteLine(product[i].Description);
                Console.WriteLine(product[i].Price);
            }

        }

        internal void Run()
        {
            string text = File.ReadAllText("Product.json");
            Product product = JsonSerializer.Deserialize<Product>(text);
            
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);

        }

        
    }
}
