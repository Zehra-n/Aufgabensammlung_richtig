using System;

namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Bitte geben Sie eine Ganzzahl zwischen 1 und 12 ein:");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out int zahl)) 
                {
                    
                    if (zahl >= 1 && zahl <= 12)
                    {
                        string monthName = GetMonthName(zahl);
                        Console.WriteLine($"Der {zahl}. Monat ist: {monthName}");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 12 ein.");
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl ein.");
                }
            }

            
            Console.WriteLine("Drücken Sie eine Taste zum Beenden...");
            Console.ReadKey();
        }

        static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "Januar";
                case 2: return "Februar";
                case 3: return "März";
                case 4: return "April";
                case 5: return "Mai";
                case 6: return "Juni";
                case 7: return "Juli";
                case 8: return "August";
                case 9: return "September";
                case 10: return "Oktober";
                case 11: return "November";
                case 12: return "Dezember";
                default: return ""; 
            }
        }
    }
}