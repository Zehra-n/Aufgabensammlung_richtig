namespace Aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine positive Ganzzahl ein: ");

            int zahl;
            if (int.TryParse(Console.ReadLine(), out zahl) && zahl > 0)
            {
                string binaer = Convert.ToString(zahl, 2);
                Console.WriteLine($"Die Zahl {zahl} im binären Format ist: {binaer}");
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige positive Ganzzahl ein.");
            }
        }
    }
}
