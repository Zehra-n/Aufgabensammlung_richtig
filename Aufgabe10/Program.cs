namespace Aufgabe10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bitte geben Sie die erste positive Ganzzahl ein: ");
            if (int.TryParse(Console.ReadLine(), out int zahl1) && zahl1 > 0)
            {

                Console.Write("Bitte geben Sie die zweite positive Ganzzahl ein: ");
                if (int.TryParse(Console.ReadLine(), out int zahl2) && zahl2 > 0)
                {
                    if (zahl1 > zahl2)
                    {
                        int temp = zahl1;
                        zahl1 = zahl2;
                        zahl2 = temp;
                    }

                    Console.WriteLine("\nZahl\tQuersumme\tDivisionsergebnis");
                    Console.WriteLine("----\t---------\t-----------------");

                    for (int i = zahl1; i <= zahl2; i++)
                    {
                        int quersumme = BerechneQuersumme(i);
                        if (i % quersumme == 0)
                        {
                            int divisionsergebnis = i / quersumme;
                            Console.WriteLine($"{i}\t{quersumme}\t\t{divisionsergebnis}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geben Sie eine gültige positive Ganzzahl ein.");
                }
            }
            else
            {
                Console.WriteLine("Geben Sie eine gültige positive Ganzzahl ein.");
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
