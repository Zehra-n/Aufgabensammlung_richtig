namespace Aufgabe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie die Länge der Linie ein: ");
            if (int.TryParse(Console.ReadLine(), out int laenge) && laenge > 0)
            {
                for (int i = 0; i < laenge; i++)
                {
                    for (int j = 0; j < laenge; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Bitte geben Sie eine gültige positive Ganzzahl ein.");
            }
        }
    }
}
