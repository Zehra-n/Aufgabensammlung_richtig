namespace Aufgabe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 12));
            Console.WriteLine("Kleines 1x1:");
            Console.WriteLine(new string('-', 12));

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    // Ausgabe des Produkts mit Formatierung
                    Console.Write($"{i * j,4}");// {i * j,4} sorgt für eine Breite von 4 Zeichen
                    //Console.Write($"{i * j}\t");
                }
                Console.WriteLine(); // Neue Zeile nach jeder Reihe
            }
        }
    }
}

