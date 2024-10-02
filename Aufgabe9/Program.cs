using System.Numerics;

namespace Aufgabe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl :");

            if (int.TryParse(Console.ReadLine(), out int zahl) && zahl > 0)
            {
                int quersumme = BerechneQuersumme(zahl);
                Console.WriteLine($"Die Quersumme der Zahl {zahl} ist: {quersumme}");
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige positive Ganzzahl ein.");
            }
        }

        static int BerechneQuersumme(int zahl)
        {
            int quersumme = 0;
            while (zahl > 0)
            {
                quersumme += zahl % 10;
                zahl /= 10;
            }
            return quersumme;
        }
    }
}
