using System;

namespace Aufgabe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = 0;
            bool eingabe = false;

            while (!eingabe)
            {
                Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out km))
                {
                    if (km <= 42)
                    {
                        eingabe = true;
                    }
                    else
                    {
                        Console.WriteLine("Das schaffst du nicht!");
                    }
                }
                else
                {
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
                }
            }

            int inm = km * 1000; 
            long runden = inm / 400; 
            Console.WriteLine($"Das sind {runden} Runden. Bereit für den Lauf? (ja/nein)");

            string bereit = Console.ReadLine();
            if (bereit.ToLower() == "ja") 
            {
                for (int i = 1; i <= runden; i++) 
                {
                    Console.WriteLine($"Du läufst Runde {i}");
                }
                Console.WriteLine("Du hast es geschafft!");
            }
            else
            {
                Console.WriteLine("Ende");
            }
        }
    }
}



