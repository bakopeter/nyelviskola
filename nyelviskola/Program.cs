using NyelviskolaCL;

namespace nyelviskola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a betöltendő Json fájl nevét! ");

            string? path = Console.ReadLine();
            
            Console.WriteLine("");

            List<object> list = JSImporterService.Import(path!);

            string[,] messages = DBExporterService.Export(list);

            if (messages[0, 0] != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Az alábbi bejegyzések sikeresen bekerültek az adatbázsba!");
                int i = 0; 
                while (i < messages.GetLength(1) && messages[0, i] != null) 
                { 
                    Console.Write($"{messages[0, i]}, "); i++; 
                };
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
            }

            if (messages[1, 0] != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Az alábbi bejegyzések már korábban bekerültek az adatbázsba!");
                int i = 0; 
                while (i < messages.GetLength(1) && messages[1, i] != null)
                {
                    Console.Write($"{messages[1, i]}, "); i++;
                };
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}
