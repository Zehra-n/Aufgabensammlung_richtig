namespace Aufgabe02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tage = 0;
            bool eingabe = false;

            while (!eingabe)
            {
                Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out tage))
                {
                    if (tage == 28 || tage == 29 || tage == 30 || tage == 31)
                    {
                        eingabe = true;
                    }
                    else
                    {
                        Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl zwischen 28 und 31 ein.");
                    }
                }
                else
                {
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
                }
            }

            long sekunden = tage * 24 * 60 * 60;
            Console.WriteLine($"Die Anzahl der Sekunden in einem Monat mit {tage} Tagen beträgt: {sekunden}");

            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
}
