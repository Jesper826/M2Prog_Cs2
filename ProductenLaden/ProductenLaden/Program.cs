using System.Text.Json;

namespace ProductenLaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        static void Main2(string[] args)
        {
            Program program = new Program();
            program.RunProducten();
        }

        internal void RunProducten() 
        {
            string text = File.ReadAllText("Producten.json");
            Product[] product = JsonSerializer.Deserialize<Product[]>(text);

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("");
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
