namespace Aufgabe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pfrüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine(new string('*', 61));

            Console.WriteLine("Eingabe Jahr (q to quit): /");
            string input = Console.ReadLine();
            int zahl;

            if (int.TryParse(input, out zahl))
            {

                if (zahl % 4 == 0)
                {
                    Console.WriteLine($"Das Jahr {zahl} ist ein Schaltjahr.");

                }
                else
                {
                    Console.WriteLine($"Das Jahr {zahl} ist KEIN Schaltjahr.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen Jahr ein.");
            }
        }

    }
}

