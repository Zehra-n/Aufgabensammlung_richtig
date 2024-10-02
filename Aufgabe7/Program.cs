namespace Aufgabe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind:");
            // Variable für die Ausgabe
            string output = "";

            for (int i = 1; i <= 30; i++)
            {
                // Überprüfen, ob die Zahl durch 3 oder 5 teilbar ist
                if (i % 3 == 0 || i % 5 == 0)
                {
                    // Wenn output nicht leer ist, ein Komma hinzufügen
                    if (output != "")
                    {
                        output += ", ";
                    }
                    // Die Zahl zur Ausgabe hinzufügen
                    output += i;
                }
            }

            // Ausgabe der Ergebnisse
            Console.WriteLine(output);
        }
    }
}
