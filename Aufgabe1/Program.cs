using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Bitte geben Sie die erste Zahl ein: ");
                string input1 = Console.ReadLine();

                int zahl1 = Convert.ToInt32(input1);

                Console.Write("Bitte geben Sie die zweite Zahl ein: ");
                string input2 = Console.ReadLine();

                int zahl2 = Convert.ToInt32(input2);

                int summe = zahl1 + zahl2;


                Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist: {summe}");

                Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
                Console.ReadKey();
        }
    }
}
